/* Nicholas Uramkin
 * Lab 5
 * ITSE 1430
 * 4/30/2018
 * SqlMovieDatabase.cs
 * */

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicholasUramkin.MovieLib.Data.Sql
{
    /// <summary>
    /// Adds movie to SQL database
    /// </summary>
    public class SqlMovieDatabase : MovieDatabase
    {
        private readonly string _connectionString;

        /// <summary>
        /// SqlMovieDatabase constructor (sets connection string)
        /// </summary>
        /// <param name="connectionString">Needed to connect to database</param>
        /// <exception cref="ArgumentNullException"><paramref name="connectionString"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="connectionString"/> is empty.</exception>
        public SqlMovieDatabase (string connectionString)
        {
            if (connectionString == null)
                throw new ArgumentNullException(nameof(connectionString));
            if (connectionString == "")
                throw new ArgumentException("Connection string cannot be empty.", nameof(connectionString));

            _connectionString = connectionString;
        }

        //adds a movie to the database
        protected override Movie AddCore( Movie movie )
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("AddMovie", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@title", movie.Title);
                cmd.Parameters.AddWithValue("@length", movie.Length);
                cmd.Parameters.AddWithValue("@description", movie.Description);
                cmd.Parameters.AddWithValue("@isOwned", movie.Owned);

                conn.Open();
                var result = cmd.ExecuteScalar();

                var id = Convert.ToInt32(result);
                movie.Id = id;
            }
            return movie;
        }

        //gets all movies from database
        protected override IEnumerable<Movie> GetAllCore()
        {
            var items = new List<Movie>();

            using (var conn = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("GetAllMovies", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                conn.Open();

                var ds = new DataSet();

                var da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                da.Fill(ds);

                if (ds.Tables.Count == 1)
                {
                    foreach (var row in ds.Tables[0].Rows.OfType<DataRow>())
                    {
                        var movie = new Movie() {
                        Id = row.Field<int>("Id"),
                            Title = row.Field<string>("Title"),
                            Description = row.Field<string>("Description"),
                            Length = row.Field<int>("Length"),
                            Owned = row.Field<bool>("isOwned")
                        };
                    items.Add(movie);
                    }
                }
            }
            return items;
        }

        //gets a movie from the database by id
        protected override Movie GetCore( int id )
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("GetMovie", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@id", id));

                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        return ReadData(reader);
                }
            }
            return null;
        }

        //reads data from database into a movie
        private static Movie ReadData( SqlDataReader reader )
        {
            var movie = new Movie() {
                Id = reader.GetInt32(0),
                Title = reader.GetString(1),
                Length = reader.GetInt32(3),
                Description = reader.GetString(2),
                Owned = reader.GetBoolean(4)
            };
            return movie;
        }

        //gets a movie from database by its title
        protected override Movie GetMovieByTitleCore( string title )
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("GetAllMovies", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var movie = ReadData(reader);
                        if (String.Compare(movie.Title, title, true) == 0)
                            return movie;
                    }
                }
            }
            return null;
        }

        //deletes movie from database
        protected override void RemoveCore( int id )
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("RemoveMovie", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@id", id));

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //updates/edits movie in database
        protected override Movie UpdateCore( Movie movie )
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("UpdateMovie", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@id", movie.Id));
                cmd.Parameters.AddWithValue("@title", movie.Title);
                cmd.Parameters.AddWithValue("@length", movie.Length);
                cmd.Parameters.AddWithValue("@description", movie.Description);
                cmd.Parameters.AddWithValue("@isOwned", movie.Owned);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            return movie;
        }
    }
}

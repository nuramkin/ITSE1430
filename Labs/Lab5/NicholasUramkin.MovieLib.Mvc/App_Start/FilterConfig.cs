using System.Web;
using System.Web.Mvc;

namespace NicholasUramkin.MovieLib.Mvc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters( GlobalFilterCollection filters )
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

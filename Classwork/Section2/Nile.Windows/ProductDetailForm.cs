using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nile.Windows
{
    public /*abstract*/ partial class ProductDetailForm : Form
    {
        public ProductDetailForm()
        {
            InitializeComponent();
        }

        public ProductDetailForm( string title) : this() //: base()
        {
            Text = title;
        }

        public ProductDetailForm( Product product ) : this("Edit Product")
        {
            //InitializeComponent();

            //Text = "Edit Product";
            Product = product;
        }

        public Product Product { get; set; }//property

        //public abstract DialogResult ShowDialogEx();

        //public virtual DialogResult ShowDialogEx()
        //{
        //    return ShowDialog();
        //}

        private void OnCancel( object sender, EventArgs e )
        {
        }

        protected override void OnLoad( EventArgs e )
        {
            //call base type
            //OnLoad(e);
            base.OnLoad(e);



            //load product
            //only this if using whole object
            if (Product != null)
            {
                _txtName.Text = Product.Name;
                _txtDescription.Text = Product.Description;
                _txtPrice.Text = Product.Price.ToString();
                _chkIsDiscontinued.Checked = Product.IsDiscontinued;
            }

            ValidateChildren();
        }
        private void OnSave( object sender, EventArgs e )
        {
            //force validation of child controls
            if (!ValidateChildren())
                return;

            //create product
            var product = new Product();
            product.Name = _txtName.Text;
            product.Description = _txtDescription.Text;
            product.Price = ConvertToPrice(_txtPrice);
            product.IsDiscontinued = _chkIsDiscontinued.Checked;

            //validate
            var message = product.Validate();
            if (!String.IsNullOrEmpty(message))
            {
                DisplayError(message);
                return;
            }

            //return from form
            Product = product;
            DialogResult = DialogResult.OK;
            
            //Setting this to None will prevent close if needed
            //DialogResult = DialogResult.None;(for accept button)
            Close();
        }

        private decimal ConvertToPrice (TextBox control)
        {
            if (Decimal.TryParse(control.Text, out var price))
                return price;

            return -1;
        }

        private void DisplayError ( string message )
        {
            MessageBox.Show(this, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _txtName_Validating( object sender, CancelEventArgs e )
        {
            var textbox = sender as TextBox;

            if (String.IsNullOrEmpty(textbox.Text))
            {
                _errProvider.SetError(textbox, "Name is required");
                e.Cancel = true;
            } else
                _errProvider.SetError(textbox, "");
        }

        private void _txtPrice_Validating( object sender, CancelEventArgs e )
        {
            var textbox = sender as TextBox;

            var price = ConvertToPrice(textbox);
            if (price < 0)
            {
                _errProvider.SetError(textbox, "Price must be >= 0");
                e.Cancel = true;
            } else
                _errProvider.SetError(textbox, "");
        }
    }
}

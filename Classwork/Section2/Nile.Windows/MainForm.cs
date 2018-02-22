﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            //PlayingWithProductMembers();
        }

        private void PlayingWithProductMembers ()
        {
            var product = new Product();

            Decimal.TryParse("123", out var price);
            product.Price = price;

            var name = product.Name;
            //var name = product.GetName();
            product.Name = "Product A";
            product.Price = 50;
            product.IsDiscontinued = true;

            //product.ActualPrice = 10;
            var price2 = product.ActualPrice;

            //product.SetName("Product A");
            //product.Description = "None";
            var error = product.Validate();

            var str = product.ToString();

            var productB = new Product();
            //product.Name = "Product B";
            //productB.SetName("Product B");
            //productB.Description = product.Description;
            error = productB.Validate();
        }

        private void OnProductAdd( object sender, EventArgs e )
        {
            var button = sender as ToolStripMenuItem;

            var form = new ProductDetailForm("Add Product");

            //show form modally
            var result = form.ShowDialog(this);
            if (result != DialogResult.OK)
                return;

            //add the product
            _product = form.Product;
            MessageBox.Show("Product Added");

        }

        private void OnProductEdit( object sender, EventArgs e )
        {
            if (_product == null)
                return;
            var form = new ProductDetailForm(_product);
            form.Product = _product;

            //show form modally
            var result = form.ShowDialog(this);
            if (result != DialogResult.OK)
                return;

            //edit the product
            _product = form.Product;
        }

        private void OnProductRemove( object sender, EventArgs e )
        {
            if (!ShowConfirmation("Are you sure?", "Remove Product"))
                return;

            //Remove product
            _product = null;
            MessageBox.Show("Product removed");
        }

        private void OnFileExit( object sender, EventArgs e )
        {
            Close();
        }

        private void OnHelpAbout( object sender, EventArgs e )
        {
            MessageBox.Show(this, "Not implemented", "Help About", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private bool ShowConfirmation (string message, string title)
        {
            return MessageBox.Show(this, message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private Product _product;
    }
}

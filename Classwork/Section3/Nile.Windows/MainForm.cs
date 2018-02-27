﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nile.Data.Memory;

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

            RefreshUI();
        }

        private void RefreshUI ()
        {
            //get the products
            var products = _database.GetAll();

            //bind to grid
            dataGridView1.DataSource = products;
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

            //add to database
            _database.Add(form.Product, out var message);
            if (!String.IsNullOrEmpty(message))
                MessageBox.Show(message);

            //find empty array element
            //var index = FindEmptyProductIndex();
            //    if(index >= 0)
            //        _products[index] = form.Product;

        }

        //private int FindEmptyProductIndex()
        //{
        //    for (var index = 0; index < _products.Length; ++index)
        //    {
        //        if (_products[index] == null)
        //            return index;
        //    }

        //    return -1;
        //}

        //helper method to find first empty element
        private void OnProductEdit( object sender, EventArgs e )
        {
            //get the first product
            var products = _database.GetAll();
            var product = (products.Length > 0) ? products[0] : null;
            if (product == null)
                return;

            //var index = FindEmptyProductIndex() - 1;
            //if (index < 0)
            //    return;

            //if (_product == null)
            //    return;



            var form = new ProductDetailForm(product);
           

            //show form modally
            var result = form.ShowDialog(this);
            if (result != DialogResult.OK)
                return;


            //update the product
            _database.Edit(form.Product, out var message);
            if (!String.IsNullOrEmpty(message))
                MessageBox.Show(message);
        }

        private void OnProductRemove( object sender, EventArgs e )
        {
            //var index = FindEmptyProductIndex() - 1;
            //if (index < 0)
            //    return;
            //get the first product
            var products = _database.GetAll();
            var product = (products.Length > 0) ? products[0] : null;
            if (product == null)
                return;

            if (!ShowConfirmation("Are you sure?", "Remove Product"))
                return;

            //Remove product
            _database.Remove(product.Id);
            //_products[index] = null;
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

        private MemoryProductDatabase _database = new MemoryProductDatabase();
    }
}

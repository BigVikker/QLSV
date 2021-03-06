﻿using QLSV.Common;
using QLSV.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV.ChirldForm
{
    public partial class CreateProductForm : Form
    {
        public CreateProductForm()
        {
            InitializeComponent();
        }
        public Product_Frm mainForm { get; set; }
        public CreateProductForm(Product_Frm add_Frm)
        {
            InitializeComponent();
            this.mainForm = add_Frm;
            this.mainForm.Enabled = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private async void button_submit_Click(object sender, EventArgs e)
        {
            PRODUCT newProduct = new PRODUCT()
            {
                ProductName = textBox_productName.Text,
                ProductDescription = textBox_decProduct.Text,
                ProductPrice = Int32.Parse(textBox_price.Text),
                PromotionPrice = Int32.Parse(textBox_promoPrice.Text)
                    ,
                ProductImage = textBox_sourImg.Text,
                ProductStock = Int32.Parse(textBox_stock.Text)
                    ,
                ProductStatus = checkBox_status.Checked,
                BrandID = (comboBox_brand.SelectedIndex + 1)
            };
            var json = JsonConvert.SerializeObject(newProduct);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            string url = GlobalVariable.url + "api/product/create";

            try
            {
                var client = new HttpClient();
                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AdminController.AdminToken);
                client.BaseAddress = new Uri(url);

                var response = await client.PostAsync(url, data);
                if (response.IsSuccessStatusCode)
                {
                    // Succes
                    //mainForm.DTGV_Layout_product();
                    MessageBox.Show("Tao sản phẩm thành công");
                }
                else
                {
                    //Fail
                    MessageBox.Show("Tao sản phẩm không thành công");

                }
            }
            catch
            {
                // Fail
                MessageBox.Show("Tao sản phẩm không thành công");
            }
            Close();
        }

        private async void CreateProductForm_Load(object sender, EventArgs e)
        {
            string url = GlobalVariable.url + "api/brand";
            string json = await new GlobalVariable().GetApiAsync(url);
            var list = JsonConvert.DeserializeObject<List<BRAND>>(json);
            foreach (var i in list)
            {
                comboBox_brand.Items.Add(i.BrandName);
            }
        }

        private void checkBox_status_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_onlyNumberApc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_promoPrice_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox_stock_TextChanged(object sender, EventArgs e)
        {
        }

        private void CreateProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.mainForm.Load_List();
            this.mainForm.Enabled = true;
        }
    }
}

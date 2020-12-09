using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APIBanDienThoai.Common;
using APIBanDienThoai.Models;
using Newtonsoft.Json;
using System.Net.Http;
using QLSV.ChirldForm;

namespace QLSV
{
    public partial class ProductForm : UserControl
    {
        private static ProductForm inst;
        public static ProductForm Instance
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                    inst = new ProductForm();
                return inst;
            }
        }
        public ProductForm()
        {
            InitializeComponent();
            Load_List();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }
        public async void Load_List()
        {
            //brand_dtgv.Columns.Add("Col1", "Status");
            //brand_dtgv.Rows.Add("Loading...");
            loading_lbl.Visible = true;
            try
            {
                string url = GlobalVariable.url + "api/product/getall";
                string json = await new GlobalVariable().GetApiAsync(url);
                var list = JsonConvert.DeserializeObject<List<PRODUCT>>(json);
                product_dtgv.DataSource = null;
                product_dtgv.DataSource = list;
                loading_lbl.Visible = false;
            }
            catch
            {
                MessageBox.Show("Cannot get data", "Fail");
                product_dtgv.DataSource = null;
                loading_lbl.Visible = false;
            }
        }

        private void product_dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            productID_lbl.Text = product_dtgv.Rows[rowIndex].Cells[0].Value.ToString();
            txtbox_ProductName.Text = product_dtgv.Rows[rowIndex].Cells[1].Value.ToString();
            txtBox_Description.Text = product_dtgv.Rows[rowIndex].Cells[2].Value.ToString();
            txtBox_Price.Text = product_dtgv.Rows[rowIndex].Cells[3].Value.ToString();
            txtBox_PromoPrice.Text = product_dtgv.Rows[rowIndex].Cells[4].Value.ToString();
            txtBox_Stock.Text = product_dtgv.Rows[rowIndex].Cells[7].Value.ToString();
            txtBox_Img.Text = product_dtgv.Rows[rowIndex].Cells[7].Value.ToString();

        }

        private void product_dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productEdit_btn.Enabled = true;
            int rowIndex = e.RowIndex;
            productID_lbl.Text = product_dtgv.Rows[rowIndex].Cells[0].Value.ToString();
            txtbox_ProductName.Text = product_dtgv.Rows[rowIndex].Cells[1].Value.ToString();
            txtBox_Description.Text = product_dtgv.Rows[rowIndex].Cells[2].Value.ToString();
            txtBox_Price.Text = product_dtgv.Rows[rowIndex].Cells[3].Value.ToString();
            try {
                txtBox_PromoPrice.Text = product_dtgv.Rows[rowIndex].Cells[4].Value.ToString();
            }
            catch
            {
                txtBox_PromoPrice.Text = "0";
            }
            txtBox_Stock.Text = product_dtgv.Rows[rowIndex].Cells[7].Value.ToString();
            txtBox_Img.Text = product_dtgv.Rows[rowIndex].Cells[7].Value.ToString();
            if (product_dtgv.Rows[rowIndex].Cells[10].Value.ToString() == "True")
            {
                checkBox_status.Checked = true;
            }
            else checkBox_status.Checked = false;
        }

        private async void deleteProduct_btn_Click(object sender, EventArgs e)
        {
            deleteProduct_btn.Enabled = false;
            if (productID_lbl.Text == null || productID_lbl.Text.ToString() == "ID") {
                deleteProduct_btn.Enabled = true;
                return;
            }
            string url = GlobalVariable.url + "api/product/delete?id=" + productID_lbl.Text;
            try
            {
                var client = new HttpClient();
                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AdminController.AdminToken);
                client.BaseAddress = new Uri(url);

                var response = await client.DeleteAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Delete Success", "Success");
                    Load_List();
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync(), "Fail");
                }
                deleteProduct_btn.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Error while deleting product", "Fail");
                deleteProduct_btn.Enabled = true;
            }
        }

        private async void productEdit_btn_Click(object sender, EventArgs e)
        {
            productEdit_btn.Enabled = false;
            var json = JsonConvert.SerializeObject(new PRODUCT()
            {
                ProductName = txtbox_ProductName.Text.ToString()
                ,
                ProductDescription = txtBox_Description.Text.ToString()
                ,
                ProductPrice = Int32.Parse(txtBox_Price.Text)
                ,
                PromotionPrice = Int32.Parse(txtBox_PromoPrice.Text)
                ,
                ProductStock = Int32.Parse(txtBox_Stock.Text)
                ,
                ProductImage = txtBox_Img.Text.ToString()
                ,
                ProductStatus = checkBox_status.Checked
            }) ;
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            string url = GlobalVariable.url + "api/product/update?id=" + productID_lbl.Text;

            try
            {
                var client = new HttpClient();
                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AdminController.AdminToken);
                client.BaseAddress = new Uri(url);

                var response = await client.PutAsync(url, data);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Update Success", "Success");
                    Load_List();
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync(), "Fail");
                }
                productEdit_btn.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Error while updating product", "Fail");
                productEdit_btn.Enabled = true;
            }
        }

        private void createProduct_btn_Click(object sender, EventArgs e)
        {
            CreateProductForm newform = new CreateProductForm(this);
            newform.Show();
        }
    }
}

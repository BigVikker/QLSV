using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV.Common;
using QLSV.Models;
using Newtonsoft.Json;
using System.Net.Http;
using QLSV.ChirldForm;
using System.Text.RegularExpressions;

namespace QLSV
{
    public partial class Product_Frm : UserControl
    {
        private static Product_Frm inst;
        public static Product_Frm Instance
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                    inst = new Product_Frm();
                return inst;
            }
        }
        public Product_Frm()
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
            //int rowIndex = e.RowIndex;
            //productID_lbl.Text = product_dtgv.Rows[rowIndex].Cells[0].Value.ToString();
            //txtbox_ProductName.Text = product_dtgv.Rows[rowIndex].Cells[1].Value.ToString();
            //txtBox_Description.Text = product_dtgv.Rows[rowIndex].Cells[2].Value.ToString();
            //txtBox_Price.Text = product_dtgv.Rows[rowIndex].Cells[3].Value.ToString();
            //txtBox_PromoPrice.Text = product_dtgv.Rows[rowIndex].Cells[4].Value.ToString();
            //txtBox_Stock.Text = product_dtgv.Rows[rowIndex].Cells[7].Value.ToString();
            //txtBox_Img.Text = product_dtgv.Rows[rowIndex].Cells[7].Value.ToString();

        }

        private void product_dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productEdit_btn.Enabled = true;
            int rowIndex = e.RowIndex;
            productID_lbl.Text = product_dtgv.Rows[rowIndex].Cells[0].Value.ToString();
            txtbox_ProductName.Text = product_dtgv.Rows[rowIndex].Cells[1].Value.ToString();
            txtBox_Description.Text = product_dtgv.Rows[rowIndex].Cells[2].Value.ToString();
            var price = product_dtgv.Rows[rowIndex].Cells[3].Value;
            txtBox_Price.Text = Convert.ToDecimal(price).ToString("#,##0") + "đ";
            var promo = product_dtgv.Rows[rowIndex].Cells[4].Value;
            txtBox_PromoPrice.Text = (promo == null) ? "0đ" : Convert.ToDecimal(promo).ToString("#,##0") + "đ";
            txtBox_Stock.Text = product_dtgv.Rows[rowIndex].Cells[7].Value.ToString();
            txtBox_Img.Text = product_dtgv.Rows[rowIndex].Cells[6].Value.ToString();
            if (product_dtgv.Rows[rowIndex].Cells[10].Value.ToString() == "True")
            {
                checkBox_status.Checked = true;
            }
            else checkBox_status.Checked = false;
        }

        private async void deleteProduct_btn_Click(object sender, EventArgs e)
        {
            deleteProduct_btn.Enabled = false;
            DialogResult dialogResult = MessageBox.Show("Do you want to delete this product ?", "Warnning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                if (productID_lbl.Text == null || productID_lbl.Text.ToString() == "ID")
                {
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
                Load_List();
            }
        }

        private async void productEdit_btn_Click(object sender, EventArgs e)
        {
            productEdit_btn.Enabled = false;
            var price1 = txtBox_Price.Text.ToString();
            price1 = Regex.Replace(price1, " ", "");
            price1 = Regex.Replace(price1, ",", "");
            price1 = Regex.Replace(price1, "đ", "");
            int truePrice = Convert.ToInt32(price1);
            price1 = txtBox_PromoPrice.Text.ToString();
            price1 = Regex.Replace(price1, ",", "");
            price1 = Regex.Replace(price1, " ", "");
            price1 = Regex.Replace(price1, "đ", "");
            int trueProPrice = Convert.ToInt32(price1);
            bool isCheck = checkBox_status.Checked;
            PRODUCT newProduct = new PRODUCT()
            {
                ProductName = txtbox_ProductName.Text.ToString()
                ,
                ProductDescription = txtBox_Description.Text.ToString()
                ,
                ProductPrice = truePrice
                ,
                PromotionPrice = trueProPrice
                ,
                ProductStock = Convert.ToInt32(txtBox_Stock.Text)
                ,
                ProductImage = txtBox_Img.Text.ToString()
                ,
                ProductStatus = isCheck
            };

            var json = JsonConvert.SerializeObject(newProduct);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var idBrand = productID_lbl.Text.ToString();
            string url = GlobalVariable.url + "api/product/update?id=" + idBrand;

            try
            {
                var client = new HttpClient();
                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AdminController.AdminToken);
                client.BaseAddress = new Uri(url);

                var response = await client.PutAsync(url, data);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Update !");
                    Load_List();
                }
                else
                {
                    MessageBox.Show("An Error while updating");
                    Load_List();
                }
            }
            catch
            {
                MessageBox.Show("An Error while updating");
                Load_List();
            }
        }
        private void onlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void createProduct_btn_Click(object sender, EventArgs e)
        {
            CreateProductForm newform = new CreateProductForm(this);
            newform.Show();
        }
        public void DestroyDTDV()
        {
            product_dtgv.DataSource = null;
        }
        private void product_dtgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btn_Find_ClickAsync(object sender, EventArgs e)
        {
            try {
                loading_lbl.Visible = true;
                string productID = txtBox_findByID.Text.ToString();
                string url = GlobalVariable.url + "api/product/detail?id=" + productID;
                string json = await new GlobalVariable().GetApiAsync(url);
                PRODUCT list = JsonConvert.DeserializeObject<PRODUCT>(json);
                if (list != null)
                {
                    List<PRODUCT> listObj = new List<PRODUCT>();
                    listObj.Add(list);
                    product_dtgv.DataSource = null;
                    product_dtgv.DataSource = listObj;
                }
                else
                {
                    MessageBox.Show("Cant Find this ID");
                    Load_List();
                }
                loading_lbl.Visible = false;
            }
            catch
            {
                MessageBox.Show("Error");
                Load_List();
            }


        }
    }
}

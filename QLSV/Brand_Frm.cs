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

namespace QLSV
{
    public partial class Brand_Frm : UserControl
    {
        private string brandtxt_temp = null;
        private static Brand_Frm inst;
        public static Brand_Frm Instance
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                    inst = new Brand_Frm();
                return inst;
            }
        }
        public Brand_Frm()
        {
            InitializeComponent();
            Load_List();
        }

        public async void Load_List()
        {
            //brand_dtgv.Columns.Add("Col1", "Status");
            //brand_dtgv.Rows.Add("Loading...");
            loading_lbl.Visible = true;
            try
            {
                string url = GlobalVariable.url + "api/brand";
                string json = await new GlobalVariable().GetApiAsync(url);
                var list = JsonConvert.DeserializeObject<List<BRAND>>(json);
                brand_dtgv.DataSource = null;
                brand_dtgv.DataSource = list;
                loading_lbl.Visible = false;
            }
            catch
            {
                MessageBox.Show("Cannot get data", "Fail");
                brand_dtgv.DataSource = null;
                loading_lbl.Visible = false;
            }
        }

        private async void createBrand_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(brand_txtbox.Text))
            {
                createBrand_btn.Enabled = false;
                var json = JsonConvert.SerializeObject(new BRAND()
                {
                    BrandName = brand_txtbox.Text
                });
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                string url = GlobalVariable.url + "api/brand/create";

                try
                {
                    var client = new HttpClient();
                    //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AdminController.AdminToken);
                    client.BaseAddress = new Uri(url);

                    var response = await client.PostAsync(url, data);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Create Success", "Success");
                        Load_List();
                    }
                    else
                    {
                        MessageBox.Show(await response.Content.ReadAsStringAsync(), "Fail");
                    }
                    createBrand_btn.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Error while creating brand", "Fail");
                    createBrand_btn.Enabled = true;
                }
            }
        }

        private void brand_dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            brandid_lbl.Text = brand_dtgv.Rows[rowIndex].Cells[0].Value.ToString();
            brandtxt_temp = brand_dtgv.Rows[rowIndex].Cells[1].Value.ToString();
            brandname_txtbox.Text = brand_dtgv.Rows[rowIndex].Cells[1].Value.ToString();
            brandurl_lbl.Text = brand_dtgv.Rows[rowIndex].Cells[2].Value.ToString();
            branddate_lbl.Text = brand_dtgv.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void brandname_txtbox_OnValueChanged(object sender, EventArgs e)
        {
            if (brandname_txtbox.Text != brandtxt_temp)
                brandedit_btn.Enabled = true;
            else
                brandedit_btn.Enabled = false;

        }
        public void DestroyDTGV()
        {
            brand_dtgv.DataSource = null;
        }
        private async void brandedit_btn_Click(object sender, EventArgs e)
        {
            brandedit_btn.Enabled = false;
               var json = JsonConvert.SerializeObject(new BRAND()
            {
                BrandName = brandname_txtbox.Text
            });
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            string url = GlobalVariable.url + "api/brand/update?id=" + brandid_lbl.Text;

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
                brandedit_btn.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Error while updating brand", "Fail"); 
                brandedit_btn.Enabled = true;
            }
        }

        private async void deletebrand_btn_Click(object sender, EventArgs e)
        {
            deletebrand_btn.Enabled = false;
            string url = GlobalVariable.url + "api/brand/delete?id=" + brandid_lbl.Text;

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
                deletebrand_btn.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Error while deleting brand", "Fail");
                deletebrand_btn.Enabled = true;
            }
        }

        private void brand_dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //public bool isClickProduct { get; set; }
        //public bool isClickBrand { get; set; }
        //public bool isClickCustomer { get; set; }
        //public bool isClickOrder { get; set; }
        //public bool isClick { get; set; }
        //private async void SinhVienDTGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    //MessageBox.Show("Row: " + e.RowIndex + " Cells" + e.ColumnIndex + " " + isClickProduct + isClickBrand + isClickCustomer + isClickOrder);
        //    if (isClickBrand)
        //    {
        //        if (e.ColumnIndex == 5)
        //        {
        //            var idBrand = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        //            string url = GlobalVariable.url + "api/brand/delete?id=" + idBrand;
        //            DialogResult dialogResult = MessageBox.Show("Ban co muon xoa Brand hay khong ?", "Canh Bao", MessageBoxButtons.YesNo);
        //            if (dialogResult == DialogResult.Yes)
        //            {
        //                try
        //                {
        //                    var client = new HttpClient();
        //                    //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AdminController.AdminToken);
        //                    client.BaseAddress = new Uri(url);
        //                    var response = await client.DeleteAsync(url);
        //                    if (response.IsSuccessStatusCode)
        //                    {
        //                        MessageBox.Show("Xoa Thanh Cong");
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("Khong Thanh Cong");
        //                    }
        //                }
        //                catch
        //                {
        //                    MessageBox.Show("Khong Thanh Cong");
        //                }
        //            }
        //            else if (dialogResult == DialogResult.No)
        //            {
        //                //Unknow
        //            }
        //            DTGV_Layout_Brand();
        //        }
        //        if (e.ColumnIndex == 4)
        //        {
        //            if (isClick == false)
        //            {
        //                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[1];
        //                dataGridView1.CurrentCell = cell;
        //                dataGridView1.ReadOnly = false;
        //                foreach (DataGridViewRow row in this.dataGridView1.Rows)
        //                {
        //                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
        //                    {
        //                        if (row.Index != e.RowIndex || i != 1)
        //                            row.Cells[i].ReadOnly = true;
        //                        else
        //                        {
        //                            row.Cells[i].ReadOnly = false;
        //                        }
        //                    }
        //                }
        //                isClick = true;
        //            }
        //            else
        //            {
        //                var newBrandName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        //                //MessageBox.Show(newBrandName);
        //                var json = JsonConvert.SerializeObject(new BRAND() { BrandName = newBrandName });
        //                var data = new StringContent(json, Encoding.UTF8, "application/json");
        //                var idBrand = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        //                string url = GlobalVariable.url + "api/brand/update?id=" + idBrand;

        //                try
        //                {
        //                    var client = new HttpClient();
        //                    //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AdminController.AdminToken);
        //                    client.BaseAddress = new Uri(url);

        //                    var response = await client.PutAsync(url, data);
        //                    if (response.IsSuccessStatusCode)
        //                    {
        //                        MessageBox.Show("Update thanh cong");

        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("Update khong thanh cong");
        //                    }
        //                }
        //                catch
        //                {
        //                    MessageBox.Show("Update khong thanh cong");
        //                }
        //                isClick = false;
        //                DTGV_Layout_Brand();
        //            }
        //        }
        //    }

        //    // delete product
        //    if (e.ColumnIndex == 14 && isClickProduct)
        //    {
        //        var idProduct = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        //        string url = GlobalVariable.url + "api/product/delete?id=" + idProduct;
        //        DialogResult dialogResult = MessageBox.Show("Ban co muon xoa San pham hay khong ?", "Canh Bao", MessageBoxButtons.YesNo);
        //        if (dialogResult == DialogResult.Yes)
        //        {
        //            try
        //            {
        //                var client = new HttpClient();
        //                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AdminController.AdminToken);
        //                client.BaseAddress = new Uri(url);
        //                var response = await client.DeleteAsync(url);
        //                if (response.IsSuccessStatusCode)
        //                {
        //                    MessageBox.Show("Xoa Thanh Cong");
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Khong Thanh Cong");
        //                }
        //            }
        //            catch
        //            {
        //                MessageBox.Show("Khong Thanh Cong");
        //            }
        //        }
        //        else if (dialogResult == DialogResult.No)
        //        {
        //            //Unknow
        //        }
        //        DTGV_Layout_product();
        //    }


        //    // chinh sua san pham
        //    if (isClickProduct)
        //    {
        //        if (e.ColumnIndex == 13)
        //        {
        //            if (isClick == false)
        //            {
        //                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[1];
        //                dataGridView1.CurrentCell = cell;
        //                dataGridView1.ReadOnly = false;
        //                //foreach (DataGridViewRow row in this.DTGV.Rows)
        //                //{
        //                //    for (int i = 0; i < DTGV.Columns.Count; i++)
        //                //    {
        //                //        if (row.Index != e.RowIndex || i != 1 || i != 2 || i != 3 || i != 4 || i != 6 || i != 7)
        //                //            row.Cells[i].ReadOnly = true;
        //                //        else
        //                //        {
        //                //            row.Cells[i].ReadOnly = false;
        //                //        }
        //                //    }
        //                //}
        //                isClick = true;
        //            }
        //            else
        //            {
        //                var price = dataGridView1.Rows[e.RowIndex].Cells[3].Value;
        //                int price1 = Convert.ToInt32(price);
        //                var promotePrice = dataGridView1.Rows[e.RowIndex].Cells[4].Value;
        //                int promotePrice1 = Convert.ToInt32(promotePrice);
        //                PRODUCT newPRODUCT = new PRODUCT() { ProductName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), ProductDescription = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()
        //                , ProductPrice = price1
        //                , PromotionPrice = promotePrice1
        //                , ProductURL = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString(), ProductStock = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString()), ProductStatus = true
        //                , ProductImage = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString()
        //                };

        //                var json = JsonConvert.SerializeObject(newPRODUCT);
        //                var data = new StringContent(json, Encoding.UTF8, "application/json");
        //                var idBrand = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        //                string url = GlobalVariable.url + "api/product/update?id=" + idBrand;

        //                try
        //                {
        //                    var client = new HttpClient();
        //                    //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AdminController.AdminToken);
        //                    client.BaseAddress = new Uri(url);

        //                    var response = await client.PutAsync(url, data);
        //                    if (response.IsSuccessStatusCode)
        //                    {
        //                        MessageBox.Show("Update thanh cong");

        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("Update khong thanh cong");
        //                    }
        //                }
        //                catch
        //                {
        //                    MessageBox.Show("Update khong thanh cong");
        //                }
        //                isClick = false;
        //                DTGV_Layout_product();
        //            }
        //        }
        //    }

        //    // delete Customer
        //    if (e.ColumnIndex == 9 && isClickCustomer)
        //    {
        //        var idCustomer = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        //        string url = GlobalVariable.url + "api/customer/delete?id=" + idCustomer;
        //        DialogResult dialogResult = MessageBox.Show("Ban co muon xoa Customer hay khong ?", "Canh Bao", MessageBoxButtons.YesNo);
        //        if (dialogResult == DialogResult.Yes)
        //        {
        //            try
        //            {
        //                var client = new HttpClient();
        //                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AdminController.AdminToken);
        //                client.BaseAddress = new Uri(url);
        //                var response = await client.DeleteAsync(url);
        //                if (response.IsSuccessStatusCode)
        //                {
        //                    MessageBox.Show("Xoa Thanh Cong");
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Khong Thanh Cong");
        //                }
        //            }
        //            catch
        //            {
        //                MessageBox.Show("Khong Thanh Cong");
        //            }
        //        }
        //        else if (dialogResult == DialogResult.No)
        //        {
        //            //Unknow
        //        }
        //        DTGV_Layout_customer();
        //    }
        //}

        //public async void DTGV_Layout(object sender, LayoutEventArgs e)
        //{

        //}


        //public async void DTGV_Layout_Brand()
        //{
        //    isClickBrand = true;
        //    isClickCustomer = false;
        //    isClickOrder = false;
        //    isClickProduct = false;


        //    dataGridView1.Columns.Clear();
        //    dataGridView1.DataSource = null;
        //    string url = GlobalVariable.url + "api/brand";
        //    string json = await new GlobalVariable().GetApiAsync(url);
        //    var list = JsonConvert.DeserializeObject<List<BRAND>>(json);
        //    dataGridView1.DataSource = list;
        //    dataGridView1.ReadOnly = true;

        //    DataGridViewButtonColumn btn_Sua = new DataGridViewButtonColumn();
        //    dataGridView1.Columns.Add(btn_Sua);
        //    btn_Sua.HeaderText = "Chinh Sua";
        //    btn_Sua.Text = "Chinh Sua";
        //    btn_Sua.UseColumnTextForButtonValue = true;

        //    DataGridViewButtonColumn btn_Xoa = new DataGridViewButtonColumn();
        //    dataGridView1.Columns.Add(btn_Xoa);
        //    btn_Xoa.HeaderText = "Xoa";
        //    btn_Xoa.Text = "Xoa Brand";
        //    btn_Xoa.UseColumnTextForButtonValue = true;
        //}
        //public async void DTGV_Layout_product()
        //{
        //    isClickBrand = false;
        //    isClickCustomer = false;
        //    isClickOrder = false;
        //    isClickProduct =  true;

        //    dataGridView1.Columns.Clear();
        //    dataGridView1.DataSource = null;
        //    string url = GlobalVariable.url + "api/product/getall";
        //    string json = await new GlobalVariable().GetApiAsync(url);
        //    var list = JsonConvert.DeserializeObject<List<PRODUCT>>(json);
        //    dataGridView1.DataSource = list;
        //    dataGridView1.ReadOnly = true;

        //    DataGridViewButtonColumn btn_Sua = new DataGridViewButtonColumn();
        //    dataGridView1.Columns.Add(btn_Sua);
        //    btn_Sua.HeaderText = "Chinh Sua";
        //    btn_Sua.Text = "Chinh Sua";
        //    btn_Sua.UseColumnTextForButtonValue = true;

        //    DataGridViewButtonColumn btn_Xoa = new DataGridViewButtonColumn();
        //    dataGridView1.Columns.Add(btn_Xoa);
        //    btn_Xoa.HeaderText = "Xoa";
        //    btn_Xoa.Text = "Xoa san pham";
        //    btn_Xoa.UseColumnTextForButtonValue = true;
        //}
        //public async void DTGV_Layout_customer()
        //{
        //    isClickBrand = false;
        //    isClickCustomer = true;
        //    isClickOrder = false;
        //    isClickProduct = false;

        //    dataGridView1.Columns.Clear();
        //    dataGridView1.DataSource = null;
        //    string url = GlobalVariable.url + "api/customer/getall";
        //    string json = await new GlobalVariable().GetApiAsync(url);
        //    var list = JsonConvert.DeserializeObject<List<CUSTOMER>>(json);
        //    dataGridView1.DataSource = list;
        //    dataGridView1.ReadOnly = true;

        //    DataGridViewButtonColumn btn_Sua = new DataGridViewButtonColumn();
        //    dataGridView1.Columns.Add(btn_Sua);
        //    btn_Sua.HeaderText = "Chinh Sua";
        //    btn_Sua.Text = "Chinh Sua";
        //    btn_Sua.UseColumnTextForButtonValue = true;

        //    DataGridViewButtonColumn btn_Xoa = new DataGridViewButtonColumn();
        //    dataGridView1.Columns.Add(btn_Xoa);
        //    btn_Xoa.HeaderText = "Xoa";
        //    btn_Xoa.Text = "Xoa khach hang";
        //    btn_Xoa.UseColumnTextForButtonValue = true;
        //}

        //public async void DTGV_Layout_order()
        //{

        //    isClickBrand = false;
        //    isClickCustomer = false;
        //    isClickOrder = true;
        //    isClickProduct = false;

        //    dataGridView1.Columns.Clear();
        //    dataGridView1.DataSource = null;
        //    string url = GlobalVariable.url + "api/customer/getall";
        //    string json = await new GlobalVariable().GetApiAsync(url);
        //    var list = JsonConvert.DeserializeObject<List<CUSTOMER>>(json);
        //    dataGridView1.DataSource = list;
        //    dataGridView1.ReadOnly = true;

        //    DataGridViewButtonColumn btn_Sua = new DataGridViewButtonColumn();
        //    dataGridView1.Columns.Add(btn_Sua);
        //    btn_Sua.HeaderText = "Chinh Sua";
        //    btn_Sua.Text = "Chinh Sua";
        //    btn_Sua.UseColumnTextForButtonValue = true;

        //    DataGridViewButtonColumn btn_Xoa = new DataGridViewButtonColumn();
        //    dataGridView1.Columns.Add(btn_Xoa);
        //    btn_Xoa.HeaderText = "Xoa";
        //    btn_Xoa.Text = "Xoa khach hang";
        //    btn_Xoa.UseColumnTextForButtonValue = true;
        //}

        //private void button_taoMoi_Click(object sender, EventArgs e)
        //{
        //    if (isClickBrand)
        //    {
        //        CreateBrandForm brandFormCreate = new CreateBrandForm(this);
        //        brandFormCreate.Show();
        //    }
        //    if (isClickProduct)
        //    {
        //        CreateProductForm productFormCreate = new CreateProductForm(this);
        //        productFormCreate.Show();
        //    }
        //}

        //private void groupBox2_Enter(object sender, EventArgs e)
        //{

        //}
    }
}

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
    public partial class Add_Frm : UserControl
    {
        public bool isClickProduct { get; set; }
        public bool isClickBrand { get; set; }
        public bool isClickCustomer { get; set; }
        public bool isClickOrder { get; set; }
        public bool isClick { get; set; }
        public void Theme(bool e)
        {
            if (e == true)
            {//dark
                DTGV.BackgroundColor = Color.FromArgb(54, 57, 63);
                this.BackColor = Color.FromArgb(54, 57, 63);
            } else if (e == false)
            {//light
                DTGV.BackgroundColor = Color.White;
                this.BackColor = Color.White;
            }
        }

        private const char V = '.';
        private static Add_Frm inst;

       

        public static Add_Frm Instance
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                    inst = new Add_Frm();
                return inst;
            }
        }
        public Add_Frm()
        {
            InitializeComponent();
        }

        public async void Load_List()
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void SinhVienDTGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Row: " + e.RowIndex + " Cells" + e.ColumnIndex + " " + isClickProduct + isClickBrand + isClickCustomer + isClickOrder);
            if (isClickBrand)
            {
                if (e.ColumnIndex == 5)
                {
                    var idBrand = DTGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string url = GlobalVariable.url + "api/brand/delete?id=" + idBrand;
                    DialogResult dialogResult = MessageBox.Show("Ban co muon xoa Brand hay khong ?", "Canh Bao", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            var client = new HttpClient();
                            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AdminController.AdminToken);
                            client.BaseAddress = new Uri(url);
                            var response = await client.DeleteAsync(url);
                            if (response.IsSuccessStatusCode)
                            {
                                MessageBox.Show("Xoa Thanh Cong");
                            }
                            else
                            {
                                MessageBox.Show("Khong Thanh Cong");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Khong Thanh Cong");
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //Unknow
                    }
                    DTGV_Layout_Brand();
                }
                if (e.ColumnIndex == 4)
                {
                    if (isClick == false)
                    {
                        DataGridViewCell cell = DTGV.Rows[e.RowIndex].Cells[1];
                        DTGV.CurrentCell = cell;
                        DTGV.ReadOnly = false;
                        foreach (DataGridViewRow row in this.DTGV.Rows)
                        {
                            for (int i = 0; i < DTGV.Columns.Count; i++)
                            {
                                if (row.Index != e.RowIndex || i != 1)
                                    row.Cells[i].ReadOnly = true;
                                else
                                {
                                    row.Cells[i].ReadOnly = false;
                                }
                            }
                        }
                        isClick = true;
                    }
                    else
                    {
                        var newBrandName = DTGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                        //MessageBox.Show(newBrandName);
                        var json = JsonConvert.SerializeObject(new BRAND() { BrandName = newBrandName });
                        var data = new StringContent(json, Encoding.UTF8, "application/json");
                        var idBrand = DTGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                        string url = GlobalVariable.url + "api/brand/update?id=" + idBrand;

                        try
                        {
                            var client = new HttpClient();
                            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AdminController.AdminToken);
                            client.BaseAddress = new Uri(url);

                            var response = await client.PutAsync(url, data);
                            if (response.IsSuccessStatusCode)
                            {
                                MessageBox.Show("Update thanh cong");

                            }
                            else
                            {
                                MessageBox.Show("Update khong thanh cong");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Update khong thanh cong");
                        }
                        isClick = false;
                        DTGV_Layout_Brand();
                    }
                }
            }

            // delete product
            if (e.ColumnIndex == 14 && isClickProduct)
            {
                var idProduct = DTGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                string url = GlobalVariable.url + "api/product/delete?id=" + idProduct;
                DialogResult dialogResult = MessageBox.Show("Ban co muon xoa San pham hay khong ?", "Canh Bao", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        var client = new HttpClient();
                        //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AdminController.AdminToken);
                        client.BaseAddress = new Uri(url);
                        var response = await client.DeleteAsync(url);
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Xoa Thanh Cong");
                        }
                        else
                        {
                            MessageBox.Show("Khong Thanh Cong");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Khong Thanh Cong");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //Unknow
                }
                DTGV_Layout_product();
            }


            // chinh sua san pham
            if (isClickProduct)
            {
                if (e.ColumnIndex == 13)
                {
                    if (isClick == false)
                    {
                        DataGridViewCell cell = DTGV.Rows[e.RowIndex].Cells[1];
                        DTGV.CurrentCell = cell;
                        DTGV.ReadOnly = false;
                        //foreach (DataGridViewRow row in this.DTGV.Rows)
                        //{
                        //    for (int i = 0; i < DTGV.Columns.Count; i++)
                        //    {
                        //        if (row.Index != e.RowIndex || i != 1 || i != 2 || i != 3 || i != 4 || i != 6 || i != 7)
                        //            row.Cells[i].ReadOnly = true;
                        //        else
                        //        {
                        //            row.Cells[i].ReadOnly = false;
                        //        }
                        //    }
                        //}
                        isClick = true;
                    }
                    else
                    {
                        var price = DTGV.Rows[e.RowIndex].Cells[3].Value;
                        int price1 = Convert.ToInt32(price);
                        var promotePrice = DTGV.Rows[e.RowIndex].Cells[4].Value;
                        int promotePrice1 = Convert.ToInt32(promotePrice);
                        PRODUCT newPRODUCT = new PRODUCT() { ProductName = DTGV.Rows[e.RowIndex].Cells[1].Value.ToString(), ProductDescription = DTGV.Rows[e.RowIndex].Cells[2].Value.ToString()
                        , ProductPrice = price1
                        , PromotionPrice = promotePrice1
                        , ProductURL = DTGV.Rows[e.RowIndex].Cells[6].Value.ToString(), ProductStock = Int32.Parse(DTGV.Rows[e.RowIndex].Cells[7].Value.ToString()), ProductStatus = true
                        , ProductImage = DTGV.Rows[e.RowIndex].Cells[6].Value.ToString()
                        };
                        
                        var json = JsonConvert.SerializeObject(newPRODUCT);
                        var data = new StringContent(json, Encoding.UTF8, "application/json");
                        var idBrand = DTGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                        string url = GlobalVariable.url + "api/product/update?id=" + idBrand;

                        try
                        {
                            var client = new HttpClient();
                            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AdminController.AdminToken);
                            client.BaseAddress = new Uri(url);

                            var response = await client.PutAsync(url, data);
                            if (response.IsSuccessStatusCode)
                            {
                                MessageBox.Show("Update thanh cong");

                            }
                            else
                            {
                                MessageBox.Show("Update khong thanh cong");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Update khong thanh cong");
                        }
                        isClick = false;
                        DTGV_Layout_product();
                    }
                }
            }

            // delete Customer
            if (e.ColumnIndex == 9 && isClickCustomer)
            {
                var idCustomer = DTGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                string url = GlobalVariable.url + "api/customer/delete?id=" + idCustomer;
                DialogResult dialogResult = MessageBox.Show("Ban co muon xoa Customer hay khong ?", "Canh Bao", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        var client = new HttpClient();
                        //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AdminController.AdminToken);
                        client.BaseAddress = new Uri(url);
                        var response = await client.DeleteAsync(url);
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Xoa Thanh Cong");
                        }
                        else
                        {
                            MessageBox.Show("Khong Thanh Cong");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Khong Thanh Cong");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //Unknow
                }
                DTGV_Layout_customer();
            }
        }

        public async void DTGV_Layout(object sender, LayoutEventArgs e)
        {
            
        }


        public async void DTGV_Layout_Brand()
        {
            isClickBrand = true;
            isClickCustomer = false;
            isClickOrder = false;
            isClickProduct = false;


            DTGV.Columns.Clear();
            DTGV.DataSource = null;
            string url = GlobalVariable.url + "api/brand";
            string json = await new GlobalVariable().GetApiAsync(url);
            var list = JsonConvert.DeserializeObject<List<BRAND>>(json);
            DTGV.DataSource = list;
            DTGV.ReadOnly = true;

            DataGridViewButtonColumn btn_Sua = new DataGridViewButtonColumn();
            DTGV.Columns.Add(btn_Sua);
            btn_Sua.HeaderText = "Chinh Sua";
            btn_Sua.Text = "Chinh Sua";
            btn_Sua.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn btn_Xoa = new DataGridViewButtonColumn();
            DTGV.Columns.Add(btn_Xoa);
            btn_Xoa.HeaderText = "Xoa";
            btn_Xoa.Text = "Xoa Brand";
            btn_Xoa.UseColumnTextForButtonValue = true;
        }
        public async void DTGV_Layout_product()
        {
            isClickBrand = false;
            isClickCustomer = false;
            isClickOrder = false;
            isClickProduct =  true;

            DTGV.Columns.Clear();
            DTGV.DataSource = null;
            string url = GlobalVariable.url + "api/product/getall";
            string json = await new GlobalVariable().GetApiAsync(url);
            var list = JsonConvert.DeserializeObject<List<PRODUCT>>(json);
            DTGV.DataSource = list;
            DTGV.ReadOnly = true;

            DataGridViewButtonColumn btn_Sua = new DataGridViewButtonColumn();
            DTGV.Columns.Add(btn_Sua);
            btn_Sua.HeaderText = "Chinh Sua";
            btn_Sua.Text = "Chinh Sua";
            btn_Sua.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn btn_Xoa = new DataGridViewButtonColumn();
            DTGV.Columns.Add(btn_Xoa);
            btn_Xoa.HeaderText = "Xoa";
            btn_Xoa.Text = "Xoa san pham";
            btn_Xoa.UseColumnTextForButtonValue = true;
        }
        public async void DTGV_Layout_customer()
        {
            isClickBrand = false;
            isClickCustomer = true;
            isClickOrder = false;
            isClickProduct = false;

            DTGV.Columns.Clear();
            DTGV.DataSource = null;
            string url = GlobalVariable.url + "api/customer/getall";
            string json = await new GlobalVariable().GetApiAsync(url);
            var list = JsonConvert.DeserializeObject<List<CUSTOMER>>(json);
            DTGV.DataSource = list;
            DTGV.ReadOnly = true;

            DataGridViewButtonColumn btn_Sua = new DataGridViewButtonColumn();
            DTGV.Columns.Add(btn_Sua);
            btn_Sua.HeaderText = "Chinh Sua";
            btn_Sua.Text = "Chinh Sua";
            btn_Sua.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn btn_Xoa = new DataGridViewButtonColumn();
            DTGV.Columns.Add(btn_Xoa);
            btn_Xoa.HeaderText = "Xoa";
            btn_Xoa.Text = "Xoa khach hang";
            btn_Xoa.UseColumnTextForButtonValue = true;
        }

        public async void DTGV_Layout_order()
        {
            
            isClickBrand = false;
            isClickCustomer = false;
            isClickOrder = true;
            isClickProduct = false;

            DTGV.Columns.Clear();
            DTGV.DataSource = null;
            string url = GlobalVariable.url + "api/customer/getall";
            string json = await new GlobalVariable().GetApiAsync(url);
            var list = JsonConvert.DeserializeObject<List<CUSTOMER>>(json);
            DTGV.DataSource = list;
            DTGV.ReadOnly = true;

            DataGridViewButtonColumn btn_Sua = new DataGridViewButtonColumn();
            DTGV.Columns.Add(btn_Sua);
            btn_Sua.HeaderText = "Chinh Sua";
            btn_Sua.Text = "Chinh Sua";
            btn_Sua.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn btn_Xoa = new DataGridViewButtonColumn();
            DTGV.Columns.Add(btn_Xoa);
            btn_Xoa.HeaderText = "Xoa";
            btn_Xoa.Text = "Xoa khach hang";
            btn_Xoa.UseColumnTextForButtonValue = true;
        }

        private void button_taoMoi_Click(object sender, EventArgs e)
        {
            if (isClickBrand)
            {
                CreateBrandForm brandFormCreate = new CreateBrandForm(this);
                brandFormCreate.Show();
            }
            if (isClickProduct)
            {
                CreateProductForm productFormCreate = new CreateProductForm(this);
                productFormCreate.Show();
            }
        }
    }
}

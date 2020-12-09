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
using Newtonsoft.Json;
using APIBanDienThoai.Models;
using System.Net.Http;

namespace QLSV
{
    public partial class OrderForm : UserControl
    {
        private static OrderForm inst;
        public static OrderForm Instance
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                    inst = new OrderForm();
                return inst;
            }
        }
        public async void Load_List()
        {
            //brand_dtgv.Columns.Add("Col1", "Status");
            //brand_dtgv.Rows.Add("Loading...");
            loading_lbl.Visible = true;
            try
            {
                string url = GlobalVariable.url + "api/order/getall";
                string json = await new GlobalVariable().GetApiAsync(url);
                var list = JsonConvert.DeserializeObject<List<ORDER>>(json);
                order_dtgv.DataSource = null;
                order_dtgv.DataSource = list;
                loading_lbl.Visible = false;
            }
            catch
            {
                MessageBox.Show("Cannot get data", "Fail");
                order_dtgv.DataSource = null;
                loading_lbl.Visible = false;
            }
        }
        public OrderForm()
        {
            InitializeComponent();
            Load_List();
        }

        private void order_dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void orderEdit_btn_Click(object sender, EventArgs e)
        {
            //orderEdit_btn.Enabled = false;
            //var json = JsonConvert.SerializeObject(new BRAND()
            //{
            //    BrandName = brandname_txtbox.Text
            //});
            //var data = new StringContent(json, Encoding.UTF8, "application/json");
            //string url = GlobalVariable.url + "api/brand/update?id=" + brandid_lbl.Text;

            //try
            //{
            //    var client = new HttpClient();
            //    //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AdminController.AdminToken);
            //    client.BaseAddress = new Uri(url);

            //    var response = await client.PutAsync(url, data);
            //    if (response.IsSuccessStatusCode)
            //    {
            //        MessageBox.Show("Update Success", "Success");
            //        Load_List();
            //    }
            //    else
            //    {
            //        MessageBox.Show(await response.Content.ReadAsStringAsync(), "Fail");
            //    }
            //    orderEdit_btn.Enabled = true;
            //}
            //catch
            //{
            //    MessageBox.Show("Error while updating brand", "Fail");
            //    orderEdit_btn.Enabled = true;
            //}
        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void order_dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            orderID_lbl.Text = order_dtgv.Rows[rowIndex].Cells[0].Value.ToString();
            txtBox_dateOrder.Text = order_dtgv.Rows[rowIndex].Cells[1].Value.ToString();
            txtBox_total.Text = order_dtgv.Rows[rowIndex].Cells[2].Value.ToString();
            txtBox_cusName.Text = order_dtgv.Rows[rowIndex].Cells[3].Value.ToString();
            txtBox_cusPhone.Text = order_dtgv.Rows[rowIndex].Cells[4].Value.ToString();
            txtBox_cusAddress.Text = order_dtgv.Rows[rowIndex].Cells[5].Value.ToString();
            txtBox_Status.Text = order_dtgv.Rows[rowIndex].Cells[6].Value.ToString();
            try
            {
                lable_CustomerID.Text = order_dtgv.Rows[rowIndex].Cells[7].Value.ToString();
            }
            catch
            {
                lable_CustomerID.Text = null;
            }

        }
    }
}

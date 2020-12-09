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
using Newtonsoft.Json;
using QLSV.Models;
using System.Net.Http;
using QLSV.ChirldForm;

namespace QLSV
{
    public partial class Order_Frm : UserControl
    {
        private int currentrow = 0;
        private static Order_Frm inst;
        public static Order_Frm Instance
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                    inst = new Order_Frm();
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
        public Order_Frm()
        {
            InitializeComponent();
            Load_List();
        }

        private async void orderEdit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                orderEdit_btn.Enabled = false;

                string url = GlobalVariable.url + "api/order/getall";
                string json = await new GlobalVariable().GetApiAsync(url);
                var list = JsonConvert.DeserializeObject<List<ORDER>>(json);

                var order = list.Where(x => x.OrderID == Convert.ToInt32(orderID_lbl.Text)).SingleOrDefault();

                OrderDetail orderdetail_frm = new OrderDetail();

                await orderdetail_frm.LoadData(order);
                orderdetail_frm.Show();
            }
            catch
            {
                MessageBox.Show("Fail to load data"); orderEdit_btn.Enabled = true;
            }
        }

        public async Task<string> LoadStatus(int orderid)
        {
            try
            {
                string url = GlobalVariable.url + "api/order/getorderstatus?orderid=" + orderid;
                string json = await new GlobalVariable().GetApiAsync(url);
                var item = JsonConvert.DeserializeObject<ORDERSTATUS>(json);

                return item.StatusName;
            }
            catch
            {
                return "null";
            }
        }

        private async void order_dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loading_lbl.Visible = true;
            int rowIndex = currentrow = e.RowIndex;
            var orderid = order_dtgv.Rows[rowIndex].Cells[0].Value.ToString();
            txtBox_Status.Text = await LoadStatus(Convert.ToInt32(orderid));

            orderID_lbl.Text = orderid;
            txtBox_dateOrder.Text = order_dtgv.Rows[rowIndex].Cells[1].Value.ToString();

            var total = order_dtgv.Rows[rowIndex].Cells[2].Value;
            txtBox_total.Text = Convert.ToDecimal(total).ToString("#,##0") + "đ";

            var cusName = order_dtgv.Rows[rowIndex].Cells[3].Value;
            txtBox_cusName.Text = (cusName == null) ? "null" : cusName.ToString();

            var cusPhone = order_dtgv.Rows[rowIndex].Cells[4].Value;
            txtBox_cusPhone.Text = (cusPhone == null) ? "null" : cusPhone.ToString();

            var cusAdd = order_dtgv.Rows[rowIndex].Cells[5].Value;
            txtBox_cusAddress.Text = (cusAdd == null) ? "null" : cusAdd.ToString();

            //txtBox_Status.Text = order_dtgv.Rows[rowIndex].Cells[6].Value.ToString();
            var cusID = order_dtgv.Rows[rowIndex].Cells[7].Value;
            lable_CustomerID.Text = (cusID == null) ? "null" : cusID.ToString();

            //txtBox_cusName.Text = order_dtgv.Rows[rowIndex].Cells[3].Value.ToString();
            //txtBox_cusPhone.Text = order_dtgv.Rows[rowIndex].Cells[4].Value.ToString();
            //txtBox_cusAddress.Text = order_dtgv.Rows[rowIndex].Cells[5].Value.ToString();

            loading_lbl.Visible = false;
        }

        private void orderID_lbl_TextChanged(object sender, EventArgs e)
        {
            if (currentrow != 0)
            {
                orderEdit_btn.Enabled = true;
            }
        }
    }
}

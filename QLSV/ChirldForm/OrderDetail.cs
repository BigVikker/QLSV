
using Newtonsoft.Json;
using QLSV.Common;
using QLSV.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV.ChirldForm
{
    public partial class OrderDetail : Form
    {
        public OrderDetail()
        {
            InitializeComponent();
        }

        public async Task LoadData(ORDER order)
        {
            await LoadDTGV(order.OrderID);
            await LoadStatus(order.OrderID);

            orderID_lbl.Text = order.OrderID.ToString();
            OrderDate_lbl.Text = order.OrderDate.ToString();

            total_lbl.Text = order.Total.Value.ToString("#,##0") + "đ";


            var cusName = order.CustomerName;
            txtBox_cusName.Text = (cusName == null) ? "null" : cusName.ToString();

            var cusPhone = order.CustomerPhone;
            txtBox_cusPhone.Text = (cusPhone == null) ? "null" : cusPhone.ToString();

            var cusAdd = order.CustomerAddress;
            txtBox_cusAddress.Text = (cusAdd == null) ? "null" : cusAdd.ToString();

            var cusID = order.CustomerID;
            lable_CustomerID.Text = (cusID == null) ? "null" : cusID.ToString();

        }
        public async Task LoadDTGV(int orderid)
        {
            loading_lbl.Visible = true;
            try
            {
                string url = GlobalVariable.url + "api/order/getproductlist?orderid=" + orderid;
                string json = await new GlobalVariable().GetApiAsync(url);
                var list = JsonConvert.DeserializeObject<List<PRODUCT>>(json);

                orderproduct_dtgv.DataSource = list;
                loading_lbl.Visible = false;
            }
            catch
            {
                MessageBox.Show("Fail to load product data");
            }
        }

        public async Task LoadStatus(int orderid)
        {
            try
            {
                string url = GlobalVariable.url + "api/order/getorderstatus?orderid=" + orderid;
                string json = await new GlobalVariable().GetApiAsync(url);
                var item = JsonConvert.DeserializeObject<ORDERSTATUS>(json);

                txtBox_Status.Text = item.StatusName;
            }
            catch
            {
                MessageBox.Show("Fail to load status data");
            }
        }
            
    }
}

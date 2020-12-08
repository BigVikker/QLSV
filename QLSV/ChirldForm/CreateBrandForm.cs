using APIBanDienThoai.Common;
using APIBanDienThoai.Models;
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
    public partial class CreateBrandForm : Form
    {
        public CreateBrandForm(Brand_Frm add_Frm)
        {
            InitializeComponent();
            this.mainForm = add_Frm;
            
        }
        public Brand_Frm mainForm { get; set; }

        private async void button_submit_Click(object sender, EventArgs e)
        {
            if (textBox_brandName.Text != "")
            {
                var json = JsonConvert.SerializeObject(new BRAND() { BrandName = textBox_brandName.Text });
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                string url = GlobalVariable.url + "api/brand/create";
                try
                {
                    var client = new HttpClient();
                    client.BaseAddress = new Uri(url);
                    var response = await client.PostAsync(url, data);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Succes");
                        //mainForm.DTGV_Layout_Brand();

                    }
                    else
                    {
                        MessageBox.Show("Fail");
                    }
                }
                catch
                {
                    MessageBox.Show("Fail");
                }
                this.Close();
            }
            else MessageBox.Show("Fail");
            
        }
        
    }
}


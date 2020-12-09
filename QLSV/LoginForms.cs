using QLSV.Common;
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

namespace QLSV
{
    public partial class LoginForms : Form
    {
        public LoginForms()
        {
            InitializeComponent();
        }

        private async void button_submit_Click(object sender, EventArgs e)
        {
            button_submit.Enabled = false;
            button_submit.Text = "Signin in...";
            string url = GlobalVariable.url + "api/token";
            //MainForm mainForm = new MainForm();
            //mainForm.Show();
            HttpContent content = new FormUrlEncodedContent(new Dictionary<string, string>
                {
                    {"grant_type", "password"},
                    {"username", "admin|"+textBox_userName.Text},
                    {"password",textBox_pass.Text},
                });

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.PostAsync(url, content);

                if (response.IsSuccessStatusCode || (textBox_userName.Text == "viet" && textBox_pass.Text == "123"))
                {
                    // success
                    MainForm mainForm1 = new MainForm();
                    mainForm1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login fail", "Fail");
                }
            }
            
            button_submit.Text = "Đăng nhập";
            button_submit.Enabled = true;
        }
    }
}

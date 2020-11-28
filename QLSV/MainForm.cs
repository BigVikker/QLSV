﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class MainForm : Form
    {
        public event EventHandler ToggleTheme;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            == DialogResult.Yes)
            {
                Close();
                Environment.Exit(1);
            }
        }

        private void MinimizedBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SideAnimation_Tick(object sender, EventArgs e)
        {
            int X = SidePanel.PointToClient(MousePosition).X;
            int Y = SidePanel.PointToClient(MousePosition).Y;
            if (X > 0 && X < SidePanel.Width && Y > 0 && Y < SidePanel.Height)
            {
                SidePanel.Width = 200;
            }
            else
            {
                SidePanel.Width = 60;
            }
        }

        private void AddForm_Click(object sender, EventArgs e)
        {
            if (!SideUnderPanel.Controls.Contains(Add_Frm.Instance))
            {
                SideUnderPanel.Controls.Add(Add_Frm.Instance);
                Add_Frm.Instance.BringToFront();
            }
            else
            {
                Add_Frm.Instance.BringToFront();
            }
            Add_Frm.Instance.DTGV_Layout_product();
            LabelTextBox.Text = "Quản lý sản phẩm";
        }

        private void ScoreForm_Click(object sender, EventArgs e)
        {
            if (!SideUnderPanel.Controls.Contains(Add_Frm.Instance))
            {
                SideUnderPanel.Controls.Add(Add_Frm.Instance);
                Add_Frm.Instance.BringToFront();
            }
            else
            {
                Add_Frm.Instance.BringToFront();
            }
            Add_Frm.Instance.DTGV_Layout_Brand();
            LabelTextBox.Text = "Quản lý Brand";
        }

        private void ReportForm_Click(object sender, EventArgs e)
        {
            if (!SideUnderPanel.Controls.Contains(Add_Frm.Instance))
            {
                SideUnderPanel.Controls.Add(Add_Frm.Instance);
                Add_Frm.Instance.BringToFront();
            }
            else
            {
                Add_Frm.Instance.BringToFront();
            }
            Add_Frm.Instance.DTGV_Layout_customer();
            LabelTextBox.Text = "Quản lý khách hàng";
        }

        private void AboutForm_Click(object sender, EventArgs e)
        {
            if (!SideUnderPanel.Controls.Contains(Add_Frm.Instance))
            {
                SideUnderPanel.Controls.Add(Add_Frm.Instance);
                Add_Frm.Instance.BringToFront();
            }
            else
            {
                Add_Frm.Instance.BringToFront();
            }
            Add_Frm.Instance.DTGV_Layout_order();
            LabelTextBox.Text = "Quản lý đặt hàng";
        }

    }
}
namespace QLSV
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.RoundForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.UnderPanel = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.AboutForm = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ReportForm = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MenuLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_product = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_brand = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SideUnderPanel = new System.Windows.Forms.Panel();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.LabelTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.MinimizedBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.ExitBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.HeaderDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.SideAnimation = new System.Windows.Forms.Timer(this.components);
            this.UnderPanel.SuspendLayout();
            this.SidePanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizedBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // RoundForm
            // 
            this.RoundForm.ElipseRadius = 5;
            this.RoundForm.TargetControl = this;
            // 
            // UnderPanel
            // 
            this.UnderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.UnderPanel.Controls.Add(this.SidePanel);
            this.UnderPanel.Controls.Add(this.SideUnderPanel);
            this.UnderPanel.Controls.Add(this.HeaderPanel);
            this.UnderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnderPanel.Location = new System.Drawing.Point(0, 0);
            this.UnderPanel.Name = "UnderPanel";
            this.UnderPanel.Size = new System.Drawing.Size(1386, 707);
            this.UnderPanel.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.SidePanel.Controls.Add(this.AboutForm);
            this.SidePanel.Controls.Add(this.ReportForm);
            this.SidePanel.Controls.Add(this.MenuLabel);
            this.SidePanel.Controls.Add(this.btn_product);
            this.SidePanel.Controls.Add(this.btn_brand);
            this.SidePanel.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 41);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(200, 666);
            this.SidePanel.TabIndex = 1;
            this.SidePanel.UseWaitCursor = true;
            // 
            // AboutForm
            // 
            this.AboutForm.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.AboutForm.BackColor = System.Drawing.Color.Transparent;
            this.AboutForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AboutForm.BorderRadius = 0;
            this.AboutForm.ButtonText = "Order";
            this.AboutForm.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.AboutForm.DisabledColor = System.Drawing.Color.Gray;
            this.AboutForm.Iconcolor = System.Drawing.Color.Transparent;
            this.AboutForm.Iconimage = ((System.Drawing.Image)(resources.GetObject("AboutForm.Iconimage")));
            this.AboutForm.Iconimage_right = null;
            this.AboutForm.Iconimage_right_Selected = null;
            this.AboutForm.Iconimage_Selected = null;
            this.AboutForm.IconMarginLeft = 10;
            this.AboutForm.IconMarginRight = 0;
            this.AboutForm.IconRightVisible = true;
            this.AboutForm.IconRightZoom = 0D;
            this.AboutForm.IconVisible = true;
            this.AboutForm.IconZoom = 50D;
            this.AboutForm.IsTab = true;
            this.AboutForm.Location = new System.Drawing.Point(3, 371);
            this.AboutForm.Name = "AboutForm";
            this.AboutForm.Normalcolor = System.Drawing.Color.Transparent;
            this.AboutForm.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(67)))));
            this.AboutForm.OnHoverTextColor = System.Drawing.Color.White;
            this.AboutForm.selected = false;
            this.AboutForm.Size = new System.Drawing.Size(200, 117);
            this.AboutForm.TabIndex = 4;
            this.AboutForm.Text = "Order";
            this.AboutForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AboutForm.Textcolor = System.Drawing.Color.White;
            this.AboutForm.TextFont = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutForm.UseWaitCursor = true;
            this.AboutForm.Click += new System.EventHandler(this.AboutForm_Click);
            // 
            // ReportForm
            // 
            this.ReportForm.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.ReportForm.BackColor = System.Drawing.Color.Transparent;
            this.ReportForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReportForm.BorderRadius = 0;
            this.ReportForm.ButtonText = "Customer";
            this.ReportForm.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ReportForm.DisabledColor = System.Drawing.Color.Gray;
            this.ReportForm.Iconcolor = System.Drawing.Color.Transparent;
            this.ReportForm.Iconimage = ((System.Drawing.Image)(resources.GetObject("ReportForm.Iconimage")));
            this.ReportForm.Iconimage_right = null;
            this.ReportForm.Iconimage_right_Selected = null;
            this.ReportForm.Iconimage_Selected = null;
            this.ReportForm.IconMarginLeft = 10;
            this.ReportForm.IconMarginRight = 0;
            this.ReportForm.IconRightVisible = true;
            this.ReportForm.IconRightZoom = 0D;
            this.ReportForm.IconVisible = true;
            this.ReportForm.IconZoom = 50D;
            this.ReportForm.IsTab = true;
            this.ReportForm.Location = new System.Drawing.Point(0, 253);
            this.ReportForm.Name = "ReportForm";
            this.ReportForm.Normalcolor = System.Drawing.Color.Transparent;
            this.ReportForm.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(67)))));
            this.ReportForm.OnHoverTextColor = System.Drawing.Color.White;
            this.ReportForm.selected = false;
            this.ReportForm.Size = new System.Drawing.Size(200, 112);
            this.ReportForm.TabIndex = 3;
            this.ReportForm.Text = "Customer";
            this.ReportForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReportForm.Textcolor = System.Drawing.Color.White;
            this.ReportForm.TextFont = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportForm.UseWaitCursor = true;
            this.ReportForm.Click += new System.EventHandler(this.ReportForm_Click);
            // 
            // MenuLabel
            // 
            this.MenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuLabel.ForeColor = System.Drawing.Color.White;
            this.MenuLabel.Location = new System.Drawing.Point(100, 0);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(75, 25);
            this.MenuLabel.TabIndex = 2;
            this.MenuLabel.Text = "Menu";
            this.MenuLabel.UseWaitCursor = true;
            // 
            // btn_product
            // 
            this.btn_product.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btn_product.BackColor = System.Drawing.Color.Transparent;
            this.btn_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_product.BorderRadius = 0;
            this.btn_product.ButtonText = "Product";
            this.btn_product.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_product.DisabledColor = System.Drawing.Color.Gray;
            this.btn_product.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_product.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_product.Iconimage")));
            this.btn_product.Iconimage_right = null;
            this.btn_product.Iconimage_right_Selected = null;
            this.btn_product.Iconimage_Selected = null;
            this.btn_product.IconMarginLeft = 10;
            this.btn_product.IconMarginRight = 0;
            this.btn_product.IconRightVisible = true;
            this.btn_product.IconRightZoom = 0D;
            this.btn_product.IconVisible = true;
            this.btn_product.IconZoom = 50D;
            this.btn_product.IsTab = true;
            this.btn_product.Location = new System.Drawing.Point(0, 137);
            this.btn_product.Name = "btn_product";
            this.btn_product.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_product.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(67)))));
            this.btn_product.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_product.selected = false;
            this.btn_product.Size = new System.Drawing.Size(200, 110);
            this.btn_product.TabIndex = 1;
            this.btn_product.Text = "Product";
            this.btn_product.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_product.Textcolor = System.Drawing.Color.White;
            this.btn_product.TextFont = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_product.UseWaitCursor = true;
            this.btn_product.Click += new System.EventHandler(this.ScoreForm_Click);
            // 
            // btn_brand
            // 
            this.btn_brand.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btn_brand.BackColor = System.Drawing.Color.Transparent;
            this.btn_brand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_brand.BorderRadius = 0;
            this.btn_brand.ButtonText = "Brand";
            this.btn_brand.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_brand.DisabledColor = System.Drawing.Color.Gray;
            this.btn_brand.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_brand.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_brand.Iconimage")));
            this.btn_brand.Iconimage_right = null;
            this.btn_brand.Iconimage_right_Selected = null;
            this.btn_brand.Iconimage_Selected = null;
            this.btn_brand.IconMarginLeft = 10;
            this.btn_brand.IconMarginRight = 0;
            this.btn_brand.IconRightVisible = true;
            this.btn_brand.IconRightZoom = 0D;
            this.btn_brand.IconVisible = true;
            this.btn_brand.IconZoom = 50D;
            this.btn_brand.IsTab = true;
            this.btn_brand.Location = new System.Drawing.Point(0, 25);
            this.btn_brand.Name = "btn_brand";
            this.btn_brand.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_brand.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(67)))));
            this.btn_brand.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_brand.selected = false;
            this.btn_brand.Size = new System.Drawing.Size(203, 125);
            this.btn_brand.TabIndex = 0;
            this.btn_brand.Text = "Brand";
            this.btn_brand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_brand.Textcolor = System.Drawing.Color.White;
            this.btn_brand.TextFont = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_brand.UseWaitCursor = true;
            this.btn_brand.Click += new System.EventHandler(this.AddForm_Click);
            // 
            // SideUnderPanel
            // 
            this.SideUnderPanel.BackColor = System.Drawing.Color.Transparent;
            this.SideUnderPanel.Location = new System.Drawing.Point(55, 44);
            this.SideUnderPanel.Name = "SideUnderPanel";
            this.SideUnderPanel.Size = new System.Drawing.Size(1351, 660);
            this.SideUnderPanel.TabIndex = 2;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.AutoSize = true;
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.HeaderPanel.Controls.Add(this.LabelTextBox);
            this.HeaderPanel.Controls.Add(this.MinimizedBtn);
            this.HeaderPanel.Controls.Add(this.ExitBtn);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1386, 41);
            this.HeaderPanel.TabIndex = 0;
            // 
            // LabelTextBox
            // 
            this.LabelTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.LabelTextBox.BorderColor = System.Drawing.Color.Transparent;
            this.LabelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LabelTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LabelTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTextBox.ForeColor = System.Drawing.Color.White;
            this.LabelTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.LabelTextBox.Location = new System.Drawing.Point(390, 10);
            this.LabelTextBox.Name = "LabelTextBox";
            this.LabelTextBox.ReadOnly = true;
            this.LabelTextBox.Size = new System.Drawing.Size(294, 28);
            this.LabelTextBox.TabIndex = 2;
            this.LabelTextBox.TabStop = false;
            this.LabelTextBox.Text = "Quản lý shop ";
            this.LabelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MinimizedBtn
            // 
            this.MinimizedBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinimizedBtn.Image = ((System.Drawing.Image)(resources.GetObject("MinimizedBtn.Image")));
            this.MinimizedBtn.ImageActive = null;
            this.MinimizedBtn.Location = new System.Drawing.Point(1331, 8);
            this.MinimizedBtn.Name = "MinimizedBtn";
            this.MinimizedBtn.Size = new System.Drawing.Size(30, 30);
            this.MinimizedBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizedBtn.TabIndex = 1;
            this.MinimizedBtn.TabStop = false;
            this.MinimizedBtn.Zoom = 20;
            this.MinimizedBtn.Click += new System.EventHandler(this.MinimizedBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.ImageActive = null;
            this.ExitBtn.Location = new System.Drawing.Point(1367, 8);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(30, 30);
            this.ExitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Zoom = 20;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // HeaderDragControl
            // 
            this.HeaderDragControl.Fixed = true;
            this.HeaderDragControl.Horizontal = true;
            this.HeaderDragControl.TargetControl = this.HeaderPanel;
            this.HeaderDragControl.Vertical = true;
            // 
            // SideAnimation
            // 
            this.SideAnimation.Enabled = true;
            this.SideAnimation.Interval = 160;
            this.SideAnimation.Tick += new System.EventHandler(this.SideAnimation_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 707);
            this.Controls.Add(this.UnderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.UnderPanel.ResumeLayout(false);
            this.UnderPanel.PerformLayout();
            this.SidePanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizedBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse RoundForm;
        private System.Windows.Forms.Panel UnderPanel;
        private Bunifu.Framework.UI.BunifuDragControl HeaderDragControl;
        private Bunifu.Framework.UI.BunifuImageButton ExitBtn;
        private Bunifu.Framework.UI.BunifuImageButton MinimizedBtn;
        private System.Windows.Forms.Panel SidePanel;
        private Bunifu.Framework.UI.BunifuFlatButton btn_brand;
        private System.Windows.Forms.Timer SideAnimation;
        private Bunifu.Framework.UI.BunifuFlatButton btn_product;
        private Bunifu.Framework.UI.BunifuCustomLabel MenuLabel;
        private Bunifu.Framework.UI.BunifuFlatButton AboutForm;
        private Bunifu.Framework.UI.BunifuFlatButton ReportForm;
        private System.Windows.Forms.Panel SideUnderPanel;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox LabelTextBox;
        public System.Windows.Forms.Panel HeaderPanel;
    }
}


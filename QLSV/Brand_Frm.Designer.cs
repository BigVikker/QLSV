namespace QLSV
{
    partial class Brand_Frm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RoundCorner = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.brand_dtgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label_ThongBao = new System.Windows.Forms.Label();
            this.brand_txtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.createBrand_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.brandname_txtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.brandid_lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.brandurl_lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.branddate_lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.brandedit_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.deletebrand_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.loading_lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brand_dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // RoundCorner
            // 
            this.RoundCorner.ElipseRadius = 10;
            this.RoundCorner.TargetControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.loading_lbl);
            this.groupBox2.Controls.Add(this.brand_dtgv);
            this.groupBox2.Location = new System.Drawing.Point(161, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 386);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // brand_dtgv
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.brand_dtgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.brand_dtgv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.brand_dtgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.brand_dtgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.brand_dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.brand_dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.brand_dtgv.DoubleBuffered = true;
            this.brand_dtgv.EnableHeadersVisualStyles = false;
            this.brand_dtgv.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.brand_dtgv.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.brand_dtgv.Location = new System.Drawing.Point(6, 15);
            this.brand_dtgv.Name = "brand_dtgv";
            this.brand_dtgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.brand_dtgv.Size = new System.Drawing.Size(496, 367);
            this.brand_dtgv.TabIndex = 7;
            this.brand_dtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.brand_dtgv_CellClick);
            // 
            // label_ThongBao
            // 
            this.label_ThongBao.AutoSize = true;
            this.label_ThongBao.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ThongBao.ForeColor = System.Drawing.Color.Lime;
            this.label_ThongBao.Location = new System.Drawing.Point(232, 0);
            this.label_ThongBao.Name = "label_ThongBao";
            this.label_ThongBao.Size = new System.Drawing.Size(505, 40);
            this.label_ThongBao.TabIndex = 4;
            this.label_ThongBao.Text = "Phần mềm quản lý shop điện thoại";
            // 
            // brand_txtbox
            // 
            this.brand_txtbox.BackColor = System.Drawing.Color.White;
            this.brand_txtbox.BorderColorFocused = System.Drawing.Color.Lime;
            this.brand_txtbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.brand_txtbox.BorderColorMouseHover = System.Drawing.Color.LimeGreen;
            this.brand_txtbox.BorderThickness = 3;
            this.brand_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.brand_txtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.brand_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.brand_txtbox.isPassword = false;
            this.brand_txtbox.Location = new System.Drawing.Point(167, 98);
            this.brand_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.brand_txtbox.Name = "brand_txtbox";
            this.brand_txtbox.Size = new System.Drawing.Size(276, 44);
            this.brand_txtbox.TabIndex = 5;
            this.brand_txtbox.Text = "Brand Name";
            this.brand_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // createBrand_btn
            // 
            this.createBrand_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.createBrand_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.createBrand_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.createBrand_btn.BorderRadius = 0;
            this.createBrand_btn.ButtonText = "Create";
            this.createBrand_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createBrand_btn.DisabledColor = System.Drawing.Color.Gray;
            this.createBrand_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.createBrand_btn.Iconimage = null;
            this.createBrand_btn.Iconimage_right = null;
            this.createBrand_btn.Iconimage_right_Selected = null;
            this.createBrand_btn.Iconimage_Selected = null;
            this.createBrand_btn.IconMarginLeft = 0;
            this.createBrand_btn.IconMarginRight = 0;
            this.createBrand_btn.IconRightVisible = true;
            this.createBrand_btn.IconRightZoom = 0D;
            this.createBrand_btn.IconVisible = true;
            this.createBrand_btn.IconZoom = 90D;
            this.createBrand_btn.IsTab = false;
            this.createBrand_btn.Location = new System.Drawing.Point(483, 98);
            this.createBrand_btn.Name = "createBrand_btn";
            this.createBrand_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.createBrand_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.createBrand_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.createBrand_btn.selected = false;
            this.createBrand_btn.Size = new System.Drawing.Size(146, 44);
            this.createBrand_btn.TabIndex = 6;
            this.createBrand_btn.Text = "Create";
            this.createBrand_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.createBrand_btn.Textcolor = System.Drawing.Color.White;
            this.createBrand_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBrand_btn.Click += new System.EventHandler(this.createBrand_btn_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(721, 243);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(26, 20);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "ID";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(721, 386);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(105, 20);
            this.bunifuCustomLabel3.TabIndex = 10;
            this.bunifuCustomLabel3.Text = "Created Date";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(721, 340);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(42, 20);
            this.bunifuCustomLabel4.TabIndex = 9;
            this.bunifuCustomLabel4.Text = "URL";
            // 
            // brandname_txtbox
            // 
            this.brandname_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.brandname_txtbox.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.brandname_txtbox.ForeColor = System.Drawing.Color.White;
            this.brandname_txtbox.HintForeColor = System.Drawing.Color.Empty;
            this.brandname_txtbox.HintText = "";
            this.brandname_txtbox.isPassword = false;
            this.brandname_txtbox.LineFocusedColor = System.Drawing.Color.Lime;
            this.brandname_txtbox.LineIdleColor = System.Drawing.Color.Gray;
            this.brandname_txtbox.LineMouseHoverColor = System.Drawing.Color.Lime;
            this.brandname_txtbox.LineThickness = 4;
            this.brandname_txtbox.Location = new System.Drawing.Point(859, 280);
            this.brandname_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.brandname_txtbox.Name = "brandname_txtbox";
            this.brandname_txtbox.Size = new System.Drawing.Size(171, 33);
            this.brandname_txtbox.TabIndex = 12;
            this.brandname_txtbox.Text = "Brand Name";
            this.brandname_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.brandname_txtbox.OnValueChanged += new System.EventHandler(this.brandname_txtbox_OnValueChanged);
            // 
            // brandid_lbl
            // 
            this.brandid_lbl.AutoSize = true;
            this.brandid_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandid_lbl.ForeColor = System.Drawing.Color.White;
            this.brandid_lbl.Location = new System.Drawing.Point(855, 243);
            this.brandid_lbl.Name = "brandid_lbl";
            this.brandid_lbl.Size = new System.Drawing.Size(26, 20);
            this.brandid_lbl.TabIndex = 13;
            this.brandid_lbl.Text = "ID";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(721, 293);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(98, 20);
            this.bunifuCustomLabel5.TabIndex = 14;
            this.bunifuCustomLabel5.Text = "Brand Name";
            // 
            // brandurl_lbl
            // 
            this.brandurl_lbl.AutoSize = true;
            this.brandurl_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandurl_lbl.ForeColor = System.Drawing.Color.White;
            this.brandurl_lbl.Location = new System.Drawing.Point(855, 340);
            this.brandurl_lbl.Name = "brandurl_lbl";
            this.brandurl_lbl.Size = new System.Drawing.Size(42, 20);
            this.brandurl_lbl.TabIndex = 15;
            this.brandurl_lbl.Text = "URL";
            // 
            // branddate_lbl
            // 
            this.branddate_lbl.AutoSize = true;
            this.branddate_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branddate_lbl.ForeColor = System.Drawing.Color.White;
            this.branddate_lbl.Location = new System.Drawing.Point(855, 386);
            this.branddate_lbl.Name = "branddate_lbl";
            this.branddate_lbl.Size = new System.Drawing.Size(105, 20);
            this.branddate_lbl.TabIndex = 16;
            this.branddate_lbl.Text = "Created Date";
            // 
            // brandedit_btn
            // 
            this.brandedit_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.brandedit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.brandedit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.brandedit_btn.BorderRadius = 0;
            this.brandedit_btn.ButtonText = "Edit";
            this.brandedit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brandedit_btn.DisabledColor = System.Drawing.Color.Gray;
            this.brandedit_btn.Enabled = false;
            this.brandedit_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.brandedit_btn.Iconimage = null;
            this.brandedit_btn.Iconimage_right = null;
            this.brandedit_btn.Iconimage_right_Selected = null;
            this.brandedit_btn.Iconimage_Selected = null;
            this.brandedit_btn.IconMarginLeft = 0;
            this.brandedit_btn.IconMarginRight = 0;
            this.brandedit_btn.IconRightVisible = true;
            this.brandedit_btn.IconRightZoom = 0D;
            this.brandedit_btn.IconVisible = true;
            this.brandedit_btn.IconZoom = 90D;
            this.brandedit_btn.IsTab = false;
            this.brandedit_btn.Location = new System.Drawing.Point(859, 449);
            this.brandedit_btn.Name = "brandedit_btn";
            this.brandedit_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.brandedit_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.brandedit_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.brandedit_btn.selected = false;
            this.brandedit_btn.Size = new System.Drawing.Size(146, 44);
            this.brandedit_btn.TabIndex = 17;
            this.brandedit_btn.Text = "Edit";
            this.brandedit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.brandedit_btn.Textcolor = System.Drawing.Color.White;
            this.brandedit_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandedit_btn.Click += new System.EventHandler(this.brandedit_btn_Click);
            // 
            // deletebrand_btn
            // 
            this.deletebrand_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.deletebrand_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.deletebrand_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deletebrand_btn.BorderRadius = 0;
            this.deletebrand_btn.ButtonText = "Delete";
            this.deletebrand_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebrand_btn.DisabledColor = System.Drawing.Color.Gray;
            this.deletebrand_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.deletebrand_btn.Iconimage = null;
            this.deletebrand_btn.Iconimage_right = null;
            this.deletebrand_btn.Iconimage_right_Selected = null;
            this.deletebrand_btn.Iconimage_Selected = null;
            this.deletebrand_btn.IconMarginLeft = 0;
            this.deletebrand_btn.IconMarginRight = 0;
            this.deletebrand_btn.IconRightVisible = true;
            this.deletebrand_btn.IconRightZoom = 0D;
            this.deletebrand_btn.IconVisible = true;
            this.deletebrand_btn.IconZoom = 90D;
            this.deletebrand_btn.IsTab = false;
            this.deletebrand_btn.Location = new System.Drawing.Point(859, 509);
            this.deletebrand_btn.Name = "deletebrand_btn";
            this.deletebrand_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.deletebrand_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.deletebrand_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.deletebrand_btn.selected = false;
            this.deletebrand_btn.Size = new System.Drawing.Size(146, 44);
            this.deletebrand_btn.TabIndex = 18;
            this.deletebrand_btn.Text = "Delete";
            this.deletebrand_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deletebrand_btn.Textcolor = System.Drawing.Color.White;
            this.deletebrand_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebrand_btn.Click += new System.EventHandler(this.deletebrand_btn_Click);
            // 
            // loading_lbl
            // 
            this.loading_lbl.AutoSize = true;
            this.loading_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loading_lbl.ForeColor = System.Drawing.Color.White;
            this.loading_lbl.Location = new System.Drawing.Point(204, 158);
            this.loading_lbl.Name = "loading_lbl";
            this.loading_lbl.Size = new System.Drawing.Size(78, 20);
            this.loading_lbl.TabIndex = 19;
            this.loading_lbl.Text = "Loading...";
            this.loading_lbl.Visible = false;
            // 
            // Brand_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.deletebrand_btn);
            this.Controls.Add(this.brandedit_btn);
            this.Controls.Add(this.branddate_lbl);
            this.Controls.Add(this.brandurl_lbl);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.brandid_lbl);
            this.Controls.Add(this.brandname_txtbox);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.createBrand_btn);
            this.Controls.Add(this.brand_txtbox);
            this.Controls.Add(this.label_ThongBao);
            this.Controls.Add(this.groupBox2);
            this.Name = "Brand_Frm";
            this.Size = new System.Drawing.Size(1265, 639);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brand_dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse RoundCorner;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_ThongBao;
        private Bunifu.Framework.UI.BunifuFlatButton createBrand_btn;
        private Bunifu.Framework.UI.BunifuMetroTextbox brand_txtbox;
        private Bunifu.Framework.UI.BunifuCustomDataGrid brand_dtgv;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox brandname_txtbox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel brandid_lbl;
        private Bunifu.Framework.UI.BunifuCustomLabel branddate_lbl;
        private Bunifu.Framework.UI.BunifuCustomLabel brandurl_lbl;
        private Bunifu.Framework.UI.BunifuFlatButton brandedit_btn;
        private Bunifu.Framework.UI.BunifuFlatButton deletebrand_btn;
        private Bunifu.Framework.UI.BunifuCustomLabel loading_lbl;
    }
}

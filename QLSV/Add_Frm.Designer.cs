namespace QLSV
{
    partial class Add_Frm
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
            this.DTGV = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.button_taoMoi = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV)).BeginInit();
            this.SuspendLayout();
            // 
            // RoundCorner
            // 
            this.RoundCorner.ElipseRadius = 10;
            this.RoundCorner.TargetControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DTGV);
            this.groupBox2.Location = new System.Drawing.Point(17, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(986, 436);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // DTGV
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DTGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DTGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.DTGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DTGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DTGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGV.DoubleBuffered = true;
            this.DTGV.EnableHeadersVisualStyles = false;
            this.DTGV.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DTGV.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.DTGV.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.DTGV.Location = new System.Drawing.Point(6, 19);
            this.DTGV.Name = "DTGV";
            this.DTGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DTGV.Size = new System.Drawing.Size(974, 413);
            this.DTGV.TabIndex = 0;
            this.DTGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SinhVienDTGV_CellContentClick);
            // 
            // button_taoMoi
            // 
            this.button_taoMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_taoMoi.Location = new System.Drawing.Point(886, 8);
            this.button_taoMoi.Name = "button_taoMoi";
            this.button_taoMoi.Size = new System.Drawing.Size(100, 34);
            this.button_taoMoi.TabIndex = 3;
            this.button_taoMoi.Text = "Tạo mới";
            this.button_taoMoi.UseVisualStyleBackColor = false;
            this.button_taoMoi.Click += new System.EventHandler(this.button_taoMoi_Click);
            // 
            // Add_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.button_taoMoi);
            this.Controls.Add(this.groupBox2);
            this.Name = "Add_Frm";
            this.Size = new System.Drawing.Size(1020, 500);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse RoundCorner;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DTGV;
        private System.Windows.Forms.Button button_taoMoi;
    }
}

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
            this.RoundCorner = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_taoMoi = new System.Windows.Forms.Button();
            this.label_ThongBao = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RoundCorner
            // 
            this.RoundCorner.ElipseRadius = 10;
            this.RoundCorner.TargetControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(17, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(971, 388);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(959, 363);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SinhVienDTGV_CellContentClick);
            // 
            // button_taoMoi
            // 
            this.button_taoMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_taoMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_taoMoi.Location = new System.Drawing.Point(864, 45);
            this.button_taoMoi.Name = "button_taoMoi";
            this.button_taoMoi.Size = new System.Drawing.Size(118, 34);
            this.button_taoMoi.TabIndex = 3;
            this.button_taoMoi.Text = "Tạo mới";
            this.button_taoMoi.UseVisualStyleBackColor = false;
            this.button_taoMoi.Click += new System.EventHandler(this.button_taoMoi_Click);
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
            // Add_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.label_ThongBao);
            this.Controls.Add(this.button_taoMoi);
            this.Controls.Add(this.groupBox2);
            this.Name = "Add_Frm";
            this.Size = new System.Drawing.Size(1000, 486);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse RoundCorner;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_taoMoi;
        private System.Windows.Forms.Label label_ThongBao;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

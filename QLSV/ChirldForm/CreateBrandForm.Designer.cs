namespace QLSV.ChirldForm
{
    partial class CreateBrandForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_brandName = new System.Windows.Forms.Label();
            this.textBox_brandName = new System.Windows.Forms.TextBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo brand mới";
            // 
            // label_brandName
            // 
            this.label_brandName.AutoSize = true;
            this.label_brandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_brandName.Location = new System.Drawing.Point(47, 75);
            this.label_brandName.Name = "label_brandName";
            this.label_brandName.Size = new System.Drawing.Size(111, 18);
            this.label_brandName.TabIndex = 1;
            this.label_brandName.Text = "Tên brand mới :";
            // 
            // textBox_brandName
            // 
            this.textBox_brandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_brandName.Location = new System.Drawing.Point(164, 73);
            this.textBox_brandName.Name = "textBox_brandName";
            this.textBox_brandName.Size = new System.Drawing.Size(214, 22);
            this.textBox_brandName.TabIndex = 2;
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(152, 137);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(115, 23);
            this.button_submit.TabIndex = 3;
            this.button_submit.Text = "xác nhận";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // CreateBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 212);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.textBox_brandName);
            this.Controls.Add(this.label_brandName);
            this.Controls.Add(this.label1);
            this.Name = "CreateBrand";
            this.Text = "CreateBrand";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_brandName;
        private System.Windows.Forms.TextBox textBox_brandName;
        private System.Windows.Forms.Button button_submit;
    }
}
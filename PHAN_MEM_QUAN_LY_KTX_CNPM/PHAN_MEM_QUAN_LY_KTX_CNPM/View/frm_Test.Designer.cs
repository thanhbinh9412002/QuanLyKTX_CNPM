
namespace PHAN_MEM_QUAN_LY_KTX_CNPM
{
    partial class frm_Test
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
            this.btn_Phong = new System.Windows.Forms.Button();
            this.btn_SinhVien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Phong
            // 
            this.btn_Phong.Location = new System.Drawing.Point(103, 79);
            this.btn_Phong.Name = "btn_Phong";
            this.btn_Phong.Size = new System.Drawing.Size(123, 66);
            this.btn_Phong.TabIndex = 0;
            this.btn_Phong.Text = "Phòng";
            this.btn_Phong.UseVisualStyleBackColor = true;
            this.btn_Phong.Click += new System.EventHandler(this.btn_Phong_Click);
            // 
            // btn_SinhVien
            // 
            this.btn_SinhVien.Location = new System.Drawing.Point(321, 79);
            this.btn_SinhVien.Name = "btn_SinhVien";
            this.btn_SinhVien.Size = new System.Drawing.Size(123, 66);
            this.btn_SinhVien.TabIndex = 1;
            this.btn_SinhVien.Text = "Sinh Viên";
            this.btn_SinhVien.UseVisualStyleBackColor = true;
            this.btn_SinhVien.Click += new System.EventHandler(this.btn_SinhVien_Click);
            // 
            // frm_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_SinhVien);
            this.Controls.Add(this.btn_Phong);
            this.Name = "frm_Test";
            this.Text = "frm_Test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Phong;
        private System.Windows.Forms.Button btn_SinhVien;
    }
}
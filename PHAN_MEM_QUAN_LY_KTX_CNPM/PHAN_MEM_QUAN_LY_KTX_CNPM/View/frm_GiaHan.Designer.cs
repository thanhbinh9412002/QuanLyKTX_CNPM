
namespace PHAN_MEM_QUAN_LY_KTX_CNPM
{
    partial class frm_GiaHan
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
            this.groupBox_giahan = new System.Windows.Forms.GroupBox();
            this.txt_masv = new PHAN_MEM_QUAN_LY_KTX_CNPM.effect.RJTextBox();
            this.btn_goi = new CustomButton.VBButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbb_soky = new System.Windows.Forms.ComboBox();
            this.groupBox_giahan.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_giahan
            // 
            this.groupBox_giahan.Controls.Add(this.cbb_soky);
            this.groupBox_giahan.Controls.Add(this.txt_masv);
            this.groupBox_giahan.Controls.Add(this.btn_goi);
            this.groupBox_giahan.Controls.Add(this.label9);
            this.groupBox_giahan.Controls.Add(this.label10);
            this.groupBox_giahan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_giahan.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox_giahan.Location = new System.Drawing.Point(98, 67);
            this.groupBox_giahan.Name = "groupBox_giahan";
            this.groupBox_giahan.Size = new System.Drawing.Size(695, 320);
            this.groupBox_giahan.TabIndex = 44;
            this.groupBox_giahan.TabStop = false;
            this.groupBox_giahan.Text = "Gia hạn";
            // 
            // txt_masv
            // 
            this.txt_masv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_masv.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_masv.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_masv.BorderSize = 2;
            this.txt_masv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_masv.ForeColor = System.Drawing.Color.DimGray;
            this.txt_masv.Location = new System.Drawing.Point(394, 83);
            this.txt_masv.Margin = new System.Windows.Forms.Padding(4);
            this.txt_masv.Multiline = false;
            this.txt_masv.Name = "txt_masv";
            this.txt_masv.Padding = new System.Windows.Forms.Padding(7);
            this.txt_masv.PasswordChar = false;
            this.txt_masv.Size = new System.Drawing.Size(104, 31);
            this.txt_masv.TabIndex = 43;
            this.txt_masv.Texts = "";
            this.txt_masv.UnderlinedStyle = false;
            // 
            // btn_goi
            // 
            this.btn_goi.BackColor = System.Drawing.Color.LightCoral;
            this.btn_goi.BackgroundColor = System.Drawing.Color.LightCoral;
            this.btn_goi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_goi.BorderRadius = 20;
            this.btn_goi.BorderSize = 0;
            this.btn_goi.FlatAppearance.BorderSize = 0;
            this.btn_goi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_goi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_goi.ForeColor = System.Drawing.Color.Black;
            this.btn_goi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_goi.Location = new System.Drawing.Point(301, 196);
            this.btn_goi.Name = "btn_goi";
            this.btn_goi.Size = new System.Drawing.Size(118, 58);
            this.btn_goi.TabIndex = 42;
            this.btn_goi.Text = "Gởi";
            this.btn_goi.TextColor = System.Drawing.Color.Black;
            this.btn_goi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_goi.UseVisualStyleBackColor = false;
            this.btn_goi.Click += new System.EventHandler(this.btn_goi_Click);
            // 
            // label9
            // 
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(244, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 36);
            this.label9.TabIndex = 39;
            this.label9.Text = "Số kỳ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(188, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 44);
            this.label10.TabIndex = 34;
            this.label10.Text = "Mã sinh viên";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbb_soky
            // 
            this.cbb_soky.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbb_soky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_soky.FormattingEnabled = true;
            this.cbb_soky.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbb_soky.Location = new System.Drawing.Point(394, 129);
            this.cbb_soky.Name = "cbb_soky";
            this.cbb_soky.Size = new System.Drawing.Size(104, 28);
            this.cbb_soky.TabIndex = 44;
            // 
            // frm_GiaHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(879, 486);
            this.Controls.Add(this.groupBox_giahan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_GiaHan";
            this.Text = "frm_GiaHan";
            this.Load += new System.EventHandler(this.frm_GiaHan_Load);
            this.groupBox_giahan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_giahan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private CustomButton.VBButton btn_goi;
        private effect.RJTextBox txt_masv;
        private System.Windows.Forms.ComboBox cbb_soky;
    }
}
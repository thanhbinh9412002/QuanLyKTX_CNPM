
namespace PHAN_MEM_QUAN_LY_KTX_CNPM
{
    partial class frm_TraPhong
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
            this.groupBox_traphong = new System.Windows.Forms.GroupBox();
            this.btn_goi = new CustomButton.VBButton();
            this.dateTimePicker_ngaytra = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_maphong = new System.Windows.Forms.TextBox();
            this.txt_masv = new System.Windows.Forms.TextBox();
            this.groupBox_traphong.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_traphong
            // 
            this.groupBox_traphong.Controls.Add(this.txt_masv);
            this.groupBox_traphong.Controls.Add(this.txt_maphong);
            this.groupBox_traphong.Controls.Add(this.btn_goi);
            this.groupBox_traphong.Controls.Add(this.dateTimePicker_ngaytra);
            this.groupBox_traphong.Controls.Add(this.label6);
            this.groupBox_traphong.Controls.Add(this.label2);
            this.groupBox_traphong.Controls.Add(this.label7);
            this.groupBox_traphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_traphong.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox_traphong.Location = new System.Drawing.Point(92, 56);
            this.groupBox_traphong.Name = "groupBox_traphong";
            this.groupBox_traphong.Size = new System.Drawing.Size(704, 333);
            this.groupBox_traphong.TabIndex = 40;
            this.groupBox_traphong.TabStop = false;
            this.groupBox_traphong.Text = "Trả phòng";
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
            this.btn_goi.Location = new System.Drawing.Point(270, 252);
            this.btn_goi.Name = "btn_goi";
            this.btn_goi.Size = new System.Drawing.Size(118, 58);
            this.btn_goi.TabIndex = 43;
            this.btn_goi.Text = "Gởi";
            this.btn_goi.TextColor = System.Drawing.Color.Black;
            this.btn_goi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_goi.UseVisualStyleBackColor = false;
            this.btn_goi.Click += new System.EventHandler(this.btn_goi_Click);
            // 
            // dateTimePicker_ngaytra
            // 
            this.dateTimePicker_ngaytra.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker_ngaytra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_ngaytra.Location = new System.Drawing.Point(357, 190);
            this.dateTimePicker_ngaytra.Name = "dateTimePicker_ngaytra";
            this.dateTimePicker_ngaytra.Size = new System.Drawing.Size(220, 26);
            this.dateTimePicker_ngaytra.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(190, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 37);
            this.label6.TabIndex = 41;
            this.label6.Text = "Ngày trả";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 32);
            this.label2.TabIndex = 39;
            this.label2.Text = "Mã sinh viên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(153, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 42);
            this.label7.TabIndex = 34;
            this.label7.Text = "Mã phòng";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_maphong
            // 
            this.txt_maphong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_maphong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_maphong.Location = new System.Drawing.Point(357, 62);
            this.txt_maphong.Name = "txt_maphong";
            this.txt_maphong.Size = new System.Drawing.Size(135, 38);
            this.txt_maphong.TabIndex = 44;
            // 
            // txt_masv
            // 
            this.txt_masv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_masv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_masv.Location = new System.Drawing.Point(357, 126);
            this.txt_masv.Name = "txt_masv";
            this.txt_masv.Size = new System.Drawing.Size(135, 38);
            this.txt_masv.TabIndex = 45;
            // 
            // frm_TraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(879, 486);
            this.Controls.Add(this.groupBox_traphong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_TraPhong";
            this.Text = "frm_TraPhong";
            this.Load += new System.EventHandler(this.frm_TraPhong_Load);
            this.groupBox_traphong.ResumeLayout(false);
            this.groupBox_traphong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_traphong;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngaytra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private CustomButton.VBButton btn_goi;
        private System.Windows.Forms.TextBox txt_masv;
        private System.Windows.Forms.TextBox txt_maphong;
    }
}
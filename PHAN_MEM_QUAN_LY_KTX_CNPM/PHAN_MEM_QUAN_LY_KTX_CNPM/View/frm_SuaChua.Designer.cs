
namespace PHAN_MEM_QUAN_LY_KTX_CNPM
{
    partial class frm_SuaChua
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
            this.groupBox_suachua = new System.Windows.Forms.GroupBox();
            this.btn_goi = new CustomButton.VBButton();
            this.cbb_tenthietbi_suachua = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_chitiet_suachua = new PHAN_MEM_QUAN_LY_KTX_CNPM.effect.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_soluong_suachua = new PHAN_MEM_QUAN_LY_KTX_CNPM.effect.RJTextBox();
            this.groupBox_suachua.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_suachua
            // 
            this.groupBox_suachua.Controls.Add(this.btn_goi);
            this.groupBox_suachua.Controls.Add(this.cbb_tenthietbi_suachua);
            this.groupBox_suachua.Controls.Add(this.label5);
            this.groupBox_suachua.Controls.Add(this.txt_chitiet_suachua);
            this.groupBox_suachua.Controls.Add(this.label4);
            this.groupBox_suachua.Controls.Add(this.label3);
            this.groupBox_suachua.Controls.Add(this.txt_soluong_suachua);
            this.groupBox_suachua.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_suachua.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox_suachua.Location = new System.Drawing.Point(93, 67);
            this.groupBox_suachua.Name = "groupBox_suachua";
            this.groupBox_suachua.Size = new System.Drawing.Size(708, 327);
            this.groupBox_suachua.TabIndex = 1;
            this.groupBox_suachua.TabStop = false;
            this.groupBox_suachua.Text = "Sửa chữa";
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
            this.btn_goi.Location = new System.Drawing.Point(537, 45);
            this.btn_goi.Name = "btn_goi";
            this.btn_goi.Size = new System.Drawing.Size(118, 58);
            this.btn_goi.TabIndex = 42;
            this.btn_goi.Text = "Gởi";
            this.btn_goi.TextColor = System.Drawing.Color.Black;
            this.btn_goi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_goi.UseVisualStyleBackColor = false;
            this.btn_goi.Click += new System.EventHandler(this.btn_goi_Click);
            // 
            // cbb_tenthietbi_suachua
            // 
            this.cbb_tenthietbi_suachua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_tenthietbi_suachua.FormattingEnabled = true;
            this.cbb_tenthietbi_suachua.Location = new System.Drawing.Point(179, 45);
            this.cbb_tenthietbi_suachua.Name = "cbb_tenthietbi_suachua";
            this.cbb_tenthietbi_suachua.Size = new System.Drawing.Size(104, 28);
            this.cbb_tenthietbi_suachua.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 38);
            this.label5.TabIndex = 37;
            this.label5.Text = "Chi tiết";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_chitiet_suachua
            // 
            this.txt_chitiet_suachua.BackColor = System.Drawing.SystemColors.Window;
            this.txt_chitiet_suachua.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_chitiet_suachua.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_chitiet_suachua.BorderSize = 2;
            this.txt_chitiet_suachua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chitiet_suachua.ForeColor = System.Drawing.Color.DimGray;
            this.txt_chitiet_suachua.Location = new System.Drawing.Point(179, 139);
            this.txt_chitiet_suachua.Margin = new System.Windows.Forms.Padding(4);
            this.txt_chitiet_suachua.Multiline = true;
            this.txt_chitiet_suachua.Name = "txt_chitiet_suachua";
            this.txt_chitiet_suachua.Padding = new System.Windows.Forms.Padding(7);
            this.txt_chitiet_suachua.PasswordChar = false;
            this.txt_chitiet_suachua.Size = new System.Drawing.Size(476, 127);
            this.txt_chitiet_suachua.TabIndex = 36;
            this.txt_chitiet_suachua.Texts = "";
            this.txt_chitiet_suachua.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 44);
            this.label4.TabIndex = 35;
            this.label4.Text = "Số lượng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 38);
            this.label3.TabIndex = 34;
            this.label3.Text = "Tên thiết bị";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_soluong_suachua
            // 
            this.txt_soluong_suachua.BackColor = System.Drawing.SystemColors.Window;
            this.txt_soluong_suachua.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_soluong_suachua.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_soluong_suachua.BorderSize = 2;
            this.txt_soluong_suachua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soluong_suachua.ForeColor = System.Drawing.Color.DimGray;
            this.txt_soluong_suachua.Location = new System.Drawing.Point(180, 96);
            this.txt_soluong_suachua.Margin = new System.Windows.Forms.Padding(4);
            this.txt_soluong_suachua.Multiline = false;
            this.txt_soluong_suachua.Name = "txt_soluong_suachua";
            this.txt_soluong_suachua.Padding = new System.Windows.Forms.Padding(7);
            this.txt_soluong_suachua.PasswordChar = false;
            this.txt_soluong_suachua.Size = new System.Drawing.Size(104, 35);
            this.txt_soluong_suachua.TabIndex = 3;
            this.txt_soluong_suachua.Texts = "";
            this.txt_soluong_suachua.UnderlinedStyle = false;
            // 
            // frm_SuaChua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(879, 486);
            this.Controls.Add(this.groupBox_suachua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_SuaChua";
            this.Text = "frm_SuaChua";
            this.Load += new System.EventHandler(this.frm_SuaChua_Load);
            this.groupBox_suachua.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_suachua;
        private System.Windows.Forms.ComboBox cbb_tenthietbi_suachua;
        private System.Windows.Forms.Label label5;
        private effect.RJTextBox txt_chitiet_suachua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private effect.RJTextBox txt_soluong_suachua;
        private CustomButton.VBButton btn_goi;
    }
}
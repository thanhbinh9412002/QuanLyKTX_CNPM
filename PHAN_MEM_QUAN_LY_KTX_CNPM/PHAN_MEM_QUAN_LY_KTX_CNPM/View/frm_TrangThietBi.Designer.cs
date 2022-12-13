
namespace PHAN_MEM_QUAN_LY_KTX_CNPM
{
    partial class frm_TrangThietBi
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.cbbTenTBITimKiem = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.gbThongTinTB = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mathietbi = new System.Windows.Forms.TextBox();
            this.txt_tenthietbi = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_trangthietbi = new System.Windows.Forms.DataGridView();
            this.MaThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbThongTinTB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trangthietbi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Salmon;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = global::PHAN_MEM_QUAN_LY_KTX_CNPM.Properties.Resources.remove_icon;
            this.btnHuy.Location = new System.Drawing.Point(814, 458);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(131, 58);
            this.btnHuy.TabIndex = 134;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // cbbTenTBITimKiem
            // 
            this.cbbTenTBITimKiem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbbTenTBITimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenTBITimKiem.FormattingEnabled = true;
            this.cbbTenTBITimKiem.Location = new System.Drawing.Point(597, 122);
            this.cbbTenTBITimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbTenTBITimKiem.Name = "cbbTenTBITimKiem";
            this.cbbTenTBITimKiem.Size = new System.Drawing.Size(133, 28);
            this.cbbTenTBITimKiem.TabIndex = 130;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Salmon;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Image = global::PHAN_MEM_QUAN_LY_KTX_CNPM.Properties.Resources.Restart_icon;
            this.btnLoad.Location = new System.Drawing.Point(597, 397);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(131, 58);
            this.btnLoad.TabIndex = 133;
            this.btnLoad.Text = "Load";
            this.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Salmon;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::PHAN_MEM_QUAN_LY_KTX_CNPM.Properties.Resources.Filter_icon;
            this.btnTimKiem.Location = new System.Drawing.Point(597, 159);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(131, 58);
            this.btnTimKiem.TabIndex = 132;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(595, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 22);
            this.label5.TabIndex = 131;
            this.label5.Text = "Tìm kiếm";
            // 
            // gbThongTinTB
            // 
            this.gbThongTinTB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbThongTinTB.Controls.Add(this.label2);
            this.gbThongTinTB.Controls.Add(this.txt_mathietbi);
            this.gbThongTinTB.Controls.Add(this.txt_tenthietbi);
            this.gbThongTinTB.Controls.Add(this.txt_soluong);
            this.gbThongTinTB.Controls.Add(this.label3);
            this.gbThongTinTB.Controls.Add(this.label4);
            this.gbThongTinTB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbThongTinTB.Location = new System.Drawing.Point(68, 51);
            this.gbThongTinTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbThongTinTB.Name = "gbThongTinTB";
            this.gbThongTinTB.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbThongTinTB.Size = new System.Drawing.Size(458, 225);
            this.gbThongTinTB.TabIndex = 129;
            this.gbThongTinTB.TabStop = false;
            this.gbThongTinTB.Text = "Thông tin thiết bị";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 30);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mã thiết bị";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_mathietbi
            // 
            this.txt_mathietbi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_mathietbi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mathietbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mathietbi.Location = new System.Drawing.Point(200, 32);
            this.txt_mathietbi.Name = "txt_mathietbi";
            this.txt_mathietbi.Size = new System.Drawing.Size(117, 29);
            this.txt_mathietbi.TabIndex = 17;
            // 
            // txt_tenthietbi
            // 
            this.txt_tenthietbi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_tenthietbi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tenthietbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenthietbi.Location = new System.Drawing.Point(200, 71);
            this.txt_tenthietbi.Name = "txt_tenthietbi";
            this.txt_tenthietbi.Size = new System.Drawing.Size(117, 29);
            this.txt_tenthietbi.TabIndex = 18;
            // 
            // txt_soluong
            // 
            this.txt_soluong.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_soluong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soluong.Location = new System.Drawing.Point(200, 108);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(117, 29);
            this.txt_soluong.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 35);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tên thiết bị";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 30);
            this.label4.TabIndex = 22;
            this.label4.Text = "Số lượng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.Salmon;
            this.btn_luu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Image = global::PHAN_MEM_QUAN_LY_KTX_CNPM.Properties.Resources.Save_icon;
            this.btn_luu.Location = new System.Drawing.Point(814, 331);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(131, 58);
            this.btn_luu.TabIndex = 128;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.Salmon;
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Image = global::PHAN_MEM_QUAN_LY_KTX_CNPM.Properties.Resources.setting;
            this.btn_sua.Location = new System.Drawing.Point(814, 203);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(131, 58);
            this.btn_sua.TabIndex = 127;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Salmon;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.Black;
            this.btn_them.Image = global::PHAN_MEM_QUAN_LY_KTX_CNPM.Properties.Resources.add_icon;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.Location = new System.Drawing.Point(814, 81);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(131, 58);
            this.btn_them.TabIndex = 126;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1047, 31);
            this.label1.TabIndex = 125;
            this.label1.Text = "TRANG THIẾT BỊ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_trangthietbi
            // 
            this.dgv_trangthietbi.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_trangthietbi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_trangthietbi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThietBi,
            this.TenThietBi,
            this.TongSoLuong});
            this.dgv_trangthietbi.Location = new System.Drawing.Point(68, 315);
            this.dgv_trangthietbi.Name = "dgv_trangthietbi";
            this.dgv_trangthietbi.RowHeadersWidth = 51;
            this.dgv_trangthietbi.Size = new System.Drawing.Size(458, 223);
            this.dgv_trangthietbi.TabIndex = 124;
            // 
            // MaThietBi
            // 
            this.MaThietBi.DataPropertyName = "MaThietBi";
            this.MaThietBi.HeaderText = "Mã thiết bị";
            this.MaThietBi.MinimumWidth = 6;
            this.MaThietBi.Name = "MaThietBi";
            this.MaThietBi.Width = 125;
            // 
            // TenThietBi
            // 
            this.TenThietBi.DataPropertyName = "TenThietBi";
            this.TenThietBi.HeaderText = "Tên thiết bị";
            this.TenThietBi.MinimumWidth = 6;
            this.TenThietBi.Name = "TenThietBi";
            this.TenThietBi.Width = 125;
            // 
            // TongSoLuong
            // 
            this.TongSoLuong.DataPropertyName = "TongSoLuong";
            this.TongSoLuong.HeaderText = "Số lượng";
            this.TongSoLuong.MinimumWidth = 6;
            this.TongSoLuong.Name = "TongSoLuong";
            this.TongSoLuong.Width = 125;
            // 
            // frm_TrangThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1047, 593);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.cbbTenTBITimKiem);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbThongTinTB);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_trangthietbi);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_TrangThietBi";
            this.Text = "frm_TrangThietBi";
            this.Load += new System.EventHandler(this.frm_TrangThietBi_Load);
            this.gbThongTinTB.ResumeLayout(false);
            this.gbThongTinTB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trangthietbi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ComboBox cbbTenTBITimKiem;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbThongTinTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mathietbi;
        private System.Windows.Forms.TextBox txt_tenthietbi;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_trangthietbi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongSoLuong;
    }
}
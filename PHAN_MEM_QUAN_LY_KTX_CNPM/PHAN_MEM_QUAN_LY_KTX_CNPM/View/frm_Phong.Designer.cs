﻿
namespace PHAN_MEM_QUAN_LY_KTX_CNPM
{
    partial class frm_Phong
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
            this.main_panel = new System.Windows.Forms.Panel();
            this.panel_child = new System.Windows.Forms.Panel();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.gbThongTinPhong = new System.Windows.Forms.GroupBox();
            this.cbbSVToiDa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGiaPhong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSVHienTai = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHD = new System.Windows.Forms.Button();
            this.btnThietBiTrongPhong = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnPhongConCho = new System.Windows.Forms.Button();
            this.btnChiTietPhong = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiemPhongDay = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cbbTinhTrang = new System.Windows.Forms.ComboBox();
            this.main_panel.SuspendLayout();
            this.panel_child.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.gbThongTinPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aquamarine;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(845, 32);
            this.label1.TabIndex = 84;
            this.label1.Text = "QUẢN LÍ PHÒNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.panel_child);
            this.main_panel.Location = new System.Drawing.Point(0, 34);
            this.main_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(844, 400);
            this.main_panel.TabIndex = 85;
            // 
            // panel_child
            // 
            this.panel_child.Controls.Add(this.dgvPhong);
            this.panel_child.Controls.Add(this.gbThongTinPhong);
            this.panel_child.Controls.Add(this.btnSua);
            this.panel_child.Controls.Add(this.btnHD);
            this.panel_child.Controls.Add(this.btnThietBiTrongPhong);
            this.panel_child.Controls.Add(this.btnLoad);
            this.panel_child.Controls.Add(this.btnPhongConCho);
            this.panel_child.Controls.Add(this.btnChiTietPhong);
            this.panel_child.Controls.Add(this.btnXoa);
            this.panel_child.Controls.Add(this.btnTimKiemPhongDay);
            this.panel_child.Controls.Add(this.btnHuy);
            this.panel_child.Controls.Add(this.btnLuu);
            this.panel_child.Controls.Add(this.btnThem);
            this.panel_child.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_child.Location = new System.Drawing.Point(0, 0);
            this.panel_child.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_child.Name = "panel_child";
            this.panel_child.Size = new System.Drawing.Size(844, 400);
            this.panel_child.TabIndex = 0;
            // 
            // dgvPhong
            // 
            this.dgvPhong.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(7, 1);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.Size = new System.Drawing.Size(514, 285);
            this.dgvPhong.TabIndex = 125;
            // 
            // gbThongTinPhong
            // 
            this.gbThongTinPhong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbThongTinPhong.Controls.Add(this.cbbTinhTrang);
            this.gbThongTinPhong.Controls.Add(this.cbbSVToiDa);
            this.gbThongTinPhong.Controls.Add(this.label6);
            this.gbThongTinPhong.Controls.Add(this.txtGiaPhong);
            this.gbThongTinPhong.Controls.Add(this.label5);
            this.gbThongTinPhong.Controls.Add(this.txtSVHienTai);
            this.gbThongTinPhong.Controls.Add(this.txtMaPhong);
            this.gbThongTinPhong.Controls.Add(this.label4);
            this.gbThongTinPhong.Controls.Add(this.label3);
            this.gbThongTinPhong.Controls.Add(this.label2);
            this.gbThongTinPhong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbThongTinPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTinPhong.Location = new System.Drawing.Point(526, 3);
            this.gbThongTinPhong.Name = "gbThongTinPhong";
            this.gbThongTinPhong.Size = new System.Drawing.Size(313, 210);
            this.gbThongTinPhong.TabIndex = 126;
            this.gbThongTinPhong.TabStop = false;
            this.gbThongTinPhong.Text = "Thông tin phòng";
            // 
            // cbbSVToiDa
            // 
            this.cbbSVToiDa.FormattingEnabled = true;
            this.cbbSVToiDa.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8"});
            this.cbbSVToiDa.Location = new System.Drawing.Point(142, 131);
            this.cbbSVToiDa.Name = "cbbSVToiDa";
            this.cbbSVToiDa.Size = new System.Drawing.Size(114, 24);
            this.cbbSVToiDa.TabIndex = 55;
            this.cbbSVToiDa.SelectedIndexChanged += new System.EventHandler(this.cbbSVToiDa_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 53;
            this.label6.Text = "Tình Trạng";
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtGiaPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGiaPhong.Enabled = false;
            this.txtGiaPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaPhong.Location = new System.Drawing.Point(143, 56);
            this.txtGiaPhong.Multiline = true;
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Size = new System.Drawing.Size(112, 29);
            this.txtGiaPhong.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Giá phòng ";
            // 
            // txtSVHienTai
            // 
            this.txtSVHienTai.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSVHienTai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSVHienTai.Enabled = false;
            this.txtSVHienTai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSVHienTai.Location = new System.Drawing.Point(143, 91);
            this.txtSVHienTai.Multiline = true;
            this.txtSVHienTai.Name = "txtSVHienTai";
            this.txtSVHienTai.Size = new System.Drawing.Size(112, 29);
            this.txtSVHienTai.TabIndex = 48;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMaPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhong.Location = new System.Drawing.Point(144, 21);
            this.txtMaPhong.Multiline = true;
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(112, 29);
            this.txtMaPhong.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sinh viên hiện tại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sinh viên tối đa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phòng ";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LightCoral;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(241, 288);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 44);
            this.btnSua.TabIndex = 124;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHD
            // 
            this.btnHD.BackColor = System.Drawing.Color.LightCoral;
            this.btnHD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHD.Location = new System.Drawing.Point(694, 350);
            this.btnHD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHD.Name = "btnHD";
            this.btnHD.Size = new System.Drawing.Size(78, 44);
            this.btnHD.TabIndex = 123;
            this.btnHD.Text = "Hóa Đơn";
            this.btnHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHD.UseVisualStyleBackColor = false;
            this.btnHD.Click += new System.EventHandler(this.btnHD_Click);
            // 
            // btnThietBiTrongPhong
            // 
            this.btnThietBiTrongPhong.BackColor = System.Drawing.Color.LightCoral;
            this.btnThietBiTrongPhong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThietBiTrongPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThietBiTrongPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThietBiTrongPhong.Location = new System.Drawing.Point(515, 350);
            this.btnThietBiTrongPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThietBiTrongPhong.Name = "btnThietBiTrongPhong";
            this.btnThietBiTrongPhong.Size = new System.Drawing.Size(162, 44);
            this.btnThietBiTrongPhong.TabIndex = 122;
            this.btnThietBiTrongPhong.Text = "Thiết bị trong phòng";
            this.btnThietBiTrongPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThietBiTrongPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThietBiTrongPhong.UseVisualStyleBackColor = false;
            this.btnThietBiTrongPhong.Click += new System.EventHandler(this.btnThietBiTrongPhong_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.LightCoral;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(490, 288);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLoad.Size = new System.Drawing.Size(91, 44);
            this.btnLoad.TabIndex = 121;
            this.btnLoad.Text = "Load";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnPhongConCho
            // 
            this.btnPhongConCho.BackColor = System.Drawing.Color.LightCoral;
            this.btnPhongConCho.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPhongConCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhongConCho.Location = new System.Drawing.Point(158, 350);
            this.btnPhongConCho.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPhongConCho.Name = "btnPhongConCho";
            this.btnPhongConCho.Size = new System.Drawing.Size(189, 44);
            this.btnPhongConCho.TabIndex = 119;
            this.btnPhongConCho.Text = "Tìm kiếm phòng còn chỗ";
            this.btnPhongConCho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPhongConCho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPhongConCho.UseVisualStyleBackColor = false;
            this.btnPhongConCho.Click += new System.EventHandler(this.btnPhongConCho_Click);
            // 
            // btnChiTietPhong
            // 
            this.btnChiTietPhong.BackColor = System.Drawing.Color.LightCoral;
            this.btnChiTietPhong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChiTietPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietPhong.Location = new System.Drawing.Point(358, 350);
            this.btnChiTietPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChiTietPhong.Name = "btnChiTietPhong";
            this.btnChiTietPhong.Size = new System.Drawing.Size(151, 44);
            this.btnChiTietPhong.TabIndex = 118;
            this.btnChiTietPhong.Text = "Chi Tiết Phòng";
            this.btnChiTietPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChiTietPhong.UseVisualStyleBackColor = false;
            this.btnChiTietPhong.Click += new System.EventHandler(this.btnChiTietPhong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightCoral;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(127, 288);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 44);
            this.btnXoa.TabIndex = 117;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiemPhongDay
            // 
            this.btnTimKiemPhongDay.BackColor = System.Drawing.Color.LightCoral;
            this.btnTimKiemPhongDay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimKiemPhongDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemPhongDay.Location = new System.Drawing.Point(7, 350);
            this.btnTimKiemPhongDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimKiemPhongDay.Name = "btnTimKiemPhongDay";
            this.btnTimKiemPhongDay.Size = new System.Drawing.Size(147, 44);
            this.btnTimKiemPhongDay.TabIndex = 116;
            this.btnTimKiemPhongDay.Text = "Tìm kiếm phòng đủ";
            this.btnTimKiemPhongDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemPhongDay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiemPhongDay.UseVisualStyleBackColor = false;
            this.btnTimKiemPhongDay.Click += new System.EventHandler(this.btnTimKiemPhongDay_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.LightCoral;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(632, 288);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(91, 44);
            this.btnHuy.TabIndex = 115;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LightCoral;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(368, 288);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(91, 44);
            this.btnLuu.TabIndex = 114;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightCoral;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(7, 288);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 44);
            this.btnThem.TabIndex = 113;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightCoral;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(724, 438);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 44);
            this.btnThoat.TabIndex = 120;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cbbTinhTrang
            // 
            this.cbbTinhTrang.FormattingEnabled = true;
            this.cbbTinhTrang.Items.AddRange(new object[] {
            "Đang sử dụng ",
            "Đang sửa chữa"});
            this.cbbTinhTrang.Location = new System.Drawing.Point(142, 162);
            this.cbbTinhTrang.Name = "cbbTinhTrang";
            this.cbbTinhTrang.Size = new System.Drawing.Size(114, 24);
            this.cbbTinhTrang.TabIndex = 56;
            // 
            // frm_Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 479);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Name = "frm_Phong";
            this.Text = "frm_Phong";
            this.Load += new System.EventHandler(this.frm_Phong_Load);
            this.main_panel.ResumeLayout(false);
            this.panel_child.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.gbThongTinPhong.ResumeLayout(false);
            this.gbThongTinPhong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel panel_child;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHD;
        private System.Windows.Forms.Button btnThietBiTrongPhong;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnPhongConCho;
        private System.Windows.Forms.Button btnChiTietPhong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiemPhongDay;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.GroupBox gbThongTinPhong;
        private System.Windows.Forms.ComboBox cbbSVToiDa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSVHienTai;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbTinhTrang;
    }
}


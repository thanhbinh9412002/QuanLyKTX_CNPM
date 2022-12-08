
namespace PHAN_MEM_QUAN_LY_KTX_CNPM
{
    partial class frm_Trangchu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Trangchu));
            this.timer_tieude = new System.Windows.Forms.Timer(this.components);
            this.timer_hinh = new System.Windows.Forms.Timer(this.components);
            this.timer_menu = new System.Windows.Forms.Timer(this.components);
            this.timer_caidat = new System.Windows.Forms.Timer(this.components);
            this.timer_thoigian = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel0 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_ngay = new System.Windows.Forms.TextBox();
            this.txt_gio = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_form = new System.Windows.Forms.Panel();
            this.timer_tbyeucau = new System.Windows.Forms.Timer(this.components);
            this.btn_thongbaoyeucau = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_thongtinnophi = new CustomButton.VBButton();
            this.btn_thongtincanhan = new CustomButton.VBButton();
            this.btn_yeucau = new CustomButton.VBButton();
            this.btn_dangxuat = new CustomButton.VBButton();
            this.btn_doimk = new CustomButton.VBButton();
            this.btn_thongbao = new CustomButton.VBButton();
            this.btn_thietbi = new CustomButton.VBButton();
            this.btn_phong = new CustomButton.VBButton();
            this.btn_sinhvien = new CustomButton.VBButton();
            this.btn_Trangchu = new CustomButton.VBButton();
            this.elipseControl1 = new ElipseToolDemo.ElipseControl();
            this.panel0.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_tieude
            // 
            this.timer_tieude.Tick += new System.EventHandler(this.timer_tieude_Tick);
            // 
            // timer_hinh
            // 
            this.timer_hinh.Interval = 1000;
            this.timer_hinh.Tick += new System.EventHandler(this.timer_hinh_Tick);
            // 
            // timer_menu
            // 
            this.timer_menu.Interval = 10;
            this.timer_menu.Tick += new System.EventHandler(this.timer_menu_Tick);
            // 
            // timer_caidat
            // 
            this.timer_caidat.Interval = 10;
            this.timer_caidat.Tick += new System.EventHandler(this.timer_caidat_Tick);
            // 
            // timer_thoigian
            // 
            this.timer_thoigian.Tick += new System.EventHandler(this.timer_thoigian_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aquamarine;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1213, 56);
            this.label1.TabIndex = 60;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ KÝ TÚC XÁ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel0
            // 
            this.panel0.Controls.Add(this.panel2);
            this.panel0.Controls.Add(this.panel3);
            this.panel0.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel0.Location = new System.Drawing.Point(0, 56);
            this.panel0.Name = "panel0";
            this.panel0.Size = new System.Drawing.Size(120, 632);
            this.panel0.TabIndex = 63;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.btn_thongtinnophi);
            this.panel2.Controls.Add(this.btn_thongtincanhan);
            this.panel2.Controls.Add(this.btn_yeucau);
            this.panel2.Controls.Add(this.btn_dangxuat);
            this.panel2.Controls.Add(this.btn_doimk);
            this.panel2.Controls.Add(this.btn_thongbao);
            this.panel2.Controls.Add(this.btn_thietbi);
            this.panel2.Controls.Add(this.btn_phong);
            this.panel2.Controls.Add(this.btn_sinhvien);
            this.panel2.Controls.Add(this.btn_Trangchu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 472);
            this.panel2.TabIndex = 67;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.txt_ngay);
            this.panel3.Controls.Add(this.txt_gio);
            this.panel3.Controls.Add(this.btn_down);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 472);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 160);
            this.panel3.TabIndex = 1;
            // 
            // txt_ngay
            // 
            this.txt_ngay.BackColor = System.Drawing.Color.Aquamarine;
            this.txt_ngay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ngay.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_ngay.Location = new System.Drawing.Point(3, 80);
            this.txt_ngay.Name = "txt_ngay";
            this.txt_ngay.Size = new System.Drawing.Size(83, 22);
            this.txt_ngay.TabIndex = 70;
            this.txt_ngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_gio
            // 
            this.txt_gio.BackColor = System.Drawing.Color.Aquamarine;
            this.txt_gio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_gio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gio.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_gio.Location = new System.Drawing.Point(3, 46);
            this.txt_gio.Name = "txt_gio";
            this.txt_gio.Size = new System.Drawing.Size(94, 22);
            this.txt_gio.TabIndex = 71;
            this.txt_gio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_thongbaoyeucau);
            this.panel1.Controls.Add(this.panel_form);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_right);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(120, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1093, 632);
            this.panel1.TabIndex = 64;
            // 
            // panel_form
            // 
            this.panel_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_form.ForeColor = System.Drawing.Color.Black;
            this.panel_form.Location = new System.Drawing.Point(30, 0);
            this.panel_form.Name = "panel_form";
            this.panel_form.Size = new System.Drawing.Size(1063, 632);
            this.panel_form.TabIndex = 66;
            // 
            // timer_tbyeucau
            // 
            this.timer_tbyeucau.Tick += new System.EventHandler(this.timer_tbyeucau_Tick);
            // 
            // btn_thongbaoyeucau
            // 
            this.btn_thongbaoyeucau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_thongbaoyeucau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_thongbaoyeucau.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_thongbaoyeucau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongbaoyeucau.ForeColor = System.Drawing.Color.Maroon;
            this.btn_thongbaoyeucau.Location = new System.Drawing.Point(0, 238);
            this.btn_thongbaoyeucau.Name = "btn_thongbaoyeucau";
            this.btn_thongbaoyeucau.Size = new System.Drawing.Size(24, 25);
            this.btn_thongbaoyeucau.TabIndex = 67;
            this.btn_thongbaoyeucau.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(30, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1063, 632);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // btn_right
            // 
            this.btn_right.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_right.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_right.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_right.Image = global::PHAN_MEM_QUAN_LY_KTX_CNPM.Properties.Resources.Actions_go_previous_icon;
            this.btn_right.Location = new System.Drawing.Point(0, 0);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(30, 632);
            this.btn_right.TabIndex = 48;
            this.btn_right.UseVisualStyleBackColor = false;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_down
            // 
            this.btn_down.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_down.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_down.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_down.Image = global::PHAN_MEM_QUAN_LY_KTX_CNPM.Properties.Resources.Actions_go_up_icon;
            this.btn_down.Location = new System.Drawing.Point(0, 0);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(120, 30);
            this.btn_down.TabIndex = 69;
            this.btn_down.UseVisualStyleBackColor = false;
            this.btn_down.Click += new System.EventHandler(this.button_down_Click);
            // 
            // btn_thongtinnophi
            // 
            this.btn_thongtinnophi.BackColor = System.Drawing.Color.LightCoral;
            this.btn_thongtinnophi.BackgroundColor = System.Drawing.Color.LightCoral;
            this.btn_thongtinnophi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_thongtinnophi.BorderRadius = 20;
            this.btn_thongtinnophi.BorderSize = 0;
            this.btn_thongtinnophi.FlatAppearance.BorderSize = 0;
            this.btn_thongtinnophi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thongtinnophi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongtinnophi.ForeColor = System.Drawing.Color.Black;
            this.btn_thongtinnophi.Image = global::PHAN_MEM_QUAN_LY_KTX_CNPM.Properties.Resources.document_icon;
            this.btn_thongtinnophi.Location = new System.Drawing.Point(0, 126);
            this.btn_thongtinnophi.Name = "btn_thongtinnophi";
            this.btn_thongtinnophi.Size = new System.Drawing.Size(120, 50);
            this.btn_thongtinnophi.TabIndex = 78;
            this.btn_thongtinnophi.Text = "Thanh toán hóa đơn";
            this.btn_thongtinnophi.TextColor = System.Drawing.Color.Black;
            this.btn_thongtinnophi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_thongtinnophi.UseVisualStyleBackColor = false;
            this.btn_thongtinnophi.Click += new System.EventHandler(this.btn_thongtinnophi_Click);
            // 
            // btn_thongtincanhan
            // 
            this.btn_thongtincanhan.BackColor = System.Drawing.Color.LightCoral;
            this.btn_thongtincanhan.BackgroundColor = System.Drawing.Color.LightCoral;
            this.btn_thongtincanhan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_thongtincanhan.BorderRadius = 20;
            this.btn_thongtincanhan.BorderSize = 0;
            this.btn_thongtincanhan.FlatAppearance.BorderSize = 0;
            this.btn_thongtincanhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thongtincanhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongtincanhan.ForeColor = System.Drawing.Color.Black;
            this.btn_thongtincanhan.Image = global::PHAN_MEM_QUAN_LY_KTX_CNPM.Properties.Resources.account_icon1;
            this.btn_thongtincanhan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thongtincanhan.Location = new System.Drawing.Point(0, 70);
            this.btn_thongtincanhan.Name = "btn_thongtincanhan";
            this.btn_thongtincanhan.Size = new System.Drawing.Size(120, 50);
            this.btn_thongtincanhan.TabIndex = 77;
            this.btn_thongtincanhan.Text = "Thông tin cá nhân";
            this.btn_thongtincanhan.TextColor = System.Drawing.Color.Black;
            this.btn_thongtincanhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_thongtincanhan.UseVisualStyleBackColor = false;
            this.btn_thongtincanhan.Click += new System.EventHandler(this.btn_thongtincanhan_Click);
            // 
            // btn_yeucau
            // 
            this.btn_yeucau.BackColor = System.Drawing.Color.LightCoral;
            this.btn_yeucau.BackgroundColor = System.Drawing.Color.LightCoral;
            this.btn_yeucau.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_yeucau.BorderRadius = 20;
            this.btn_yeucau.BorderSize = 0;
            this.btn_yeucau.FlatAppearance.BorderSize = 0;
            this.btn_yeucau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yeucau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_yeucau.ForeColor = System.Drawing.Color.Black;
            this.btn_yeucau.Image = global::PHAN_MEM_QUAN_LY_KTX_CNPM.Properties.Resources.request_icon;
            this.btn_yeucau.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_yeucau.Location = new System.Drawing.Point(0, 238);
            this.btn_yeucau.Name = "btn_yeucau";
            this.btn_yeucau.Size = new System.Drawing.Size(120, 50);
            this.btn_yeucau.TabIndex = 81;
            this.btn_yeucau.Text = "Yêu cầu";
            this.btn_yeucau.TextColor = System.Drawing.Color.Black;
            this.btn_yeucau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_yeucau.UseVisualStyleBackColor = false;
            this.btn_yeucau.Click += new System.EventHandler(this.btn_yeucau_Click);
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.BackColor = System.Drawing.Color.LightCoral;
            this.btn_dangxuat.BackgroundColor = System.Drawing.Color.LightCoral;
            this.btn_dangxuat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_dangxuat.BorderRadius = 20;
            this.btn_dangxuat.BorderSize = 0;
            this.btn_dangxuat.FlatAppearance.BorderSize = 0;
            this.btn_dangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangxuat.ForeColor = System.Drawing.Color.Black;
            this.btn_dangxuat.Image = global::PHAN_MEM_QUAN_LY_KTX_CNPM.Properties.Resources.logout_icon;
            this.btn_dangxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dangxuat.Location = new System.Drawing.Point(0, 406);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Size = new System.Drawing.Size(120, 50);
            this.btn_dangxuat.TabIndex = 80;
            this.btn_dangxuat.Text = "Đăng xuất";
            this.btn_dangxuat.TextColor = System.Drawing.Color.Black;
            this.btn_dangxuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dangxuat.UseVisualStyleBackColor = false;
            this.btn_dangxuat.Click += new System.EventHandler(this.btn_dangxuat_Click);
            // 
            // btn_doimk
            // 
            this.btn_doimk.BackColor = System.Drawing.Color.LightCoral;
            this.btn_doimk.BackgroundColor = System.Drawing.Color.LightCoral;
            this.btn_doimk.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_doimk.BorderRadius = 20;
            this.btn_doimk.BorderSize = 0;
            this.btn_doimk.FlatAppearance.BorderSize = 0;
            this.btn_doimk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doimk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doimk.ForeColor = System.Drawing.Color.Black;
            this.btn_doimk.Image = global::PHAN_MEM_QUAN_LY_KTX_CNPM.Properties.Resources.password_reset;
            this.btn_doimk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_doimk.Location = new System.Drawing.Point(0, 350);
            this.btn_doimk.Name = "btn_doimk";
            this.btn_doimk.Size = new System.Drawing.Size(120, 50);
            this.btn_doimk.TabIndex = 79;
            this.btn_doimk.Text = "Đổi mật khẩu";
            this.btn_doimk.TextColor = System.Drawing.Color.Black;
            this.btn_doimk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_doimk.UseVisualStyleBackColor = false;
            this.btn_doimk.Click += new System.EventHandler(this.btn_doimk_Click);
            // 
            // btn_thongbao
            // 
            this.btn_thongbao.BackColor = System.Drawing.Color.LightCoral;
            this.btn_thongbao.BackgroundColor = System.Drawing.Color.LightCoral;
            this.btn_thongbao.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_thongbao.BorderRadius = 20;
            this.btn_thongbao.BorderSize = 0;
            this.btn_thongbao.FlatAppearance.BorderSize = 0;
            this.btn_thongbao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thongbao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongbao.ForeColor = System.Drawing.Color.Black;
            this.btn_thongbao.Image = global::PHAN_MEM_QUAN_LY_KTX_CNPM.Properties.Resources.bell_icon;
            this.btn_thongbao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thongbao.Location = new System.Drawing.Point(0, 294);
            this.btn_thongbao.Name = "btn_thongbao";
            this.btn_thongbao.Size = new System.Drawing.Size(120, 50);
            this.btn_thongbao.TabIndex = 78;
            this.btn_thongbao.Text = "Thông báo";
            this.btn_thongbao.TextColor = System.Drawing.Color.Black;
            this.btn_thongbao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_thongbao.UseVisualStyleBackColor = false;
            this.btn_thongbao.Click += new System.EventHandler(this.btn_thongbao_Click);
            // 
            // btn_thietbi
            // 
            this.btn_thietbi.BackColor = System.Drawing.Color.LightCoral;
            this.btn_thietbi.BackgroundColor = System.Drawing.Color.LightCoral;
            this.btn_thietbi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_thietbi.BorderRadius = 20;
            this.btn_thietbi.BorderSize = 0;
            this.btn_thietbi.FlatAppearance.BorderSize = 0;
            this.btn_thietbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thietbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thietbi.ForeColor = System.Drawing.Color.Black;
            this.btn_thietbi.Image = global::PHAN_MEM_QUAN_LY_KTX_CNPM.Properties.Resources.device_icon;
            this.btn_thietbi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thietbi.Location = new System.Drawing.Point(0, 182);
            this.btn_thietbi.Name = "btn_thietbi";
            this.btn_thietbi.Size = new System.Drawing.Size(120, 50);
            this.btn_thietbi.TabIndex = 77;
            this.btn_thietbi.Text = "Thiết bị";
            this.btn_thietbi.TextColor = System.Drawing.Color.Black;
            this.btn_thietbi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_thietbi.UseVisualStyleBackColor = false;
            this.btn_thietbi.Click += new System.EventHandler(this.btn_thietbi_Click);
            // 
            // btn_phong
            // 
            this.btn_phong.BackColor = System.Drawing.Color.LightCoral;
            this.btn_phong.BackgroundColor = System.Drawing.Color.LightCoral;
            this.btn_phong.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_phong.BorderRadius = 20;
            this.btn_phong.BorderSize = 0;
            this.btn_phong.FlatAppearance.BorderSize = 0;
            this.btn_phong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_phong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_phong.ForeColor = System.Drawing.Color.Black;
            this.btn_phong.Image = global::PHAN_MEM_QUAN_LY_KTX_CNPM.Properties.Resources.room_icon;
            this.btn_phong.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_phong.Location = new System.Drawing.Point(0, 126);
            this.btn_phong.Name = "btn_phong";
            this.btn_phong.Size = new System.Drawing.Size(120, 50);
            this.btn_phong.TabIndex = 76;
            this.btn_phong.Text = "Phòng";
            this.btn_phong.TextColor = System.Drawing.Color.Black;
            this.btn_phong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_phong.UseVisualStyleBackColor = false;
            this.btn_phong.Click += new System.EventHandler(this.btn_phong_Click);
            // 
            // btn_sinhvien
            // 
            this.btn_sinhvien.BackColor = System.Drawing.Color.LightCoral;
            this.btn_sinhvien.BackgroundColor = System.Drawing.Color.LightCoral;
            this.btn_sinhvien.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_sinhvien.BorderRadius = 20;
            this.btn_sinhvien.BorderSize = 0;
            this.btn_sinhvien.FlatAppearance.BorderSize = 0;
            this.btn_sinhvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sinhvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sinhvien.ForeColor = System.Drawing.Color.Black;
            this.btn_sinhvien.Image = global::PHAN_MEM_QUAN_LY_KTX_CNPM.Properties.Resources.Students_icon;
            this.btn_sinhvien.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sinhvien.Location = new System.Drawing.Point(0, 70);
            this.btn_sinhvien.Name = "btn_sinhvien";
            this.btn_sinhvien.Size = new System.Drawing.Size(120, 50);
            this.btn_sinhvien.TabIndex = 70;
            this.btn_sinhvien.Text = "Sinh viên";
            this.btn_sinhvien.TextColor = System.Drawing.Color.Black;
            this.btn_sinhvien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sinhvien.UseVisualStyleBackColor = false;
            this.btn_sinhvien.Click += new System.EventHandler(this.btn_sinhvien_Click);
            // 
            // btn_Trangchu
            // 
            this.btn_Trangchu.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Trangchu.BackgroundColor = System.Drawing.Color.LightCoral;
            this.btn_Trangchu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Trangchu.BorderRadius = 20;
            this.btn_Trangchu.BorderSize = 0;
            this.btn_Trangchu.FlatAppearance.BorderSize = 0;
            this.btn_Trangchu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Trangchu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Trangchu.ForeColor = System.Drawing.Color.Black;
            this.btn_Trangchu.Image = global::PHAN_MEM_QUAN_LY_KTX_CNPM.Properties.Resources.home_icon_;
            this.btn_Trangchu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Trangchu.Location = new System.Drawing.Point(0, 14);
            this.btn_Trangchu.Name = "btn_Trangchu";
            this.btn_Trangchu.Size = new System.Drawing.Size(120, 50);
            this.btn_Trangchu.TabIndex = 69;
            this.btn_Trangchu.Text = "Trang chủ";
            this.btn_Trangchu.TextColor = System.Drawing.Color.Black;
            this.btn_Trangchu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Trangchu.UseVisualStyleBackColor = false;
            this.btn_Trangchu.Click += new System.EventHandler(this.btn_Trangchu_Click);
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 20;
            this.elipseControl1.TargetControl = this;
            // 
            // frm_Trangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 688);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel0);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Trangchu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.frm_Trangchu_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Trangchu_FormClosing);
            this.Load += new System.EventHandler(this.frm_Trangchu_Load);
            this.panel0.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ElipseToolDemo.ElipseControl elipseControl1;
        private System.Windows.Forms.Timer timer_tieude;
        private System.Windows.Forms.Timer timer_hinh;
        private System.Windows.Forms.Timer timer_menu;
        private System.Windows.Forms.Timer timer_caidat;
        private System.Windows.Forms.Timer timer_thoigian;
        private System.Windows.Forms.Panel panel0;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Panel panel2;
        private CustomButton.VBButton btn_Trangchu;
        private CustomButton.VBButton btn_sinhvien;
        private CustomButton.VBButton btn_yeucau;
        private CustomButton.VBButton btn_dangxuat;
        private CustomButton.VBButton btn_doimk;
        private CustomButton.VBButton btn_thongbao;
        private CustomButton.VBButton btn_thietbi;
        private CustomButton.VBButton btn_phong;
        private CustomButton.VBButton btn_thongtincanhan;
        private CustomButton.VBButton btn_thongtinnophi;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.TextBox txt_ngay;
        private System.Windows.Forms.TextBox txt_gio;
        public System.Windows.Forms.Panel panel_form;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_thongbaoyeucau;
        private System.Windows.Forms.Timer timer_tbyeucau;
    }
}
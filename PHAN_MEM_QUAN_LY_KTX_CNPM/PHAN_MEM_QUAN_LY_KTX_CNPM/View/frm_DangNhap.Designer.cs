
namespace PHAN_MEM_QUAN_LY_KTX_CNPM
{
    partial class frm_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.rdbtn_quanly = new System.Windows.Forms.RadioButton();
            this.rdbtn_admin = new System.Windows.Forms.RadioButton();
            this.lb_trangthai = new System.Windows.Forms.Label();
            this.rdbtn_sinhvien = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_password = new PHAN_MEM_QUAN_LY_KTX_CNPM.effect.RJTextBox();
            this.txt_user = new PHAN_MEM_QUAN_LY_KTX_CNPM.effect.RJTextBox();
            this.btn_hienpass = new CustomButton.VBButton();
            this.btn_dangnhap = new CustomButton.VBButton();
            this.elipseControl1 = new ElipseToolDemo.ElipseControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aquamarine;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ KÝ TÚC XÁ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdbtn_quanly
            // 
            this.rdbtn_quanly.AutoSize = true;
            this.rdbtn_quanly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_quanly.Location = new System.Drawing.Point(169, 133);
            this.rdbtn_quanly.Name = "rdbtn_quanly";
            this.rdbtn_quanly.Size = new System.Drawing.Size(80, 24);
            this.rdbtn_quanly.TabIndex = 19;
            this.rdbtn_quanly.TabStop = true;
            this.rdbtn_quanly.Text = "Quản lý";
            this.rdbtn_quanly.UseVisualStyleBackColor = true;
            this.rdbtn_quanly.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdbtn_quanly_KeyDown);
            // 
            // rdbtn_admin
            // 
            this.rdbtn_admin.AutoSize = true;
            this.rdbtn_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_admin.Location = new System.Drawing.Point(48, 133);
            this.rdbtn_admin.Name = "rdbtn_admin";
            this.rdbtn_admin.Size = new System.Drawing.Size(115, 24);
            this.rdbtn_admin.TabIndex = 18;
            this.rdbtn_admin.TabStop = true;
            this.rdbtn_admin.Text = "Quản trị viên";
            this.rdbtn_admin.UseVisualStyleBackColor = true;
            this.rdbtn_admin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdbtn_admin_KeyDown);
            // 
            // lb_trangthai
            // 
            this.lb_trangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_trangthai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_trangthai.Location = new System.Drawing.Point(9, 219);
            this.lb_trangthai.Name = "lb_trangthai";
            this.lb_trangthai.Size = new System.Drawing.Size(363, 62);
            this.lb_trangthai.TabIndex = 22;
            this.lb_trangthai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdbtn_sinhvien
            // 
            this.rdbtn_sinhvien.AutoSize = true;
            this.rdbtn_sinhvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_sinhvien.Location = new System.Drawing.Point(255, 133);
            this.rdbtn_sinhvien.Name = "rdbtn_sinhvien";
            this.rdbtn_sinhvien.Size = new System.Drawing.Size(89, 24);
            this.rdbtn_sinhvien.TabIndex = 26;
            this.rdbtn_sinhvien.TabStop = true;
            this.rdbtn_sinhvien.Text = "Học sinh";
            this.rdbtn_sinhvien.UseVisualStyleBackColor = true;
            this.rdbtn_sinhvien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdbtn_sinhvien_KeyDown);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCyan;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = global::PHAN_MEM_QUAN_LY_KTX_CNPM.Properties.Resources.Key_icon;
            this.button2.Location = new System.Drawing.Point(80, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 26);
            this.button2.TabIndex = 25;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = global::PHAN_MEM_QUAN_LY_KTX_CNPM.Properties.Resources.account_icon;
            this.button1.Location = new System.Drawing.Point(80, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 26);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.LightCyan;
            this.txt_password.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_password.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_password.BorderSize = 2;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.DimGray;
            this.txt_password.Location = new System.Drawing.Point(132, 87);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Multiline = false;
            this.txt_password.Name = "txt_password";
            this.txt_password.Padding = new System.Windows.Forms.Padding(7);
            this.txt_password.PasswordChar = true;
            this.txt_password.Size = new System.Drawing.Size(160, 31);
            this.txt_password.TabIndex = 32;
            this.txt_password.Texts = "";
            this.txt_password.UnderlinedStyle = true;
            this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyDown);
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.LightCyan;
            this.txt_user.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_user.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_user.BorderSize = 2;
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.Color.DimGray;
            this.txt_user.Location = new System.Drawing.Point(133, 48);
            this.txt_user.Margin = new System.Windows.Forms.Padding(4);
            this.txt_user.Multiline = false;
            this.txt_user.Name = "txt_user";
            this.txt_user.Padding = new System.Windows.Forms.Padding(7);
            this.txt_user.PasswordChar = false;
            this.txt_user.Size = new System.Drawing.Size(160, 31);
            this.txt_user.TabIndex = 31;
            this.txt_user.Texts = "";
            this.txt_user.UnderlinedStyle = true;
            this.txt_user.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_user_KeyDown);
            // 
            // btn_hienpass
            // 
            this.btn_hienpass.BackColor = System.Drawing.Color.LightCoral;
            this.btn_hienpass.BackgroundColor = System.Drawing.Color.LightCoral;
            this.btn_hienpass.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_hienpass.BorderRadius = 20;
            this.btn_hienpass.BorderSize = 0;
            this.btn_hienpass.FlatAppearance.BorderSize = 0;
            this.btn_hienpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hienpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hienpass.ForeColor = System.Drawing.Color.Black;
            this.btn_hienpass.Image = global::PHAN_MEM_QUAN_LY_KTX_CNPM.Properties.Resources.show_password;
            this.btn_hienpass.Location = new System.Drawing.Point(207, 176);
            this.btn_hienpass.Name = "btn_hienpass";
            this.btn_hienpass.Size = new System.Drawing.Size(124, 40);
            this.btn_hienpass.TabIndex = 28;
            this.btn_hienpass.Text = "Hiển thị mật khẩu";
            this.btn_hienpass.TextColor = System.Drawing.Color.Black;
            this.btn_hienpass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_hienpass.UseVisualStyleBackColor = false;
            this.btn_hienpass.Click += new System.EventHandler(this.btn_hienpass_Click);
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.BackColor = System.Drawing.Color.LightCoral;
            this.btn_dangnhap.BackgroundColor = System.Drawing.Color.LightCoral;
            this.btn_dangnhap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_dangnhap.BorderRadius = 20;
            this.btn_dangnhap.BorderSize = 0;
            this.btn_dangnhap.FlatAppearance.BorderSize = 0;
            this.btn_dangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangnhap.ForeColor = System.Drawing.Color.Black;
            this.btn_dangnhap.Image = global::PHAN_MEM_QUAN_LY_KTX_CNPM.Properties.Resources.Login_icon;
            this.btn_dangnhap.Location = new System.Drawing.Point(48, 176);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(124, 40);
            this.btn_dangnhap.TabIndex = 27;
            this.btn_dangnhap.Text = "Đăng nhập";
            this.btn_dangnhap.TextColor = System.Drawing.Color.Black;
            this.btn_dangnhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dangnhap.UseVisualStyleBackColor = false;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 20;
            this.elipseControl1.TargetControl = this;
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(378, 296);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.btn_hienpass);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.rdbtn_sinhvien);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdbtn_quanly);
            this.Controls.Add(this.rdbtn_admin);
            this.Controls.Add(this.lb_trangthai);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frm_DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdbtn_quanly;
        private System.Windows.Forms.RadioButton rdbtn_admin;
        private System.Windows.Forms.Label lb_trangthai;
        private System.Windows.Forms.RadioButton rdbtn_sinhvien;
        private System.Windows.Forms.Timer timer1;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private CustomButton.VBButton btn_hienpass;
        private CustomButton.VBButton btn_dangnhap;
        private effect.RJTextBox txt_user;
        private effect.RJTextBox txt_password;
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHAN_MEM_QUAN_LY_KTX_CNPM.BUS;

namespace PHAN_MEM_QUAN_LY_KTX_CNPM
{
    public partial class frm_DangNhap : Form
    {
        public frm_Trangchu fmTrangChu;
        private string user;
        private string role;

        // HIỆU ỨNG//
        private int counter = 0;
        private int len = 0;
        private string txt;
        private bool showpass = true;
        //-----------//-----------//

        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            user = txt_username.Texts;
            string password = txt_password.Texts;
            if (rdbtn_quanly.Checked == true)
            {
                role = "Quản Lý";
            }
            else
            {
                role = "Sinh Viên";
            }
            DangNhap_BUS dnBUS = new DangNhap_BUS();
            int kq = dnBUS.Check_Tai_Khoan(user,password,role);
            if (kq == 1)
            {
                txt_username.Focus();
                this.Hide();
                fmTrangChu = new frm_Trangchu(user, role);
                fmTrangChu.ShowDialog();
                this.Show();
                txt_username.Texts = "";
                txt_password.Texts = "";
            }
            else
            {
                lb_trangthai.Text = "Đăng nhập không thành công! Vui lòng kiểm tra lại !";
                txt_password.Texts = "";
                txt_password.Focus();
            }
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            txt_username.Focus();
            txt = label1.Text;
            len = txt.Length;
            label1.Text = "";
            timer1.Start();
        }

        private void btn_hienpass_Click(object sender, EventArgs e)
        {
            if (showpass)
            {
                txt_password.PasswordChar = false;
                btn_hienpass.Text = "Ẩn mật khẩu";
                btn_hienpass.Image = PHAN_MEM_QUAN_LY_KTX_CNPM.Properties.Resources.private_password;
                showpass = false;
            }
            else
            {
                txt_password.PasswordChar = true;
                btn_hienpass.Text = "Hiện mật khẩu";
                btn_hienpass.Image = PHAN_MEM_QUAN_LY_KTX_CNPM.Properties.Resources.show_password;
                showpass = true;
            }
        }
        private void frm_TrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter > len)
            {
                counter = 0;
                label1.Text = "";
            }
            else
            {
                label1.Text = txt.Substring(0, counter);
                if (label1.ForeColor == Color.Blue)
                    label1.ForeColor = Color.Orange;
                else
                    label1.ForeColor = Color.Blue;
            }
        }
    }
}

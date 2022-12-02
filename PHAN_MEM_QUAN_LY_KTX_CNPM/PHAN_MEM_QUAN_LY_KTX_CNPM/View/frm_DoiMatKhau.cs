using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHAN_MEM_QUAN_LY_KTX_CNPM
{
    public partial class frm_DoiMatKhau : Form
    {
        private string user;
        private string role;
        private bool showpass = true;
        public frm_DoiMatKhau(string user = "", string role = "")
        {
            InitializeComponent();
            this.user = user;
            this.role = role;
        }

        private void btn_showpass_Click(object sender, EventArgs e)
        {
            if (showpass)
            {
                txt_newpass.PasswordChar = false;
                txt_confirmnewpass.PasswordChar = false;
                btn_showpass.Text = "Ẩn mật khẩu";
                btn_showpass.Image = PHAN_MEM_QUAN_LY_KTX_CNPM.Properties.Resources.private_password;
                showpass = false;
            }
            else
            {
                txt_newpass.PasswordChar = true;
                txt_confirmnewpass.PasswordChar = true;
                btn_showpass.Text = "Hiện mật khẩu";
                btn_showpass.Image = PHAN_MEM_QUAN_LY_KTX_CNPM.Properties.Resources.show_password;
                showpass = true;
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn đổi mật khẩu", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txt_newpass.Texts.Length >= 8)
                {
                    if (txt_newpass.Texts == txt_confirmnewpass.Texts)
                    {
                        DoiMatKhau_BUS dmkBUS = new DoiMatKhau_BUS();
                        if (dmkBUS.DoiMatKhau(user, txt_newpass.Texts) == 1)
                        {
                            if (MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                            {
                                this.Close();
                            }
                        }
                        else
                        {
                            lb_trangthai.Text = "Đã có lỗi xảy ra! Vui lòng kiểm tra lại!";
                            txt_newpass.Texts = "";
                            txt_confirmnewpass.Texts = "";
                            txt_newpass.Focus();
                        }
                    }
                    else
                    {
                        lb_trangthai.Text = "Xác nhận mật khẩu mới không chính xác! Vui lòng nhập lại!";
                        txt_confirmnewpass.ResetText();
                        txt_confirmnewpass.Focus();
                    }
                }
                else
                {
                    lb_trangthai.Text = "Mật khẩu mới phải tối thiểu 8 ký tự!";
                    txt_newpass.Texts = "";
                    txt_confirmnewpass.Texts = "";
                    txt_newpass.Focus();
                }
            }
        }

        private void frm_DoiMatKhau_Load(object sender, EventArgs e)
        {
            txt_user.Texts = user;
            txt_user.Enabled = false;
            txt_newpass.Focus();
        }
    }
}

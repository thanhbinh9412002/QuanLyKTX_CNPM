﻿using System;
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
    public partial class frm_Trangchu : Form
    {
        //Form//

        frm_DoiMatKhau fmDoiMatKhau;
        frm_YeuCau fmYeuCau;

        private string user;
        private string role;

        // HIỆU ỨNG//
        private int counter = 0;
        private int len = 0;
        private string txt;
        public Image t1, t2, t3;
        public bool Hided_caidat = false;
        public bool Hided_menu = false;
        public int x, y;
        //-----------//-----------//

        public frm_Trangchu(string user = "", string role = "")
        {
            InitializeComponent();
            this.user = user;
            this.role = role;
           
        }

        private void frm_Trangchu_Load(object sender, EventArgs e)
        {
            loadeffect();
            if (role == "Quản Lý")
            {
                MainEnable();
            }
            else
            {
                MainNoEnable();
            }
        }

        private void MainEnable()
        {
            btn_thongtinnophi.Visible = false;
            btn_thongtincanhan.Visible = false;
            btn_sinhvien.Visible = true;
            btn_phong.Visible = true;
            btn_thietbi.Visible = true;
            btn_thongbao.Visible = true;
            btn_yeucau.Visible = true;
            btn_dangxuat.Visible = true;
            btn_doimk.Visible = true;
            btn_Trangchu.Visible = true;
            x = 460;
            y = 340;
        }

        private void MainNoEnable()
        {
            btn_thongtinnophi.Visible = true;
            btn_thongtincanhan.Visible = true;
            btn_sinhvien.Visible = false;
            btn_phong.Visible = false;
            btn_thietbi.Visible = false;
            btn_thongbao.Visible = true;
            btn_yeucau.Visible = true;
            btn_dangxuat.Visible = true;
            btn_doimk.Visible = true;
            btn_Trangchu.Visible = true;
            btn_dangxuat.Location = btn_doimk.Location;
            btn_doimk.Location = btn_thongbao.Location;
            btn_thongbao.Location = btn_yeucau.Location;
            btn_yeucau.Location = btn_thietbi.Location;   
            x = 400;
            y = 280;
        }

        private void loadeffect()
        {
            t1 = new Bitmap(Application.StartupPath + "\\Resources\\ktx1.png");
            t2 = new Bitmap(Application.StartupPath + "\\Resources\\ktx2.png");
            t3 = new Bitmap(Application.StartupPath + "\\Resources\\ktx3.png");
            pictureBox1.Image = t1;
            timer_hinh.Start();
            txt = label1.Text;
            len = txt.Length;
            label1.Text = "";
            timer_tieude.Start();
            Hided_caidat = false;
            Hided_menu = false;
            timer_menu.Start();
            timer_caidat.Start();
            timer_thoigian.Start();
            panel_form.Visible = false;
        }

        private void timer_menu_Tick(object sender, EventArgs e)
        {
            if(Hided_menu)
            {
                panel0.Width = panel0.Width + 20;
                btn_right.Image = PHAN_MEM_QUAN_LY_KTX_CNPM.Properties.Resources.Actions_go_previous_icon;
                if (panel0.Width == 120)
                {
                    timer_menu.Stop();
                    Hided_menu = false;
                    this.Refresh();
                }    
            }
            else
            {
                panel0.Width = panel0.Width - 20;
                btn_right.Image = PHAN_MEM_QUAN_LY_KTX_CNPM.Properties.Resources.Actions_go_next_icon;
                if (panel0.Width == 0)
                {
                    timer_menu.Stop();
                    Hided_menu = true;
                    this.Refresh();
                }
            }    
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            timer_menu.Start();
        }

        private void button_down_Click(object sender, EventArgs e)
        {
            timer_caidat.Start();
        }

        private void timer_caidat_Tick(object sender, EventArgs e)
        {
            if (Hided_caidat)
            {
                panel2.Height = panel2.Height + 20;
                btn_down.Image = PHAN_MEM_QUAN_LY_KTX_CNPM.Properties.Resources.Actions_go_up_icon;
                if (panel2.Height == x)
                {
                    timer_caidat.Stop();
                    Hided_caidat = false;
                    this.Refresh();
                }
            }
            else
            {
                panel2.Height = panel2.Height - 20;
                btn_down.Image = PHAN_MEM_QUAN_LY_KTX_CNPM.Properties.Resources.Actions_go_down_icon;
                if (panel2.Height == y)
                {
                    timer_caidat.Stop();
                    Hided_caidat = true;
                    this.Refresh();
                }
            }
        }

        private void frm_Trangchu_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("\tPHẦN MỀM QUẢN LÝ KÝ TÚC XÁ" +
                                                         "\nNhóm 09\nThành viên:\n" +
                                                         "\n\t1. Nguyễn Thanh Bình\tMSSV: 20133025" +
                                                         "\n\t2. Nguyễn Nhật Triều\tMSSV: 20133102" +
                                                         "\n\t3. Đoàn Quốc Trung\tMSSV: 20133104" +
                                                         "\n\t4. Mai Thanh Trung\tMSSV: 20133105",
                            "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void timer_thoigian_Tick(object sender, EventArgs e)
        {
            txt_gio.Text = DateTime.Now.ToLongTimeString();
            txt_ngay.Text = DateTime.Now.Date.ToString();
            txt_gio.Enabled = false;
            txt_ngay.Enabled = false;
        }

        private void frm_Trangchu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void timer_tieude_Tick(object sender, EventArgs e)
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

        private void timer_hinh_Tick(object sender, EventArgs e)
        {
            if(pictureBox1.Image == t1)
            {
                pictureBox1.Image = t2;
            }
            else if (pictureBox1.Image == t2)
            {
                pictureBox1.Image = t3;
            }
            else if (pictureBox1.Image == t3)
            {
                pictureBox1.Image = t1;
            }
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_doimk_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            panel_form.Visible = true;
            panel_form.Controls.Clear();
            fmDoiMatKhau = new frm_DoiMatKhau(user, role);
            fmDoiMatKhau.TopLevel = false;
            panel_form.Controls.Add(fmDoiMatKhau);
            fmDoiMatKhau.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fmDoiMatKhau.Dock = DockStyle.Fill;
            fmDoiMatKhau.Show();    
        }

        private void btn_Trangchu_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            panel_form.Visible = false;
        }


        private void btn_sinhvien_Click(object sender, EventArgs e)
        {
            /*  pictureBox1.Visible = false;
              panel_form.Visible = true;
              panel_form.Controls.Clear();
              fmDoiMatKhau = new frm_DoiMatKhau(user, role);              Đổi tên form thích hợp
              fmDoiMatKhau.TopLevel = false;
              panel_form.Controls.Add(fmDoiMatKhau);
              fmDoiMatKhau.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
              fmDoiMatKhau.Dock = DockStyle.Fill;
              fmDoiMatKhau.Show();*/
        }

        private void btn_phong_Click(object sender, EventArgs e)
        {
            /*  pictureBox1.Visible = false;
            panel_form.Visible = true;
            panel_form.Controls.Clear();
           fmDoiMatKhau = new frm_DoiMatKhau(user, role);              Đổi tên form thích hợp
           fmDoiMatKhau.TopLevel = false;
           panel_form.Controls.Add(fmDoiMatKhau);
           fmDoiMatKhau.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
           fmDoiMatKhau.Dock = DockStyle.Fill;
           fmDoiMatKhau.Show();*/
        }

        private void btn_yeucau_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            panel_form.Visible = true;
            panel_form.Controls.Clear();
            fmYeuCau = new frm_YeuCau(user, role);
            fmYeuCau.TopLevel = false;
            panel_form.Controls.Add(fmYeuCau);
            fmYeuCau.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fmYeuCau.Dock = DockStyle.Fill;
            fmYeuCau.Show();
        }

        private void btn_thongtincanhan_Click(object sender, EventArgs e)
        {
            /*  pictureBox1.Visible = false;
            panel_form.Visible = true;
           fmDoiMatKhau = new frm_DoiMatKhau(user, role);              Đổi tên form thích hợp
           fmDoiMatKhau.TopLevel = false;
           panel_form.Controls.Add(fmDoiMatKhau);
           fmDoiMatKhau.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
           fmDoiMatKhau.Dock = DockStyle.Fill;
           fmDoiMatKhau.Show();*/
        }

        private void btn_thongtinnophi_Click(object sender, EventArgs e)
        {
            /*  pictureBox1.Visible = false;
            panel_form.Visible = true;
            panel_form.Controls.Clear();
            fmDoiMatKhau = new frm_DoiMatKhau(user, role);              Đổi tên form thích hợp
           fmDoiMatKhau.TopLevel = false;
           panel1.Controls.Add(fmDoiMatKhau);
           fmDoiMatKhau.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
           fmDoiMatKhau.Dock = DockStyle.Fill;
           fmDoiMatKhau.Show();*/
        }

        private void btn_thietbi_Click(object sender, EventArgs e)
        {
            /*  pictureBox1.Visible = false;
            panel_form.Visible = true;
            panel_form.Controls.Clear();
            fmDoiMatKhau = new frm_DoiMatKhau(user, role);              Đổi tên form thích hợp
           fmDoiMatKhau.TopLevel = false;
           panel_form.Controls.Add(fmDoiMatKhau);
           fmDoiMatKhau.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
           fmDoiMatKhau.Dock = DockStyle.Fill;
           fmDoiMatKhau.Show();*/
        }

        private void btn_thongbao_Click(object sender, EventArgs e)
        {
            /*  pictureBox1.Visible = false;
            panel_form.Visible = true;
            panel_form.Controls.Clear();
            fmDoiMatKhau = new frm_DoiMatKhau(user, role);              Đổi tên form thích hợp
           fmDoiMatKhau.TopLevel = false;
           panel_form.Controls.Add(fmDoiMatKhau);
           fmDoiMatKhau.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
           fmDoiMatKhau.Dock = DockStyle.Fill;
           fmDoiMatKhau.Show();*/
        }
    }
}
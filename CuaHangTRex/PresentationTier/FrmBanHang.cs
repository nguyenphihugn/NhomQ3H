using CuaHangTRex.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangTRex.PresentationTier
{
    public partial class FrmBanHang : Form
    {
        private NhanVienViewModel nhanVien;
        public string maNV;
        private Button currentBtn;
        private Panel leftBorderBtn;
        private Form activeForm = null;
        public FrmBanHang(NhanVienViewModel nv)
        {
            InitializeComponent();
            customizeDesign();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 59);
            paneSideMenu.Controls.Add(leftBorderBtn);
            nhanVien = nv;
            maNV = nv.MaNV;
            if (nv.ChucVu == "Quản Lý")
            {
                this.Text = "Xin chào nhà quản lý " + nv.TenNV;
                btnQuanLyNhanVien.Enabled = true;
            }
            else
            {
                this.Text = "Xin chào " + nv.TenNV + " với mã nhân viên: " + nv.MaNV;
                btnQuanLyNhanVien.Enabled = false;
            }
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37,36,81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(currentBtn.Location.X, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(11, 7, 17);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void customizeDesign()
        {
            panelMenuTaiKhoan.Visible = false;
            panelMenuKhachHang.Visible = false;
            panelMenuSanPham.Visible = false;
            panelMenuNghiepVu.Visible = false;
        }

        private void hideSubMenu()
        {
            if(panelMenuTaiKhoan.Visible == true)
                panelMenuTaiKhoan.Visible = false;

            if (panelMenuKhachHang.Visible == true)
                panelMenuKhachHang.Visible = false;

            if (panelMenuSanPham.Visible == true)
                panelMenuSanPham.Visible = false;

            if (panelMenuNghiepVu.Visible == true)
                panelMenuNghiepVu.Visible = false;
        }

        private void showSubMneu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                //hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }


        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            this.pictureLogo.Image = global::CuaHangTRex.Properties.Resources.profile1;
            //this.pictureLogo.Image = global::CuaHangTRex.Properties.Resources;
            showSubMneu(panelMenuTaiKhoan);
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender, RGBColors.color6);
            labelLogo.Text = "Quan Ly Nhan Su";
            labelLogo.TextAlign = ContentAlignment.MiddleCenter;
            openChildForm(new FrmQuanLyNhanVien());
            //labelLogo.Text = "Quản Lý Nhân Sự";
            //hideSubMenu();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            this.pictureLogo.Image = global::CuaHangTRex.Properties.Resources.rating;
            //this.pictureLogo.Image = global::CuaHangTRex.Properties.Resources.rating;
            showSubMneu(panelMenuKhachHang);
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            this.pictureLogo.Image = global::CuaHangTRex.Properties.Resources.jogging;
            //this.pictureLogo.Image = global::CuaHangTRex.Properties.Resources.jogging;
            showSubMneu(panelMenuSanPham);
        }

        private void btnNghiepVu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            this.pictureLogo.Image = global::CuaHangTRex.Properties.Resources.health_check;
            //this.pictureLogo.Image = global::CuaHangTRex.Properties.Resources.health_check1;
            showSubMneu(panelMenuNghiepVu);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            this.pictureLogo.Image = global::CuaHangTRex.Properties.Resources.help;
            //this.pictureLogo.Image = global::CuaHangTRex.Properties.Resources.help;
            ActivateButton(sender, RGBColors.color5);
            labelLogo.Text = "Ho Tro Tu Van";
            labelLogo.TextAlign = ContentAlignment.MiddleCenter;
            openChildForm(new FrmHelp());
        }

        
        private void openChildForm(Form ChildForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(ChildForm);
            panelChildForm.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }
        private void FrmBanHang_Load(object sender, EventArgs e)
        {
            
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Add(new TimeSpan());
            lblgio.Text = String.Format("{0:hh:mm:ss tt}", dt);
            lblngay.Text = String.Format("{0:dd/MM/yyyy}", dt);
        }

       

        

        private void menuDoiMatKhau_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan thongTinCaNhan = new ThongTinCaNhan(maNV);
            thongTinCaNhan.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQuanLyKhachHang frmQuanLyKhachHang = new FrmQuanLyKhachHang();
            frmQuanLyKhachHang.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                FrmDangNhap frmDangNhap = new FrmDangNhap();
                frmDangNhap.Closed += (s, args) => this.Close();
                frmDangNhap.Show();
            }
        }

        private void pictureHome_Click(object sender, EventArgs e)
        {
            
            Reset();
        }

       
        private void Reset()
        {
            DisableButton();
            hideSubMenu();
            this.pictureLogo.Image = global::CuaHangTRex.Properties.Resources.home;
            //this.pictureLogo.Image = global::CuaHangTRex.Properties.Resources.home;
            if (activeForm != null)
            {
                activeForm.Close();
            }           
            labelLogo.Text = "Shop Giay T-Rex";
            leftBorderBtn.Visible = false;
        }

        private void btnThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            labelLogo.Text = "Thong Tin Tai Khoan";
            labelLogo.TextAlign = ContentAlignment.MiddleCenter;
            openChildForm(new ThongTinCaNhan(maNV));
        }

        private void btnQLKhach_Click(object sender, EventArgs e)
        {
            labelLogo.Text = "Thong Tin Khach Hang";
            labelLogo.TextAlign = ContentAlignment.MiddleCenter;
            openChildForm(new FrmQuanLyKhachHang());
        }

        private void btnQL_SanPham_Click(object sender, EventArgs e)
        {
            labelLogo.Text = "Quan Ly San Pham";
            labelLogo.TextAlign = ContentAlignment.MiddleCenter;
            openChildForm(new FrmQuanLySanPham());
        }

        private void btnQL_NhaCungCap_Click(object sender, EventArgs e)
        {
            labelLogo.Text = "Nha Cung Cap";
            labelLogo.TextAlign = ContentAlignment.MiddleCenter;
            openChildForm(new FrmQuanLyNhaCungCap());
        }

        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            labelLogo.Text = "Mua Hang San Pham";
            labelLogo.TextAlign = ContentAlignment.MiddleCenter;
            openChildForm(new FrmQuanLyMuaBan(maNV));
        }

        private void btnQLNghiepVu_Click(object sender, EventArgs e)
        {
            labelLogo.Text = "Phieu Nhap Hang";
            labelLogo.TextAlign = ContentAlignment.MiddleCenter;
            openChildForm(new FrmQuanLyPhieuNhapHang());
        }

        private void btnQuanLyHoaDon_Click(object sender, EventArgs e)
        {
            labelLogo.Text = "Hoa Don Khach Hang";
            labelLogo.TextAlign = ContentAlignment.MiddleCenter;
            openChildForm(new FrmQuanLiHoaDon());
        }

        private void btnXuatBC_Click(object sender, EventArgs e)
        {
            labelLogo.Text = "Bao Cao Hang Thang";
            labelLogo.TextAlign = ContentAlignment.MiddleCenter;
            openChildForm(new FrmXuatBaoCao());          
        }
    }
}

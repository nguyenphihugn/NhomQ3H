using CuaHangTRex.DataTier.Models;
using CuaHangTRex.LogicTier;
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
    public partial class FrmCT_NoiCungCap : Form
    {
        private NoiCungCapBUS noiCungCapBUS;
        public static FrmCT_NoiCungCap instance;
        public FrmCT_NoiCungCap()
        {
            InitializeComponent();
            instance = this;
            noiCungCapBUS = new NoiCungCapBUS();
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmailNCC.Text == "" || txtMaNCC.Text == "" || txtTenNCC.Text == "" || txtSĐTNCC.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin nhà cung cấp!!!");
                Noi_Cung_Cap s = new Noi_Cung_Cap();
                s.MaNCC = txtMaNCC.Text;
                s.TenNCC = txtTenNCC.Text;
                s.SDT = txtSĐTNCC.Text;
                s.Email = txtEmailNCC.Text;
                noiCungCapBUS.them(s);
                MessageBox.Show("Đã thêm thành công!!!", "Thông Báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNCC.Text == "")
                    throw new Exception("Vui lòng nhập Mã nhà cung cấp!!!");
                if (txtEmailNCC.Text == "" && txtMaNCC.Text == "" && txtTenNCC.Text == "" && txtSĐTNCC.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin nhà cung cấp!!!");

                Noi_Cung_Cap s = new Noi_Cung_Cap();
                s.MaNCC = txtMaNCC.Text;
                if (txtTenNCC.Text == "")
                {
                    s.TenNCC = null;
                }
                else
                {
                    s.TenNCC = txtTenNCC.Text;
                }
                if (txtSĐTNCC.Text == "")
                {
                    s.SDT = null;
                }
                else
                {
                    s.SDT = txtSĐTNCC.Text;
                }
                if (txtEmailNCC.Text == "")
                {
                    s.Email = null;
                }
                else
                {
                    s.Email = txtEmailNCC.Text;
                }


                noiCungCapBUS.Update(s);
                MessageBox.Show("Đã Cập nhật thành công!!!", "Thông Báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

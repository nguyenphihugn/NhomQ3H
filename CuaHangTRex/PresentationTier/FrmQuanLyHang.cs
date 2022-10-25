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
    public partial class FrmQuanLyHang : Form
    {
        private HangBUS hangBUS;
        public static FrmQuanLyHang instance;
        public FrmQuanLyHang()
        {
            InitializeComponent();
            hangBUS = new HangBUS();
            instance = this;
        }
        private void loadHang()
        {
            dgvHang.DataSource = hangBUS.GetChung_Loais();
        }

        private void FrmQuanLyHang_Load(object sender, EventArgs e)
        {
            try
            {
                loadHang();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvHang.Rows[e.RowIndex];
                if (row != null)
                {
                    txtMaHang.Text = row.Cells[0].Value.ToString();

                    txtTenHang.Text = row.Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaHang.Text == "" || txtTenHang.Text == "")
                    MessageBox.Show("Vui lòng nhập đày đủ thông tin!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Chung_Loai hang = new Chung_Loai();
                    hang.MaLoai = txtMaHang.Text;
                    hang.TenLoaiSP = txtTenHang.Text;
                    hangBUS.them(hang);
                    MessageBox.Show("Đã cập nhập thành công!!!", "Thông Báo", MessageBoxButtons.OK);
                    loadHang();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa Hãng này không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    hangBUS.Delete(txtMaHang.Text);
                    loadHang();
                    MessageBox.Show("Đã xóa dữ liệu thành công !!!", "Thông Báo", MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

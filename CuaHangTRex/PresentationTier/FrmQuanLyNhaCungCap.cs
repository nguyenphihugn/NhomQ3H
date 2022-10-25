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
    public partial class FrmQuanLyNhaCungCap : Form
    {
        private NoiCungCapBUS noiCungCapBUS;
        public static FrmQuanLyNhaCungCap instance;
        private string MaNCCS;
        public FrmQuanLyNhaCungCap()
        {
            InitializeComponent();
            instance = this;
            noiCungCapBUS = new NoiCungCapBUS();
            labelTenNCC.Visible = false;
            labelSDT.Visible = false;
            linkLabelEmail.Visible = false;
        }

        private void loadNCC()
        {
            dgvNCC.DataSource = noiCungCapBUS.GetNoi_Cung_Caps();

        }

        private void FrmQuanLyNhaCungCap_Load(object sender, EventArgs e)
        {
            try
            {
                loadNCC();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewRow row = this.dgvNCC.Rows[e.RowIndex];
                MaNCCS = row.Cells[0].Value.ToString();
                labelTenNCC.Text = row.Cells[1].Value.ToString();


                labelSDT.Text = row.Cells[2].Value.ToString();
                linkLabelEmail.Text = row.Cells[3].Value.ToString();


                labelTenNCC.Visible = true;
                labelSDT.Visible = true;
                linkLabelEmail.Visible = true;

            }
            catch (Exception ex)
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (labelTenNCC.Text == "")
                {
                    throw new Exception("Vui lòng Chọn nhà cung cấp cần xóa!!!");
                }
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa Nhà cung cấp này", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    noiCungCapBUS.Delete(MaNCCS);
                    loadNCC();
                    labelTenNCC.Visible = false;
                    labelSDT.Visible = false;
                    linkLabelEmail.Visible = false;
                    MessageBox.Show("Đã xóa dữ liệu thành công !!!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            string timKiem = txtTimkiem.Text.ToLower();
            dgvNCC.DataSource = noiCungCapBUS.TimKiem(timKiem);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form frm = new FrmCT_NoiCungCap();
            frm.ShowDialog();
            this.Show();
            loadNCC();
        }
    }
    
}

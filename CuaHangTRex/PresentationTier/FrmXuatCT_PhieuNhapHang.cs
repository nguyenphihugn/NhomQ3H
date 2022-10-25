using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuaHangTRex.DataTier.Models;
using CuaHangTRex.DataTier;
using CuaHangTRex.LogicTier;


namespace CuaHangTRex.PresentationTier
{
    public partial class FrmXuatCT_PhieuNhapHang : Form
    {
        private CT_PhieuNhapHangBUS cT_PhieuNhapHangBUS;
        public FrmXuatCT_PhieuNhapHang(string MAPN)
        {
            InitializeComponent();
            cT_PhieuNhapHangBUS = new CT_PhieuNhapHangBUS();
            txtMaPN_XUAT.Text = MAPN;
            dgvCT_XuatPBC.Rows.Clear();
            dgvCT_XuatPBC.DataSource = cT_PhieuNhapHangBUS.GetQuanLyCT_NhapKhoXuat(MAPN);
        }

        private void FrmXuatCT_PhieuNhapHang_Load(object sender, EventArgs e)
        {

        }
    }
}

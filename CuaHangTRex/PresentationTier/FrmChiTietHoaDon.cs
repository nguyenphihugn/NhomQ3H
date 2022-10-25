using CuaHangTRex.LogicTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangTRex.PresentationTier
{
    public partial class FrmChiTietHoaDon : Form
    {
        private ChiTietHoaDonBUS chiTietHoaDonBUS;
        //static String connString = @"Data Source=LAPTOP-UVLBK69K\SQLEXPRESS;Initial Catalog=QLShopT_Rex;Integrated Security=True";
        //SqlConnection conn = new SqlConnection(connString);
        public FrmChiTietHoaDon(string data)
        {
            InitializeComponent();
            chiTietHoaDonBUS = new ChiTietHoaDonBUS();
            txtMaHD.Enabled = false;
            txtMaHD.Text = data;
            dgvChiTiet.Rows.Clear();
            dgvChiTiet.DataSource = chiTietHoaDonBUS.Getct_HoaDon_xuatBaoCao(data);
            //loadfrom();
        }

        //public void loadfrom()
        //{
        //    dgvChiTiet.DataSource = chiTietHoaDonBUS.GetQuanLyHoaDon();
        //    loadMaHD();
        //}

        public void loadMaHD()
        {
            //if (conn.State == ConnectionState.Closed)
            //    conn.Open();
            //SqlCommand cmd = new SqlCommand("Select * from CT_HD where MaHD=@MaHD", conn);
            //cmd.Parameters.AddWithValue("@MaHD", txtMaHD.Text);
            //cmd.ExecuteNonQuery();
            //SqlDataReader reader = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(reader);
            //dgvChiTiet.DataSource = dt;
            //if (conn.State == ConnectionState.Open)
            //    conn.Close();
        }
    }
}
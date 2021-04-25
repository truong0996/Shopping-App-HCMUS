using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CSDLNC_TH
{
    public partial class ChiTietDSDonHang : Form
    {
        public ChiTietDSDonHang()
        {
            InitializeComponent();
        }

        string connectionStr = @"Data Source=.\SQLExpress;Initial Catalog=QuanLyBanHang;Integrated Security=True";

        private void ChiTietDSDonHang_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionStr);
            string billDetalList;
            if (QLBH.temp == 1)
            {
                billDetalList = string.Format("SELECT * " +
                                                   "FROM CHI_TIET_DON_HANG " +
                                                   "WHERE MA_DON_HANG = {0}", DSDonHang.maDH);
            }
            else if (QLBH.temp == 2)
            {
                billDetalList = string.Format("SELECT * " +
                                                   "FROM CHI_TIET_DON_HANG " +
                                                   "WHERE MA_DON_HANG = {0}", LichSuMua.maDH);
            }
            else
                billDetalList = "";
            SqlCommand cmd = new SqlCommand(billDetalList, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dtgv_ctietDsDh.DataSource = dt;
            connection.Close();
        }
    }
}

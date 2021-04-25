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
    public partial class DSDonHang : Form
    {
        public DSDonHang()
        {
            InitializeComponent();
        }

        string connectionStr = @"Data Source=.\SQLExpress;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        public string maCH = QLBH.getUserName + "_ch";
        private void DSDonHangcs_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionStr);
            string query = string.Format("SELECT MA_DON_HANG, MA_KH, DIA_CHI, TRANG_THAI " +
                                                   "FROM DANH_SACH_DON_HANG " +
                                                   "WHERE MA_CUA_HANG = '{0}'", maCH);

            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dtgv_dsdonHang.DataSource = dt;
            connection.Close();
        }

        public static String maDH = "";
        private void dtgv_dsdonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dtgv_dsdonHang.Rows[index];
            maDH = selectedRow.Cells[0].Value.ToString();
        }
        private void billDetailBtn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            if(maDH == "")
            {
                MessageBox.Show("Bạn chưa chọn đơn hàng :)");
                return; 
            }
            ChiTietDSDonHang ct = new ChiTietDSDonHang();
            QLBH.temp = 1;
            ct.Show();
        }
    }
}

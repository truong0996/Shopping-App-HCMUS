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
    public partial class LichSuMua : Form
    {
        public LichSuMua()
        {
            InitializeComponent();
        }

        string connectionStr = @"Data Source=.\SQLExpress;Initial Catalog=QuanLyBanHang;Integrated Security=True";

        private void LichSuMua_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionStr);
            string query = string.Format("SELECT MA_DON_HANG, MA_CUA_HANG ,DIA_CHI, TRANG_THAI " +
                                                   "FROM DANH_SACH_DON_HANG " +
                                                   "WHERE MA_KH = '{0}'", QLBH.getUserName);

            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dtgv_donMua.DataSource = dt;
            connection.Close();
        }
        public static String maDH = "";
        private void dtgv_donMua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dtgv_donMua.Rows[index];
            maDH = selectedRow.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(maDH == "")
            {
                MessageBox.Show("Bạn chưa chọn đơn hàng :)");
                return;
            }
            ChiTietDSDonHang ct = new ChiTietDSDonHang();
            ct.Show();
            QLBH.temp = 2;
        }

        private void billDetailBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionStr);
                SqlCommand cmd = new SqlCommand("dbo.RECEIVE_CONFIRM", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MA_DH", SqlDbType.Int);

                cmd.Parameters["@MA_DH"].Value = maDH;
                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xác nhận thành công");
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn đơn hàng :)");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionStr);
            string query = string.Format("SELECT MA_DON_HANG, MA_CUA_HANG ,DIA_CHI, TRANG_THAI " +
                                                    "FROM DANH_SACH_DON_HANG " +
                                                    "WHERE MA_KH = '{0}'", QLBH.getUserName);

            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dtgv_donMua.DataSource = dt;
            connection.Close();
        }
    }
}

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
    public partial class CuaHang : Form
    {
        public CuaHang()
        {
            InitializeComponent();
        }

        string connectionStr = @"Data Source=.\SQLExpress;Initial Catalog=QuanLyBanHang;Integrated Security=True";


        private void CuaHang_Load(object sender, EventArgs e)
        {
            shopNameLabel.Text = QLBH.getUserName + "_ch";

            SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand cmd = new SqlCommand("dbo.SHOW_SHOP_PRODUCT", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MA_CH", SqlDbType.NVarChar, 50);
            cmd.Parameters["@MA_CH"].Value = shopNameLabel.Text;
            connection.Open();
            DataTable dt = new DataTable();

            dt.Load(cmd.ExecuteReader());
            dtgv_ch.DataSource = dt;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand cmd = new SqlCommand("dbo.SHOW_SHOP_PRODUCT", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MA_CH", SqlDbType.NVarChar, 50);
            cmd.Parameters["@MA_CH"].Value = shopNameLabel.Text;
            connection.Open();
            DataTable dt = new DataTable();

            dt.Load(cmd.ExecuteReader());
            dtgv_ch.DataSource = dt;
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            CuaHangThemSP addProd = new CuaHangThemSP();
            addProd.Show();
        }

        private void billBtn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            DSDonHang ds = new DSDonHang();
            ds.Show();
        }

        public string maSP = "";
        private void dtgv_ch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dtgv_ch.Rows[index];
            maSP = selectedRow.Cells[0].Value.ToString();
        }

        private void deleteProductBtn_Click(object sender, EventArgs e)
        {
            if (maSP == "")
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm :)");
                return;
            }
            try
            {

                SqlConnection connection = new SqlConnection(connectionStr);

                SqlCommand cmd = new SqlCommand("dbo.DELETE_SHOP_PRODUCT", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MA_SP", SqlDbType.NVarChar, 50);
                cmd.Parameters["@MA_SP"].Value = maSP;

                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm :)");
            }
        }

      
    }
}

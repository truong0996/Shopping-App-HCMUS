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
using Microsoft.VisualBasic;

namespace CSDLNC_TH
{
    public partial class GioHang : Form
    {
        public GioHang()
        {
            InitializeComponent();
        }

        string connectionStr = @"Data Source=.\SQLExpress;Initial Catalog=QuanLyBanHang;Integrated Security=True";


        static string maGH = QLBH.getUserName + "_gh";
        private void updateCartBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand cmd = new SqlCommand("dbo.SHOW_CART_PRODUCT", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MA_GH", SqlDbType.NVarChar, 50);

            cmd.Parameters["@MA_GH"].Value = maGH;

            connection.Open();
            DataTable dt = new DataTable();

            dt.Load(cmd.ExecuteReader());
            dtgv_gh.DataSource = dt;


            // Hiển thị tổng tiền
            string totalMoneyQuery = string.Format("SELECT TONG_TIEN FROM GIO_HANG WHERE MA_GIO_HANG = '{0}'", maGH);
            SqlCommand cmd2 = new SqlCommand(totalMoneyQuery, connection);
            var temp = cmd2.ExecuteScalar();
            totalMoneyLabel.Text = temp.ToString();

            connection.Close();
        }
      

        static string maSP;
        private void dtgv_gh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dtgv_gh.Rows[index];
            maSP = selectedRow.Cells[3].Value.ToString();
        }

        private void deleteProductBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionStr);

                SqlCommand cmd = new SqlCommand("dbo.DELETE_PRODUCT", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MA_GH", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@MA_SP", SqlDbType.NVarChar, 50);

                cmd.Parameters["@MA_GH"].Value = maGH;
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

        private void fixQuantityBtn_Click(object sender, EventArgs e)
        {

            string fixQuantityTxt = Interaction.InputBox("Nhập số lượng sản phẩm", "Số lượng", "", 300, 300);
            int quantity;
            try
            {
                quantity = int.Parse(fixQuantityTxt);
            }
            catch
            {
                MessageBox.Show("Số nhập phải đúng định dạng");
                return;
            }
            if (quantity <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0");
                return;
            }
            else if (quantity > 0)
            {
                try
                {
                    SqlConnection connection = new SqlConnection(connectionStr);

                    SqlCommand cmd = new SqlCommand("dbo.CHANGE_QUANTITY", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@MA_GH", SqlDbType.NVarChar, 50);
                    cmd.Parameters.Add("@MA_SP", SqlDbType.NVarChar, 50);
                    cmd.Parameters.Add("@SO_LUONG_MOI", SqlDbType.Int);

                    cmd.Parameters["@MA_GH"].Value = maGH;
                    cmd.Parameters["@MA_SP"].Value = maSP;
                    cmd.Parameters["@SO_LUONG_MOI"].Value = quantity;

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công");
                    connection.Close();
                }
                catch
                {
                    MessageBox.Show("Bạn chưa chọn sản phẩm :)");
                }
            }
        }

        private void purchaseBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionStr);

            SqlCommand cmd2 = new SqlCommand("dbo.BILL_REQUEST", connection);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.Add("@MA_GIO_HANG", SqlDbType.NVarChar, 50);
            cmd2.Parameters.Add("@MA_KH", SqlDbType.NVarChar, 50);

            cmd2.Parameters["@MA_GIO_HANG"].Value = maGH;
            cmd2.Parameters["@MA_KH"].Value = QLBH.getUserName;

            SqlCommand cmd3 = new SqlCommand("dbo.DELETE_ALL_PRODUCT", connection);
            cmd3.CommandType = CommandType.StoredProcedure;
            cmd3.Parameters.Add("@MA_GH", SqlDbType.NVarChar, 50);
            cmd3.Parameters["@MA_GH"].Value = maGH;

            connection.Open();

            //cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            MessageBox.Show("Mua thành công");
            connection.Close();
        }

        private void GioHang_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand cmd = new SqlCommand("dbo.SHOW_CART_PRODUCT", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MA_GH", SqlDbType.NVarChar, 50);

            cmd.Parameters["@MA_GH"].Value = maGH;

            connection.Open();
            DataTable dt = new DataTable();

            dt.Load(cmd.ExecuteReader());
            dtgv_gh.DataSource = dt;


            // Hiển thị tổng tiền
            string totalMoneyQuery = string.Format("SELECT TONG_TIEN FROM GIO_HANG WHERE MA_GIO_HANG = '{0}'", maGH);
            SqlCommand cmd2 = new SqlCommand(totalMoneyQuery, connection);
            var temp = cmd2.ExecuteScalar();
            totalMoneyLabel.Text = temp.ToString();

            connection.Close();
        }
    }
}

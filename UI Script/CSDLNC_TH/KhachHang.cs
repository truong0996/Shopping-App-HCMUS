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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        string connectionStr = @"Data Source=.\SQLExpress;Initial Catalog=QuanLyBanHang;Integrated Security=True";

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand cmd = new SqlCommand("dbo.SEARCH", connection);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@NAME", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@CATEGORY", SqlDbType.NVarChar, 50);

            cmd.Parameters["@NAME"].Value = searchTxtBox.Text;
            cmd.Parameters["@CATEGORY"].Value = danhMucComBox.Text;

            connection.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dtgv_kh.DataSource = dt;
            connection.Close();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = QLBH.getUserName;

            SqlConnection connection = new SqlConnection(connectionStr);
            SqlCommand cmd = new SqlCommand("dbo.SEARCH", connection);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@NAME", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@CATEGORY", SqlDbType.NVarChar, 50);

            cmd.Parameters["@NAME"].Value = searchTxtBox.Text;
            cmd.Parameters["@CATEGORY"].Value = danhMucComBox.Text;

            connection.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dtgv_kh.DataSource = dt;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            QLBH form1 = new QLBH();
            form1.Show();
        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
           
            //this.Hide();
            GioHang gh = new GioHang();
            gh.Show();
        }

        static string maSP;
        private void dtgv_kh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dtgv_kh.Rows[index];
            maSP = selectedRow.Cells[6].Value.ToString();
        }

        private void addCartBtn_Click(object sender, EventArgs e)
        {
            string quantityTxt = Interaction.InputBox("Nhập số lượng sản phẩm", "Số lượng", "", 300, 300);
            int quantity;
            try
            {
                quantity = int.Parse(quantityTxt);
            }
            catch 
            {
                MessageBox.Show("Số nhập phải đúng định dạng");
                return;
            }
           
            if(quantity <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0");
                return;
            }
            else if (quantity > 0)
            {
                SqlConnection connection = new SqlConnection(connectionStr);

                SqlCommand cmd = new SqlCommand("dbo.ADD_TO_CART", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MA_GIO_HANG", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@MA_SAN_PHAM", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@SO_LUONG", SqlDbType.Int);

                cmd.Parameters["@MA_GIO_HANG"].Value = usernameLabel.Text + "_gh";
                cmd.Parameters["@MA_SAN_PHAM"].Value = maSP;
                cmd.Parameters["@SO_LUONG"].Value = quantity;

                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm sản phẩm thành công");
                connection.Close();
            }
        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            LichSuMua dm = new LichSuMua();
            dm.Show();
        }

        private void shopBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionStr);

            SqlCommand cmd = new SqlCommand("dbo.CHECK_SHOP", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MA_KH", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@FLAG", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Parameters["@MA_KH"].Value = QLBH.getUserName;
            connection.Open();
            cmd.ExecuteNonQuery();
            int flag = Convert.ToInt32(cmd.Parameters["@FLAG"].Value);
            if (flag == 1)
            {
                //this.Hide();
                CuaHang ch = new CuaHang();
                ch.Show();
            }
            else if (flag == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chưa tạo cửa hàng. Bạn có muốn tạo 1 cửa hàng dành riêng cho bạn?", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlCommand cmd2 = new SqlCommand("dbo.SHOP_REGISTER", connection);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.Add("@MA_KH", SqlDbType.NVarChar, 50);
                    cmd2.Parameters["@MA_KH"].Value = QLBH.getUserName;
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Success");

                }
            }
            connection.Close();

        }

       
    }
}

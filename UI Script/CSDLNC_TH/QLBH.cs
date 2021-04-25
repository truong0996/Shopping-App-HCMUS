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
    public partial class QLBH : Form
    {
        public QLBH()
        {
            InitializeComponent();
        }
        string connectionStr = @"Data Source=.\SQLExpress;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        public static String getUserName = "";
        public static int temp;

        private void loginBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionStr);

            SqlCommand cmd = new SqlCommand("dbo.LOG_IN", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@ID", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@PASS", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@FLAG", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd.Parameters["@ID"].Value = loginIdTxtBox.Text;
            cmd.Parameters["@PASS"].Value = loginPassTxtBox.Text;

            connection.Open();
            cmd.ExecuteNonQuery();

            int flag = Convert.ToInt32(cmd.Parameters["@FLAG"].Value);
            if(flag == 1)
            {
                //this.Hide();
                getUserName = loginIdTxtBox.Text;
                KhachHang kh = new KhachHang();
                kh.Show();
            }
            else if (flag == 0)
            {
                MessageBox.Show("Not found");
            }
            connection.Close();
        }

        

        private void registerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionStr);

                SqlCommand cmd = new SqlCommand("dbo.REGISTER", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ID", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@PASS", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@NAME", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@DOB", SqlDbType.Date);
                cmd.Parameters.Add("@ADDR", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@PHONE", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@EMAIL", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@FLAG", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.Parameters["@ID"].Value = registerIdTxtBox.Text;
                cmd.Parameters["@PASS"].Value = registerPassTxtBox.Text;
                cmd.Parameters["@NAME"].Value = registerNameTxtBox.Text;
                cmd.Parameters["@DOB"].Value = registerDoBTxtBox.Text;
                cmd.Parameters["@ADDR"].Value = registerAddrTxtBox.Text;
                cmd.Parameters["@PHONE"].Value = registerPhoneTxtBox.Text;
                cmd.Parameters["@EMAIL"].Value = registerAddrTxtBox.Text;

                connection.Open();
                cmd.ExecuteNonQuery();

                int flag = Convert.ToInt32(cmd.Parameters["@FLAG"].Value);
                if (flag == 1)
                {
                    MessageBox.Show("Success");
                }
                else if (flag == 0)
                {
                    MessageBox.Show("Already exist");
                }
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Thông tin bạn nhập không hợp lệ");
            }
        }
    }
}

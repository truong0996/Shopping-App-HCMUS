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
    public partial class CuaHangThemSP : Form
    {
        public CuaHangThemSP()
        {
            InitializeComponent();
        }

        string connectionStr = @"Data Source=.\SQLExpress;Initial Catalog=QuanLyBanHang;Integrated Security=True";


        private void addProdBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionStr);

                SqlCommand cmd = new SqlCommand("dbo.ADD_PRODUCT", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MA_CH", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@TEN_DM", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@TEN_SP", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@GIA_SP", SqlDbType.Money);
                cmd.Parameters.Add("@SL_CON_LAI", SqlDbType.Int);
                cmd.Parameters.Add("@MO_TA", SqlDbType.NVarChar, 2000);

                cmd.Parameters["@MA_CH"].Value = QLBH.getUserName + "_ch";
                cmd.Parameters["@TEN_DM"].Value = themSpComBox.Text;
                cmd.Parameters["@TEN_SP"].Value = prodNameTxtBox.Text;
                cmd.Parameters["@GIA_SP"].Value = Double.Parse(prodPriceTxtBox.Text);
                cmd.Parameters["@SL_CON_LAI"].Value = int.Parse(prodQuantityTxtBox.Text);
                cmd.Parameters["@MO_TA"].Value = prodAboutTxtBox.Text;

                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm sản phẩm thành công");
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Thông tin bạn nhập không hợp lệ :)");
            }
        }
    }
}

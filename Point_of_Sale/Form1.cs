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
using System.Data.SqlClient;

namespace Point_of_Sale
{
    public partial class POS : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-00FS4QN\\SQLEXPRESS;Initial Catalog=PointOfSale;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        public POS()
        {
            InitializeComponent();

        }

        private void POS_Load(object sender, EventArgs e)
        { 
            LoadData();
            TotalSum();
        }

        private void Barcode_KeyDown(object sender, KeyEventArgs e)
        {
            int barcode = 0;
            try
            {
                barcode = int.Parse(Barcode.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Barcode");
            }

            if (e.KeyCode == Keys.Enter)
            {
                SearchCode(this, new EventArgs(), barcode);
            }
        }

        private void SearchCode(object sender, EventArgs e, int barcode)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Products WHERE ProductCode = '" + barcode + "'";
            SqlDataReader re = cmd.ExecuteReader();

            string ProductID = "";
            string ProductCode = "";
            string ProductName = "";
            string ProductPrice = "";

            if (re.Read())
            {
                ProductID = re[0].ToString();
                ProductCode = re[1].ToString();
                ProductName = re[2].ToString();
                ProductPrice = re[3].ToString();
            }
            re.Close();

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con;
            cmd2.CommandType = CommandType.Text;

            try
            {
                cmd2.CommandText = "INSERT INTO Orders (OrderID, ProductCode, ProductName, ProductPrice, ProductQuantity) VALUES('" + int.Parse(ProductID) + "', '" + int.Parse(ProductCode) + "', '" + ProductName + "', '" + int.Parse(ProductPrice) + "', 1)";
                cmd2.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                cmd2.CommandText = "UPDATE Orders SET ProductQuantity = ProductQuantity + 1 WHERE ProductCode = '" + barcode + "'";
                SqlCommand cmd3 = new SqlCommand();
                cmd3.Connection = con;
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "UPDATE Orders SET ProductPrice = ProductPrice + ProductPrice WHERE ProductCode = '" + barcode + "'";

                cmd3.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();

            }

            con.Close();

            LoadData();
            TotalSum();


        }

        private void TotalSum()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SUM(ProductPrice) FROM Orders";

            try
            {
                int total = (int)cmd.ExecuteScalar();
                Total.Text = total.ToString();
            }
            catch (Exception ex)
            {
                Total.Text = "0";
            }

            con.Close();
        }

        private void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Orders", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Orders_vis.DataSource = dt;
        }

        private void Orders_vis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Orders_vis_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int orderId = Convert.ToInt32(e.Row.Cells["OrderID"].Value);

            DialogResult result = MessageBox.Show("Delete this record from the database?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }

            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM Orders WHERE OrderID = @OrderID", con);
                cmd.Parameters.AddWithValue("@OrderID", orderId);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting from database: " + ex.Message);
                e.Cancel = true;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            TotalSum();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure? You want to Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset the Menu?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Orders";
                cmd.ExecuteNonQuery();
                con.Close();
                LoadData();
            }
        }
    }
}

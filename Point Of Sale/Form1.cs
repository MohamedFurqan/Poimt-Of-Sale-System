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

namespace Point_Of_Sale
{
    public partial class POS : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Mohamed Furqan\\Documents\\GitHub\\Poimt-Of-Sale-System\\Point Of Sale\\Point Of Sale.mdf\";Integrated Security=True;Connect Timeout=30");

        public POS()
        {
            InitializeComponent();
        }

        private void POS_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'point_Of_SaleDataSet1.Orders' table. You can move, or remove it, as needed.
            //this.ordersTableAdapter1.Fill(this.point_Of_SaleDataSet1.Orders);
            //// TODO: This line of code loads data into the 'point_Of_SaleDataSet.Orders' table. You can move, or remove it, as needed.
            //this.ordersTableAdapter.Fill(this.point_Of_SaleDataSet.Orders);
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
            cmd.CommandText = "SELECT * FROM Products WHERE ProductCode = '"+barcode+"'";
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
            cmd2.CommandText = "INSERT INTO Orders (OrderID, ProductCode, ProductName, ProductPrice, ProductQuantity) VALUES('"+int.Parse(ProductID)+"', '"+int.Parse(ProductCode)+"', '"+ProductName+"', '"+int.Parse(ProductPrice)+"', 1)";
            cmd2.ExecuteNonQuery();
            con.Close();

            LoadData();
            
            
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
            LoadData();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.custom
{
    public partial class UserCart : Form
    {
        string email;
        public UserCart(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void UserCart_Load(object sender, EventArgs e)
        {
            string command = "SELECT  CART.C_EMAIL, CART.P_ID, CART.STOCK, PRODUCT.NAME, PRODUCT.PRICE*CART.STOCK AS PRICE, PRODUCT.CATEGORY, PRODUCT.S_EMAIL FROM S5584994.CART, S5584994.PRODUCT WHERE(CART.P_ID = PRODUCT.P_ID) AND CART.C_EMAIL = '" + email+"'";
            oracleConnection1.ConnectionString ="USER ID=S5584994;DATA SOURCE=localhost:1521/xepdb1;PASSWORD=S5584994";
            oracleConnection1.Open();
            oracleDataAdapter1.SelectCommand = new Oracle.ManagedDataAccess.Client.OracleCommand(command, oracleConnection1);
            DataSet data = new DataSet();
            oracleDataAdapter1.Fill(data);
            dataGridView1.DataSource = data.Tables[0].DefaultView;

            oracleConnection1.Close();

            DataGridViewColumn p_id = dataGridView1.Columns["P_ID"];
            p_id.Visible = false;
            DataGridViewColumn c_email = dataGridView1.Columns["C_EMAIL"];
            c_email.Visible = false;
            DataGridViewColumn name = dataGridView1.Columns["NAME"];
            name.HeaderText = "제품명";
            DataGridViewColumn stock = dataGridView1.Columns["STOCK"];
            stock.HeaderText = "담긴 수량";
            DataGridViewColumn price = dataGridView1.Columns["PRICE"];
            price.HeaderText = "가격";
            DataGridViewColumn category = dataGridView1.Columns["CATEGORY"];
            category.HeaderText = "카테고리";
            DataGridViewColumn s_email = dataGridView1.Columns["S_EMAIL"];
            s_email.HeaderText = "판매자";


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cARTBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

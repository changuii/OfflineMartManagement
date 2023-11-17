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
        string name;
        public UserCart(string email, string name)
        {
            InitializeComponent();
            this.email = email;
            this.name = name;
        }

        private void UserCart_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.CART_VIEW1' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.cART_VIEW1TableAdapter.Fill(this.dataSet1.CART_VIEW1);
            this.cARTVIEW1BindingSource.Filter = $"C_EMAIL = '{this.email}'";
            this.tableNameLabel.Text = $"{this.name}님의 장바구니입니다.";
            this.updateTableView();
            errorLabel.Text = "";
            /*string command = "SELECT  CART.C_EMAIL, CART.P_ID, CART.STOCK, PRODUCT.NAME, PRODUCT.PRICE*CART.STOCK AS PRICE, PRODUCT.CATEGORY, PRODUCT.S_EMAIL FROM S5584994.CART, S5584994.PRODUCT WHERE(CART.P_ID = PRODUCT.P_ID) AND CART.C_EMAIL = '" + email+"'";
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

            s_email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill*/
            ;

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

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.updateTableView();   
        }
        private void updateTableView()
        {
            DataGridViewRow data = this.dataGridView1.CurrentRow;

            if (data != null)
            {
                this.nameLabel.Text = data.Cells[0].Value.ToString();
                this.p_stockLabel.Text = data.Cells[1].Value.ToString();
                this.p_priceLabel.Text = data.Cells[2].Value.ToString();
                this.stockLabel.Text = data.Cells[3].Value.ToString();
                this.priceLabel.Text = data.Cells[4].Value.ToString();
                this.categoryLabel.Text = data.Cells[5].Value.ToString();
            }
        }

        private void sellectPurchase_Click(object sender, EventArgs e)
        {
            DataGridViewRow data = this.dataGridView1.CurrentRow;

            if(data != null)
            {
                int p_stock = int.Parse(data.Cells[1].Value.ToString());
                int stock = int.Parse(data.Cells[3].Value.ToString());
                if((stock - p_stock) >= 0)
                {
                    this.purchaseTableAdapter1.Fill(dataSet1.PURCHASE);
                    DataTable purchaseTable = dataSet1.Tables["PURCHASE"];
                    DateTime now = DateTime.Now;
                    DataRow newData = purchaseTable.NewRow();
                    newData["C_EMAIL"] = this.email;
                    newData["P_ID"] = data.Cells[7].Value.ToString();
                    newData["PURCHASE_DATE"] = now;
                    newData["PRICE"] = data.Cells[2].Value.ToString();
                    newData["STOCK"] = data.Cells[1].Value.ToString();
                    newData["ALLOW"] = "구매요청진행중";
                    newData["ID"] = now.ToString("yyyy-MM-dd HH:mm:ss") + this.email + data.Cells[7].Value.ToString();
                    purchaseTable.Rows.Add(newData);

                    this.cartTableAdapter1.Fill(dataSet1.CART);
                    DataTable cartTable = dataSet1.Tables["CART"];
                    string[] key = {this.email, data.Cells[7].Value.ToString() };
                    DataRow target = cartTable.Rows.Find(key);
                    target.Delete();

                    this.cartTableAdapter1.Update(dataSet1.CART);
                    this.purchaseTableAdapter1.Update(dataSet1.PURCHASE);
                    this.cART_VIEW1TableAdapter.Fill(dataSet1.CART_VIEW1);
                    this.updateTableView();
                    errorLabel.ForeColor = Color.MediumSeaGreen;
                    errorLabel.Text = "성공적으로 구매요청 처리되었습니다.";


                }
                else
                {
                    errorLabel.Text = $"선택하신 상품의 현재 재고가 {-1 * (stock - p_stock)}개 \r\n부족하여 구매할 수 없습니다.";
                }

            }
            else
            {
                errorLabel.ForeColor = Color.DarkRed;
                errorLabel.Text = "선택하신 상품이 없습니다.";
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            DataGridViewRow data = this.dataGridView1.CurrentRow;
            if(data != null)
            {
                this.cartTableAdapter1.Fill(dataSet1.CART);
                DataTable cartTable = dataSet1.Tables["CART"];
                string[] key = { this.email, data.Cells[7].Value.ToString() };
                DataRow target = cartTable.Rows.Find(key);
                target.Delete();
                this.cartTableAdapter1.Update(dataSet1.CART);
                errorLabel.ForeColor = Color.MediumSeaGreen;
                errorLabel.Text = "선택한 상품이 장바구니에서 제거되었습니다.";
                this.cART_VIEW1TableAdapter.Fill(dataSet1.CART_VIEW1);
                this.updateTableView();

            }
            else
            {
                errorLabel.ForeColor = Color.DarkRed;
                errorLabel.Text = "선택한 상품이 없습니다.";
            }
        }

        private void allPurchase_Click(object sender, EventArgs e)
        {
            List<string> checkStock = new List<string>();

            DataGridViewRowCollection allData = this.dataGridView1.Rows;
            foreach(DataGridViewRow data in allData)
            {
                int p_stock = int.Parse(data.Cells[1].Value.ToString());
                int stock = int.Parse(data.Cells[3].Value.ToString());
                if((stock - p_stock) < 0)
                {
                    checkStock.Add(data.Cells[0].Value.ToString());
                }
            }

            if(checkStock.Count == 0)
            {
                purchaseTableAdapter1.Fill(dataSet1.PURCHASE);
                DataTable purchaseTable = dataSet1.Tables["PURCHASE"];
                foreach (DataGridViewRow data in allData)
                {
                    DataRow newData = purchaseTable.NewRow();
                    DateTime now = DateTime.Now;
                    newData["C_EMAIL"] = this.email;
                    newData["P_ID"] = data.Cells[7].Value.ToString();
                    newData["PURCHASE_DATE"] = now;
                    newData["PRICE"] = data.Cells[2].Value.ToString();
                    newData["STOCK"] = data.Cells[1].Value.ToString();
                    newData["ALLOW"] = "구매요청진행중";
                    newData["ID"] = now.ToString("yyyy-MM-dd HH:mm:ss") + this.email + data.Cells[7].Value.ToString();
                    purchaseTable.Rows.Add(newData);
                }

                cartTableAdapter1.Fill(dataSet1.CART);
                DataTable cartTable = dataSet1.Tables["CART"];
                DataRow[] cart = cartTable.Select($"C_EMAIL = '{this.email}'");
                foreach(DataRow row in cart)
                {
                    row.Delete();
                }

                this.purchaseTableAdapter1.Update(dataSet1.PURCHASE);
                this.cartTableAdapter1.Update(dataSet1.CART);
                this.cART_VIEW1TableAdapter.Fill(dataSet1.CART_VIEW1);
                errorLabel.ForeColor = Color.MediumSeaGreen;
                errorLabel.Text = "전체 상품이 구매요청 처리되었습니다.";


            }
            else
            {
                string lackStock = checkStock[0];
                for(int i =1; i<checkStock.Count; i++)
                {
                    
                    if(i%5 == 0)
                    {
                        lackStock += "와(과) \r\n" + checkStock[i];
                    }
                    else
                    {
                        lackStock += "와(과) " + checkStock[i];
                    }
                }
                lackStock += "이(가) \r\n재고가 부족합니다.";
                errorLabel.Text = lackStock;
                errorLabel.ForeColor = Color.DarkRed;
            }

        }
    }
}

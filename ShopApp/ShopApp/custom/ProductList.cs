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
    public partial class ProductList : Form
    {
        DataTable cartTable;
        DataTable productTable;
        DataTable purchaseTable;
        string email;
        string p_id;
        string stock;
        public ProductList(string email)
        {
            InitializeComponent();
            this.email = email;
            errorText.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet11.PRODUCT' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.pRODUCTTableAdapter.Fill(this.dataSet11.PRODUCT);
            DataGridViewRow data = dataGridView1.CurrentRow;
            if (data != null)
            {
                this.p_id = data.Cells[0].Value.ToString();
                productName.Text = data.Cells[1].Value.ToString();
                productPrice.Text = "가격 : " + data.Cells[2].Value.ToString();
                productStock.Text = "재고 : " + data.Cells[3].Value.ToString();
                productCategory.Text = data.Cells[4].Value.ToString();
                productSeller.Text = "판매자 : " + data.Cells[5].Value.ToString();
                string[] combo = new string[int.Parse(data.Cells[3].Value.ToString().Equals("") ? "1" : data.Cells[3].Value.ToString())];
                for (int i = 0; i < combo.Length; i++)
                {
                    combo[i] = (i + 1).ToString();
                }
                selectStock.Items.Clear();
                selectStock.Items.AddRange(combo);

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productName_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow data = dataGridView1.CurrentRow;
            if (data != null)
            {
                this.p_id = data.Cells[0].Value.ToString();
                productName.Text = data.Cells[1].Value.ToString();
                productPrice.Text = "가격 : "+data.Cells[2].Value.ToString();
                productStock.Text = "재고 : "+data.Cells[3].Value.ToString();
                productCategory.Text = data.Cells[4].Value.ToString();
                productSeller.Text = "판매자 : "+data.Cells[5].Value.ToString();
                string[] combo = new string[int.Parse(data.Cells[3].Value.ToString().Equals("") ? "1" : data.Cells[3].Value.ToString())];
                for (int i =0; i < combo.Length; i++)
                {
                    combo[i] = (i+1).ToString();
                }
                selectStock.Items.Clear();
                selectStock.Items.AddRange(combo);

            }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
        }

        private void productCard_Enter(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.stock = selectStock.Text;
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            cartTableAdapter1.Fill(dataSet11.CART);
            cartTable = dataSet11.Tables["CART"];

            DataRow[] data = cartTable.Select($"C_EMAIL = '{this.email}' AND P_ID = '{this.p_id}'");
            if(data.Length > 0)
            {
                DataRow update = data[0];
                update["STOCK"] = int.Parse(update["STOCK"].ToString()) + int.Parse(this.stock);
            }
            else {
                MessageBox.Show("asd");
                DataRow newData = cartTable.NewRow();
                newData["C_EMAIL"] = this.email;
                newData["P_ID"] = this.p_id;
                newData["STOCK"] = this.stock;
                cartTable.Rows.Add(newData);
            }

            cartTableAdapter1.Update(dataSet11.CART);
            errorText.ForeColor = Color.MediumSeaGreen;
            errorText.Text = "장바구니에 담겼습니다.";

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = $"NAME LIKE '%{this.searchTextBox.Texts}%'";
            DataGridViewRow data = dataGridView1.CurrentRow;
            if (data != null)
            {
                this.p_id = data.Cells[0].Value.ToString();
                productName.Text = data.Cells[1].Value.ToString();
                productPrice.Text = "가격 : " + data.Cells[2].Value.ToString();
                productStock.Text = "재고 : " + data.Cells[3].Value.ToString();
                productCategory.Text = data.Cells[4].Value.ToString();
                productSeller.Text = "판매자 : " + data.Cells[5].Value.ToString();
                string[] combo = new string[int.Parse(data.Cells[3].Value.ToString().Equals("") ? "1" : data.Cells[3].Value.ToString())];
                for (int i = 0; i < combo.Length; i++)
                {
                    combo[i] = (i + 1).ToString();
                }
                selectStock.Items.Clear();
                selectStock.Items.AddRange(combo);

            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;

            purchaseTableAdapter1.Fill(dataSet11.PURCHASE);
            purchaseTable = dataSet11.Tables["PURCHASE"];

            DataRow newData = purchaseTable.NewRow();
            newData["C_EMAIL"] = this.email;
            newData["P_ID"] = this.p_id;
            newData["ID"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")+this.email+this.p_id;
            newData["PURCHASE_DATE"] = dt;
            newData["STOCK"] = int.Parse(selectStock.Text);
            newData["PRICE"] = int.Parse(productPrice.Text.Replace("가격 : ", "")) * int.Parse(selectStock.Text);
            newData["ALLOW"] = "구매요청진행중";

            purchaseTable.Rows.Add(newData);

            purchaseTableAdapter1.Update(dataSet11.PURCHASE);
            errorText.ForeColor = Color.MediumSeaGreen;
            errorText.Text = productName.Text + "이(가) 성공적으로 구매요청되었습니다.";
            
            

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

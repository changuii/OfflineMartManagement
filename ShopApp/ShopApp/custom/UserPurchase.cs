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
    public partial class UserPurchase : Form
    {
        string email;
        string[] combo = { "구매요청진행중", "구매완료", "환불요청진행중", "환불완료" };

        public UserPurchase(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void UserPurchase_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.PURCHASE_VIEW1' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.pURCHASE_VIEW1TableAdapter.Fill(this.dataSet1.PURCHASE_VIEW1);
            this.pURCHASEVIEW1BindingSource.Filter = "C_EMAIL = '" + this.email + "'";

            errorTextBox.Text = "";
            DataGridViewRow data = this.dataGridView1.CurrentRow;

            if (data != null)
            {
                this.timeLabel.Text = data.Cells[2].Value.ToString();
                this.p_priceLabel.Text = data.Cells[3].Value.ToString();
                this.p_stockLabel.Text = data.Cells[4].Value.ToString();
                this.allowLabel.Text = data.Cells[5].Value.ToString();
                this.nameLabel.Text = data.Cells[6].Value.ToString();
                this.priceLabel.Text = data.Cells[7].Value.ToString();
                this.stockLabel.Text = data.Cells[8].Value.ToString();
                this.categoryLabel.Text = data.Cells[9].Value.ToString();
                this.sellerLabel.Text = data.Cells[10].Value.ToString();


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow data = this.dataGridView1.CurrentRow;

            if(data != null)
            {
                this.timeLabel.Text = data.Cells[2].Value.ToString();
                this.p_priceLabel.Text = data.Cells[3].Value.ToString();
                this.p_stockLabel.Text = data.Cells[4].Value.ToString();
                this.allowLabel.Text = data.Cells[5].Value.ToString();
                this.nameLabel.Text = data.Cells[6].Value.ToString();
                this.priceLabel.Text = data.Cells[7].Value.ToString();
                this.stockLabel.Text = data.Cells[8].Value.ToString();
                this.categoryLabel.Text = data.Cells[9].Value.ToString();
                this.sellerLabel.Text = data.Cells[10].Value.ToString();


            }

        }

        private void updateInfo()
        {
            DataGridViewRow data = this.dataGridView1.CurrentRow;

            if (data != null)
            {
                this.timeLabel.Text = data.Cells[2].Value.ToString();
                this.p_priceLabel.Text = data.Cells[3].Value.ToString();
                this.p_stockLabel.Text = data.Cells[4].Value.ToString();
                this.allowLabel.Text = data.Cells[5].Value.ToString();
                this.nameLabel.Text = data.Cells[6].Value.ToString();
                this.priceLabel.Text = data.Cells[7].Value.ToString();
                this.stockLabel.Text = data.Cells[8].Value.ToString();
                this.categoryLabel.Text = data.Cells[9].Value.ToString();
                this.sellerLabel.Text = data.Cells[10].Value.ToString();


            }
        }

        private void allowFilterButton1_Click(object sender, EventArgs e)
        {
            this.pURCHASEVIEW1BindingSource.Filter = $"C_EMAIL = '{this.email}' AND ALLOW = '{this.combo[1]}'";
            this.updateInfo();
        }

        private void allowFilterButton4_Click(object sender, EventArgs e)
        {
            this.pURCHASEVIEW1BindingSource.Filter = $"C_EMAIL = '{this.email}'";
            this.updateInfo();
        }

        private void allowFilterButton2_Click(object sender, EventArgs e)
        {
            this.pURCHASEVIEW1BindingSource.Filter = $"C_EMAIL = '{this.email}' AND ALLOW = '{this.combo[2]}'";
            this.updateInfo();
        }

        private void allowFilterButton3_Click(object sender, EventArgs e)
        {
            this.pURCHASEVIEW1BindingSource.Filter = $"C_EMAIL = '{this.email}' AND ALLOW = '{this.combo[3]}'";
            this.updateInfo();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            this.pURCHASEVIEW1BindingSource.Filter = $"C_EMAIL = '{this.email}' AND ALLOW = '{this.combo[0]}'";
            this.updateInfo();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            this.purchaseTableAdapter1.Fill(dataSet1.PURCHASE);
            DataTable purchaseTable = dataSet1.Tables["PURCHASE"];

            DataGridViewRow row = dataGridView1.CurrentRow;
            string allow = row.Cells[5].Value.ToString();
            if (allow.Equals(combo[1])) 
            {
                DataRow data = purchaseTable.Rows.Find(row.Cells[11].Value.ToString());
                data["ALLOW"] = combo[2];
                purchaseTableAdapter1.Update(dataSet1.PURCHASE);
                errorTextBox.ForeColor = Color.MediumSeaGreen;
                errorTextBox.Text = "환불 요청이 완료되었습니다.";
                this.pURCHASE_VIEW1TableAdapter.Fill(dataSet1.PURCHASE_VIEW1);
                
            }
            else if(allow.Equals(combo[3]))
            {
                errorTextBox.ForeColor = Color.DarkRed;
                errorTextBox.Text = "이미 환불완료된 제품입니다.";
            }else if (allow.Equals(combo[0]))
            {
                errorTextBox.ForeColor = Color.DarkRed;
                errorTextBox.Text = "구매 요청 진행중인 제품입니다.";
            }else if (allow.Equals(combo[2]))
            {
                errorTextBox.ForeColor = Color.DarkRed;
                errorTextBox.Text = "이미 환불 진행중인 제품입니다.";
            }
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            this.purchaseTableAdapter1.Fill(dataSet1.PURCHASE);
            DataTable purchaseTable = dataSet1.Tables["PURCHASE"];

            DataGridViewRow row = dataGridView1.CurrentRow;
            string allow = row.Cells[5].Value.ToString();
            if (allow.Equals(combo[2]))
            {
                DataRow data = purchaseTable.Rows.Find(row.Cells[11].Value.ToString());
                data["ALLOW"] = combo[1];
                purchaseTableAdapter1.Update(dataSet1.PURCHASE);
                errorTextBox.ForeColor = Color.MediumSeaGreen;
                errorTextBox.Text = "환불 요청 취소되었습니다.";
                this.pURCHASE_VIEW1TableAdapter.Fill(dataSet1.PURCHASE_VIEW1);

            }
            else if (allow.Equals(combo[3]))
            {
                errorTextBox.ForeColor = Color.DarkRed;
                errorTextBox.Text = "이미 환불완료된 제품입니다.";
            }
            else if (allow.Equals(combo[0]))
            {
                errorTextBox.ForeColor = Color.DarkRed;
                errorTextBox.Text = "구매 요청 진행중인 제품입니다.";
            }
            else if (allow.Equals(combo[1]))
            {
                errorTextBox.ForeColor = Color.DarkRed;
                errorTextBox.Text = "구매가 완료된 제품입니다.";
            }
        }
    }
}

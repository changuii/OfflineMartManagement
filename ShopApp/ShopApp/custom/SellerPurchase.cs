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
    public partial class SellerPurchase : Form
    {
        DataTable purchaseViewTable;
        DataTable purchaseTable;
        public SellerPurchase()
        {
            InitializeComponent();
        }

        private void SellerPurchase_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.PURCHASE_VIEW1' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.pURCHASE_VIEW1TableAdapter.Fill(this.dataSet1.PURCHASE_VIEW1);

            DataGridViewRow dr = dataGridView1.CurrentRow;

            if (dr != null)
            {
                nameLabel.Text = dr.Cells[6].Value.ToString();
                p_idLabel.Text = "제품코드 : " + dr.Cells[1].Value.ToString();
                priceLabel.Text = "가격 : " + dr.Cells[7].Value.ToString();
                stockLabel.Text = "재고 : " + dr.Cells[8].Value.ToString();
                categoryLabel.Text = "분류 : " + dr.Cells[9].Value.ToString();
                sellerLabel.Text = "판매자 : " + dr.Cells[10].Value.ToString();
                timeLabel.Text = "구매시간 : " + dr.Cells[2].Value.ToString();
                c_emailLabel.Text = "구매자 : " + dr.Cells[0].Value.ToString();
                c_stockLabel.Text = "구매수량 : " + dr.Cells[4].Value.ToString();
                c_priceLabel.Text = "전체가격 : " + dr.Cells[3].Value.ToString();
                allowLabel.Text = "허용여부 : " + dr.Cells[5].Value.ToString();
            }
            string[] combo = { "구매요청진행중", "구매완료", "환불요청진행중", "환불완료" };
            comboBox1.Items.AddRange(combo);
            comboBox1.Text = combo[0];
            comboBox2.Items.AddRange(combo);
            comboBox2.Text = combo[0];

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.CurrentRow;

            if (dr != null)
            {
                nameLabel.Text = dr.Cells[6].Value.ToString();
                p_idLabel.Text = "제품코드 : " + dr.Cells[1].Value.ToString();
                priceLabel.Text = "가격 : " + dr.Cells[7].Value.ToString();
                stockLabel.Text = "재고 : " + dr.Cells[8].Value.ToString();
                categoryLabel.Text = "분류 : " + dr.Cells[9].Value.ToString();
                sellerLabel.Text = "판매자 : "+dr.Cells[10].Value.ToString();
                timeLabel.Text = "구매시간 : "+dr.Cells[2].Value.ToString();
                c_emailLabel.Text = "구매자 : "+dr.Cells[0].Value.ToString();
                c_stockLabel.Text = "구매수량 : "+dr.Cells[4].Value.ToString();
                c_priceLabel.Text = "전체가격 : "+dr.Cells[3].Value.ToString();
                allowLabel.Text = "허용여부 : "+dr.Cells[5].Value.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            pURCHASE_VIEW1TableAdapter.Fill(dataSet1.PURCHASE_VIEW1);
            purchaseViewTable = dataSet1.Tables["PURCHASE_VIEW1"];

            pURCHASEVIEW1BindingSource.Filter = $"ALLOW = '{this.comboBox1.Text}'";

        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.CurrentRow;
            string purchaseid = dr.Cells[11].Value.ToString();
            purchaseTableAdapter1.Fill(dataSet1.PURCHASE);
            this.purchaseTable = dataSet1.Tables["PURCHASE"];

            DataRow row = purchaseTable.Rows.Find(purchaseid);
            if(row != null)
            {
                row["ALLOW"] = comboBox2.Text;
                purchaseTableAdapter1.Update(dataSet1.PURCHASE);
                this.pURCHASE_VIEW1TableAdapter.Fill(dataSet1.PURCHASE_VIEW1);
            }
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

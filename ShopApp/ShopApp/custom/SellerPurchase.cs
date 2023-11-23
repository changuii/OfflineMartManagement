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
        string s_email;
        string[] combo = { "구매요청진행중", "구매완료", "환불요청진행중", "환불완료", "전체보기" };
        public SellerPurchase(string s_email)
        {
            InitializeComponent();
            this.s_email = s_email;
        }

        private void SellerPurchase_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.PURCHASE_VIEW1' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.pURCHASE_VIEW1TableAdapter.Fill(this.dataSet1.PURCHASE_VIEW1);
            errorText.Text = "";
            this.pURCHASEVIEW1BindingSource.Filter = $"S_EMAIL = '{this.s_email}'";
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
                if (dr.Cells[5].Value.ToString().Equals(combo[0]))
                {
                    comboBox2.Text = "";
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add(combo[1]);

                }
                else if (dr.Cells[5].Value.ToString().Equals(combo[2]))
                {
                    comboBox2.Text = "";
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add(combo[3]);

                }
                else
                {
                    comboBox2.Text = "";
                    comboBox2.Items.Clear();
                }
            }
            comboBox1.Items.AddRange(combo);
            comboBox1.Text = combo[0];


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

                if (dr.Cells[5].Value.ToString().Equals(combo[0]))
                {
                    comboBox2.Text = combo[1];
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add(combo[1]);

                }else if (dr.Cells[5].Value.ToString().Equals(combo[2]))
                {
                    comboBox2.Text = combo[3];
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add(combo[3]);

                }
                else
                {
                    comboBox2.Text = "";
                    comboBox2.Items.Clear();
                }

            }
        }

        private void cellClick()
        {
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

                if (dr.Cells[5].Value.ToString().Equals(combo[0]))
                {
                    comboBox2.Text = combo[1];
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add(combo[1]);

                }
                else if (dr.Cells[5].Value.ToString().Equals(combo[2]))
                {
                    comboBox2.Text = combo[3];
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add(combo[3]);

                }
                else
                {
                    comboBox2.Text = "";
                    comboBox2.Items.Clear();
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            if (!comboBox1.Text.Equals(combo[4]))
            {
                pURCHASE_VIEW1TableAdapter.Fill(dataSet1.PURCHASE_VIEW1);
                purchaseViewTable = dataSet1.Tables["PURCHASE_VIEW1"];
                errorText.ForeColor = Color.MediumSeaGreen;
                errorText.Text = $"성공적으로 {comboBox1.Text}로 필터링되었습니다.";
                pURCHASEVIEW1BindingSource.Filter = $"ALLOW = '{this.comboBox1.Text}' AND S_EMAIL = '{this.s_email}' ";
                cellClick();
            }
            else
            {
                pURCHASE_VIEW1TableAdapter.Fill(dataSet1.PURCHASE_VIEW1);
                purchaseViewTable = dataSet1.Tables["PURCHASE_VIEW1"];
                errorText.ForeColor = Color.MediumSeaGreen;
                errorText.Text = $"성공적으로 {comboBox1.Text}로 필터링되었습니다.";
                pURCHASEVIEW1BindingSource.Filter = $"S_EMAIL = '{this.s_email}'";
                this.cellClick();
            }
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.CurrentRow;
            string purchaseid = dr.Cells[11].Value.ToString();
            purchaseTableAdapter1.Fill(dataSet1.PURCHASE);
            this.purchaseTable = dataSet1.Tables["PURCHASE"];

            productTableAdapter1.Fill(dataSet1.PRODUCT);
            DataTable productTable = dataSet1.Tables["PRODUCT"];

            DataRow row = purchaseTable.Rows.Find(purchaseid);
            if (comboBox2.Text != null && comboBox2.Text != "")
            {
                if (row != null && comboBox2.Text.Equals(combo[1]))
                {
                    
                    DataRow data = productTable.Rows.Find(int.Parse(row["P_ID"].ToString()));
                    int stock = int.Parse(data["STOCK"].ToString());
                    stock -= int.Parse(dr.Cells[4].Value.ToString());
                    if (stock >= 0)
                    {
                        data["STOCK"] = stock;
                        row["ALLOW"] = comboBox2.Text;
                        this.productTableAdapter1.Update(dataSet1.PRODUCT);
                        purchaseTableAdapter1.Update(dataSet1.PURCHASE);
                        this.pURCHASE_VIEW1TableAdapter.Fill(dataSet1.PURCHASE_VIEW1);
                        errorText.ForeColor = Color.MediumSeaGreen;
                        errorText.Text = $"선택하신 요청이 {comboBox2.Text}처리 되었습니다.";
                    }
                    else
                    {
                        errorText.ForeColor = Color.DarkRed;
                        errorText.Text = "재고가 부족합니다. 재고가 추가되면 다시 시도하세요";
                    }

                } else if (row != null && comboBox2.Text.Equals(combo[3])){
                    DataRow data = productTable.Rows.Find(int.Parse(row["P_ID"].ToString()));
                    int stock = int.Parse(data["STOCK"].ToString());
                    stock += int.Parse(dr.Cells[4].Value.ToString());
                    data["STOCK"] = stock;
                    row["ALLOW"] = comboBox2.Text;
                    this.productTableAdapter1.Update(dataSet1.PRODUCT);
                    purchaseTableAdapter1.Update(dataSet1.PURCHASE);
                    this.pURCHASE_VIEW1TableAdapter.Fill(dataSet1.PURCHASE_VIEW1);
                    errorText.ForeColor = Color.MediumSeaGreen;
                    errorText.Text = $"선택하신 요청이 {comboBox2.Text}처리 되었습니다.";
                }

                
            }
            else
            {
                errorText.ForeColor = Color.DarkRed;
                errorText.Text = "환불/구매 완료되었거나 값이 선택되지 않았습니다.";
            }
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

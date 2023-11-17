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
    public partial class AdminProductRegister : Form
    {
        DataTable productTable;
        public AdminProductRegister()
        {
            InitializeComponent();
        }

        private void AdminProductRegister_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.SELLER' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.sELLERTableAdapter.Fill(this.dataSet1.SELLER);
            // TODO: 이 코드는 데이터를 'dataSet1.PRODUCT' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.pRODUCTTableAdapter.Fill(this.dataSet1.PRODUCT);
            errorText.Text = "";
            DataGridViewRow dc = dataGridView2.CurrentRow;

            if (dc != null)
            {
                sellerTextBox.Texts = dc.Cells[0].Value.ToString();
            }
            dc = dataGridView1.CurrentRow;

            if (dc != null)
            {
                p_idTextBox.Texts = dc.Cells[0].Value.ToString();
                nameTextBox.Texts = dc.Cells[1].Value.ToString();
                priceTextBox.Texts = dc.Cells[2].Value.ToString();
                categoryTextBox.Texts = dc.Cells[4].Value.ToString();
                stockTextBox.Texts = dc.Cells[3].Value.ToString();
            }
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             DataGridViewRow dc = dataGridView2.CurrentRow;

            if(dc != null)
            {
                sellerTextBox.Texts = dc.Cells[0].Value.ToString();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dc = dataGridView1.CurrentRow;

            if (dc != null)
            {
                p_idTextBox.Texts = dc.Cells[0].Value.ToString();
                nameTextBox.Texts = dc.Cells[1].Value.ToString();
                priceTextBox.Texts = dc.Cells[2].Value.ToString();
                categoryTextBox.Texts = dc.Cells[4].Value.ToString();
                stockTextBox.Texts = dc.Cells[3].Value.ToString();
            }
        }

        private void registerTextBox_Click(object sender, EventArgs e)
        {
            pRODUCTTableAdapter.Fill(dataSet1.PRODUCT);
            productTable = dataSet1.Tables["PRODUCT"];

            DataRow newData = productTable.Rows.Find(p_idTextBox.Texts);

            try
            {
                if (newData != null)
                {
                    newData["NAME"] = nameTextBox.Texts;
                    string price = newData["PRICE"].ToString();
                    newData["PRICE"] = priceTextBox.Texts;
                    newData["STOCK"] = stockTextBox.Texts;
                    newData["CATEGORY"] = categoryTextBox.Texts;
                    newData["S_EMAIL"] = sellerTextBox.Texts;
                    pRODUCTTableAdapter.Update(dataSet1.PRODUCT);
                    errorText.Text = "정상적으로 수정되었습니다.";
                    errorText.ForeColor = Color.MediumSeaGreen;
                    //공지
                    if (!price.Equals(priceTextBox.Texts))
                    {
                        notificationTableAdapter1.Fill(dataSet1.NOTIFICATION);
                        DataTable notificationTable = dataSet1.Tables["NOTIFICATION"];
                        DataRow notification = notificationTable.NewRow();
                        notification["CREATION_TIME"] = DateTime.Now;
                        notification["TITLE"] = $"[상품가격변경] {nameTextBox.Texts}의 가격이 변경되었습니다. ";
                        notification["CONTENT"] = $"{nameTextBox.Texts}의 가격이 {price}원에서 {priceTextBox.Texts}원으로 변경되었습니다. 확인하시고 구매하시길 바랍니다.";
                        notificationTable.Rows.Add(notification);
                        notificationTableAdapter1.Update(dataSet1.NOTIFICATION);
                    }

                }
                else
                {
                    newData = productTable.NewRow();
                    newData["P_ID"] = p_idTextBox.Texts;
                    newData["NAME"] = nameTextBox.Texts;
                    newData["PRICE"] = priceTextBox.Texts;
                    newData["STOCK"] = stockTextBox.Texts;
                    newData["CATEGORY"] = categoryTextBox.Texts;
                    newData["S_EMAIL"] = sellerTextBox.Texts;
                    productTable.Rows.Add(newData);
                    pRODUCTTableAdapter.Update(dataSet1.PRODUCT);
                    errorText.Text = "정상적으로 등록되었습니다.";
                    errorText.ForeColor = Color.MediumSeaGreen;

                    //공지
                    notificationTableAdapter1.Fill(dataSet1.NOTIFICATION);
                    DataTable notificationTable = dataSet1.Tables["NOTIFICATION"];
                    DataRow notification = notificationTable.NewRow();
                    notification["CREATION_TIME"] = DateTime.Now;
                    notification["TITLE"] = $"[신규상품입고] {nameTextBox.Texts}가 새롭게 입고되었습니다. ";
                    notification["CONTENT"] = $"새로운 상품 {nameTextBox.Texts}가 저희 가게에 새롭게 입고되었습니다. 많은 관심 부탁드립니다.";
                    notificationTable.Rows.Add(notification);
                    notificationTableAdapter1.Update(dataSet1.NOTIFICATION);
                }
            }catch(Exception ex)
            {
                errorText.ForeColor = Color.DarkRed;
                errorText.Text = ex.Message;
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            errorText.Text = "정상적으로 비워졌습니다.";
            errorText.ForeColor = Color.MediumSeaGreen;
            p_idTextBox.Texts = "";
            nameTextBox.Texts = "";
            priceTextBox.Texts = "";
            stockTextBox.Texts = "";
            categoryTextBox.Texts = "";
            sellerTextBox.Texts = "";

        }
    }
}

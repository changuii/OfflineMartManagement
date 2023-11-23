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
    public partial class AdminProductList : Form
    {
        public AdminProductList()
        {
            InitializeComponent();
        }

        private void AdminProductList_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet11.PURCHASE_VIEW_PRODUCT1' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.pURCHASE_VIEW_PRODUCT1TableAdapter.Fill(this.dataSet11.PURCHASE_VIEW_PRODUCT1);
            this.selectTableView();
            this.errorText.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.selectTableView();
        }

        public void selectTableView()
        {
            DataGridViewRow data = this.dataGridView1.CurrentRow;

            if(data != null)
            {
                this.nameLabel.Text = data.Cells[0].Value.ToString();
                this.purchaseStock.Text = data.Cells[1].Value.ToString();
                this.refundStock.Text = data.Cells[2].Value.ToString();
                this.purchaseRequest.Text = data.Cells[3].Value.ToString();
                this.refundRequest.Text = data.Cells[4].Value.ToString();
                this.stock.Text = data.Cells[5].Value.ToString();
                this.refundPStock.Text = data.Cells[6].Value.ToString();
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {

            dataGridView1.Sort(dataGridView1.Columns[1], System.ComponentModel.ListSortDirection.Descending);
            this.selectTableView();
            errorText.ForeColor = Color.MediumSeaGreen;
            errorText.Text = "구매금액 순서로 정렬되었습니다.";
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[2], System.ComponentModel.ListSortDirection.Descending);
            this.selectTableView();
            errorText.ForeColor = Color.MediumSeaGreen;
            errorText.Text = "환불금액 순서로 정렬되었습니다.";
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[5], System.ComponentModel.ListSortDirection.Descending);
            this.selectTableView();
            errorText.ForeColor = Color.MediumSeaGreen;
            errorText.Text = "현재재고 순서로 정렬되었습니다.";
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[6], System.ComponentModel.ListSortDirection.Descending);
            this.selectTableView();
            errorText.ForeColor = Color.MediumSeaGreen;
            errorText.Text = "반품수량 순서로 정렬되었습니다.";
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            this.selectTableView();
        }
    }
}

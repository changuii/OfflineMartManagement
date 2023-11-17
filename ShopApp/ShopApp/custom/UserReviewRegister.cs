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
    public partial class UserReviewRegister : Form
    {
        string email;
        public UserReviewRegister(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void UserReviewRegister_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.PURCHASE_VIEW1' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.pURCHASE_VIEW1TableAdapter.Fill(this.dataSet1.PURCHASE_VIEW1);
            this.reviewTableAdapter1.Fill(this.dataSet1.REVIEW);
            errorLabel.Text = "";

            var filteredRows = dataSet1.PURCHASE_VIEW1.AsEnumerable()
                .Where(row => row.Field<string>("C_EMAIL") == this.email && row.Field<string>("ALLOW") == "구매완료")
                .ToArray();

            DataTable filteredTable = dataSet1.PURCHASE_VIEW1.Clone();
            foreach (var row in filteredRows)
            {
                filteredTable.ImportRow(row);
            }

            this.pURCHASEVIEW1BindingSource.DataSource = filteredTable;



            this.c_emailLabel.Text = this.email;

            DataGridViewRow data1 = this.dataGridView1.CurrentRow;
            if (data1 != null)
            {
                string id = data1.Cells[11].Value.ToString();
                this.nameLabel.Text = data1.Cells[2].Value.ToString();
                this.c_emailLabel.Text = this.email;

                reviewTableAdapter1.Fill(this.dataSet1.REVIEW);
                DataTable reviewTable = this.dataSet1.Tables["REVIEW"];

                DataRow[] review = reviewTable.Select($"ID = '{id}'");
                if (review.Length > 0)
                {
                    titleTextBox.Text = review[0]["TITLE"].ToString();
                    contentTextBox.Text = review[0]["CONTENT"].ToString();
                    timeLabel.Text = review[0]["CREATION_TIME"].ToString();
                }


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void c_emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow data = this.dataGridView1.CurrentRow;

            if(data != null)
            {
                string id = data.Cells[11].Value.ToString();
                this.nameLabel.Text = data.Cells[2].Value.ToString();
                this.c_emailLabel.Text = this.email;

                reviewTableAdapter1.Fill(this.dataSet1.REVIEW);
                DataTable reviewTable = this.dataSet1.Tables["REVIEW"];

                DataRow[] review = reviewTable.Select($"ID = '{id}'");
                if(review.Length > 0)
                {
                    titleTextBox.Text = review[0]["TITLE"].ToString();
                    contentTextBox.Text = review[0]["CONTENT"].ToString();
                    timeLabel.Text = "작성시간 : "+review[0]["CREATION_TIME"].ToString();
                }
                else
                {
                    titleTextBox.Text = "";
                    contentTextBox.Text = "";
                    timeLabel.Text = "작성시간";
                }


            }
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            DataGridViewRow data = this.dataGridView1.CurrentRow;
            reviewTableAdapter1.Fill(this.dataSet1.REVIEW);
            DataTable reviewTable = this.dataSet1.Tables["REVIEW"];

            if (data != null)
            {
                DataRow[] review = reviewTable.Select($"ID = '{data.Cells[11].Value.ToString()}'");
                if(review.Length > 0)
                {
                    DataRow row = review[0];
                    row["TITLE"] = titleTextBox.Text;
                    row["CONTENT"] = contentTextBox.Text;
                    errorLabel.Text = "성공적으로 리뷰가 수정되었습니다.";
                    errorLabel.ForeColor = Color.MediumSeaGreen;
                    this.pURCHASE_VIEW1TableAdapter.Fill(dataSet1.PURCHASE_VIEW1);
                }
                else
                {
                    DataRow row = reviewTable.NewRow();
                    row["CREATION_TIME"] = DateTime.Now;
                    row["C_EMAIL"] = c_emailLabel.Text;
                    row["p_id"] = data.Cells[1].Value.ToString();
                    row["TITLE"] = titleTextBox.Text;
                    row["CONTENT"] = contentTextBox.Text;
                    row["ID"] = data.Cells[11].Value.ToString();
                    reviewTable.Rows.Add(row);
                    errorLabel.Text = "성공적으로 리뷰가 등록되었습니다.";
                    errorLabel.ForeColor = Color.MediumSeaGreen;
                    this.pURCHASE_VIEW1TableAdapter.Fill(dataSet1.PURCHASE_VIEW1);

                }
                this.reviewTableAdapter1.Update(dataSet1.REVIEW);
            }
        }
    }
}

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
    public partial class UserReview : Form
    {
        public UserReview()
        {
            InitializeComponent();
        }

        private void UserReview_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.REVIEW_VIEW1' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.rEVIEW_VIEW1TableAdapter.Fill(this.dataSet1.REVIEW_VIEW1);
            errorLabel.Text = "";
            DataGridViewRow data = this.dataGridView1.CurrentRow;
            
            if (data != null)
            {
                this.nameLabel.Text = data.Cells[0].Value.ToString();
                this.c_emailLabel.Text = data.Cells[1].Value.ToString();
                this.titleLabel.Text = data.Cells[2].Value.ToString();
                this.contentLabel.Text = data.Cells[3].Value.ToString();
                this.timeLabel.Text = data.Cells[4].Value.ToString();
            }
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            if (this.searchTextBox.Text != "")
            {
                this.rEVIEWVIEW1BindingSource.Filter = $"TITLE LIKE '%{this.searchTextBox.Text}%'";
                errorLabel.ForeColor = Color.MediumSeaGreen;
                errorLabel.Text = this.searchTextBox.Text + ", 검색이 완료되었습니다.";
                DataGridViewRow data = this.dataGridView1.CurrentRow;

                if (data != null)
                {
                    this.nameLabel.Text = data.Cells[0].Value.ToString();
                    this.c_emailLabel.Text = data.Cells[1].Value.ToString();
                    this.titleLabel.Text = data.Cells[2].Value.ToString();
                    this.contentLabel.Text = data.Cells[3].Value.ToString();
                    this.timeLabel.Text = data.Cells[4].Value.ToString();
                }
            }
            else
            {
                this.rEVIEW_VIEW1TableAdapter.Fill(dataSet1.REVIEW_VIEW1);
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow data = this.dataGridView1.CurrentRow;

            if(data != null)
            {
                this.nameLabel.Text = data.Cells[0].Value.ToString();
                this.c_emailLabel.Text = data.Cells[1].Value.ToString();
                this.titleLabel.Text = data.Cells[2].Value.ToString();
                this.contentLabel.Text = data.Cells[3].Value.ToString();
                this.timeLabel.Text = data.Cells[4].Value.ToString();
            }
        }
    }
}

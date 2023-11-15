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
    public partial class UserNotification : Form
    {
        public UserNotification()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UserNotification_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.NOTIFICATION' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.nOTIFICATIONTableAdapter.Fill(this.dataSet1.NOTIFICATION);
            errorLabel.Text = "";
            DataGridViewRow data = this.dataGridView1.CurrentRow;

            if (data != null)
            {
                this.timeLabel.Text = data.Cells[0].Value.ToString();
                this.titleTextBox.Text = data.Cells[1].Value.ToString();
                this.contentTextBox.Text = data.Cells[2].Value.ToString();
            }
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            if (this.searchTextBox.Text != "")
            {
                this.nOTIFICATIONBindingSource.Filter = $"TITLE LIKE '%{this.searchTextBox.Text}%'";
                errorLabel.ForeColor = Color.MediumSeaGreen;
                errorLabel.Text = this.searchTextBox.Text + ", 검색이 완료되었습니다.";
                DataGridViewRow data = this.dataGridView1.CurrentRow;

                if (data != null)
                {
                    this.timeLabel.Text = data.Cells[0].Value.ToString();
                    this.titleTextBox.Text = data.Cells[1].Value.ToString();
                    this.contentTextBox.Text = data.Cells[2].Value.ToString();
                }
            }
            else
            {
                this.nOTIFICATIONTableAdapter.Fill(dataSet1.NOTIFICATION);
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow data = this.dataGridView1.CurrentRow;

            if(data != null)
            {
                this.timeLabel.Text = data.Cells[0].Value.ToString();
                this.titleTextBox.Text = data.Cells[1].Value.ToString();
                this.contentTextBox.Text = data.Cells[2].Value.ToString();
            }
        }
    }
}

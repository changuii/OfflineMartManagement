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
    public partial class AdminNotification : Form
    {
        DataTable notificationTable;
        public AdminNotification()
        {
            InitializeComponent();
        }

        private void AdminNotification_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.NOTIFICATION' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.nOTIFICATIONTableAdapter.Fill(this.dataSet1.NOTIFICATION);
            errorLabel.Text = "";
            DataGridViewRow data = this.dataGridView1.CurrentRow;

            if (data != null)
            {
                this.timeLabel.Text = "작성시간 : " + data.Cells[0].Value.ToString();
                this.titleTextBox.Text = data.Cells[1].Value.ToString();
                this.contentTextBox.Text = data.Cells[2].Value.ToString();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DataGridViewRow data = this.dataGridView1.CurrentRow;

            if(data != null)
            {
                this.timeLabel.Text = "작성시간 : "+data.Cells[0].Value.ToString();
                this.titleTextBox.Text = data.Cells[1].Value.ToString();
                this.contentTextBox.Text = data.Cells[2].Value.ToString();
            }


        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            this.timeLabel.Text = "작성시간";
            this.titleTextBox.Text = "";
            this.contentTextBox.Text = "";
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            this.nOTIFICATIONTableAdapter.Fill(dataSet1.NOTIFICATION);
            this.notificationTable = dataSet1.Tables["NOTIFICATION"];

            DataRow data;
            try
            {
                if (!this.timeLabel.Text.Equals("작성시간"))
                {
                    data = this.notificationTable.Rows.Find(DateTime.Parse(this.timeLabel.Text.Replace("작성시간 : ", "")));
                    data["TITLE"] = this.titleTextBox.Text;
                    data["CONTENT"] = this.contentTextBox.Text;
                    this.errorLabel.ForeColor = Color.MediumSeaGreen;
                    this.errorLabel.Text = "공지가 성공적으로 수정되었습니다.";
                }
                else
                {
                    data = this.notificationTable.NewRow();
                    data["CREATION_TIME"] = DateTime.Now.ToString();
                    data["TITLE"] = this.titleTextBox.Text;
                    data["CONTENT"] = this.contentTextBox.Text;
                    this.notificationTable.Rows.Add(data);

                    this.errorLabel.ForeColor = Color.MediumSeaGreen;
                    this.errorLabel.Text = "공지가 성공적으로 등록되었습니다.";
                }

                this.nOTIFICATIONTableAdapter.Update(dataSet1.NOTIFICATION);

            }
            catch(Exception ex)
            {
                this.errorLabel.ForeColor = Color.DarkRed;
                this.errorLabel.Text = ex.Message;
            }
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            if (this.titleTextBox.Text != "")
            {
                this.nOTIFICATIONBindingSource.Filter = $"TITLE LIKE '%{this.titleTextBox.Text}%'";

            }
            else
            {
                this.nOTIFICATIONTableAdapter.Fill(dataSet1.NOTIFICATION);
            }
        }

        private void errorLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

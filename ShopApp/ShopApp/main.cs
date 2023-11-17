using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp
{
    public partial class main : Form
    {
        DataTable userTable = new DataTable();
        DataTable sellerTable = new DataTable();
        DataTable adminTable = new DataTable();
        public main()
        {
            InitializeComponent();
            userRadio.Checked = true;
            errorText.Text = "";
        }
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Signup form2 = new Signup();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Texts;
            string pw = passwordTextBox.Texts;


            if (userRadio.Checked)
            {
                string condition = $"C_EMAIL = '{email}' AND PASSWORD = '{pw}'";
                customerTableAdapter1.Fill(dataSet11.CUSTOMER);
                this.userTable = dataSet11.Tables["CUSTOMER"];
                DataRow[] result = userTable.Select(condition);
                if (result.Length > 0)
                {
                    this.Hide();
                    User user = new User(result[0]["C_EMAIL"].ToString(), result[0]["NAME"].ToString());
                    user.Show();
                }
                else
                {
                    errorText.Text = "이메일이 존재하지 않거나 비밀번호가 일치하지 않습니다.";
                    
                }

            } else if (sellerRadio.Checked)
            {
                string condition = $"S_EMAIL = '{email}' AND PASSWORD = '{pw}'";
                sellerTableAdapter1.Fill(dataSet11.SELLER);
                this.sellerTable = dataSet11.Tables["SELLER"];
                DataRow[] result = sellerTable.Select(condition);

                if (result.Length > 0)
                {
                    this.Hide();
                    Seller seller = new Seller();
                    seller.Show();
                }
                else
                {
                    errorText.Text = "이메일이 존재하지 않거나 비밀번호가 일치하지 않습니다.";
                }
            }
            else if (adminRadio.Checked)
            {
                string condition = $"EMAIL = '{email}' AND PASSWORD = '{pw}'";
                adminTableAdapter1.Fill(dataSet11.ADMIN);
                this.adminTable = dataSet11.Tables["ADMIN"];
                DataRow[] result = adminTable.Select(condition);

                if (result.Length > 0)
                {
                    this.Hide();
                    Management management = new Management(this.emailTextBox.Texts);
                    management.Show();
                }
                else
                {
                    errorText.Text = "이메일이 존재하지 않거나 비밀번호가 일치하지 않습니다.";
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup signup = new Signup();
            signup.Show();

        }

        private void customRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

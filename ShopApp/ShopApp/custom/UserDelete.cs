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
    public partial class UserDelete : Form
    {
        User user;
        private string email;
        public UserDelete(string email, User user)
        {
            InitializeComponent();
            errorText.Text = "";
            this.email = email;
            this.user = user;
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void errorText_Click(object sender, EventArgs e)
        {

           
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            if (costomTextBox1.Texts.Equals(costomTextBox2.Texts))
            {
                customerTableAdapter1.Fill(dataSet11.CUSTOMER);
                DataTable customerTable = dataSet11.Tables["CUSTOMER"];

                DataRow datarow = customerTable.Rows.Find(this.email);
                string password = datarow["PASSWORD"].ToString();
                if (password.Equals(costomTextBox1.Texts))
                {
                    datarow.Delete();
                    main main = new main();

                    this.customerTableAdapter1.Update(dataSet11.CUSTOMER);
                    main.Show();
                    user.Close();
                    this.Close();
                }
                else
                {
                    errorText.Text = "비밀번호가 일치하지 않습니다.";
                }

            }
            else
            {
                errorText.ForeColor = Color.DarkRed;
                errorText.Text = "입력하신 두개의 비밀번호가 동일하지 않습니다.";
            }
        }
    }
}

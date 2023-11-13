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
    public partial class Signup : Form
    {
        DataTable userTable = new DataTable();
        DataTable sellerTable = new DataTable();
        DataTable adminTable = new DataTable();
        public Signup()
        {
            
            InitializeComponent();
            this.customRadioButton1.Checked = true;
            errorText.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main form1 = new main();
            form1.Show();
            this.Close();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Texts;
            string pw1 = passwordTextBox1.Texts;
            string pw2 = passwordTextBox2.Texts;
            string name = nameTextBox.Texts;

            if (!pw1.Equals(pw2)) {
                errorText.Text = "비밀번호가 일치하지 않습니다.";
            }

            if (customRadioButton1.Checked)
            {
                customerTableAdapter1.Fill(dataSet11.CUSTOMER);
                userTable = dataSet11.Tables["CUSTOMER"];
                DataRow data = userTable.Rows.Find(email);

                if (data != null)
                {
                    errorText.Text = "이미 존재하는 이메일입니다.";
                }
                else
                {
                    DataRow newData = userTable.NewRow();
                    newData["C_EMAIL"] = email;
                    newData["PASSWORD"] = pw1;
                    newData["NAME"] = name;
                    newData["RATING"] = "NORMAL";
                    userTable.Rows.Add(newData);

                    customerTableAdapter1.Update(dataSet11.CUSTOMER);
                    main main = new main();
                    main.Show();
                    this.Close();
                }


            }else if (customRadioButton2.Checked)
            {
                sellerTableAdapter1.Fill(dataSet11.SELLER);
                sellerTable = dataSet11.Tables["SELLER"];
                DataRow data = sellerTable.Rows.Find(email);
                if(data != null)
                {
                    errorText.Text = "이미 존재하는 이메일입니다.";
                }
                else
                {
                    DataRow newData = sellerTable.NewRow();
                    newData["S_EMAIL"] = email;
                    newData["PASSWORD"] = pw1;
                    newData["NAME"] = name;
                    sellerTable.Rows.Add(newData);

                    sellerTableAdapter1.Update(dataSet11.SELLER);
                    main main = new main();
                    main.Show();
                    this.Close();
                }
                
            }else if (customRadioButton3.Checked)
            {
                adminTableAdapter1.Fill(dataSet11.ADMIN);
                adminTable = dataSet11.Tables["ADMIN"];
                DataRow data = adminTable.Rows.Find(email);
                if(data != null)
                {
                    errorText.Text = "이미 존재하는 이메일입니다.";
                }
                else
                {
                    DataRow newData = adminTable.NewRow();
                    newData["EMAIL"] = email;
                    newData["PASSWORD"] = pw1;

                    adminTableAdapter1.Update(dataSet11.ADMIN);
                    main main = new main();
                    main.Show();
                    this.Close();
                }

            }

            

            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
        }
    }
}

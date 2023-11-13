using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopApp.custom;

namespace ShopApp
{
    public partial class User : Form
    {
        string email;
        string name;

        public User(string email, string name)
        {
            InitializeComponent();
            this.email = email;
            this.name = name;
        }

        private void User_Load(object sender, EventArgs e)
        {
            this.nameLabel.Text = name + "님 환영합니다!";
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            sellect_button(1);
            panel2.Controls.Clear();
            ProductList productList = new ProductList(this.email);
            productList.TopLevel = false;
            productList.Dock = DockStyle.Fill;
            productList.Visible = true;
            panel2.Controls.Add(productList);
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sellect_button(int buttonIndex)
        {
            this.button1Panel.Visible = false;
            this.button2Panel.Visible = false;
            this.button3Panel.Visible = false;
            this.button4Panel.Visible = false;
            this.button5Panel.Visible = false;
            if (buttonIndex == 1)
            {
                sellectIcon.IconChar = button1.IconChar;
                this.button1Panel.Visible = true;
            }else if(buttonIndex == 2){
                sellectIcon.IconChar = button2.IconChar;
                this.button2Panel.Visible = true;
            }else if(buttonIndex == 3)
            {
                sellectIcon.IconChar = button3.IconChar;
                this.button3Panel.Visible = true;
            }
            else if(buttonIndex == 4)
            {
                sellectIcon.IconChar = button4.IconChar;
                this.button4Panel.Visible = true;
            }
            else if(buttonIndex == 5)
            {
                sellectIcon.IconChar = button5.IconChar;
                this.button5Panel.Visible = true;
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            sellect_button(2);
            panel2.Controls.Clear();
            UserCart userCart = new UserCart(this.email);
            userCart.TopLevel = false;
            userCart.Dock = DockStyle.Fill;
            userCart.Visible = true;
            panel2.Controls.Add(userCart);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sellect_button(3);
            panel2.Controls.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sellect_button(4);
            panel2.Controls.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sellect_button(5);
            panel2.Controls.Clear();
        }
    }
}

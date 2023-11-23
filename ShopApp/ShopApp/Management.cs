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
    public partial class Management : Form
    {
        string email = "";
        public Management(string email)
        {
            this.email = email;
            InitializeComponent();
            timer1.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void management_Load(object sender, EventArgs e)
        {
            sellect_button(1);
            panel2.Controls.Clear();
            AdminProductRegister adminProductRegister = new AdminProductRegister();
            adminProductRegister.TopLevel = false;
            adminProductRegister.Dock = DockStyle.Fill;
            adminProductRegister.Visible = true;
            panel2.Controls.Add(adminProductRegister);
        }

        private void ClockEvent(object sender, EventArgs e)
        {
            timeLabel.Text = "현재 시각 : "+DateTime.Now.ToString();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            emailLabel.Text = this.email + "님 환영합니다.";
            
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
           
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
            }
            else if (buttonIndex == 2)
            {
                sellectIcon.IconChar = button2.IconChar;
                this.button2Panel.Visible = true;
            }
            else if (buttonIndex == 3)
            {
                sellectIcon.IconChar = button3.IconChar;
                this.button3Panel.Visible = true;
            }
            else if (buttonIndex == 4)
            {
                sellectIcon.IconChar = button4.IconChar;
                this.button4Panel.Visible = true;
            }
            else if (buttonIndex == 5)
            {
                sellectIcon.IconChar = button5.IconChar;
                this.button5Panel.Visible = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sellect_button(1);
            panel2.Controls.Clear();
            AdminProductRegister adminProductRegister = new AdminProductRegister();
            adminProductRegister.TopLevel = false;
            adminProductRegister.Dock = DockStyle.Fill;
            adminProductRegister.Visible = true;
            panel2.Controls.Add(adminProductRegister);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            sellect_button(2);
            panel2.Controls.Clear();
            AdminNotification adminNotification = new AdminNotification();
            adminNotification.TopLevel = false;
            adminNotification.Dock = DockStyle.Fill;
            adminNotification.Visible = true;
            panel2.Controls.Add(adminNotification);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sellect_button(3);
            panel2.Controls.Clear();
            AdminUserRating adminUserRating = new AdminUserRating();
            adminUserRating.TopLevel = false;
            adminUserRating.Dock = DockStyle.Fill;
            adminUserRating.Visible = true;
            panel2.Controls.Add(adminUserRating);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sellect_button(4);
            panel2.Controls.Clear();
            AdminMonthSales adminMonthSales = new AdminMonthSales();
            adminMonthSales.TopLevel = false;
            adminMonthSales.Dock = DockStyle.Fill;
            adminMonthSales.Visible = true;
            panel2.Controls.Add(adminMonthSales);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sellect_button(5);
            panel2.Controls.Clear();
            AdminProductList adminProductList = new AdminProductList();
            adminProductList.TopLevel = false;
            adminProductList.Dock = DockStyle.Fill;
            adminProductList.Visible = true;
            panel2.Controls.Add(adminProductList);
        }
    }
}

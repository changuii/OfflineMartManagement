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
        DataTable notificationTable;

        public User(string email, string name)
        {
            InitializeComponent();
            this.email = email;
            this.name = name;
        }

        private void User_Load(object sender, EventArgs e)
        {
            this.nameLabel.Text = name + "님 환영합니다!";
            sellect_button(1);
            panel2.Controls.Clear();
            ProductList productList = new ProductList(this.email);
            productList.TopLevel = false;
            productList.Dock = DockStyle.Fill;
            productList.Visible = true;
            panel2.Controls.Add(productList);
            this.notificationTableAdapter1.Fill(dataSet11.NOTIFICATION);
            notificationTable = dataSet11.Tables["NOTIFICATION"];
            DataRow[] notification = notificationTable.Select("", "CREATION_TIME DESC");
            notificationLabel.Text = "최신 공지사항 : "+notification[0][2].ToString();
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
            this.button6Panel.Visible = false;
            this.button7Panel.Visible = false;
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
            else if(buttonIndex == 6)
            {
                sellectIcon.IconChar = button6.IconChar;
                this.button6Panel.Visible = true;
            }else if(buttonIndex == 7)
            {
                sellectIcon.IconChar = button7.IconChar;
                this.button7Panel.Visible = true;
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            sellect_button(2);
            panel2.Controls.Clear();
            UserCart userCart = new UserCart(this.email, this.name);
            userCart.TopLevel = false;
            userCart.Dock = DockStyle.Fill;
            userCart.Visible = true;
            panel2.Controls.Add(userCart);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sellect_button(3);
            panel2.Controls.Clear();
            UserPurchase userPurchase = new UserPurchase(this.email);
            userPurchase.TopLevel = false;
            userPurchase.Dock = DockStyle.Fill;
            userPurchase.Visible = true;
            panel2.Controls.Add(userPurchase);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sellect_button(4);
            panel2.Controls.Clear();
            UserNotification userNotification = new UserNotification();
            userNotification.TopLevel = false;
            userNotification.Dock = DockStyle.Fill;
            userNotification.Visible = true;
            panel2.Controls.Add(userNotification);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sellect_button(5);
            panel2.Controls.Clear();
            UserReview userReview = new UserReview();
            userReview.TopLevel = false;
            userReview.Dock = DockStyle.Fill;
            userReview.Visible = true;
            panel2.Controls.Add(userReview);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sellect_button(6);
            panel2.Controls.Clear();
            UserReviewRegister userReviewRegister = new UserReviewRegister(this.email);
            userReviewRegister.TopLevel = false;
            userReviewRegister.Dock = DockStyle.Fill;
            userReviewRegister.Visible = true;
            panel2.Controls.Add(userReviewRegister);
        }

        private void botton7_Click(object sender, EventArgs e)
        {
            sellect_button(7);
            panel2.Controls.Clear();
            UserInfo userInfo = new UserInfo(this.email, this);
            userInfo.TopLevel = false;
            userInfo.Dock = DockStyle.Fill;
            userInfo.Visible = true;
            panel2.Controls.Add(userInfo);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

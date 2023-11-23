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
    public partial class Seller : Form
    {
        string s_email;
        public Seller(string s_email)
        {
            InitializeComponent();
            this.s_email = s_email;
            this.emailLabel.Text = this.s_email + "님 환영합니다.!"; 
        }

        private void sellectIcon_Click(object sender, EventArgs e)
        {

        }

        private void sellect_button(int buttonIndex)
        {
            this.button1Panel.Visible = false;
            this.button2Panel.Visible = false;
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
            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sellect_button(1);
            panel2.Controls.Clear();
            SellerPurchase sellerPurchase = new SellerPurchase(this.s_email);
            sellerPurchase.TopLevel = false;
            sellerPurchase.Dock = DockStyle.Fill;
            sellerPurchase.Visible = true;
            panel2.Controls.Add(sellerPurchase);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sellect_button(2);
            panel2.Controls.Clear();
            AdminUserRating adminUserRating = new AdminUserRating();
            adminUserRating.TopLevel = false;
            adminUserRating.Dock = DockStyle.Fill;
            adminUserRating.Visible = true;
            panel2.Controls.Add(adminUserRating);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sellect_button(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sellect_button(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sellect_button(5);
        }

        private void Seller_Load(object sender, EventArgs e)
        {
            sellect_button(1);
            panel2.Controls.Clear();
            SellerPurchase sellerPurchase = new SellerPurchase(this.s_email);
            sellerPurchase.TopLevel = false;
            sellerPurchase.Dock = DockStyle.Fill;
            sellerPurchase.Visible = true;
            panel2.Controls.Add(sellerPurchase);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

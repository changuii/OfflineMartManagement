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
    }
}

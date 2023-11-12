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
        public Signup()
        {
            InitializeComponent();
            this.customRadioButton1.Checked = true;
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

            main main = new main();
            main.Show();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

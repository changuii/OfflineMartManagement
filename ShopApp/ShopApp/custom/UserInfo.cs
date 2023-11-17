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
    public partial class UserInfo : Form
    {
        string email;
        User user;
        public UserInfo(string email, User user)
        {
            InitializeComponent();
            this.email = email;
            this.user = user;
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            customerTableAdapter1.Fill(dataSet11.CUSTOMER);
            DataTable userTable = dataSet11.Tables["CUSTOMER"];
            DataRow user = userTable.Rows.Find(this.email);
            this.nameLabel1.Text = user["NAME"].ToString();
            this.idLabel2.Text = this.email;
            this.ratingLabel.Text = user["RATING"].ToString();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            UserDelete delete = new UserDelete(this.email, user);
            delete.ShowDialog();
        }
    }
}

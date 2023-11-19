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
    public partial class AdminMonthSales : Form
    {
        public AdminMonthSales()
        {
            InitializeComponent();
        }

        private void AdminMonthSales_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AdminMonthSalesTable adminMonthSalesTable = new AdminMonthSalesTable();
            adminMonthSalesTable.TopLevel = false;
            adminMonthSalesTable.Dock = DockStyle.Fill;
            adminMonthSalesTable.Visible = true;
            panel1.Controls.Add(adminMonthSalesTable);
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AdminMonthSalesTable adminMonthSalesTable = new AdminMonthSalesTable();
            adminMonthSalesTable.TopLevel = false;
            adminMonthSalesTable.Dock = DockStyle.Fill;
            adminMonthSalesTable.Visible = true;
            panel1.Controls.Add(adminMonthSalesTable);
        }

        private void customButton3_Click(object sender, EventArgs e)
        {

        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AdminSalesWeek adminSalesWeek = new AdminSalesWeek();
            adminSalesWeek.TopLevel = false;
            adminSalesWeek.Dock = DockStyle.Fill;
            adminSalesWeek.Visible = true;
            panel1.Controls.Add(adminSalesWeek);
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AdminSalesDay adminSalesDay = new AdminSalesDay();
            adminSalesDay.TopLevel = false;
            adminSalesDay.Dock = DockStyle.Fill;
            adminSalesDay.Visible = true;
            panel1.Controls.Add(adminSalesDay);
        }

        private void customButton3_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AdminSalesDOW adminSalesDOW = new AdminSalesDOW();
            adminSalesDOW.TopLevel = false;
            adminSalesDOW.Dock = DockStyle.Fill;
            adminSalesDOW.Visible = true;
            panel1.Controls.Add(adminSalesDOW);
        }
    }
}

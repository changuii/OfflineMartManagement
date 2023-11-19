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
    public partial class AdminSalesDay : Form
    {
        public AdminSalesDay()
        {
            InitializeComponent();
        }

        private void AdminSalesDay_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.PURCHASE_VIEW_DAY1' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.pURCHASE_VIEW_DAY1TableAdapter.Fill(this.dataSet1.PURCHASE_VIEW_DAY1);

        }
    }
}

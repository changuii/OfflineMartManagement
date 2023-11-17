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
    public partial class AdminUserRating : Form
    {
        public AdminUserRating()
        {
            InitializeComponent();
        }

        private void AdminUserRating_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.CUSTOMER' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.cUSTOMERTableAdapter.Fill(this.dataSet1.CUSTOMER);

        }
    }
}

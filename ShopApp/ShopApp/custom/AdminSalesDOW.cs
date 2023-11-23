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
    public partial class AdminSalesDOW : Form
    {
        public AdminSalesDOW()
        {
            InitializeComponent();
        }

        private void AdminSalesDOW_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.PURCHASE_VIEW_DOW1' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.pURCHASE_VIEW_DOW1TableAdapter.Fill(this.dataSet1.PURCHASE_VIEW_DOW1);
            this.chartUpdate();  
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        private void chartUpdate()
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending);
            // 범례 설정
            chart1.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top; // 범례를 상단에 표시
            chart1.Legends[0].Alignment = StringAlignment.Far; // 범례를 우측에 표시
            chart1.Legends[0].Enabled = true;
            chart1.Series[0]["PieLabelStyle"] = "Disabled"; // 라벨을 표시하지 않음
            chart1.Series[0].LegendText = "#VALX (#PERCENT)"; // 범례 텍스트 설정

            chart4.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top; ;
            chart4.Legends[0].Alignment = StringAlignment.Far;
            chart4.Series[0]["PieLabelStyle"] = "Disabled";
            chart4.Series[0].LegendText = "#VALX (#PERCENT)";
            chart4.Legends[0].Enabled = true;
        }
    }
}

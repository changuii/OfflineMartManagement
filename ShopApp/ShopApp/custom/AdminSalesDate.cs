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
    public partial class AdminSalesDate : Form
    {
        public AdminSalesDate()
        {
            InitializeComponent();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            string dt1 = this.dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string dt2 = this.dateTimePicker2.Value.ToString("yyyy-MM-dd");

            pURCHASEVIEWDATE1BindingSource.Filter = $"PURCHASE_DATE >= '{dt1}' AND PURCHASE_DATE <= '{dt2}'";

            // 데이터를 바탕으로 차트 업데이트
            chart1.DataSource = pURCHASEVIEWDATE1BindingSource;
            chart1.Series[0].XValueMember = "PURCHASE_DATE"; // X축 데이터 멤버 설정
            chart1.Series[0].YValueMembers = "SALE_PRICE"; // Y축 데이터 멤버 설정
            chart1.DataBind();
            chart1.Refresh(); // chart1 재그리기
            

            // 동일하게 다른 차트들에 대해서도 수행
            chart2.DataSource = pURCHASEVIEWDATE1BindingSource;
            chart2.Series[0].XValueMember = "PURCHASE_DATE";
            chart2.Series[0].YValueMembers = "SALE_STOCK";
            chart2.DataBind();
            chart2.Refresh();
            

            chart3.DataSource = pURCHASEVIEWDATE1BindingSource;
            chart3.Series[0].XValueMember = "PURCHASE_DATE";
            chart3.Series[0].YValueMembers = "SALE_PRICE";
            chart3.DataBind();
            chart3.Refresh();
            

            chart4.DataSource = pURCHASEVIEWDATE1BindingSource;
            chart4.Series[0].XValueMember = "PURCHASE_DATE";
            chart4.Series[0].YValueMembers = "SALE_STOCK";
            chart4.DataBind();
            chart4.Refresh();

            this.chartUpdate();
        }


        private void AdminSalesDate_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.PURCHASE_VIEW_DATE1' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.pURCHASE_VIEW_DATE1TableAdapter.Fill(this.dataSet1.PURCHASE_VIEW_DATE1);
            this.chartUpdate();
            
        }
        private void chartUpdate()
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending);
            // 범례 설정
            chart1.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top; // 범례를 상단에 표시
            chart1.Legends[0].Alignment = StringAlignment.Far; // 범례를 우측에 표시
            chart1.Legends[0].Enabled = true;
            chart1.Series[0]["PieLabelStyle"] = "Disabled"; // 라벨을 표시하지 않음
            chart1.Series[0].LegendText = "#VALX{yyyy-MM-dd} (#PERCENT)"; // 범례 텍스트 설정

            chart4.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top; ;
            chart4.Legends[0].Alignment = StringAlignment.Far;
            chart4.Series[0]["PieLabelStyle"] = "Disabled";
            chart4.Series[0].LegendText = "#VALX{yyyy-MM-dd} (#PERCENT)";
            chart4.Legends[0].Enabled = true;
        }

       

    }
}

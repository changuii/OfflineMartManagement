﻿using System;
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
        string[] combo = {"TERRIBLE","BAD", "NORMAL","GOLD", "PLATINUM", "VIP", "VVIP" };
        public AdminUserRating()
        {
            InitializeComponent();
        }

        private void AdminUserRating_Load(object sender, EventArgs e)
        {
            this.updateUserRating();
            // TODO: 이 코드는 데이터를 'dataSet1.CUSTOMER_VIEW1' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.cUSTOMER_VIEW1TableAdapter1.Fill(dataSet1.CUSTOMER_VIEW1);
            
            errorLabel.Text = "";
            this.comboBox1.Items.AddRange(combo);
            


            this.updateTableView();
        }

        private void updateUserRating()
        {
            this.customerTableAdapter1.Fill(dataSet1.CUSTOMER);
            DataTable table = dataSet1.Tables["CUSTOMER"];
            this.customeR_VIEW_RATING1TableAdapter1.Fill(dataSet1.CUSTOMER_VIEW_RATING1);
            DataTable rating = dataSet1.Tables["CUSTOMER_VIEW_RATING1"];

            DataRow[] datas = rating.Select();
            foreach (DataRow data in datas)
            {
                DataRow user = table.Rows.Find(data["C_EMAIL"]);
                if (int.Parse(data["S_PRICE"].ToString()) == 0 && int.Parse(data["R_PRICE"].ToString()) > 0)
                {
                    user["RATING"] = "TERRIBLE";
                }
                else
                {
                    if (int.Parse(data["S_PRICE"].ToString()) - int.Parse(data["R_PRICE"].ToString()) < 0)
                    {
                        user["RATING"] = "BAD";
                    }
                    else if (int.Parse(data["S_PRICE"].ToString()) > 100000 && int.Parse(data["S_PRICE"].ToString()) < 500000)
                    {
                        user["RATING"] = "GOLD";
                    }
                    else if (int.Parse(data["S_PRICE"].ToString()) > 500000 && int.Parse(data["S_PRICE"].ToString()) < 1000000)
                    {
                        user["RATING"] = "PLATINUM";
                    }
                    else if (int.Parse(data["S_PRICE"].ToString()) > 1000000 && int.Parse(data["S_PRICE"].ToString()) < 1500000)
                    {
                        user["RATING"] = "VIP";
                    }
                    else if (int.Parse(data["S_PRICE"].ToString()) > 1500000)
                    {
                        user["RATING"] = "VVIP";
                    }
                    else
                    {
                        user["RATING"] = "NORMAL";
                    }
                }
            }
            this.customerTableAdapter1.Update(dataSet1.CUSTOMER);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updateTableView()
        {
            DataGridViewRow data = dataGridView1.CurrentRow;

            if(data != null)
            {
                this.nameLabel.Text = data.Cells[0].Value.ToString();
                this.c_emailLabel.Text = data.Cells[1].Value.ToString();
                this.passwordLabel.Text = data.Cells[2].Value.ToString();
                this.ratingLabel.Text = data.Cells[3].Value.ToString();
                this.sale_count.Text = data.Cells[4].Value.ToString();
                this.refund.Text = data.Cells[5].Value.ToString();
                this.allPrice.Text = data.Cells[6].Value.ToString();
                this.comboBox1.Text = combo[0];
            }

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.updateTableView();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            DataGridViewRow data = dataGridView1.CurrentRow;
            
            if(data != null)
            {
                if (!data.Cells[3].Value.ToString().Equals(comboBox1.Text))
                {
                    customerTableAdapter1.Fill(dataSet1.CUSTOMER);
                    DataTable userTable = dataSet1.Tables["CUSTOMER"];
                    DataRow[] dataRow = userTable.Select($"C_EMAIL = '{c_emailLabel.Text}'");
                    if(dataRow.Length > 0)
                    {
                        string targetName = dataRow[0]["NAME"].ToString(); 
                        dataRow[0]["RATING"] = comboBox1.Text;
                        this.customerTableAdapter1.Update(dataSet1.CUSTOMER);
                        this.customerTableAdapter1.Fill(dataSet1.CUSTOMER);
                        this.cUSTOMER_VIEW1TableAdapter1.Fill(dataSet1.CUSTOMER_VIEW1);
                        this.updateTableView();
                        errorLabel.Text = $"{targetName}님의 등급이 변경되었습니다.";
                        errorLabel.ForeColor = Color.MediumSeaGreen;
                    }

                }
                else
                {
                    errorLabel.ForeColor = Color.DarkRed;
                    errorLabel.Text = "이미 변경되었습니다.";
                }

            }
            else
            {
                errorLabel.ForeColor = Color.DarkRed;
                errorLabel.Text = "선택된 유저가 없습니다.";
            }
        }
    }
}

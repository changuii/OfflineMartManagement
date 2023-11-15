
namespace ShopApp.custom
{
    partial class UserPurchase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new ShopApp.DataSet1();
            this.pURCHASEVIEW1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pURCHASE_VIEW1TableAdapter = new ShopApp.DataSet1TableAdapters.PURCHASE_VIEW1TableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pURCHASEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSTOCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLLOWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allowFilterButton1 = new ShopApp.custom.CustomButton();
            this.allowFilterButton2 = new ShopApp.custom.CustomButton();
            this.allowFilterButton3 = new ShopApp.custom.CustomButton();
            this.allowFilterButton4 = new ShopApp.custom.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASEVIEW1BindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cEMAILDataGridViewTextBoxColumn,
            this.pIDDataGridViewTextBoxColumn,
            this.pURCHASEDATEDataGridViewTextBoxColumn,
            this.pPRICEDataGridViewTextBoxColumn,
            this.pSTOCKDataGridViewTextBoxColumn,
            this.aLLOWDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.pRICEDataGridViewTextBoxColumn,
            this.sTOCKDataGridViewTextBoxColumn,
            this.cATEGORYDataGridViewTextBoxColumn,
            this.sEMAILDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pURCHASEVIEW1BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1010, 241);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pURCHASEVIEW1BindingSource
            // 
            this.pURCHASEVIEW1BindingSource.DataMember = "PURCHASE_VIEW1";
            this.pURCHASEVIEW1BindingSource.DataSource = this.dataSet1;
            // 
            // pURCHASE_VIEW1TableAdapter
            // 
            this.pURCHASE_VIEW1TableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.allowFilterButton4);
            this.panel1.Controls.Add(this.allowFilterButton3);
            this.panel1.Controls.Add(this.allowFilterButton2);
            this.panel1.Controls.Add(this.allowFilterButton1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 367);
            this.panel1.TabIndex = 1;
            // 
            // cEMAILDataGridViewTextBoxColumn
            // 
            this.cEMAILDataGridViewTextBoxColumn.DataPropertyName = "C_EMAIL";
            this.cEMAILDataGridViewTextBoxColumn.HeaderText = "C_EMAIL";
            this.cEMAILDataGridViewTextBoxColumn.Name = "cEMAILDataGridViewTextBoxColumn";
            this.cEMAILDataGridViewTextBoxColumn.ReadOnly = true;
            this.cEMAILDataGridViewTextBoxColumn.Visible = false;
            // 
            // pIDDataGridViewTextBoxColumn
            // 
            this.pIDDataGridViewTextBoxColumn.DataPropertyName = "P_ID";
            this.pIDDataGridViewTextBoxColumn.HeaderText = "P_ID";
            this.pIDDataGridViewTextBoxColumn.Name = "pIDDataGridViewTextBoxColumn";
            this.pIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pURCHASEDATEDataGridViewTextBoxColumn
            // 
            this.pURCHASEDATEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pURCHASEDATEDataGridViewTextBoxColumn.DataPropertyName = "PURCHASE_DATE";
            this.pURCHASEDATEDataGridViewTextBoxColumn.HeaderText = "구매시간";
            this.pURCHASEDATEDataGridViewTextBoxColumn.Name = "pURCHASEDATEDataGridViewTextBoxColumn";
            this.pURCHASEDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pPRICEDataGridViewTextBoxColumn
            // 
            this.pPRICEDataGridViewTextBoxColumn.DataPropertyName = "P_PRICE";
            this.pPRICEDataGridViewTextBoxColumn.HeaderText = "전체가격";
            this.pPRICEDataGridViewTextBoxColumn.Name = "pPRICEDataGridViewTextBoxColumn";
            this.pPRICEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pSTOCKDataGridViewTextBoxColumn
            // 
            this.pSTOCKDataGridViewTextBoxColumn.DataPropertyName = "P_STOCK";
            this.pSTOCKDataGridViewTextBoxColumn.HeaderText = "구매수량";
            this.pSTOCKDataGridViewTextBoxColumn.Name = "pSTOCKDataGridViewTextBoxColumn";
            this.pSTOCKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aLLOWDataGridViewTextBoxColumn
            // 
            this.aLLOWDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aLLOWDataGridViewTextBoxColumn.DataPropertyName = "ALLOW";
            this.aLLOWDataGridViewTextBoxColumn.HeaderText = "허용여부";
            this.aLLOWDataGridViewTextBoxColumn.Name = "aLLOWDataGridViewTextBoxColumn";
            this.aLLOWDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "제품명";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRICEDataGridViewTextBoxColumn
            // 
            this.pRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "제품가격";
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            this.pRICEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTOCKDataGridViewTextBoxColumn
            // 
            this.sTOCKDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sTOCKDataGridViewTextBoxColumn.DataPropertyName = "STOCK";
            this.sTOCKDataGridViewTextBoxColumn.HeaderText = "현재 제품수량";
            this.sTOCKDataGridViewTextBoxColumn.Name = "sTOCKDataGridViewTextBoxColumn";
            this.sTOCKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cATEGORYDataGridViewTextBoxColumn
            // 
            this.cATEGORYDataGridViewTextBoxColumn.DataPropertyName = "CATEGORY";
            this.cATEGORYDataGridViewTextBoxColumn.HeaderText = "카테고리";
            this.cATEGORYDataGridViewTextBoxColumn.Name = "cATEGORYDataGridViewTextBoxColumn";
            this.cATEGORYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sEMAILDataGridViewTextBoxColumn
            // 
            this.sEMAILDataGridViewTextBoxColumn.DataPropertyName = "S_EMAIL";
            this.sEMAILDataGridViewTextBoxColumn.HeaderText = "판매자";
            this.sEMAILDataGridViewTextBoxColumn.Name = "sEMAILDataGridViewTextBoxColumn";
            this.sEMAILDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // allowFilterButton1
            // 
            this.allowFilterButton1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.allowFilterButton1.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.allowFilterButton1.BorderRadius = 40;
            this.allowFilterButton1.BorderSize = 0;
            this.allowFilterButton1.FlatAppearance.BorderSize = 0;
            this.allowFilterButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allowFilterButton1.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.allowFilterButton1.ForeColor = System.Drawing.Color.White;
            this.allowFilterButton1.Location = new System.Drawing.Point(21, 247);
            this.allowFilterButton1.Name = "allowFilterButton1";
            this.allowFilterButton1.Size = new System.Drawing.Size(150, 40);
            this.allowFilterButton1.TabIndex = 2;
            this.allowFilterButton1.Text = "구매된 내역조회";
            this.allowFilterButton1.UseVisualStyleBackColor = false;
            // 
            // allowFilterButton2
            // 
            this.allowFilterButton2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.allowFilterButton2.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.allowFilterButton2.BorderRadius = 40;
            this.allowFilterButton2.BorderSize = 0;
            this.allowFilterButton2.FlatAppearance.BorderSize = 0;
            this.allowFilterButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allowFilterButton2.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.allowFilterButton2.ForeColor = System.Drawing.Color.White;
            this.allowFilterButton2.Location = new System.Drawing.Point(177, 247);
            this.allowFilterButton2.Name = "allowFilterButton2";
            this.allowFilterButton2.Size = new System.Drawing.Size(150, 40);
            this.allowFilterButton2.TabIndex = 3;
            this.allowFilterButton2.Text = "환불요청 내역조회";
            this.allowFilterButton2.UseVisualStyleBackColor = false;
            // 
            // allowFilterButton3
            // 
            this.allowFilterButton3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.allowFilterButton3.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.allowFilterButton3.BorderRadius = 40;
            this.allowFilterButton3.BorderSize = 0;
            this.allowFilterButton3.FlatAppearance.BorderSize = 0;
            this.allowFilterButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allowFilterButton3.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.allowFilterButton3.ForeColor = System.Drawing.Color.White;
            this.allowFilterButton3.Location = new System.Drawing.Point(333, 247);
            this.allowFilterButton3.Name = "allowFilterButton3";
            this.allowFilterButton3.Size = new System.Drawing.Size(150, 40);
            this.allowFilterButton3.TabIndex = 4;
            this.allowFilterButton3.Text = "환불된 내역조회";
            this.allowFilterButton3.UseVisualStyleBackColor = false;
            // 
            // allowFilterButton4
            // 
            this.allowFilterButton4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.allowFilterButton4.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.allowFilterButton4.BorderRadius = 40;
            this.allowFilterButton4.BorderSize = 0;
            this.allowFilterButton4.FlatAppearance.BorderSize = 0;
            this.allowFilterButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allowFilterButton4.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.allowFilterButton4.ForeColor = System.Drawing.Color.White;
            this.allowFilterButton4.Location = new System.Drawing.Point(489, 247);
            this.allowFilterButton4.Name = "allowFilterButton4";
            this.allowFilterButton4.Size = new System.Drawing.Size(150, 40);
            this.allowFilterButton4.TabIndex = 5;
            this.allowFilterButton4.Text = "전체 내역 조회";
            this.allowFilterButton4.UseVisualStyleBackColor = false;
            // 
            // UserPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 560);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserPurchase";
            this.Text = "UserPurchase";
            this.Load += new System.EventHandler(this.UserPurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASEVIEW1BindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pURCHASEVIEW1BindingSource;
        private DataSet1TableAdapters.PURCHASE_VIEW1TableAdapter pURCHASE_VIEW1TableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pURCHASEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pSTOCKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLLOWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOCKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGORYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEMAILDataGridViewTextBoxColumn;
        private CustomButton allowFilterButton4;
        private CustomButton allowFilterButton3;
        private CustomButton allowFilterButton2;
        private CustomButton allowFilterButton1;
    }
}
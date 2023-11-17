
namespace ShopApp.custom
{
    partial class SellerPurchase
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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pURCHASEVIEW1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ShopApp.DataSet1();
            this.pURCHASE_VIEW1TableAdapter = new ShopApp.DataSet1TableAdapters.PURCHASE_VIEW1TableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorText = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.allowLabel = new System.Windows.Forms.Label();
            this.c_stockLabel = new System.Windows.Forms.Label();
            this.c_priceLabel = new System.Windows.Forms.Label();
            this.c_emailLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sellerLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.stockLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.p_idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.purchaseTableAdapter1 = new ShopApp.DataSet1TableAdapters.PURCHASETableAdapter();
            this.productTableAdapter1 = new ShopApp.DataSet1TableAdapters.PRODUCTTableAdapter();
            this.customButton2 = new ShopApp.custom.CustomButton();
            this.customButton1 = new ShopApp.custom.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASEVIEW1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.sEMAILDataGridViewTextBoxColumn,
            this.ID});
            this.dataGridView1.DataSource = this.pURCHASEVIEW1BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1010, 243);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // cEMAILDataGridViewTextBoxColumn
            // 
            this.cEMAILDataGridViewTextBoxColumn.DataPropertyName = "C_EMAIL";
            this.cEMAILDataGridViewTextBoxColumn.HeaderText = "구매자";
            this.cEMAILDataGridViewTextBoxColumn.Name = "cEMAILDataGridViewTextBoxColumn";
            this.cEMAILDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pIDDataGridViewTextBoxColumn
            // 
            this.pIDDataGridViewTextBoxColumn.DataPropertyName = "P_ID";
            this.pIDDataGridViewTextBoxColumn.HeaderText = "제품코드";
            this.pIDDataGridViewTextBoxColumn.Name = "pIDDataGridViewTextBoxColumn";
            this.pIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pURCHASEDATEDataGridViewTextBoxColumn
            // 
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
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "가격";
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            this.pRICEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTOCKDataGridViewTextBoxColumn
            // 
            this.sTOCKDataGridViewTextBoxColumn.DataPropertyName = "STOCK";
            this.sTOCKDataGridViewTextBoxColumn.HeaderText = "재고";
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
            this.sEMAILDataGridViewTextBoxColumn.Visible = false;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // pURCHASEVIEW1BindingSource
            // 
            this.pURCHASEVIEW1BindingSource.DataMember = "PURCHASE_VIEW1";
            this.pURCHASEVIEW1BindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pURCHASE_VIEW1TableAdapter
            // 
            this.pURCHASE_VIEW1TableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.errorText);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("던파 비트비트체 TTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 561);
            this.panel1.TabIndex = 1;
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.Font = new System.Drawing.Font("던파 비트비트체 TTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.errorText.ForeColor = System.Drawing.Color.DarkRed;
            this.errorText.Location = new System.Drawing.Point(701, 264);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(85, 15);
            this.errorText.TabIndex = 7;
            this.errorText.Text = "errorText";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.customButton2);
            this.groupBox4.Controls.Add(this.comboBox2);
            this.groupBox4.Location = new System.Drawing.Point(344, 476);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(351, 74);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "RequestProcess";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 28);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(180, 26);
            this.comboBox2.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.timeLabel);
            this.groupBox3.Controls.Add(this.allowLabel);
            this.groupBox3.Controls.Add(this.c_stockLabel);
            this.groupBox3.Controls.Add(this.c_priceLabel);
            this.groupBox3.Controls.Add(this.c_emailLabel);
            this.groupBox3.Location = new System.Drawing.Point(320, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 219);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RequestInfo";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeLabel.Location = new System.Drawing.Point(20, 25);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(58, 20);
            this.timeLabel.TabIndex = 5;
            this.timeLabel.Text = "Time";
            // 
            // allowLabel
            // 
            this.allowLabel.AutoSize = true;
            this.allowLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.allowLabel.Location = new System.Drawing.Point(20, 185);
            this.allowLabel.Name = "allowLabel";
            this.allowLabel.Size = new System.Drawing.Size(79, 20);
            this.allowLabel.TabIndex = 4;
            this.allowLabel.Text = "ALLOW";
            // 
            // c_stockLabel
            // 
            this.c_stockLabel.AutoSize = true;
            this.c_stockLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.c_stockLabel.Location = new System.Drawing.Point(20, 145);
            this.c_stockLabel.Name = "c_stockLabel";
            this.c_stockLabel.Size = new System.Drawing.Size(96, 20);
            this.c_stockLabel.TabIndex = 3;
            this.c_stockLabel.Text = "C_STOCK";
            // 
            // c_priceLabel
            // 
            this.c_priceLabel.AutoSize = true;
            this.c_priceLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.c_priceLabel.Location = new System.Drawing.Point(20, 105);
            this.c_priceLabel.Name = "c_priceLabel";
            this.c_priceLabel.Size = new System.Drawing.Size(94, 20);
            this.c_priceLabel.TabIndex = 2;
            this.c_priceLabel.Text = "C_PRICE";
            // 
            // c_emailLabel
            // 
            this.c_emailLabel.AutoSize = true;
            this.c_emailLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.c_emailLabel.Location = new System.Drawing.Point(20, 65);
            this.c_emailLabel.Name = "c_emailLabel";
            this.c_emailLabel.Size = new System.Drawing.Size(97, 20);
            this.c_emailLabel.TabIndex = 1;
            this.c_emailLabel.Text = "C_EMAIL";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sellerLabel);
            this.groupBox2.Controls.Add(this.categoryLabel);
            this.groupBox2.Controls.Add(this.stockLabel);
            this.groupBox2.Controls.Add(this.priceLabel);
            this.groupBox2.Controls.Add(this.p_idLabel);
            this.groupBox2.Controls.Add(this.nameLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 219);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ProductInfo";
            // 
            // sellerLabel
            // 
            this.sellerLabel.AutoSize = true;
            this.sellerLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sellerLabel.Location = new System.Drawing.Point(20, 189);
            this.sellerLabel.Name = "sellerLabel";
            this.sellerLabel.Size = new System.Drawing.Size(83, 20);
            this.sellerLabel.TabIndex = 5;
            this.sellerLabel.Text = "SELLER";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.categoryLabel.Location = new System.Drawing.Point(20, 159);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(116, 20);
            this.categoryLabel.TabIndex = 4;
            this.categoryLabel.Text = "CATEGORY";
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.stockLabel.Location = new System.Drawing.Point(20, 129);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(73, 20);
            this.stockLabel.TabIndex = 3;
            this.stockLabel.Text = "STOCK";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.priceLabel.Location = new System.Drawing.Point(20, 99);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(71, 20);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "PRICE";
            // 
            // p_idLabel
            // 
            this.p_idLabel.AutoSize = true;
            this.p_idLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.p_idLabel.Location = new System.Drawing.Point(19, 69);
            this.p_idLabel.Name = "p_idLabel";
            this.p_idLabel.Size = new System.Drawing.Size(56, 20);
            this.p_idLabel.TabIndex = 1;
            this.p_idLabel.Text = "P_ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nameLabel.Location = new System.Drawing.Point(19, 25);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(98, 30);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customButton1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 476);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 74);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RequestFilter";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 26);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // purchaseTableAdapter1
            // 
            this.purchaseTableAdapter1.ClearBeforeFill = true;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.customButton2.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.customButton2.BorderRadius = 40;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(192, 20);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(150, 40);
            this.customButton2.TabIndex = 1;
            this.customButton2.Text = "허용여부 변경";
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.customButton1.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.customButton1.BorderRadius = 40;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(169, 20);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(150, 40);
            this.customButton1.TabIndex = 1;
            this.customButton1.Text = "요청 필터링 ";
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // SellerPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 560);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellerPurchase";
            this.Text = "SellerPurchase";
            this.Load += new System.EventHandler(this.SellerPurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASEVIEW1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pURCHASEVIEW1BindingSource;
        private DataSet1TableAdapters.PURCHASE_VIEW1TableAdapter pURCHASE_VIEW1TableAdapter;
        private System.Windows.Forms.Panel panel1;
        private CustomButton customButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label allowLabel;
        private System.Windows.Forms.Label c_stockLabel;
        private System.Windows.Forms.Label c_priceLabel;
        private System.Windows.Forms.Label c_emailLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label sellerLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label p_idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private CustomButton customButton2;
        private System.Windows.Forms.ComboBox comboBox2;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private DataSet1TableAdapters.PURCHASETableAdapter purchaseTableAdapter1;
        private System.Windows.Forms.Label errorText;
        private DataSet1TableAdapters.PRODUCTTableAdapter productTableAdapter1;
    }
}

namespace ShopApp.custom
{
    partial class UserCart
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
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSTOCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARTVIEW1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ShopApp.DataSet1();
            this.cART_VIEW1TableAdapter = new ShopApp.DataSet1TableAdapters.CART_VIEW1TableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableNameLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.productCard = new System.Windows.Forms.GroupBox();
            this.productSeller = new System.Windows.Forms.Label();
            this.productStock = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.productPrice = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stockLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.sellerLabel = new System.Windows.Forms.Label();
            this.p_stockLabel = new System.Windows.Forms.Label();
            this.p_priceLabel = new System.Windows.Forms.Label();
            this.cartTableAdapter1 = new ShopApp.DataSet1TableAdapters.CARTTableAdapter();
            this.purchaseTableAdapter1 = new ShopApp.DataSet1TableAdapters.PURCHASETableAdapter();
            this.customButton1 = new ShopApp.custom.CustomButton();
            this.allPurchase = new ShopApp.custom.CustomButton();
            this.sellectPurchase = new ShopApp.custom.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARTVIEW1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.productCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nAMEDataGridViewTextBoxColumn,
            this.pSTOCKDataGridViewTextBoxColumn,
            this.pPRICEDataGridViewTextBoxColumn,
            this.sTOCKDataGridViewTextBoxColumn,
            this.pRICEDataGridViewTextBoxColumn,
            this.cATEGORYDataGridViewTextBoxColumn,
            this.cEMAILDataGridViewTextBoxColumn,
            this.pIDDataGridViewTextBoxColumn,
            this.sEMAILDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cARTVIEW1BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(643, 526);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "제품명";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pSTOCKDataGridViewTextBoxColumn
            // 
            this.pSTOCKDataGridViewTextBoxColumn.DataPropertyName = "P_STOCK";
            this.pSTOCKDataGridViewTextBoxColumn.HeaderText = "담긴수량";
            this.pSTOCKDataGridViewTextBoxColumn.Name = "pSTOCKDataGridViewTextBoxColumn";
            this.pSTOCKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pPRICEDataGridViewTextBoxColumn
            // 
            this.pPRICEDataGridViewTextBoxColumn.DataPropertyName = "P_PRICE";
            this.pPRICEDataGridViewTextBoxColumn.HeaderText = "전체가격";
            this.pPRICEDataGridViewTextBoxColumn.Name = "pPRICEDataGridViewTextBoxColumn";
            this.pPRICEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTOCKDataGridViewTextBoxColumn
            // 
            this.sTOCKDataGridViewTextBoxColumn.DataPropertyName = "STOCK";
            this.sTOCKDataGridViewTextBoxColumn.HeaderText = "현재재고";
            this.sTOCKDataGridViewTextBoxColumn.Name = "sTOCKDataGridViewTextBoxColumn";
            this.sTOCKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRICEDataGridViewTextBoxColumn
            // 
            this.pRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "개당가격";
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            this.pRICEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cATEGORYDataGridViewTextBoxColumn
            // 
            this.cATEGORYDataGridViewTextBoxColumn.DataPropertyName = "CATEGORY";
            this.cATEGORYDataGridViewTextBoxColumn.HeaderText = "카테고리";
            this.cATEGORYDataGridViewTextBoxColumn.Name = "cATEGORYDataGridViewTextBoxColumn";
            this.cATEGORYDataGridViewTextBoxColumn.ReadOnly = true;
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
            // sEMAILDataGridViewTextBoxColumn
            // 
            this.sEMAILDataGridViewTextBoxColumn.DataPropertyName = "S_EMAIL";
            this.sEMAILDataGridViewTextBoxColumn.HeaderText = "S_EMAIL";
            this.sEMAILDataGridViewTextBoxColumn.Name = "sEMAILDataGridViewTextBoxColumn";
            this.sEMAILDataGridViewTextBoxColumn.ReadOnly = true;
            this.sEMAILDataGridViewTextBoxColumn.Visible = false;
            // 
            // cARTVIEW1BindingSource
            // 
            this.cARTVIEW1BindingSource.DataMember = "CART_VIEW1";
            this.cARTVIEW1BindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cART_VIEW1TableAdapter
            // 
            this.cART_VIEW1TableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tableNameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 560);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 526);
            this.panel2.TabIndex = 2;
            // 
            // tableNameLabel
            // 
            this.tableNameLabel.AutoSize = true;
            this.tableNameLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tableNameLabel.Location = new System.Drawing.Point(12, 8);
            this.tableNameLabel.Name = "tableNameLabel";
            this.tableNameLabel.Size = new System.Drawing.Size(78, 22);
            this.tableNameLabel.TabIndex = 1;
            this.tableNameLabel.Text = "label1";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel.Location = new System.Drawing.Point(651, 421);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(88, 15);
            this.errorLabel.TabIndex = 8;
            this.errorLabel.Text = "errorLabel";
            // 
            // productCard
            // 
            this.productCard.Controls.Add(this.stockLabel);
            this.productCard.Controls.Add(this.priceLabel);
            this.productCard.Controls.Add(this.sellerLabel);
            this.productCard.Controls.Add(this.p_stockLabel);
            this.productCard.Controls.Add(this.p_priceLabel);
            this.productCard.Controls.Add(this.label1);
            this.productCard.Controls.Add(this.label2);
            this.productCard.Controls.Add(this.productSeller);
            this.productCard.Controls.Add(this.productStock);
            this.productCard.Controls.Add(this.categoryLabel);
            this.productCard.Controls.Add(this.productPrice);
            this.productCard.Controls.Add(this.nameLabel);
            this.productCard.Font = new System.Drawing.Font("던파 비트비트체 TTF", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.productCard.Location = new System.Drawing.Point(651, 8);
            this.productCard.Name = "productCard";
            this.productCard.Size = new System.Drawing.Size(347, 292);
            this.productCard.TabIndex = 9;
            this.productCard.TabStop = false;
            this.productCard.Text = "Product";
            // 
            // productSeller
            // 
            this.productSeller.AutoSize = true;
            this.productSeller.Font = new System.Drawing.Font("던파 비트비트체 TTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.productSeller.Location = new System.Drawing.Point(35, 240);
            this.productSeller.Name = "productSeller";
            this.productSeller.Size = new System.Drawing.Size(99, 27);
            this.productSeller.TabIndex = 5;
            this.productSeller.Text = "판매자 :";
            // 
            // productStock
            // 
            this.productStock.AutoSize = true;
            this.productStock.Font = new System.Drawing.Font("던파 비트비트체 TTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.productStock.Location = new System.Drawing.Point(13, 100);
            this.productStock.Name = "productStock";
            this.productStock.Size = new System.Drawing.Size(121, 27);
            this.productStock.TabIndex = 4;
            this.productStock.Text = "담긴수량 :";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.categoryLabel.Location = new System.Drawing.Point(214, 16);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(101, 20);
            this.categoryLabel.TabIndex = 3;
            this.categoryLabel.Text = "category";
            // 
            // productPrice
            // 
            this.productPrice.AutoSize = true;
            this.productPrice.Font = new System.Drawing.Font("던파 비트비트체 TTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.productPrice.Location = new System.Drawing.Point(13, 135);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(121, 27);
            this.productPrice.TabIndex = 2;
            this.productPrice.Text = "전체가격 :";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nameLabel.Location = new System.Drawing.Point(13, 40);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(122, 37);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("던파 비트비트체 TTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(13, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "현재재고 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("던파 비트비트체 TTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(13, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "개당가격 :";
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.stockLabel.Location = new System.Drawing.Point(140, 170);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(106, 27);
            this.stockLabel.TabIndex = 12;
            this.stockLabel.Text = "현재재고";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.priceLabel.Location = new System.Drawing.Point(140, 205);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(107, 27);
            this.priceLabel.TabIndex = 11;
            this.priceLabel.Text = "개당가격";
            // 
            // sellerLabel
            // 
            this.sellerLabel.AutoSize = true;
            this.sellerLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sellerLabel.Location = new System.Drawing.Point(140, 240);
            this.sellerLabel.Name = "sellerLabel";
            this.sellerLabel.Size = new System.Drawing.Size(84, 27);
            this.sellerLabel.TabIndex = 10;
            this.sellerLabel.Text = "판매자";
            // 
            // p_stockLabel
            // 
            this.p_stockLabel.AutoSize = true;
            this.p_stockLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.p_stockLabel.Location = new System.Drawing.Point(140, 100);
            this.p_stockLabel.Name = "p_stockLabel";
            this.p_stockLabel.Size = new System.Drawing.Size(106, 27);
            this.p_stockLabel.TabIndex = 9;
            this.p_stockLabel.Text = "담긴수량";
            // 
            // p_priceLabel
            // 
            this.p_priceLabel.AutoSize = true;
            this.p_priceLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.p_priceLabel.Location = new System.Drawing.Point(140, 135);
            this.p_priceLabel.Name = "p_priceLabel";
            this.p_priceLabel.Size = new System.Drawing.Size(106, 27);
            this.p_priceLabel.TabIndex = 8;
            this.p_priceLabel.Text = "전체가격";
            // 
            // cartTableAdapter1
            // 
            this.cartTableAdapter1.ClearBeforeFill = true;
            // 
            // purchaseTableAdapter1
            // 
            this.purchaseTableAdapter1.ClearBeforeFill = true;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.customButton1.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.customButton1.BorderRadius = 40;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(654, 452);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(344, 40);
            this.customButton1.TabIndex = 11;
            this.customButton1.Text = "선택한 상품 장바구니에서 제거";
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // allPurchase
            // 
            this.allPurchase.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.allPurchase.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.allPurchase.BorderRadius = 40;
            this.allPurchase.BorderSize = 0;
            this.allPurchase.FlatAppearance.BorderSize = 0;
            this.allPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allPurchase.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.allPurchase.ForeColor = System.Drawing.Color.White;
            this.allPurchase.Location = new System.Drawing.Point(829, 498);
            this.allPurchase.Name = "allPurchase";
            this.allPurchase.Size = new System.Drawing.Size(170, 40);
            this.allPurchase.TabIndex = 10;
            this.allPurchase.Text = "전체 상품 구매";
            this.allPurchase.UseVisualStyleBackColor = false;
            this.allPurchase.Click += new System.EventHandler(this.allPurchase_Click);
            // 
            // sellectPurchase
            // 
            this.sellectPurchase.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.sellectPurchase.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.sellectPurchase.BorderRadius = 40;
            this.sellectPurchase.BorderSize = 0;
            this.sellectPurchase.FlatAppearance.BorderSize = 0;
            this.sellectPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellectPurchase.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sellectPurchase.ForeColor = System.Drawing.Color.White;
            this.sellectPurchase.Location = new System.Drawing.Point(654, 498);
            this.sellectPurchase.Name = "sellectPurchase";
            this.sellectPurchase.Size = new System.Drawing.Size(170, 40);
            this.sellectPurchase.TabIndex = 7;
            this.sellectPurchase.Text = "선택한 상품 구매";
            this.sellectPurchase.UseVisualStyleBackColor = false;
            this.sellectPurchase.Click += new System.EventHandler(this.sellectPurchase_Click);
            // 
            // UserCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 560);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.allPurchase);
            this.Controls.Add(this.productCard);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sellectPurchase);
            this.Controls.Add(this.errorLabel);
            this.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "UserCart";
            this.Text = "UserCart";
            this.Load += new System.EventHandler(this.UserCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARTVIEW1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.productCard.ResumeLayout(false);
            this.productCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cARTVIEW1BindingSource;
        private DataSet1TableAdapters.CART_VIEW1TableAdapter cART_VIEW1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pSTOCKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOCKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGORYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tableNameLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label errorLabel;
        private CustomButton sellectPurchase;
        private System.Windows.Forms.GroupBox productCard;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label sellerLabel;
        private System.Windows.Forms.Label p_stockLabel;
        private System.Windows.Forms.Label p_priceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label productSeller;
        private System.Windows.Forms.Label productStock;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label productPrice;
        private System.Windows.Forms.Label nameLabel;
        private CustomButton allPurchase;
        private CustomButton customButton1;
        private DataSet1TableAdapters.CARTTableAdapter cartTableAdapter1;
        private DataSet1TableAdapters.PURCHASETableAdapter purchaseTableAdapter1;
    }
}
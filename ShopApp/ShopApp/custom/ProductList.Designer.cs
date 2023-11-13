
namespace ShopApp.custom
{
    partial class ProductList
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
            this.productName = new System.Windows.Forms.Label();
            this.productCard = new System.Windows.Forms.GroupBox();
            this.productPrice = new System.Windows.Forms.Label();
            this.productCategory = new System.Windows.Forms.Label();
            this.productStock = new System.Windows.Forms.Label();
            this.productSeller = new System.Windows.Forms.Label();
            this.dataSet11 = new ShopApp.DataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTTableAdapter = new ShopApp.DataSet1TableAdapters.PRODUCTTableAdapter();
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customButton1 = new ShopApp.custom.CustomButton();
            this.customButton2 = new ShopApp.custom.CustomButton();
            this.selectStock = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.costomTextBox1 = new ShopApp.textbox.CostomTextBox();
            this.cartTableAdapter1 = new ShopApp.DataSet1TableAdapters.CARTTableAdapter();
            this.productCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("던파 비트비트체 TTF", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.productName.Location = new System.Drawing.Point(100, 40);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(122, 37);
            this.productName.TabIndex = 1;
            this.productName.Text = "Name";
            this.productName.Click += new System.EventHandler(this.productName_Click);
            // 
            // productCard
            // 
            this.productCard.Controls.Add(this.productSeller);
            this.productCard.Controls.Add(this.productStock);
            this.productCard.Controls.Add(this.productCategory);
            this.productCard.Controls.Add(this.productPrice);
            this.productCard.Controls.Add(this.productName);
            this.productCard.Font = new System.Drawing.Font("던파 비트비트체 TTF", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.productCard.Location = new System.Drawing.Point(620, 12);
            this.productCard.Name = "productCard";
            this.productCard.Size = new System.Drawing.Size(317, 236);
            this.productCard.TabIndex = 2;
            this.productCard.TabStop = false;
            this.productCard.Text = "Product";
            this.productCard.Enter += new System.EventHandler(this.productCard_Enter);
            // 
            // productPrice
            // 
            this.productPrice.AutoSize = true;
            this.productPrice.Font = new System.Drawing.Font("던파 비트비트체 TTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.productPrice.Location = new System.Drawing.Point(70, 140);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(85, 27);
            this.productPrice.TabIndex = 2;
            this.productPrice.Text = "Price";
            // 
            // productCategory
            // 
            this.productCategory.AutoSize = true;
            this.productCategory.Font = new System.Drawing.Font("던파 비트비트체 TTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.productCategory.Location = new System.Drawing.Point(213, 10);
            this.productCategory.Name = "productCategory";
            this.productCategory.Size = new System.Drawing.Size(101, 20);
            this.productCategory.TabIndex = 3;
            this.productCategory.Text = "category";
            // 
            // productStock
            // 
            this.productStock.AutoSize = true;
            this.productStock.Font = new System.Drawing.Font("던파 비트비트체 TTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.productStock.Location = new System.Drawing.Point(70, 100);
            this.productStock.Name = "productStock";
            this.productStock.Size = new System.Drawing.Size(92, 27);
            this.productStock.TabIndex = 4;
            this.productStock.Text = "Stock";
            // 
            // productSeller
            // 
            this.productSeller.AutoSize = true;
            this.productSeller.Font = new System.Drawing.Font("던파 비트비트체 TTF", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.productSeller.Location = new System.Drawing.Point(70, 180);
            this.productSeller.Name = "productSeller";
            this.productSeller.Size = new System.Drawing.Size(92, 27);
            this.productSeller.TabIndex = 5;
            this.productSeller.Text = "seller";
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.pRICEDataGridViewTextBoxColumn,
            this.sTOCKDataGridViewTextBoxColumn,
            this.cATEGORYDataGridViewTextBoxColumn,
            this.sEMAILDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pRODUCTBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(545, 560);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.dataSet11;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // pIDDataGridViewTextBoxColumn
            // 
            this.pIDDataGridViewTextBoxColumn.DataPropertyName = "P_ID";
            this.pIDDataGridViewTextBoxColumn.HeaderText = "P_ID";
            this.pIDDataGridViewTextBoxColumn.Name = "pIDDataGridViewTextBoxColumn";
            this.pIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "제품명";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            // 
            // pRICEDataGridViewTextBoxColumn
            // 
            this.pRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "가격";
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            // 
            // sTOCKDataGridViewTextBoxColumn
            // 
            this.sTOCKDataGridViewTextBoxColumn.DataPropertyName = "STOCK";
            this.sTOCKDataGridViewTextBoxColumn.HeaderText = "재고";
            this.sTOCKDataGridViewTextBoxColumn.Name = "sTOCKDataGridViewTextBoxColumn";
            // 
            // cATEGORYDataGridViewTextBoxColumn
            // 
            this.cATEGORYDataGridViewTextBoxColumn.DataPropertyName = "CATEGORY";
            this.cATEGORYDataGridViewTextBoxColumn.HeaderText = "카테고리";
            this.cATEGORYDataGridViewTextBoxColumn.Name = "cATEGORYDataGridViewTextBoxColumn";
            // 
            // sEMAILDataGridViewTextBoxColumn
            // 
            this.sEMAILDataGridViewTextBoxColumn.DataPropertyName = "S_EMAIL";
            this.sEMAILDataGridViewTextBoxColumn.HeaderText = "판매자";
            this.sEMAILDataGridViewTextBoxColumn.Name = "sEMAILDataGridViewTextBoxColumn";
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.customButton1.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.customButton1.BorderRadius = 40;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("던파 비트비트체 TTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(620, 456);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(150, 40);
            this.customButton1.TabIndex = 4;
            this.customButton1.Text = "구매";
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.customButton2.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.customButton2.BorderRadius = 40;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("던파 비트비트체 TTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(776, 456);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(150, 40);
            this.customButton2.TabIndex = 5;
            this.customButton2.Text = "장바구니 담기";
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // selectStock
            // 
            this.selectStock.Font = new System.Drawing.Font("던파 비트비트체 TTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.selectStock.FormattingEnabled = true;
            this.selectStock.Location = new System.Drawing.Point(727, 285);
            this.selectStock.Name = "selectStock";
            this.selectStock.Size = new System.Drawing.Size(121, 28);
            this.selectStock.TabIndex = 6;
            this.selectStock.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("던파 비트비트체 TTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(678, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "수량";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("던파 비트비트체 TTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(645, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "구매일자";
            // 
            // costomTextBox1
            // 
            this.costomTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.costomTextBox1.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.costomTextBox1.BorderSize = 2;
            this.costomTextBox1.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.costomTextBox1.Location = new System.Drawing.Point(729, 331);
            this.costomTextBox1.Name = "costomTextBox1";
            this.costomTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.costomTextBox1.PasswordChar = false;
            this.costomTextBox1.Size = new System.Drawing.Size(174, 35);
            this.costomTextBox1.TabIndex = 8;
            this.costomTextBox1.Texts = "";
            this.costomTextBox1.UnderlinedStyle = true;
            // 
            // cartTableAdapter1
            // 
            this.cartTableAdapter1.ClearBeforeFill = true;
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 560);
            this.Controls.Add(this.costomTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectStock);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.productCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductList";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.productCard.ResumeLayout(false);
            this.productCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.GroupBox productCard;
        private System.Windows.Forms.Label productSeller;
        private System.Windows.Forms.Label productStock;
        private System.Windows.Forms.Label productCategory;
        private System.Windows.Forms.Label productPrice;
        private DataSet1 dataSet11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private DataSet1TableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOCKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGORYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEMAILDataGridViewTextBoxColumn;
        private CustomButton customButton1;
        private CustomButton customButton2;
        private System.Windows.Forms.ComboBox selectStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private textbox.CostomTextBox costomTextBox1;
        private DataSet1TableAdapters.CARTTableAdapter cartTableAdapter1;
    }
}
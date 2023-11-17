
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
            this.pURCHASEVIEW1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ShopApp.DataSet1();
            this.pURCHASE_VIEW1TableAdapter = new ShopApp.DataSet1TableAdapters.PURCHASE_VIEW1TableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorTextBox = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sellerLabel = new System.Windows.Forms.Label();
            this.p_stockLabel = new System.Windows.Forms.Label();
            this.p_priceLabel = new System.Windows.Forms.Label();
            this.allowLabel = new System.Windows.Forms.Label();
            this.stockLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.purchaseTableAdapter1 = new ShopApp.DataSet1TableAdapters.PURCHASETableAdapter();
            this.customButton2 = new ShopApp.custom.CustomButton();
            this.customButton3 = new ShopApp.custom.CustomButton();
            this.customButton1 = new ShopApp.custom.CustomButton();
            this.allowFilterButton4 = new ShopApp.custom.CustomButton();
            this.allowFilterButton3 = new ShopApp.custom.CustomButton();
            this.allowFilterButton2 = new ShopApp.custom.CustomButton();
            this.allowFilterButton1 = new ShopApp.custom.CustomButton();
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASEVIEW1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.Column1});
            this.dataGridView1.DataSource = this.pURCHASEVIEW1BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1010, 305);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
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
            this.panel1.Controls.Add(this.customButton2);
            this.panel1.Controls.Add(this.customButton3);
            this.panel1.Controls.Add(this.customButton1);
            this.panel1.Controls.Add(this.errorTextBox);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.allowFilterButton4);
            this.panel1.Controls.Add(this.allowFilterButton3);
            this.panel1.Controls.Add(this.allowFilterButton2);
            this.panel1.Controls.Add(this.allowFilterButton1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 561);
            this.panel1.TabIndex = 1;
            // 
            // errorTextBox
            // 
            this.errorTextBox.AutoSize = true;
            this.errorTextBox.Font = new System.Drawing.Font("던파 비트비트체 TTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.errorTextBox.Location = new System.Drawing.Point(667, 327);
            this.errorTextBox.Name = "errorTextBox";
            this.errorTextBox.Size = new System.Drawing.Size(100, 20);
            this.errorTextBox.TabIndex = 24;
            this.errorTextBox.Text = "erroText";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sellerLabel);
            this.groupBox1.Controls.Add(this.p_stockLabel);
            this.groupBox1.Controls.Add(this.p_priceLabel);
            this.groupBox1.Controls.Add(this.allowLabel);
            this.groupBox1.Controls.Add(this.stockLabel);
            this.groupBox1.Controls.Add(this.priceLabel);
            this.groupBox1.Controls.Add(this.timeLabel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.categoryLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 237);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase Info";
            // 
            // sellerLabel
            // 
            this.sellerLabel.AutoSize = true;
            this.sellerLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sellerLabel.Location = new System.Drawing.Point(442, 116);
            this.sellerLabel.Name = "sellerLabel";
            this.sellerLabel.Size = new System.Drawing.Size(78, 26);
            this.sellerLabel.TabIndex = 23;
            this.sellerLabel.Text = "판매자";
            // 
            // p_stockLabel
            // 
            this.p_stockLabel.AutoSize = true;
            this.p_stockLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.p_stockLabel.Location = new System.Drawing.Point(442, 147);
            this.p_stockLabel.Name = "p_stockLabel";
            this.p_stockLabel.Size = new System.Drawing.Size(100, 26);
            this.p_stockLabel.TabIndex = 22;
            this.p_stockLabel.Text = "구매수량";
            // 
            // p_priceLabel
            // 
            this.p_priceLabel.AutoSize = true;
            this.p_priceLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.p_priceLabel.Location = new System.Drawing.Point(442, 176);
            this.p_priceLabel.Name = "p_priceLabel";
            this.p_priceLabel.Size = new System.Drawing.Size(100, 26);
            this.p_priceLabel.TabIndex = 21;
            this.p_priceLabel.Text = "전체가격";
            // 
            // allowLabel
            // 
            this.allowLabel.AutoSize = true;
            this.allowLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.allowLabel.Location = new System.Drawing.Point(135, 116);
            this.allowLabel.Name = "allowLabel";
            this.allowLabel.Size = new System.Drawing.Size(100, 26);
            this.allowLabel.TabIndex = 20;
            this.allowLabel.Text = "구매상태";
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.stockLabel.Location = new System.Drawing.Point(135, 147);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(100, 26);
            this.stockLabel.TabIndex = 19;
            this.stockLabel.Text = "제품재고";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.priceLabel.Location = new System.Drawing.Point(178, 176);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(100, 26);
            this.priceLabel.TabIndex = 18;
            this.priceLabel.Text = "제품가격";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeLabel.Location = new System.Drawing.Point(135, 85);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(100, 26);
            this.timeLabel.TabIndex = 17;
            this.timeLabel.Text = "구매시간";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("던파 비트비트체 TTF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(358, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 26);
            this.label8.TabIndex = 16;
            this.label8.Text = "판매자 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("던파 비트비트체 TTF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(336, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "구매수량 :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("던파 비트비트체 TTF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.Location = new System.Drawing.Point(29, 116);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 26);
            this.label20.TabIndex = 14;
            this.label20.Text = "구매상태 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("던파 비트비트체 TTF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(336, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "전체가격 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("던파 비트비트체 TTF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(29, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "제품재고 :";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.categoryLabel.Location = new System.Drawing.Point(516, 48);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(100, 26);
            this.categoryLabel.TabIndex = 9;
            this.categoryLabel.Text = "카테고리";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("던파 비트비트체 TTF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(29, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "현재제품가격 :";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nameLabel.Location = new System.Drawing.Point(28, 40);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(105, 35);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "제품명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("던파 비트비트체 TTF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(29, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "구매시간 :";
            // 
            // purchaseTableAdapter1
            // 
            this.purchaseTableAdapter1.ClearBeforeFill = true;
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.customButton2.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.customButton2.BorderRadius = 40;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(671, 366);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(150, 40);
            this.customButton2.TabIndex = 27;
            this.customButton2.Text = "환불 요청";
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.customButton3.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.customButton3.BorderRadius = 40;
            this.customButton3.BorderSize = 0;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customButton3.ForeColor = System.Drawing.Color.White;
            this.customButton3.Location = new System.Drawing.Point(840, 366);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(150, 40);
            this.customButton3.TabIndex = 26;
            this.customButton3.Text = "환불 요청 취소";
            this.customButton3.UseVisualStyleBackColor = false;
            this.customButton3.Click += new System.EventHandler(this.customButton3_Click);
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
            this.customButton1.Location = new System.Drawing.Point(671, 412);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(150, 40);
            this.customButton1.TabIndex = 25;
            this.customButton1.Text = "구매요청 내역조회";
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
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
            this.allowFilterButton4.Location = new System.Drawing.Point(757, 508);
            this.allowFilterButton4.Name = "allowFilterButton4";
            this.allowFilterButton4.Size = new System.Drawing.Size(150, 40);
            this.allowFilterButton4.TabIndex = 5;
            this.allowFilterButton4.Text = "전체 내역 조회";
            this.allowFilterButton4.UseVisualStyleBackColor = false;
            this.allowFilterButton4.Click += new System.EventHandler(this.allowFilterButton4_Click);
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
            this.allowFilterButton3.Location = new System.Drawing.Point(840, 458);
            this.allowFilterButton3.Name = "allowFilterButton3";
            this.allowFilterButton3.Size = new System.Drawing.Size(150, 40);
            this.allowFilterButton3.TabIndex = 4;
            this.allowFilterButton3.Text = "환불된 내역조회";
            this.allowFilterButton3.UseVisualStyleBackColor = false;
            this.allowFilterButton3.Click += new System.EventHandler(this.allowFilterButton3_Click);
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
            this.allowFilterButton2.Location = new System.Drawing.Point(671, 458);
            this.allowFilterButton2.Name = "allowFilterButton2";
            this.allowFilterButton2.Size = new System.Drawing.Size(150, 40);
            this.allowFilterButton2.TabIndex = 3;
            this.allowFilterButton2.Text = "환불요청 내역조회";
            this.allowFilterButton2.UseVisualStyleBackColor = false;
            this.allowFilterButton2.Click += new System.EventHandler(this.allowFilterButton2_Click);
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
            this.allowFilterButton1.Location = new System.Drawing.Point(840, 412);
            this.allowFilterButton1.Name = "allowFilterButton1";
            this.allowFilterButton1.Size = new System.Drawing.Size(150, 40);
            this.allowFilterButton1.TabIndex = 2;
            this.allowFilterButton1.Text = "구매된 내역조회";
            this.allowFilterButton1.UseVisualStyleBackColor = false;
            this.allowFilterButton1.Click += new System.EventHandler(this.allowFilterButton1_Click);
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
            this.aLLOWDataGridViewTextBoxColumn.HeaderText = "구매상태";
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
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "현재제품가격";
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
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASEVIEW1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pURCHASEVIEW1BindingSource;
        private DataSet1TableAdapters.PURCHASE_VIEW1TableAdapter pURCHASE_VIEW1TableAdapter;
        private System.Windows.Forms.Panel panel1;
        private CustomButton allowFilterButton4;
        private CustomButton allowFilterButton3;
        private CustomButton allowFilterButton2;
        private CustomButton allowFilterButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label sellerLabel;
        private System.Windows.Forms.Label p_stockLabel;
        private System.Windows.Forms.Label p_priceLabel;
        private System.Windows.Forms.Label allowLabel;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errorTextBox;
        private CustomButton customButton1;
        private CustomButton customButton2;
        private CustomButton customButton3;
        private DataSet1TableAdapters.PURCHASETableAdapter purchaseTableAdapter1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
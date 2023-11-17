
namespace ShopApp.custom
{
    partial class AdminProductRegister
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
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ShopApp.DataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.sEMAILDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pASSWORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sELLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTTableAdapter = new ShopApp.DataSet1TableAdapters.PRODUCTTableAdapter();
            this.sELLERTableAdapter = new ShopApp.DataSet1TableAdapters.SELLERTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.registerTextBox = new ShopApp.custom.CustomButton();
            this.sellerTextBox = new ShopApp.textbox.CostomTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.stockTextBox = new ShopApp.textbox.CostomTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.categoryTextBox = new ShopApp.textbox.CostomTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.priceTextBox = new ShopApp.textbox.CostomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new ShopApp.textbox.CostomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.p_idTextBox = new ShopApp.textbox.CostomTextBox();
            this.errorText = new System.Windows.Forms.Label();
            this.customButton4 = new ShopApp.custom.CustomButton();
            this.customButton3 = new ShopApp.custom.CustomButton();
            this.customButton2 = new ShopApp.custom.CustomButton();
            this.customButton1 = new ShopApp.custom.CustomButton();
            this.notificationTableAdapter1 = new ShopApp.DataSet1TableAdapters.NOTIFICATIONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sELLERBindingSource)).BeginInit();
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
            this.dataGridView1.Size = new System.Drawing.Size(644, 346);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // pIDDataGridViewTextBoxColumn
            // 
            this.pIDDataGridViewTextBoxColumn.DataPropertyName = "P_ID";
            this.pIDDataGridViewTextBoxColumn.HeaderText = "제품코드";
            this.pIDDataGridViewTextBoxColumn.Name = "pIDDataGridViewTextBoxColumn";
            this.pIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.sTOCKDataGridViewTextBoxColumn.HeaderText = "수량";
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
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 346);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sEMAILDataGridViewTextBoxColumn1,
            this.pASSWORDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.sELLERBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView2.Location = new System.Drawing.Point(643, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(367, 346);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseClick);
            // 
            // sEMAILDataGridViewTextBoxColumn1
            // 
            this.sEMAILDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sEMAILDataGridViewTextBoxColumn1.DataPropertyName = "S_EMAIL";
            this.sEMAILDataGridViewTextBoxColumn1.HeaderText = "판매자 이메일";
            this.sEMAILDataGridViewTextBoxColumn1.Name = "sEMAILDataGridViewTextBoxColumn1";
            this.sEMAILDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pASSWORDDataGridViewTextBoxColumn
            // 
            this.pASSWORDDataGridViewTextBoxColumn.DataPropertyName = "PASSWORD";
            this.pASSWORDDataGridViewTextBoxColumn.HeaderText = "PASSWORD";
            this.pASSWORDDataGridViewTextBoxColumn.Name = "pASSWORDDataGridViewTextBoxColumn";
            this.pASSWORDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pASSWORDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nAMEDataGridViewTextBoxColumn1
            // 
            this.nAMEDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nAMEDataGridViewTextBoxColumn1.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn1.HeaderText = "판매자 이름";
            this.nAMEDataGridViewTextBoxColumn1.Name = "nAMEDataGridViewTextBoxColumn1";
            this.nAMEDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sELLERBindingSource
            // 
            this.sELLERBindingSource.DataMember = "SELLER";
            this.sELLERBindingSource.DataSource = this.dataSet1;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // sELLERTableAdapter
            // 
            this.sELLERTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("던파 비트비트체 TTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "제품 코드";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.registerTextBox);
            this.groupBox1.Controls.Add(this.sellerTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.stockTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.categoryTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.p_idTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 196);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Info";
            // 
            // registerTextBox
            // 
            this.registerTextBox.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.registerTextBox.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.registerTextBox.BorderRadius = 40;
            this.registerTextBox.BorderSize = 0;
            this.registerTextBox.FlatAppearance.BorderSize = 0;
            this.registerTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerTextBox.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.registerTextBox.ForeColor = System.Drawing.Color.White;
            this.registerTextBox.Location = new System.Drawing.Point(323, 120);
            this.registerTextBox.Name = "registerTextBox";
            this.registerTextBox.Size = new System.Drawing.Size(150, 40);
            this.registerTextBox.TabIndex = 14;
            this.registerTextBox.Text = "등록/수정";
            this.registerTextBox.UseVisualStyleBackColor = false;
            this.registerTextBox.Click += new System.EventHandler(this.registerTextBox_Click);
            // 
            // sellerTextBox
            // 
            this.sellerTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.sellerTextBox.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.sellerTextBox.BorderSize = 2;
            this.sellerTextBox.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sellerTextBox.Location = new System.Drawing.Point(366, 65);
            this.sellerTextBox.Multiline = false;
            this.sellerTextBox.Name = "sellerTextBox";
            this.sellerTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.sellerTextBox.PasswordChar = false;
            this.sellerTextBox.Size = new System.Drawing.Size(150, 35);
            this.sellerTextBox.TabIndex = 12;
            this.sellerTextBox.Texts = "";
            this.sellerTextBox.UnderlinedStyle = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("던파 비트비트체 TTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(285, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "판매자";
            // 
            // stockTextBox
            // 
            this.stockTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.stockTextBox.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.stockTextBox.BorderSize = 2;
            this.stockTextBox.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.stockTextBox.Location = new System.Drawing.Point(366, 30);
            this.stockTextBox.Multiline = false;
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.stockTextBox.PasswordChar = false;
            this.stockTextBox.Size = new System.Drawing.Size(150, 35);
            this.stockTextBox.TabIndex = 10;
            this.stockTextBox.Texts = "";
            this.stockTextBox.UnderlinedStyle = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("던파 비트비트체 TTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(290, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "재고";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.categoryTextBox.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.categoryTextBox.BorderSize = 2;
            this.categoryTextBox.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.categoryTextBox.Location = new System.Drawing.Point(100, 135);
            this.categoryTextBox.Multiline = false;
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.categoryTextBox.PasswordChar = false;
            this.categoryTextBox.Size = new System.Drawing.Size(150, 35);
            this.categoryTextBox.TabIndex = 8;
            this.categoryTextBox.Texts = "";
            this.categoryTextBox.UnderlinedStyle = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("던파 비트비트체 TTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(13, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "카테고리";
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.priceTextBox.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.priceTextBox.BorderSize = 2;
            this.priceTextBox.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.priceTextBox.Location = new System.Drawing.Point(100, 100);
            this.priceTextBox.Multiline = false;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.priceTextBox.PasswordChar = false;
            this.priceTextBox.Size = new System.Drawing.Size(150, 35);
            this.priceTextBox.TabIndex = 6;
            this.priceTextBox.Texts = "";
            this.priceTextBox.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("던파 비트비트체 TTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(30, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "가격";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.nameTextBox.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.nameTextBox.BorderSize = 2;
            this.nameTextBox.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nameTextBox.Location = new System.Drawing.Point(100, 65);
            this.nameTextBox.Multiline = false;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.nameTextBox.PasswordChar = false;
            this.nameTextBox.Size = new System.Drawing.Size(150, 35);
            this.nameTextBox.TabIndex = 4;
            this.nameTextBox.Texts = "";
            this.nameTextBox.UnderlinedStyle = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("던파 비트비트체 TTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "제품명";
            // 
            // p_idTextBox
            // 
            this.p_idTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.p_idTextBox.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.p_idTextBox.BorderSize = 2;
            this.p_idTextBox.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.p_idTextBox.Location = new System.Drawing.Point(100, 30);
            this.p_idTextBox.Multiline = false;
            this.p_idTextBox.Name = "p_idTextBox";
            this.p_idTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.p_idTextBox.PasswordChar = false;
            this.p_idTextBox.Size = new System.Drawing.Size(150, 35);
            this.p_idTextBox.TabIndex = 2;
            this.p_idTextBox.Texts = "";
            this.p_idTextBox.UnderlinedStyle = true;
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.errorText.Location = new System.Drawing.Point(640, 393);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(100, 18);
            this.errorText.TabIndex = 19;
            this.errorText.Text = "errorText";
            // 
            // customButton4
            // 
            this.customButton4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.customButton4.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.customButton4.BorderRadius = 40;
            this.customButton4.BorderSize = 0;
            this.customButton4.FlatAppearance.BorderSize = 0;
            this.customButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton4.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customButton4.ForeColor = System.Drawing.Color.White;
            this.customButton4.Location = new System.Drawing.Point(810, 489);
            this.customButton4.Name = "customButton4";
            this.customButton4.Size = new System.Drawing.Size(150, 40);
            this.customButton4.TabIndex = 18;
            this.customButton4.Text = "등록/수정";
            this.customButton4.UseVisualStyleBackColor = false;
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
            this.customButton3.Location = new System.Drawing.Point(810, 423);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(150, 40);
            this.customButton3.TabIndex = 17;
            this.customButton3.Text = "등록/수정";
            this.customButton3.UseVisualStyleBackColor = false;
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
            this.customButton2.Location = new System.Drawing.Point(629, 489);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(150, 40);
            this.customButton2.TabIndex = 16;
            this.customButton2.Text = "등록/수정";
            this.customButton2.UseVisualStyleBackColor = false;
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
            this.customButton1.Location = new System.Drawing.Point(629, 423);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(150, 40);
            this.customButton1.TabIndex = 15;
            this.customButton1.Text = "등록정보 비우기";
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // notificationTableAdapter1
            // 
            this.notificationTableAdapter1.ClearBeforeFill = true;
            // 
            // AdminProductRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1010, 560);
            this.Controls.Add(this.errorText);
            this.Controls.Add(this.customButton4);
            this.Controls.Add(this.customButton3);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("던파 비트비트체 TTF", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminProductRegister";
            this.Text = "AdminProductRegister";
            this.Load += new System.EventHandler(this.AdminProductRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sELLERBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private DataSet1TableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOCKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGORYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource sELLERBindingSource;
        private DataSet1TableAdapters.SELLERTableAdapter sELLERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEMAILDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASSWORDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn1;
        private textbox.CostomTextBox p_idTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private CustomButton registerTextBox;
        private textbox.CostomTextBox sellerTextBox;
        private System.Windows.Forms.Label label6;
        private textbox.CostomTextBox stockTextBox;
        private System.Windows.Forms.Label label5;
        private textbox.CostomTextBox categoryTextBox;
        private System.Windows.Forms.Label label4;
        private textbox.CostomTextBox priceTextBox;
        private System.Windows.Forms.Label label3;
        private textbox.CostomTextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private CustomButton customButton1;
        private CustomButton customButton2;
        private CustomButton customButton3;
        private CustomButton customButton4;
        private System.Windows.Forms.Label errorText;
        private DataSet1TableAdapters.NOTIFICATIONTableAdapter notificationTableAdapter1;
    }
}
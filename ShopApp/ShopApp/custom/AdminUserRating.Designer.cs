
namespace ShopApp.custom
{
    partial class AdminUserRating
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
            this.dataSet1 = new ShopApp.DataSet1();
            this.cUSTOMERVIEW1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pASSWORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rATINGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALECOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEFUNDCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.customButton1 = new ShopApp.custom.CustomButton();
            this.errorLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.allPrice = new System.Windows.Forms.Label();
            this.refund = new System.Windows.Forms.Label();
            this.sale_count = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.c_emailLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.customerTableAdapter1 = new ShopApp.DataSet1TableAdapters.CUSTOMERTableAdapter();
            this.customeR_VIEW_RATING1TableAdapter1 = new ShopApp.DataSet1TableAdapters.CUSTOMER_VIEW_RATING1TableAdapter();
            this.cUSTOMER_VIEW1TableAdapter1 = new ShopApp.DataSet1TableAdapters.CUSTOMER_VIEW1TableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERVIEW1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERVIEW1BindingSource
            // 
            this.cUSTOMERVIEW1BindingSource.DataMember = "CUSTOMER_VIEW1";
            this.cUSTOMERVIEW1BindingSource.DataSource = this.dataSet1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cEMAILDataGridViewTextBoxColumn,
            this.pASSWORDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.rATINGDataGridViewTextBoxColumn,
            this.sALECOUNTDataGridViewTextBoxColumn,
            this.rEFUNDCOUNTDataGridViewTextBoxColumn,
            this.pRICEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cUSTOMERVIEW1BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(745, 560);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // cEMAILDataGridViewTextBoxColumn
            // 
            this.cEMAILDataGridViewTextBoxColumn.DataPropertyName = "C_EMAIL";
            this.cEMAILDataGridViewTextBoxColumn.HeaderText = "아이디";
            this.cEMAILDataGridViewTextBoxColumn.Name = "cEMAILDataGridViewTextBoxColumn";
            this.cEMAILDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pASSWORDDataGridViewTextBoxColumn
            // 
            this.pASSWORDDataGridViewTextBoxColumn.DataPropertyName = "PASSWORD";
            this.pASSWORDDataGridViewTextBoxColumn.HeaderText = "비밀번호";
            this.pASSWORDDataGridViewTextBoxColumn.Name = "pASSWORDDataGridViewTextBoxColumn";
            this.pASSWORDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "이름";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rATINGDataGridViewTextBoxColumn
            // 
            this.rATINGDataGridViewTextBoxColumn.DataPropertyName = "RATING";
            this.rATINGDataGridViewTextBoxColumn.HeaderText = "등급";
            this.rATINGDataGridViewTextBoxColumn.Name = "rATINGDataGridViewTextBoxColumn";
            this.rATINGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sALECOUNTDataGridViewTextBoxColumn
            // 
            this.sALECOUNTDataGridViewTextBoxColumn.DataPropertyName = "SALE_COUNT";
            this.sALECOUNTDataGridViewTextBoxColumn.HeaderText = "구매횟수";
            this.sALECOUNTDataGridViewTextBoxColumn.Name = "sALECOUNTDataGridViewTextBoxColumn";
            this.sALECOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rEFUNDCOUNTDataGridViewTextBoxColumn
            // 
            this.rEFUNDCOUNTDataGridViewTextBoxColumn.DataPropertyName = "REFUND_COUNT";
            this.rEFUNDCOUNTDataGridViewTextBoxColumn.HeaderText = "환불횟수";
            this.rEFUNDCOUNTDataGridViewTextBoxColumn.Name = "rEFUNDCOUNTDataGridViewTextBoxColumn";
            this.rEFUNDCOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRICEDataGridViewTextBoxColumn
            // 
            this.pRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "총구매금액";
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            this.pRICEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(795, 457);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 26);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Visible = false;
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
            this.customButton1.Location = new System.Drawing.Point(796, 489);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(159, 40);
            this.customButton1.TabIndex = 4;
            this.customButton1.Text = "유저 등급 변경";
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Visible = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(766, 420);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(105, 18);
            this.errorLabel.TabIndex = 5;
            this.errorLabel.Text = "errorLabel";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.errorLabel);
            this.panel1.Controls.Add(this.customButton1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 560);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.allPrice);
            this.groupBox1.Controls.Add(this.refund);
            this.groupBox1.Controls.Add(this.sale_count);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ratingLabel);
            this.groupBox1.Controls.Add(this.passwordLabel);
            this.groupBox1.Controls.Add(this.c_emailLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Location = new System.Drawing.Point(751, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 273);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Info";
            // 
            // allPrice
            // 
            this.allPrice.AutoSize = true;
            this.allPrice.Font = new System.Drawing.Font("던파 비트비트체 TTF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.allPrice.Location = new System.Drawing.Point(122, 235);
            this.allPrice.Name = "allPrice";
            this.allPrice.Size = new System.Drawing.Size(123, 22);
            this.allPrice.TabIndex = 12;
            this.allPrice.Text = "ALLPRICE";
            // 
            // refund
            // 
            this.refund.AutoSize = true;
            this.refund.Font = new System.Drawing.Font("던파 비트비트체 TTF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.refund.Location = new System.Drawing.Point(122, 205);
            this.refund.Name = "refund";
            this.refund.Size = new System.Drawing.Size(100, 22);
            this.refund.TabIndex = 11;
            this.refund.Text = "REFUND";
            // 
            // sale_count
            // 
            this.sale_count.AutoSize = true;
            this.sale_count.Font = new System.Drawing.Font("던파 비트비트체 TTF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sale_count.Location = new System.Drawing.Point(123, 175);
            this.sale_count.Name = "sale_count";
            this.sale_count.Size = new System.Drawing.Size(67, 22);
            this.sale_count.TabIndex = 10;
            this.sale_count.Text = "SALE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("던파 비트비트체 TTF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(1, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "총 구매금액 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("던파 비트비트체 TTF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(23, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "환불횟수 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("던파 비트비트체 TTF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(23, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "구매횟수 :";
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ratingLabel.Location = new System.Drawing.Point(123, 145);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(99, 22);
            this.ratingLabel.TabIndex = 6;
            this.ratingLabel.Text = "RATING";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.passwordLabel.Location = new System.Drawing.Point(122, 115);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(49, 22);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "PW";
            // 
            // c_emailLabel
            // 
            this.c_emailLabel.AutoSize = true;
            this.c_emailLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.c_emailLabel.Location = new System.Drawing.Point(123, 85);
            this.c_emailLabel.Name = "c_emailLabel";
            this.c_emailLabel.Size = new System.Drawing.Size(38, 22);
            this.c_emailLabel.TabIndex = 4;
            this.c_emailLabel.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("던파 비트비트체 TTF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(23, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "유저등급 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("던파 비트비트체 TTF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(23, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "비밀번호 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("던파 비트비트체 TTF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(41, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "아이디 :";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nameLabel.Location = new System.Drawing.Point(41, 33);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(107, 33);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // customeR_VIEW_RATING1TableAdapter1
            // 
            this.customeR_VIEW_RATING1TableAdapter1.ClearBeforeFill = true;
            // 
            // cUSTOMER_VIEW1TableAdapter1
            // 
            this.cUSTOMER_VIEW1TableAdapter1.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("던파 비트비트체 TTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(766, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 150);
            this.label7.TabIndex = 6;
            this.label7.Text = "TERRIBLE : \r\n구매금액 0원 AND 환불횟수 > 1\r\nBAD : 구매금액 - 환불금액 < 0\r\nNORMAL : 구매금액 < 100,000" +
    "\r\nGOLD : 구매금액 > 100,000\r\nPLATINUM : 구매금액 > 500,000\r\nVIP : 구매금액 > 1,000,000\r\nVVIP" +
    " : 구매금액 > 1,500,000\r\n\r\n\r\n";
            // 
            // AdminUserRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 560);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminUserRating";
            this.Text = "AdminUserRating";
            this.Load += new System.EventHandler(this.AdminUserRating_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERVIEW1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cUSTOMERVIEW1BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASSWORDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rATINGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALECOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEFUNDCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private CustomButton customButton1;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label c_emailLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameLabel;
        private DataSet1TableAdapters.CUSTOMERTableAdapter customerTableAdapter1;
        private System.Windows.Forms.Label allPrice;
        private System.Windows.Forms.Label refund;
        private System.Windows.Forms.Label sale_count;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private DataSet1TableAdapters.CUSTOMER_VIEW_RATING1TableAdapter customeR_VIEW_RATING1TableAdapter1;
        private DataSet1TableAdapters.CUSTOMER_VIEW1TableAdapter cUSTOMER_VIEW1TableAdapter1;
        private System.Windows.Forms.Label label7;
    }
}
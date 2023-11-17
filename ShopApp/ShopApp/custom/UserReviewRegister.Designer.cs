
namespace ShopApp.custom
{
    partial class UserReviewRegister
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
            this.pURCHASEVIEW1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ShopApp.DataSet1();
            this.pURCHASE_VIEW1TableAdapter = new ShopApp.DataSet1TableAdapters.PURCHASE_VIEW1TableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSTOCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLLOWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pURCHASEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.c_emailLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.customButton4 = new ShopApp.custom.CustomButton();
            this.contentLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.rEVIEWVIEW1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEVIEW_VIEW1TableAdapter = new ShopApp.DataSet1TableAdapters.REVIEW_VIEW1TableAdapter();
            this.reviewTableAdapter1 = new ShopApp.DataSet1TableAdapters.REVIEWTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASEVIEW1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rEVIEWVIEW1BindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 560);
            this.panel1.TabIndex = 1;
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
            this.nAMEDataGridViewTextBoxColumn,
            this.pPRICEDataGridViewTextBoxColumn,
            this.pSTOCKDataGridViewTextBoxColumn,
            this.aLLOWDataGridViewTextBoxColumn,
            this.pRICEDataGridViewTextBoxColumn,
            this.sTOCKDataGridViewTextBoxColumn,
            this.cATEGORYDataGridViewTextBoxColumn,
            this.pURCHASEDATEDataGridViewTextBoxColumn,
            this.sEMAILDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pURCHASEVIEW1BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(643, 560);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
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
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "제품명";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.aLLOWDataGridViewTextBoxColumn.HeaderText = "ALLOW";
            this.aLLOWDataGridViewTextBoxColumn.Name = "aLLOWDataGridViewTextBoxColumn";
            this.aLLOWDataGridViewTextBoxColumn.ReadOnly = true;
            this.aLLOWDataGridViewTextBoxColumn.Visible = false;
            // 
            // pRICEDataGridViewTextBoxColumn
            // 
            this.pRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "개당가격";
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            this.pRICEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTOCKDataGridViewTextBoxColumn
            // 
            this.sTOCKDataGridViewTextBoxColumn.DataPropertyName = "STOCK";
            this.sTOCKDataGridViewTextBoxColumn.HeaderText = "STOCK";
            this.sTOCKDataGridViewTextBoxColumn.Name = "sTOCKDataGridViewTextBoxColumn";
            this.sTOCKDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTOCKDataGridViewTextBoxColumn.Visible = false;
            // 
            // cATEGORYDataGridViewTextBoxColumn
            // 
            this.cATEGORYDataGridViewTextBoxColumn.DataPropertyName = "CATEGORY";
            this.cATEGORYDataGridViewTextBoxColumn.HeaderText = "카테고리";
            this.cATEGORYDataGridViewTextBoxColumn.Name = "cATEGORYDataGridViewTextBoxColumn";
            this.cATEGORYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pURCHASEDATEDataGridViewTextBoxColumn
            // 
            this.pURCHASEDATEDataGridViewTextBoxColumn.DataPropertyName = "PURCHASE_DATE";
            this.pURCHASEDATEDataGridViewTextBoxColumn.HeaderText = "구매시간";
            this.pURCHASEDATEDataGridViewTextBoxColumn.Name = "pURCHASEDATEDataGridViewTextBoxColumn";
            this.pURCHASEDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sEMAILDataGridViewTextBoxColumn
            // 
            this.sEMAILDataGridViewTextBoxColumn.DataPropertyName = "S_EMAIL";
            this.sEMAILDataGridViewTextBoxColumn.HeaderText = "판매자";
            this.sEMAILDataGridViewTextBoxColumn.Name = "sEMAILDataGridViewTextBoxColumn";
            this.sEMAILDataGridViewTextBoxColumn.ReadOnly = true;
            this.sEMAILDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.c_emailLabel);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.timeLabel);
            this.groupBox1.Controls.Add(this.errorLabel);
            this.groupBox1.Controls.Add(this.customButton4);
            this.groupBox1.Controls.Add(this.contentLabel);
            this.groupBox1.Controls.Add(this.titleLabel);
            this.groupBox1.Controls.Add(this.titleTextBox);
            this.groupBox1.Controls.Add(this.contentTextBox);
            this.groupBox1.Location = new System.Drawing.Point(646, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 554);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Review Create";
            // 
            // c_emailLabel
            // 
            this.c_emailLabel.AutoSize = true;
            this.c_emailLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.c_emailLabel.Location = new System.Drawing.Point(285, 44);
            this.c_emailLabel.Name = "c_emailLabel";
            this.c_emailLabel.Size = new System.Drawing.Size(69, 22);
            this.c_emailLabel.TabIndex = 12;
            this.c_emailLabel.Text = "작성자";
            this.c_emailLabel.Click += new System.EventHandler(this.c_emailLabel_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nameLabel.Location = new System.Drawing.Point(5, 36);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(91, 30);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "제품명";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeLabel.Location = new System.Drawing.Point(3, 80);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(77, 20);
            this.timeLabel.TabIndex = 9;
            this.timeLabel.Text = "작성시간";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel.Location = new System.Drawing.Point(14, 517);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(88, 15);
            this.errorLabel.TabIndex = 8;
            this.errorLabel.Text = "errorLabel";
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
            this.customButton4.Location = new System.Drawing.Point(85, 465);
            this.customButton4.Name = "customButton4";
            this.customButton4.Size = new System.Drawing.Size(190, 40);
            this.customButton4.TabIndex = 7;
            this.customButton4.Text = "리뷰 등록/수정";
            this.customButton4.UseVisualStyleBackColor = false;
            this.customButton4.Click += new System.EventHandler(this.customButton4_Click);
            // 
            // contentLabel
            // 
            this.contentLabel.AutoSize = true;
            this.contentLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.contentLabel.Location = new System.Drawing.Point(3, 164);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Size = new System.Drawing.Size(71, 15);
            this.contentLabel.TabIndex = 3;
            this.contentLabel.Text = "Content";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.titleLabel.Location = new System.Drawing.Point(3, 110);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(42, 15);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Title";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(3, 128);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(346, 28);
            this.titleTextBox.TabIndex = 1;
            // 
            // contentTextBox
            // 
            this.contentTextBox.Location = new System.Drawing.Point(6, 182);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(343, 277);
            this.contentTextBox.TabIndex = 0;
            // 
            // rEVIEWVIEW1BindingSource
            // 
            this.rEVIEWVIEW1BindingSource.DataMember = "REVIEW_VIEW1";
            this.rEVIEWVIEW1BindingSource.DataSource = this.dataSet1;
            // 
            // rEVIEW_VIEW1TableAdapter
            // 
            this.rEVIEW_VIEW1TableAdapter.ClearBeforeFill = true;
            // 
            // reviewTableAdapter1
            // 
            this.reviewTableAdapter1.ClearBeforeFill = true;
            // 
            // UserReviewRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 560);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserReviewRegister";
            this.Text = "UserReviewRegister";
            this.Load += new System.EventHandler(this.UserReviewRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASEVIEW1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rEVIEWVIEW1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pURCHASEVIEW1BindingSource;
        private DataSet1TableAdapters.PURCHASE_VIEW1TableAdapter pURCHASE_VIEW1TableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource rEVIEWVIEW1BindingSource;
        private DataSet1TableAdapters.REVIEW_VIEW1TableAdapter rEVIEW_VIEW1TableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pSTOCKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLLOWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOCKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGORYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pURCHASEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label c_emailLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label errorLabel;
        private CustomButton customButton4;
        private System.Windows.Forms.Label contentLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox contentTextBox;
        private DataSet1TableAdapters.REVIEWTableAdapter reviewTableAdapter1;
    }
}
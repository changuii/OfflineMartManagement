
namespace ShopApp.custom
{
    partial class AdminNotification
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
            this.cREATIONTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTIFICATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ShopApp.DataSet1();
            this.nOTIFICATIONTableAdapter = new ShopApp.DataSet1TableAdapters.NOTIFICATIONTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.customButton4 = new ShopApp.custom.CustomButton();
            this.customButton3 = new ShopApp.custom.CustomButton();
            this.customButton2 = new ShopApp.custom.CustomButton();
            this.customButton1 = new ShopApp.custom.CustomButton();
            this.contentLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOTIFICATIONBindingSource)).BeginInit();
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
            this.cREATIONTIMEDataGridViewTextBoxColumn,
            this.tITLEDataGridViewTextBoxColumn,
            this.cONTENTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nOTIFICATIONBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(586, 560);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // cREATIONTIMEDataGridViewTextBoxColumn
            // 
            this.cREATIONTIMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cREATIONTIMEDataGridViewTextBoxColumn.DataPropertyName = "CREATION_TIME";
            this.cREATIONTIMEDataGridViewTextBoxColumn.HeaderText = "작성된시간";
            this.cREATIONTIMEDataGridViewTextBoxColumn.Name = "cREATIONTIMEDataGridViewTextBoxColumn";
            this.cREATIONTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tITLEDataGridViewTextBoxColumn
            // 
            this.tITLEDataGridViewTextBoxColumn.DataPropertyName = "TITLE";
            this.tITLEDataGridViewTextBoxColumn.HeaderText = "제목";
            this.tITLEDataGridViewTextBoxColumn.Name = "tITLEDataGridViewTextBoxColumn";
            this.tITLEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cONTENTDataGridViewTextBoxColumn
            // 
            this.cONTENTDataGridViewTextBoxColumn.DataPropertyName = "CONTENT";
            this.cONTENTDataGridViewTextBoxColumn.HeaderText = "내용";
            this.cONTENTDataGridViewTextBoxColumn.Name = "cONTENTDataGridViewTextBoxColumn";
            this.cONTENTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOTIFICATIONBindingSource
            // 
            this.nOTIFICATIONBindingSource.DataMember = "NOTIFICATION";
            this.nOTIFICATIONBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nOTIFICATIONTableAdapter
            // 
            this.nOTIFICATIONTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 560);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timeLabel);
            this.groupBox1.Controls.Add(this.errorLabel);
            this.groupBox1.Controls.Add(this.customButton4);
            this.groupBox1.Controls.Add(this.customButton3);
            this.groupBox1.Controls.Add(this.customButton2);
            this.groupBox1.Controls.Add(this.customButton1);
            this.groupBox1.Controls.Add(this.contentLabel);
            this.groupBox1.Controls.Add(this.titleLabel);
            this.groupBox1.Controls.Add(this.titleTextBox);
            this.groupBox1.Controls.Add(this.contentTextBox);
            this.groupBox1.Location = new System.Drawing.Point(592, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 545);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notification Create";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeLabel.Location = new System.Drawing.Point(3, 35);
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
            this.errorLabel.Click += new System.EventHandler(this.errorLabel_Click);
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
            this.customButton4.Location = new System.Drawing.Point(216, 467);
            this.customButton4.Name = "customButton4";
            this.customButton4.Size = new System.Drawing.Size(190, 40);
            this.customButton4.TabIndex = 7;
            this.customButton4.Text = "제목으로 공지 조회";
            this.customButton4.UseVisualStyleBackColor = false;
            this.customButton4.Click += new System.EventHandler(this.customButton4_Click);
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
            this.customButton3.Location = new System.Drawing.Point(9, 467);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(190, 40);
            this.customButton3.TabIndex = 6;
            this.customButton3.Text = "공지 삭제";
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
            this.customButton2.Location = new System.Drawing.Point(216, 421);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(190, 40);
            this.customButton2.TabIndex = 5;
            this.customButton2.Text = "등록정보 비우기";
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
            this.customButton1.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(6, 421);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(190, 40);
            this.customButton1.TabIndex = 4;
            this.customButton1.Text = "공지 등록/수정";
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // contentLabel
            // 
            this.contentLabel.AutoSize = true;
            this.contentLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.contentLabel.Location = new System.Drawing.Point(3, 119);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Size = new System.Drawing.Size(71, 15);
            this.contentLabel.TabIndex = 3;
            this.contentLabel.Text = "Content";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.titleLabel.Location = new System.Drawing.Point(3, 65);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(42, 15);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Title";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(3, 83);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(403, 28);
            this.titleTextBox.TabIndex = 1;
            // 
            // contentTextBox
            // 
            this.contentTextBox.Location = new System.Drawing.Point(6, 137);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(400, 278);
            this.contentTextBox.TabIndex = 0;
            // 
            // AdminNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 560);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminNotification";
            this.Text = "AdminNotification";
            this.Load += new System.EventHandler(this.AdminNotification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOTIFICATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource nOTIFICATIONBindingSource;
        private DataSet1TableAdapters.NOTIFICATIONTableAdapter nOTIFICATIONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREATIONTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label contentLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox contentTextBox;
        private CustomButton customButton2;
        private CustomButton customButton1;
        private System.Windows.Forms.Label errorLabel;
        private CustomButton customButton4;
        private CustomButton customButton3;
        private System.Windows.Forms.Label timeLabel;
    }
}

namespace ShopApp.custom
{
    partial class AdminProductList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.refundPStock = new System.Windows.Forms.Label();
            this.stock = new System.Windows.Forms.Label();
            this.refundRequest = new System.Windows.Forms.Label();
            this.purchaseRequest = new System.Windows.Forms.Label();
            this.refundStock = new System.Windows.Forms.Label();
            this.purchaseStock = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customButton4 = new ShopApp.custom.CustomButton();
            this.customButton3 = new ShopApp.custom.CustomButton();
            this.customButton2 = new ShopApp.custom.CustomButton();
            this.customButton1 = new ShopApp.custom.CustomButton();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALECOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEFUNDCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALEINPROGRESSCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEFUNDINPROGRESSCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEFUNDSTOCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pURCHASEVIEWPRODUCT1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new ShopApp.DataSet1();
            this.pURCHASE_VIEW_PRODUCT1TableAdapter = new ShopApp.DataSet1TableAdapters.PURCHASE_VIEW_PRODUCT1TableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASEVIEWPRODUCT1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.errorText);
            this.panel1.Controls.Add(this.customButton4);
            this.panel1.Controls.Add(this.customButton3);
            this.panel1.Controls.Add(this.customButton2);
            this.panel1.Controls.Add(this.customButton1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 560);
            this.panel1.TabIndex = 0;
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.Location = new System.Drawing.Point(751, 332);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(100, 18);
            this.errorText.TabIndex = 6;
            this.errorText.Text = "errorText";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.refundPStock);
            this.groupBox1.Controls.Add(this.stock);
            this.groupBox1.Controls.Add(this.refundRequest);
            this.groupBox1.Controls.Add(this.purchaseRequest);
            this.groupBox1.Controls.Add(this.refundStock);
            this.groupBox1.Controls.Add(this.purchaseStock);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Location = new System.Drawing.Point(749, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 325);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase Info";
            // 
            // refundPStock
            // 
            this.refundPStock.AutoSize = true;
            this.refundPStock.Font = new System.Drawing.Font("던파 비트비트체 TTF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.refundPStock.Location = new System.Drawing.Point(154, 280);
            this.refundPStock.Name = "refundPStock";
            this.refundPStock.Size = new System.Drawing.Size(88, 22);
            this.refundPStock.TabIndex = 12;
            this.refundPStock.Text = "반품수량";
            // 
            // stock
            // 
            this.stock.AutoSize = true;
            this.stock.Font = new System.Drawing.Font("던파 비트비트체 TTF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.stock.Location = new System.Drawing.Point(154, 240);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(88, 22);
            this.stock.TabIndex = 11;
            this.stock.Text = "현재재고";
            // 
            // refundRequest
            // 
            this.refundRequest.AutoSize = true;
            this.refundRequest.Font = new System.Drawing.Font("던파 비트비트체 TTF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.refundRequest.Location = new System.Drawing.Point(154, 200);
            this.refundRequest.Name = "refundRequest";
            this.refundRequest.Size = new System.Drawing.Size(87, 22);
            this.refundRequest.TabIndex = 10;
            this.refundRequest.Text = "환불요청";
            // 
            // purchaseRequest
            // 
            this.purchaseRequest.AutoSize = true;
            this.purchaseRequest.Font = new System.Drawing.Font("던파 비트비트체 TTF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.purchaseRequest.Location = new System.Drawing.Point(154, 160);
            this.purchaseRequest.Name = "purchaseRequest";
            this.purchaseRequest.Size = new System.Drawing.Size(87, 22);
            this.purchaseRequest.TabIndex = 9;
            this.purchaseRequest.Text = "구매요청";
            // 
            // refundStock
            // 
            this.refundStock.AutoSize = true;
            this.refundStock.Font = new System.Drawing.Font("던파 비트비트체 TTF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.refundStock.Location = new System.Drawing.Point(154, 120);
            this.refundStock.Name = "refundStock";
            this.refundStock.Size = new System.Drawing.Size(88, 22);
            this.refundStock.TabIndex = 8;
            this.refundStock.Text = "환불수량";
            // 
            // purchaseStock
            // 
            this.purchaseStock.AutoSize = true;
            this.purchaseStock.Font = new System.Drawing.Font("던파 비트비트체 TTF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.purchaseStock.Location = new System.Drawing.Point(154, 80);
            this.purchaseStock.Name = "purchaseStock";
            this.purchaseStock.Size = new System.Drawing.Size(88, 22);
            this.purchaseStock.TabIndex = 7;
            this.purchaseStock.Text = "구매수량";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("던파 비트비트체 TTF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(56, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "반품수량 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("던파 비트비트체 TTF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(55, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "현재재고 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("던파 비트비트체 TTF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(18, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "환불요청수량 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("던파 비트비트체 TTF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(18, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "구매요청수량 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("던파 비트비트체 TTF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(18, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "환불완료수량 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("던파 비트비트체 TTF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(18, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "구매완료수량 :";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nameLabel.Location = new System.Drawing.Point(15, 34);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(112, 35);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nAMEDataGridViewTextBoxColumn,
            this.sALECOUNTDataGridViewTextBoxColumn,
            this.rEFUNDCOUNTDataGridViewTextBoxColumn,
            this.sALEINPROGRESSCOUNTDataGridViewTextBoxColumn,
            this.rEFUNDINPROGRESSCOUNTDataGridViewTextBoxColumn,
            this.sTOCKDataGridViewTextBoxColumn,
            this.rEFUNDSTOCKDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pURCHASEVIEWPRODUCT1BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(743, 560);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // customButton4
            // 
            this.customButton4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.customButton4.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.customButton4.BorderRadius = 40;
            this.customButton4.BorderSize = 0;
            this.customButton4.FlatAppearance.BorderSize = 0;
            this.customButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton4.ForeColor = System.Drawing.Color.White;
            this.customButton4.Location = new System.Drawing.Point(754, 513);
            this.customButton4.Name = "customButton4";
            this.customButton4.Size = new System.Drawing.Size(242, 40);
            this.customButton4.TabIndex = 5;
            this.customButton4.Text = "반품 수량 순위";
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
            this.customButton3.ForeColor = System.Drawing.Color.White;
            this.customButton3.Location = new System.Drawing.Point(754, 467);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(242, 40);
            this.customButton3.TabIndex = 4;
            this.customButton3.Text = "현재 재고량 순위";
            this.customButton3.UseVisualStyleBackColor = false;
            this.customButton3.Click += new System.EventHandler(this.customButton3_Click);
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
            this.customButton2.Location = new System.Drawing.Point(754, 421);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(242, 40);
            this.customButton2.TabIndex = 3;
            this.customButton2.Text = "환불 수량 순위";
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
            this.customButton1.Location = new System.Drawing.Point(754, 375);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(242, 40);
            this.customButton1.TabIndex = 2;
            this.customButton1.Text = "구매 수량 순위";
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "제품명";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sALECOUNTDataGridViewTextBoxColumn
            // 
            this.sALECOUNTDataGridViewTextBoxColumn.DataPropertyName = "SALE_COUNT";
            this.sALECOUNTDataGridViewTextBoxColumn.HeaderText = "구매완료";
            this.sALECOUNTDataGridViewTextBoxColumn.Name = "sALECOUNTDataGridViewTextBoxColumn";
            this.sALECOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rEFUNDCOUNTDataGridViewTextBoxColumn
            // 
            this.rEFUNDCOUNTDataGridViewTextBoxColumn.DataPropertyName = "REFUND_COUNT";
            this.rEFUNDCOUNTDataGridViewTextBoxColumn.HeaderText = "환불완료";
            this.rEFUNDCOUNTDataGridViewTextBoxColumn.Name = "rEFUNDCOUNTDataGridViewTextBoxColumn";
            this.rEFUNDCOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sALEINPROGRESSCOUNTDataGridViewTextBoxColumn
            // 
            this.sALEINPROGRESSCOUNTDataGridViewTextBoxColumn.DataPropertyName = "SALE_IN_PROGRESS_COUNT";
            this.sALEINPROGRESSCOUNTDataGridViewTextBoxColumn.HeaderText = "구매요청진행중";
            this.sALEINPROGRESSCOUNTDataGridViewTextBoxColumn.Name = "sALEINPROGRESSCOUNTDataGridViewTextBoxColumn";
            this.sALEINPROGRESSCOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rEFUNDINPROGRESSCOUNTDataGridViewTextBoxColumn
            // 
            this.rEFUNDINPROGRESSCOUNTDataGridViewTextBoxColumn.DataPropertyName = "REFUND_IN_PROGRESS_COUNT";
            this.rEFUNDINPROGRESSCOUNTDataGridViewTextBoxColumn.HeaderText = "환불요청진행중";
            this.rEFUNDINPROGRESSCOUNTDataGridViewTextBoxColumn.Name = "rEFUNDINPROGRESSCOUNTDataGridViewTextBoxColumn";
            this.rEFUNDINPROGRESSCOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTOCKDataGridViewTextBoxColumn
            // 
            this.sTOCKDataGridViewTextBoxColumn.DataPropertyName = "STOCK";
            this.sTOCKDataGridViewTextBoxColumn.HeaderText = "현재수량";
            this.sTOCKDataGridViewTextBoxColumn.Name = "sTOCKDataGridViewTextBoxColumn";
            this.sTOCKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rEFUNDSTOCKDataGridViewTextBoxColumn
            // 
            this.rEFUNDSTOCKDataGridViewTextBoxColumn.DataPropertyName = "REFUND_STOCK";
            this.rEFUNDSTOCKDataGridViewTextBoxColumn.HeaderText = "반품수량";
            this.rEFUNDSTOCKDataGridViewTextBoxColumn.Name = "rEFUNDSTOCKDataGridViewTextBoxColumn";
            this.rEFUNDSTOCKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pURCHASEVIEWPRODUCT1BindingSource
            // 
            this.pURCHASEVIEWPRODUCT1BindingSource.DataMember = "PURCHASE_VIEW_PRODUCT1";
            this.pURCHASEVIEWPRODUCT1BindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pURCHASE_VIEW_PRODUCT1TableAdapter
            // 
            this.pURCHASE_VIEW_PRODUCT1TableAdapter.ClearBeforeFill = true;
            // 
            // AdminProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 560);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminProductList";
            this.Text = "AdminProductList";
            this.Load += new System.EventHandler(this.AdminProductList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASEVIEWPRODUCT1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource pURCHASEVIEWPRODUCT1BindingSource;
        private DataSet1TableAdapters.PURCHASE_VIEW_PRODUCT1TableAdapter pURCHASE_VIEW_PRODUCT1TableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALECOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEFUNDCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALEINPROGRESSCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEFUNDINPROGRESSCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOCKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEFUNDSTOCKDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label refundPStock;
        private System.Windows.Forms.Label stock;
        private System.Windows.Forms.Label refundRequest;
        private System.Windows.Forms.Label purchaseRequest;
        private System.Windows.Forms.Label refundStock;
        private System.Windows.Forms.Label purchaseStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label errorText;
        private CustomButton customButton4;
        private CustomButton customButton3;
        private CustomButton customButton2;
        private CustomButton customButton1;
    }
}
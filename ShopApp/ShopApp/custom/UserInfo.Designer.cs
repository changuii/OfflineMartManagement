
namespace ShopApp.custom
{
    partial class UserInfo
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
            this.productCard = new System.Windows.Forms.GroupBox();
            this.ratingLabel1 = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.idLabel2 = new System.Windows.Forms.Label();
            this.customerTableAdapter1 = new ShopApp.DataSet1TableAdapters.CUSTOMERTableAdapter();
            this.dataSet11 = new ShopApp.DataSet1();
            this.customButton1 = new ShopApp.custom.CustomButton();
            this.oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.productCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // productCard
            // 
            this.productCard.Controls.Add(this.customButton1);
            this.productCard.Controls.Add(this.ratingLabel);
            this.productCard.Controls.Add(this.idLabel2);
            this.productCard.Controls.Add(this.ratingLabel1);
            this.productCard.Controls.Add(this.nameLabel1);
            this.productCard.Controls.Add(this.idLabel1);
            this.productCard.Font = new System.Drawing.Font("던파 비트비트체 TTF", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.productCard.Location = new System.Drawing.Point(229, 67);
            this.productCard.Name = "productCard";
            this.productCard.Size = new System.Drawing.Size(672, 455);
            this.productCard.TabIndex = 3;
            this.productCard.TabStop = false;
            this.productCard.Text = "UserInfo";
            // 
            // ratingLabel1
            // 
            this.ratingLabel1.AutoSize = true;
            this.ratingLabel1.Font = new System.Drawing.Font("던파 비트비트체 TTF", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ratingLabel1.Location = new System.Drawing.Point(62, 250);
            this.ratingLabel1.Name = "ratingLabel1";
            this.ratingLabel1.Size = new System.Drawing.Size(160, 60);
            this.ratingLabel1.TabIndex = 3;
            this.ratingLabel1.Text = "등급 :";
            // 
            // nameLabel1
            // 
            this.nameLabel1.AutoSize = true;
            this.nameLabel1.Font = new System.Drawing.Font("던파 비트비트체 TTF", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nameLabel1.Location = new System.Drawing.Point(56, 55);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(293, 91);
            this.nameLabel1.TabIndex = 2;
            this.nameLabel1.Text = "Name";
            // 
            // idLabel1
            // 
            this.idLabel1.AutoSize = true;
            this.idLabel1.Font = new System.Drawing.Font("던파 비트비트체 TTF", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.idLabel1.Location = new System.Drawing.Point(62, 168);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(158, 60);
            this.idLabel1.TabIndex = 1;
            this.idLabel1.Text = "ID   :";
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Font = new System.Drawing.Font("던파 비트비트체 TTF", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ratingLabel.Location = new System.Drawing.Point(226, 250);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(263, 60);
            this.ratingLabel.TabIndex = 5;
            this.ratingLabel.Text = "RATING";
            // 
            // idLabel2
            // 
            this.idLabel2.AutoSize = true;
            this.idLabel2.Font = new System.Drawing.Font("던파 비트비트체 TTF", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.idLabel2.Location = new System.Drawing.Point(226, 168);
            this.idLabel2.Name = "idLabel2";
            this.idLabel2.Size = new System.Drawing.Size(99, 60);
            this.idLabel2.TabIndex = 4;
            this.idLabel2.Text = "ID";
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.DarkRed;
            this.customButton1.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.customButton1.BorderRadius = 40;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("던파 비트비트체 TTF", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(172, 357);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(333, 62);
            this.customButton1.TabIndex = 6;
            this.customButton1.Text = "회원 탈퇴";
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Transaction = null;
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 560);
            this.Controls.Add(this.productCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserInfo";
            this.Text = "UserInfo";
            this.Load += new System.EventHandler(this.UserInfo_Load);
            this.productCard.ResumeLayout(false);
            this.productCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox productCard;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Label idLabel2;
        private System.Windows.Forms.Label ratingLabel1;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label idLabel1;
        private DataSet1TableAdapters.CUSTOMERTableAdapter customerTableAdapter1;
        private DataSet1 dataSet11;
        private CustomButton customButton1;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
    }
}
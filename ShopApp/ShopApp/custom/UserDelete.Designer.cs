
namespace ShopApp.custom
{
    partial class UserDelete
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customButton2 = new ShopApp.custom.CustomButton();
            this.customButton1 = new ShopApp.custom.CustomButton();
            this.costomTextBox1 = new ShopApp.textbox.CostomTextBox();
            this.costomTextBox2 = new ShopApp.textbox.CostomTextBox();
            this.errorText = new System.Windows.Forms.Label();
            this.customerTableAdapter1 = new ShopApp.DataSet1TableAdapters.CUSTOMERTableAdapter();
            this.dataSet11 = new ShopApp.DataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("던파 비트비트체 TTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(32, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "정말로 계정을 \r\n삭제하시겠습니까?";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(66, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 78);
            this.panel1.TabIndex = 3;
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.customButton2.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.customButton2.BorderRadius = 40;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("던파 비트비트체 TTF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(66, 474);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(241, 47);
            this.customButton2.TabIndex = 1;
            this.customButton2.Text = "취소\r\n";
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.DarkRed;
            this.customButton1.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.customButton1.BorderRadius = 40;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("던파 비트비트체 TTF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(66, 405);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(241, 47);
            this.customButton1.TabIndex = 0;
            this.customButton1.Text = "삭제하기";
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // costomTextBox1
            // 
            this.costomTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.costomTextBox1.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.costomTextBox1.BorderSize = 2;
            this.costomTextBox1.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.costomTextBox1.Location = new System.Drawing.Point(66, 234);
            this.costomTextBox1.Multiline = false;
            this.costomTextBox1.Name = "costomTextBox1";
            this.costomTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.costomTextBox1.PasswordChar = true;
            this.costomTextBox1.Size = new System.Drawing.Size(241, 35);
            this.costomTextBox1.TabIndex = 4;
            this.costomTextBox1.Texts = "";
            this.costomTextBox1.UnderlinedStyle = true;
            // 
            // costomTextBox2
            // 
            this.costomTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.costomTextBox2.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.costomTextBox2.BorderSize = 2;
            this.costomTextBox2.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.costomTextBox2.Location = new System.Drawing.Point(66, 283);
            this.costomTextBox2.Multiline = false;
            this.costomTextBox2.Name = "costomTextBox2";
            this.costomTextBox2.Padding = new System.Windows.Forms.Padding(7);
            this.costomTextBox2.PasswordChar = true;
            this.costomTextBox2.Size = new System.Drawing.Size(241, 35);
            this.costomTextBox2.TabIndex = 5;
            this.costomTextBox2.Texts = "";
            this.costomTextBox2.UnderlinedStyle = true;
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.Font = new System.Drawing.Font("던파 비트비트체 TTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.errorText.ForeColor = System.Drawing.Color.DarkRed;
            this.errorText.Location = new System.Drawing.Point(66, 216);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(49, 15);
            this.errorText.TabIndex = 6;
            this.errorText.Text = "error";
            this.errorText.Click += new System.EventHandler(this.errorText_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("던파 비트비트체 TTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(66, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 40);
            this.label2.TabIndex = 7;
            this.label2.Text = "정말로 삭제하시려면 \r\n비밀번호를 두번 작성해주세요\r\n";
            // 
            // UserDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.errorText);
            this.Controls.Add(this.costomTextBox2);
            this.Controls.Add(this.costomTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UserDelete";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomButton customButton1;
        private CustomButton customButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private textbox.CostomTextBox costomTextBox1;
        private textbox.CostomTextBox costomTextBox2;
        private System.Windows.Forms.Label errorText;
        private DataSet1TableAdapters.CUSTOMERTableAdapter customerTableAdapter1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.Label label2;
    }
}
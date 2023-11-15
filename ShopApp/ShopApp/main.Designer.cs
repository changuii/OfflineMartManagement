
namespace ShopApp
{
    partial class main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.errorText = new System.Windows.Forms.Label();
            this.passwordTextBox = new ShopApp.textbox.CostomTextBox();
            this.customButton3 = new ShopApp.custom.CustomButton();
            this.adminRadio = new ShopApp.custom.CustomRadioButton();
            this.sellerRadio = new ShopApp.custom.CustomRadioButton();
            this.userRadio = new ShopApp.custom.CustomRadioButton();
            this.customButton2 = new ShopApp.custom.CustomButton();
            this.customButton1 = new ShopApp.custom.CustomButton();
            this.emailTextBox = new ShopApp.textbox.CostomTextBox();
            this.dataSet11 = new ShopApp.DataSet1();
            this.customerTableAdapter1 = new ShopApp.DataSet1TableAdapters.CUSTOMERTableAdapter();
            this.sellerTableAdapter1 = new ShopApp.DataSet1TableAdapters.SELLERTableAdapter();
            this.adminTableAdapter1 = new ShopApp.DataSet1TableAdapters.ADMINTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 370);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("던파 비트비트체 TTF", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(122, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "로그인";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("던파 비트비트체 TTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(20, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("던파 비트비트체 TTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(16, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "PW";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.errorText);
            this.panel2.Controls.Add(this.passwordTextBox);
            this.panel2.Controls.Add(this.customButton3);
            this.panel2.Controls.Add(this.adminRadio);
            this.panel2.Controls.Add(this.sellerRadio);
            this.panel2.Controls.Add(this.userRadio);
            this.panel2.Controls.Add(this.customButton2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.customButton1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.emailTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(375, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 370);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.Font = new System.Drawing.Font("던파 비트비트체 TTF", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.errorText.ForeColor = System.Drawing.Color.DarkRed;
            this.errorText.Location = new System.Drawing.Point(57, 225);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(64, 12);
            this.errorText.TabIndex = 21;
            this.errorText.Text = "errorText";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.passwordTextBox.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.passwordTextBox.BorderSize = 2;
            this.passwordTextBox.Font = new System.Drawing.Font("던파 비트비트체 TTF", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.passwordTextBox.Location = new System.Drawing.Point(59, 183);
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.passwordTextBox.PasswordChar = true;
            this.passwordTextBox.Size = new System.Drawing.Size(277, 29);
            this.passwordTextBox.TabIndex = 20;
            this.passwordTextBox.Texts = "";
            this.passwordTextBox.UnderlinedStyle = true;
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.customButton3.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.customButton3.BorderRadius = 40;
            this.customButton3.BorderSize = 0;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.Font = new System.Drawing.Font("던파 비트비트체 TTF", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customButton3.ForeColor = System.Drawing.Color.White;
            this.customButton3.Location = new System.Drawing.Point(110, 318);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(150, 40);
            this.customButton3.TabIndex = 19;
            this.customButton3.Text = "종료";
            this.customButton3.UseVisualStyleBackColor = false;
            this.customButton3.Click += new System.EventHandler(this.customButton3_Click);
            // 
            // adminRadio
            // 
            this.adminRadio.AutoSize = true;
            this.adminRadio.CheckedColor = System.Drawing.Color.SeaGreen;
            this.adminRadio.Font = new System.Drawing.Font("던파 비트비트체 TTF", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.adminRadio.Location = new System.Drawing.Point(230, 118);
            this.adminRadio.MinimumSize = new System.Drawing.Size(0, 21);
            this.adminRadio.Name = "adminRadio";
            this.adminRadio.Size = new System.Drawing.Size(65, 21);
            this.adminRadio.TabIndex = 17;
            this.adminRadio.TabStop = true;
            this.adminRadio.Text = "관리자";
            this.adminRadio.UnCheckedColor = System.Drawing.Color.MediumSeaGreen;
            this.adminRadio.UseVisualStyleBackColor = true;
            // 
            // sellerRadio
            // 
            this.sellerRadio.AutoSize = true;
            this.sellerRadio.CheckedColor = System.Drawing.Color.SeaGreen;
            this.sellerRadio.Font = new System.Drawing.Font("던파 비트비트체 TTF", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sellerRadio.Location = new System.Drawing.Point(160, 118);
            this.sellerRadio.MinimumSize = new System.Drawing.Size(0, 21);
            this.sellerRadio.Name = "sellerRadio";
            this.sellerRadio.Size = new System.Drawing.Size(65, 21);
            this.sellerRadio.TabIndex = 16;
            this.sellerRadio.TabStop = true;
            this.sellerRadio.Text = "판매자";
            this.sellerRadio.UnCheckedColor = System.Drawing.Color.MediumSeaGreen;
            this.sellerRadio.UseVisualStyleBackColor = true;
            // 
            // userRadio
            // 
            this.userRadio.AutoSize = true;
            this.userRadio.CheckedColor = System.Drawing.Color.SeaGreen;
            this.userRadio.Font = new System.Drawing.Font("던파 비트비트체 TTF", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userRadio.Location = new System.Drawing.Point(100, 118);
            this.userRadio.MinimumSize = new System.Drawing.Size(0, 21);
            this.userRadio.Name = "userRadio";
            this.userRadio.Size = new System.Drawing.Size(55, 21);
            this.userRadio.TabIndex = 15;
            this.userRadio.TabStop = true;
            this.userRadio.Text = "유저";
            this.userRadio.UnCheckedColor = System.Drawing.Color.MediumSeaGreen;
            this.userRadio.UseVisualStyleBackColor = true;
            this.userRadio.CheckedChanged += new System.EventHandler(this.customRadioButton1_CheckedChanged);
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.customButton2.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.customButton2.BorderRadius = 40;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("던파 비트비트체 TTF", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(199, 270);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(150, 40);
            this.customButton2.TabIndex = 14;
            this.customButton2.Text = "회원가입";
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
            this.customButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("던파 비트비트체 TTF", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(30, 270);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(150, 40);
            this.customButton1.TabIndex = 13;
            this.customButton1.Text = "확인";
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.emailTextBox.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.emailTextBox.BorderSize = 2;
            this.emailTextBox.Font = new System.Drawing.Font("던파 비트비트체 TTF", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.emailTextBox.Location = new System.Drawing.Point(59, 148);
            this.emailTextBox.Multiline = false;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.emailTextBox.PasswordChar = false;
            this.emailTextBox.Size = new System.Drawing.Size(277, 29);
            this.emailTextBox.TabIndex = 9;
            this.emailTextBox.Texts = "";
            this.emailTextBox.UnderlinedStyle = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // sellerTableAdapter1
            // 
            this.sellerTableAdapter1.ClearBeforeFill = true;
            // 
            // adminTableAdapter1
            // 
            this.adminTableAdapter1.ClearBeforeFill = true;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 370);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private textbox.CostomTextBox emailTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private custom.CustomButton customButton1;
        private custom.CustomButton customButton2;
        private System.Windows.Forms.Panel panel2;
        private custom.CustomRadioButton adminRadio;
        private custom.CustomRadioButton sellerRadio;
        private custom.CustomRadioButton userRadio;
        private custom.CustomButton customButton3;
        private textbox.CostomTextBox passwordTextBox;
        private DataSet1TableAdapters.CUSTOMERTableAdapter customerTableAdapter1;
        private DataSet1TableAdapters.SELLERTableAdapter sellerTableAdapter1;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.ADMINTableAdapter adminTableAdapter1;
        private System.Windows.Forms.Label errorText;
    }
}


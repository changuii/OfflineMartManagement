
namespace ShopApp
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customButton1 = new ShopApp.custom.CustomButton();
            this.label3 = new System.Windows.Forms.Label();
            this.costomTextBox1 = new ShopApp.textbox.CostomTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.customRadioButton3 = new ShopApp.custom.CustomRadioButton();
            this.customRadioButton2 = new ShopApp.custom.CustomRadioButton();
            this.customRadioButton1 = new ShopApp.custom.CustomRadioButton();
            this.costomTextBox2 = new ShopApp.textbox.CostomTextBox();
            this.costomTextBox3 = new ShopApp.textbox.CostomTextBox();
            this.costomTextBox4 = new ShopApp.textbox.CostomTextBox();
            this.panel2.SuspendLayout();
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
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.costomTextBox4);
            this.panel2.Controls.Add(this.costomTextBox3);
            this.panel2.Controls.Add(this.costomTextBox2);
            this.panel2.Controls.Add(this.customRadioButton3);
            this.panel2.Controls.Add(this.customRadioButton2);
            this.panel2.Controls.Add(this.customRadioButton1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.customButton1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.costomTextBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(375, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 370);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("던파 비트비트체 TTF", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(112, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "회원가입";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("던파 비트비트체 TTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(20, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID";
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
            this.customButton1.Location = new System.Drawing.Point(119, 291);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(150, 40);
            this.customButton1.TabIndex = 13;
            this.customButton1.Text = "확인";
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("던파 비트비트체 TTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(15, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "PW";
            // 
            // costomTextBox1
            // 
            this.costomTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.costomTextBox1.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.costomTextBox1.BorderSize = 2;
            this.costomTextBox1.Font = new System.Drawing.Font("던파 비트비트체 TTF", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.costomTextBox1.Location = new System.Drawing.Point(59, 114);
            this.costomTextBox1.Name = "costomTextBox1";
            this.costomTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.costomTextBox1.Size = new System.Drawing.Size(277, 29);
            this.costomTextBox1.TabIndex = 9;
            this.costomTextBox1.UnderlinedStyle = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("던파 비트비트체 TTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(15, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "PW";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("던파 비트비트체 TTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(15, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "이름";
            // 
            // customRadioButton3
            // 
            this.customRadioButton3.AutoSize = true;
            this.customRadioButton3.CheckedColor = System.Drawing.Color.SeaGreen;
            this.customRadioButton3.Font = new System.Drawing.Font("던파 비트비트체 TTF", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customRadioButton3.Location = new System.Drawing.Point(227, 87);
            this.customRadioButton3.MinimumSize = new System.Drawing.Size(0, 21);
            this.customRadioButton3.Name = "customRadioButton3";
            this.customRadioButton3.Size = new System.Drawing.Size(65, 21);
            this.customRadioButton3.TabIndex = 21;
            this.customRadioButton3.TabStop = true;
            this.customRadioButton3.Text = "관리자";
            this.customRadioButton3.UnCheckedColor = System.Drawing.Color.MediumSeaGreen;
            this.customRadioButton3.UseVisualStyleBackColor = true;
            // 
            // customRadioButton2
            // 
            this.customRadioButton2.AutoSize = true;
            this.customRadioButton2.CheckedColor = System.Drawing.Color.SeaGreen;
            this.customRadioButton2.Font = new System.Drawing.Font("던파 비트비트체 TTF", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customRadioButton2.Location = new System.Drawing.Point(157, 87);
            this.customRadioButton2.MinimumSize = new System.Drawing.Size(0, 21);
            this.customRadioButton2.Name = "customRadioButton2";
            this.customRadioButton2.Size = new System.Drawing.Size(65, 21);
            this.customRadioButton2.TabIndex = 20;
            this.customRadioButton2.TabStop = true;
            this.customRadioButton2.Text = "판매자";
            this.customRadioButton2.UnCheckedColor = System.Drawing.Color.MediumSeaGreen;
            this.customRadioButton2.UseVisualStyleBackColor = true;
            // 
            // customRadioButton1
            // 
            this.customRadioButton1.AutoSize = true;
            this.customRadioButton1.CheckedColor = System.Drawing.Color.SeaGreen;
            this.customRadioButton1.Font = new System.Drawing.Font("던파 비트비트체 TTF", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customRadioButton1.Location = new System.Drawing.Point(97, 87);
            this.customRadioButton1.MinimumSize = new System.Drawing.Size(0, 21);
            this.customRadioButton1.Name = "customRadioButton1";
            this.customRadioButton1.Size = new System.Drawing.Size(55, 21);
            this.customRadioButton1.TabIndex = 19;
            this.customRadioButton1.TabStop = true;
            this.customRadioButton1.Text = "유저";
            this.customRadioButton1.UnCheckedColor = System.Drawing.Color.MediumSeaGreen;
            this.customRadioButton1.UseVisualStyleBackColor = true;
            // 
            // costomTextBox2
            // 
            this.costomTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.costomTextBox2.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.costomTextBox2.BorderSize = 2;
            this.costomTextBox2.Font = new System.Drawing.Font("던파 비트비트체 TTF", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.costomTextBox2.Location = new System.Drawing.Point(59, 238);
            this.costomTextBox2.Name = "costomTextBox2";
            this.costomTextBox2.Padding = new System.Windows.Forms.Padding(7);
            this.costomTextBox2.Size = new System.Drawing.Size(277, 29);
            this.costomTextBox2.TabIndex = 22;
            this.costomTextBox2.UnderlinedStyle = true;
            // 
            // costomTextBox3
            // 
            this.costomTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.costomTextBox3.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.costomTextBox3.BorderSize = 2;
            this.costomTextBox3.Font = new System.Drawing.Font("던파 비트비트체 TTF", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.costomTextBox3.Location = new System.Drawing.Point(59, 158);
            this.costomTextBox3.Name = "costomTextBox3";
            this.costomTextBox3.Padding = new System.Windows.Forms.Padding(7);
            this.costomTextBox3.PasswordChar = true;
            this.costomTextBox3.Size = new System.Drawing.Size(277, 29);
            this.costomTextBox3.TabIndex = 23;
            this.costomTextBox3.Texts = "";
            this.costomTextBox3.UnderlinedStyle = true;
            // 
            // costomTextBox4
            // 
            this.costomTextBox4.BackColor = System.Drawing.SystemColors.Window;
            this.costomTextBox4.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.costomTextBox4.BorderSize = 2;
            this.costomTextBox4.Font = new System.Drawing.Font("던파 비트비트체 TTF", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.costomTextBox4.Location = new System.Drawing.Point(59, 198);
            this.costomTextBox4.Name = "costomTextBox4";
            this.costomTextBox4.Padding = new System.Windows.Forms.Padding(7);
            this.costomTextBox4.PasswordChar = true;
            this.costomTextBox4.Size = new System.Drawing.Size(277, 29);
            this.costomTextBox4.TabIndex = 24;
            this.costomTextBox4.Texts = "";
            this.costomTextBox4.UnderlinedStyle = true;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 370);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private custom.CustomButton customButton1;
        private System.Windows.Forms.Label label3;
        private textbox.CostomTextBox costomTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private custom.CustomRadioButton customRadioButton3;
        private custom.CustomRadioButton customRadioButton2;
        private custom.CustomRadioButton customRadioButton1;
        private textbox.CostomTextBox costomTextBox2;
        private textbox.CostomTextBox costomTextBox4;
        private textbox.CostomTextBox costomTextBox3;
    }
}
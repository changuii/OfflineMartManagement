using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.textbox
{
    public partial class CostomTextBox : UserControl
    {
        private Color borderColor = Color.MediumSeaGreen;
        private int borderSize = 2;
        private bool underlinedStyle = false;

        public CostomTextBox()
        {
            InitializeComponent();
        }


        public Color BorderColor { 
            get => borderColor;
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        public int BorderSize {
            get => borderSize;
            
            set { 
                
                borderSize = value;
                this.Invalidate();
            } 
        }
        public bool UnderlinedStyle
        {
            get => underlinedStyle;

            set { underlinedStyle = value;
                this.Invalidate();
            }
        }

        public bool PasswordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { this.textBox1.UseSystemPasswordChar = value; }
        }

        public string Texts
        {
            get
            {
                return this.textBox1.Text;
            }
            set
            {
                this.textBox1.Text = value;
            }

        }

        public bool Multiline
        {
            get
            {
                return this.textBox1.Multiline;
            }
            set
            {
                this.textBox1.Multiline = value;
            }

        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            //Draw border
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (underlinedStyle) // Line Style
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                else // Normal style
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
            }


        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if(this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }
        private void UpdateControlHeight()
        {
            if(textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height+1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void CostomTextBox_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

    
    }


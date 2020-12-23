using _8So_WindowsForms.Resources.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _8So_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
  
        }
        public Color rColor { get; set; }
        public int Radius { get; set; }
        public Size rSize { get; set; }
        public Point TopLeft { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRoundedRectangle(new SolidBrush(rColor), TopLeft.X, TopLeft.Y, rSize.Width, rSize.Height, Radius);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace _8So_WindowsForms
{
    public partial class fmThongTin : Form
    {
        public fmThongTin()
        {
            InitializeComponent();
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/PhongHkphone");
        }


        public static class BorderRadius
        {
            [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
            private static extern IntPtr CreateRoundRectRgn(int xTopLeft, int yTopLeft, int xBotRight, int yBotRight, int nWidthEllipse, int nHeightEllipse);

            public static void SetBorderRadius(Control obj, int width, int height)
            {
                obj.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, obj.Width, obj.Height, width, height));
            }
        }

        private void btnBauDau_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm8So form2 = new fm8So();
            form2.ShowDialog();
            this.Close();
        }


    }
}

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

    public partial class fm8So : Form
    {
        int[,] MaTran;
        C_8So TamSo;
        Stack<int[,]> stk;
        PictureBox[,] Mangbt;
        int n = 3;
        int SoLanDiChuyen = 0;
        public fm8So()
        {
            InitializeComponent();

            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;

            MaTran = new int[n, n];
            TamSo = new C_8So();

            stk = new Stack<int[,]>();
            Mangbt = new PictureBox[n, n];
        }





        void load8So(int[,] a, PictureBox[,] b)
        {
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    if (a[i, j] == 0)
                    {
                        b[i, j].Image = Image.FromFile($@"C:\Users\Admin\Pictures\Saved Pictures\0.jpg");
                    }
                    else
                    {
                        b[i, j].Image = Image.FromFile($@"C:\Users\Admin\Pictures\Saved Pictures\{a[i, j]}.jpg");
                    }
                }
        }
        void khoiTao8So()
        {
            MaTran = TamSo.randomMaTran(n);

            load8So(MaTran, Mangbt);

            stk = TamSo.timKetQua(MaTran, n);
            stk.Pop();

            lbSoLanDiChuyen.Text = "0";
            SoLanDiChuyen = 0;
            btnBauDau.Enabled = false;
            btnDung.Enabled = false;
            timer1.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ComboBox cbbTocDo = new ComboBox();
            cbbTocDo.Size = new Size(216, 50);
            this.Controls.Add(cbbTocDo);

            Mangbt[0, 0] = btn1;
            Mangbt[0, 1] = btn2;
            Mangbt[0, 2] = btn3;
            Mangbt[1, 0] = btn8;
            Mangbt[1, 1] = btn0;
            Mangbt[1, 2] = btn4;
            Mangbt[2, 0] = btn7;
            Mangbt[2, 1] = btn6;
            Mangbt[2, 2] = btn5;

            btnBauDau.Enabled = false;
            btnDung.Enabled = false;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
 
                timer1.Interval = 500; 
     
            int[,] Temp = new int[n, n];

            if (stk.Count != 0)
            {
                Temp = stk.Pop();
                load8So(Temp, Mangbt);

                SoLanDiChuyen++;
                lbSoLanDiChuyen.Text = SoLanDiChuyen.ToString();
            }
            else
                timer1.Enabled = false;
        }

        private void btBauDau_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            btnBauDau.Enabled = false;
            btnDung.Enabled = true;
        }

        private void btDung_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btnDung.Enabled = false;
            btnBauDau.Enabled = true;
        }

        private void ChoiMoi(object sender, EventArgs e)
        {
            khoiTao8So();
            btnBauDau.Enabled = true;
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
        
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pConterner.Controls.Add(frm);
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            thongbao tb = new thongbao();
            tb.Show();
        }
    }
}

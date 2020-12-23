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
           

 

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if(panel2.Width >= 800)
            {
                timer1.Stop(); 
                fm8So form2 = new fm8So();
                form2.Show();
                this.Hide();
                
            }
        }
    }
}

using System.Drawing;

namespace _8So_WindowsForms
{
    partial class fm8So
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
        private void InitializeUI()
        {
            BorderRadius.SetBorderRadius(btnDung, 5, 5);
            pnDrop1.BackColor = Color.FromArgb(244, 104, 68);
            BorderRadius.SetBorderRadius(pnDrop1, 10, 10);
            pnDrop2.BackColor = Color.FromArgb(244, 104, 68);
            BorderRadius.SetBorderRadius(pnDrop2, 10, 10);
            pnDrop3.BackColor = Color.FromArgb(244, 104, 68);
            BorderRadius.SetBorderRadius(pnDrop3, 10, 10);
            pnDrop4.BackColor = Color.FromArgb(244, 104, 68);
            BorderRadius.SetBorderRadius(pnDrop4, 10, 10);

            BorderRadius.SetBorderRadius(btnChoiMoi, 5, 5);
            pnDrop24.BackColor = Color.FromArgb(230, 133, 133);
            BorderRadius.SetBorderRadius(pnDrop24, 10, 10);
            pnDrop23.BackColor = Color.FromArgb(230, 133, 133);
            BorderRadius.SetBorderRadius(pnDrop23, 10, 10);
            pnDrop22.BackColor = Color.FromArgb(230, 133, 133);
            BorderRadius.SetBorderRadius(pnDrop22, 10, 10);
            pnDrop21.BackColor = Color.FromArgb(230, 133, 133);
            BorderRadius.SetBorderRadius(pnDrop21, 10, 10);

            BorderRadius.SetBorderRadius(btnBauDau, 5, 5);
            pnDrop14.BackColor = Color.FromArgb(244, 104, 68);
            BorderRadius.SetBorderRadius(pnDrop14, 10, 10);
            pnDrop13.BackColor = Color.FromArgb(244, 104, 68);
            BorderRadius.SetBorderRadius(pnDrop13, 10, 10);
            pnDrop12.BackColor = Color.FromArgb(244, 104, 68);
            BorderRadius.SetBorderRadius(pnDrop12, 10, 10);
            pnDrop11.BackColor = Color.FromArgb(244, 104, 68);
            BorderRadius.SetBorderRadius(pnDrop11, 10, 10);

            

            btnChoiMoi.BringToFront();

        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnDrop3 = new System.Windows.Forms.Panel();
            this.pnDrop2 = new System.Windows.Forms.Panel();
            this.pnDrop1 = new System.Windows.Forms.Panel();
            this.btnDung = new System.Windows.Forms.Button();
            this.pnDrop4 = new System.Windows.Forms.Panel();
            this.pnDrop12 = new System.Windows.Forms.Panel();
            this.pnDrop13 = new System.Windows.Forms.Panel();
            this.pnDrop14 = new System.Windows.Forms.Panel();
            this.btnBauDau = new System.Windows.Forms.Button();
            this.pnDrop11 = new System.Windows.Forms.Panel();
            this.pnDrop22 = new System.Windows.Forms.Panel();
            this.pnDrop23 = new System.Windows.Forms.Panel();
            this.pnDrop24 = new System.Windows.Forms.Panel();
            this.btnChoiMoi = new System.Windows.Forms.Button();
            this.pnDrop21 = new System.Windows.Forms.Panel();
            this.lbSoLanDiChuyen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbTocDo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn0 = new System.Windows.Forms.PictureBox();
            this.btn8 = new System.Windows.Forms.PictureBox();
            this.btn7 = new System.Windows.Forms.PictureBox();
            this.btn6 = new System.Windows.Forms.PictureBox();
            this.btn5 = new System.Windows.Forms.PictureBox();
            this.btn4 = new System.Windows.Forms.PictureBox();
            this.btn3 = new System.Windows.Forms.PictureBox();
            this.btn2 = new System.Windows.Forms.PictureBox();
            this.btn1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnDrop3.SuspendLayout();
            this.pnDrop2.SuspendLayout();
            this.pnDrop1.SuspendLayout();
            this.pnDrop12.SuspendLayout();
            this.pnDrop13.SuspendLayout();
            this.pnDrop14.SuspendLayout();
            this.pnDrop22.SuspendLayout();
            this.pnDrop23.SuspendLayout();
            this.pnDrop24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pnDrop3);
            this.panel1.Controls.Add(this.pnDrop4);
            this.panel1.Controls.Add(this.pnDrop12);
            this.panel1.Controls.Add(this.pnDrop11);
            this.panel1.Controls.Add(this.pnDrop22);
            this.panel1.Controls.Add(this.pnDrop21);
            this.panel1.Controls.Add(this.lbSoLanDiChuyen);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Controls.Add(this.cbbTocDo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 531);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.panel2.Location = new System.Drawing.Point(512, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 529);
            this.panel2.TabIndex = 133;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(844, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 132;
            this.button1.Text = "✖";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnDrop3
            // 
            this.pnDrop3.Controls.Add(this.pnDrop2);
            this.pnDrop3.Location = new System.Drawing.Point(630, 169);
            this.pnDrop3.Name = "pnDrop3";
            this.pnDrop3.Size = new System.Drawing.Size(187, 56);
            this.pnDrop3.TabIndex = 130;
            // 
            // pnDrop2
            // 
            this.pnDrop2.Controls.Add(this.pnDrop1);
            this.pnDrop2.Location = new System.Drawing.Point(1, 1);
            this.pnDrop2.Name = "pnDrop2";
            this.pnDrop2.Size = new System.Drawing.Size(184, 54);
            this.pnDrop2.TabIndex = 129;
            // 
            // pnDrop1
            // 
            this.pnDrop1.Controls.Add(this.btnDung);
            this.pnDrop1.Location = new System.Drawing.Point(1, 1);
            this.pnDrop1.Name = "pnDrop1";
            this.pnDrop1.Size = new System.Drawing.Size(182, 52);
            this.pnDrop1.TabIndex = 128;
            // 
            // btnDung
            // 
            this.btnDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(104)))), ((int)(((byte)(68)))));
            this.btnDung.FlatAppearance.BorderSize = 0;
            this.btnDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDung.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDung.Location = new System.Drawing.Point(1, 1);
            this.btnDung.Name = "btnDung";
            this.btnDung.Size = new System.Drawing.Size(180, 50);
            this.btnDung.TabIndex = 17;
            this.btnDung.Text = "Stop";
            this.btnDung.UseVisualStyleBackColor = false;
            this.btnDung.Click += new System.EventHandler(this.btDung_Click);
            // 
            // pnDrop4
            // 
            this.pnDrop4.Location = new System.Drawing.Point(629, 168);
            this.pnDrop4.Name = "pnDrop4";
            this.pnDrop4.Size = new System.Drawing.Size(189, 58);
            this.pnDrop4.TabIndex = 131;
            // 
            // pnDrop12
            // 
            this.pnDrop12.Controls.Add(this.pnDrop13);
            this.pnDrop12.Location = new System.Drawing.Point(629, 97);
            this.pnDrop12.Name = "pnDrop12";
            this.pnDrop12.Size = new System.Drawing.Size(187, 56);
            this.pnDrop12.TabIndex = 128;
            // 
            // pnDrop13
            // 
            this.pnDrop13.Controls.Add(this.pnDrop14);
            this.pnDrop13.Location = new System.Drawing.Point(1, 1);
            this.pnDrop13.Name = "pnDrop13";
            this.pnDrop13.Size = new System.Drawing.Size(184, 54);
            this.pnDrop13.TabIndex = 129;
            // 
            // pnDrop14
            // 
            this.pnDrop14.Controls.Add(this.btnBauDau);
            this.pnDrop14.Location = new System.Drawing.Point(1, 1);
            this.pnDrop14.Name = "pnDrop14";
            this.pnDrop14.Size = new System.Drawing.Size(182, 52);
            this.pnDrop14.TabIndex = 128;
            // 
            // btnBauDau
            // 
            this.btnBauDau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(104)))), ((int)(((byte)(68)))));
            this.btnBauDau.FlatAppearance.BorderSize = 0;
            this.btnBauDau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBauDau.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBauDau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBauDau.Location = new System.Drawing.Point(1, 1);
            this.btnBauDau.Name = "btnBauDau";
            this.btnBauDau.Size = new System.Drawing.Size(180, 50);
            this.btnBauDau.TabIndex = 19;
            this.btnBauDau.Text = "Start";
            this.btnBauDau.UseVisualStyleBackColor = false;
            this.btnBauDau.Click += new System.EventHandler(this.btBauDau_Click);
            // 
            // pnDrop11
            // 
            this.pnDrop11.Location = new System.Drawing.Point(628, 96);
            this.pnDrop11.Name = "pnDrop11";
            this.pnDrop11.Size = new System.Drawing.Size(189, 58);
            this.pnDrop11.TabIndex = 129;
            // 
            // pnDrop22
            // 
            this.pnDrop22.Controls.Add(this.pnDrop23);
            this.pnDrop22.Location = new System.Drawing.Point(628, 34);
            this.pnDrop22.Name = "pnDrop22";
            this.pnDrop22.Size = new System.Drawing.Size(187, 56);
            this.pnDrop22.TabIndex = 126;
            // 
            // pnDrop23
            // 
            this.pnDrop23.Controls.Add(this.pnDrop24);
            this.pnDrop23.Location = new System.Drawing.Point(1, 1);
            this.pnDrop23.Name = "pnDrop23";
            this.pnDrop23.Size = new System.Drawing.Size(184, 54);
            this.pnDrop23.TabIndex = 129;
            // 
            // pnDrop24
            // 
            this.pnDrop24.Controls.Add(this.btnChoiMoi);
            this.pnDrop24.Location = new System.Drawing.Point(1, 1);
            this.pnDrop24.Name = "pnDrop24";
            this.pnDrop24.Size = new System.Drawing.Size(182, 52);
            this.pnDrop24.TabIndex = 128;
            // 
            // btnChoiMoi
            // 
            this.btnChoiMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.btnChoiMoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(165)))), ((int)(((byte)(114)))));
            this.btnChoiMoi.FlatAppearance.BorderSize = 0;
            this.btnChoiMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoiMoi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChoiMoi.ForeColor = System.Drawing.Color.White;
            this.btnChoiMoi.Location = new System.Drawing.Point(1, 1);
            this.btnChoiMoi.Name = "btnChoiMoi";
            this.btnChoiMoi.Size = new System.Drawing.Size(180, 50);
            this.btnChoiMoi.TabIndex = 102;
            this.btnChoiMoi.Text = "RamDom";
            this.btnChoiMoi.UseVisualStyleBackColor = false;
            this.btnChoiMoi.Click += new System.EventHandler(this.ChoiMoi);
            // 
            // pnDrop21
            // 
            this.pnDrop21.Location = new System.Drawing.Point(627, 33);
            this.pnDrop21.Name = "pnDrop21";
            this.pnDrop21.Size = new System.Drawing.Size(189, 58);
            this.pnDrop21.TabIndex = 127;
            // 
            // lbSoLanDiChuyen
            // 
            this.lbSoLanDiChuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.lbSoLanDiChuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSoLanDiChuyen.ForeColor = System.Drawing.Color.White;
            this.lbSoLanDiChuyen.Location = new System.Drawing.Point(624, 346);
            this.lbSoLanDiChuyen.Name = "lbSoLanDiChuyen";
            this.lbSoLanDiChuyen.Size = new System.Drawing.Size(191, 150);
            this.lbSoLanDiChuyen.TabIndex = 16;
            this.lbSoLanDiChuyen.Text = "0";
            this.lbSoLanDiChuyen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(641, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Number Of Moves";
            // 
            // cbbTocDo
            // 
            this.cbbTocDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.cbbTocDo.DropDownWidth = 185;
            this.cbbTocDo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbTocDo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTocDo.FormattingEnabled = true;
            this.cbbTocDo.ItemHeight = 25;
            this.cbbTocDo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbbTocDo.Location = new System.Drawing.Point(633, 256);
            this.cbbTocDo.Name = "cbbTocDo";
            this.cbbTocDo.Size = new System.Drawing.Size(187, 33);
            this.cbbTocDo.TabIndex = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(563, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Speed";
            // 
            // btn0
            // 
            this.btn0.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.btn0.Image = global::_8So_WindowsForms.Properties.Resources._0;
            this.btn0.Location = new System.Drawing.Point(188, 189);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(150, 150);
            this.btn0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn0.TabIndex = 29;
            this.btn0.TabStop = false;
            // 
            // btn8
            // 
            this.btn8.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.btn8.Image = global::_8So_WindowsForms.Properties.Resources._8;
            this.btn8.Location = new System.Drawing.Point(32, 189);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(150, 150);
            this.btn8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn8.TabIndex = 28;
            this.btn8.TabStop = false;
            // 
            // btn7
            // 
            this.btn7.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.btn7.Image = global::_8So_WindowsForms.Properties.Resources._7;
            this.btn7.Location = new System.Drawing.Point(32, 345);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(150, 150);
            this.btn7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn7.TabIndex = 27;
            this.btn7.TabStop = false;
            // 
            // btn6
            // 
            this.btn6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.btn6.Image = global::_8So_WindowsForms.Properties.Resources._6;
            this.btn6.Location = new System.Drawing.Point(188, 346);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(150, 150);
            this.btn6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn6.TabIndex = 26;
            this.btn6.TabStop = false;
            // 
            // btn5
            // 
            this.btn5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.btn5.Image = global::_8So_WindowsForms.Properties.Resources._5;
            this.btn5.Location = new System.Drawing.Point(344, 346);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(150, 150);
            this.btn5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn5.TabIndex = 25;
            this.btn5.TabStop = false;
            // 
            // btn4
            // 
            this.btn4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.btn4.Image = global::_8So_WindowsForms.Properties.Resources._4;
            this.btn4.Location = new System.Drawing.Point(344, 190);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(150, 150);
            this.btn4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn4.TabIndex = 24;
            this.btn4.TabStop = false;
            // 
            // btn3
            // 
            this.btn3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.btn3.Image = global::_8So_WindowsForms.Properties.Resources._3;
            this.btn3.Location = new System.Drawing.Point(344, 34);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(150, 150);
            this.btn3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn3.TabIndex = 23;
            this.btn3.TabStop = false;
            // 
            // btn2
            // 
            this.btn2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.btn2.Image = global::_8So_WindowsForms.Properties.Resources._2;
            this.btn2.Location = new System.Drawing.Point(188, 34);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(150, 150);
            this.btn2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn2.TabIndex = 22;
            this.btn2.TabStop = false;
            // 
            // btn1
            // 
            this.btn1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.btn1.Image = global::_8So_WindowsForms.Properties.Resources._11;
            this.btn1.Location = new System.Drawing.Point(32, 34);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(150, 150);
            this.btn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn1.TabIndex = 21;
            this.btn1.TabStop = false;
            // 
            // fm8So
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(877, 531);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "fm8So";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mô phỏng trò chơi 8 số";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnDrop3.ResumeLayout(false);
            this.pnDrop2.ResumeLayout(false);
            this.pnDrop1.ResumeLayout(false);
            this.pnDrop12.ResumeLayout(false);
            this.pnDrop13.ResumeLayout(false);
            this.pnDrop14.ResumeLayout(false);
            this.pnDrop22.ResumeLayout(false);
            this.pnDrop23.ResumeLayout(false);
            this.pnDrop24.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChoiMoi;
        private System.Windows.Forms.PictureBox btn1;
        private System.Windows.Forms.PictureBox btn0;
        private System.Windows.Forms.PictureBox btn8;
        private System.Windows.Forms.PictureBox btn7;
        private System.Windows.Forms.PictureBox btn6;
        private System.Windows.Forms.PictureBox btn5;
        private System.Windows.Forms.PictureBox btn4;
        private System.Windows.Forms.PictureBox btn3;
        private System.Windows.Forms.PictureBox btn2;
        private System.Windows.Forms.Label lbSoLanDiChuyen;
        private System.Windows.Forms.Button btnDung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbTocDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBauDau;
        private System.Windows.Forms.Panel pnDrop22;
        private System.Windows.Forms.Panel pnDrop23;
        private System.Windows.Forms.Panel pnDrop24;
        private System.Windows.Forms.Panel pnDrop21;
        private System.Windows.Forms.Panel pnDrop12;
        private System.Windows.Forms.Panel pnDrop13;
        private System.Windows.Forms.Panel pnDrop14;
        private System.Windows.Forms.Panel pnDrop11;
        private System.Windows.Forms.Panel pnDrop3;
        private System.Windows.Forms.Panel pnDrop2;
        private System.Windows.Forms.Panel pnDrop1;
        private System.Windows.Forms.Panel pnDrop4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}


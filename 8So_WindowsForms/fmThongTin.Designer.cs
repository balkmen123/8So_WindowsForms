using System.Drawing;
namespace _8So_WindowsForms
{
    partial class fmThongTin
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
            BorderRadius.SetBorderRadius(btnBauDau, 5, 5);
            pnDrop14.BackColor = Color.FromArgb(244, 104, 68);
            BorderRadius.SetBorderRadius(pnDrop14, 10, 10);
            pnDrop13.BackColor = Color.FromArgb(244, 104, 68);
            BorderRadius.SetBorderRadius(pnDrop13, 10, 10);
            pnDrop12.BackColor = Color.FromArgb(244, 104, 68);
            BorderRadius.SetBorderRadius(pnDrop12, 10, 10);
            pnDrop11.BackColor = Color.FromArgb(244, 104, 68);
            BorderRadius.SetBorderRadius(pnDrop11, 10, 10);
        }

            #region Windows Form Designer generated code

            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnDrop12 = new System.Windows.Forms.Panel();
            this.pnDrop13 = new System.Windows.Forms.Panel();
            this.pnDrop14 = new System.Windows.Forms.Panel();
            this.btnBauDau = new System.Windows.Forms.Button();
            this.pnDrop11 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnDrop12.SuspendLayout();
            this.pnDrop13.SuspendLayout();
            this.pnDrop14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.label2.Location = new System.Drawing.Point(201, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thực hiện :\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.label3.Location = new System.Drawing.Point(320, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 62);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nguyễn Đức Long \r\n\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.label4.Location = new System.Drawing.Point(524, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "18810310048";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.label5.Location = new System.Drawing.Point(320, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cao Hoài Nam";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.label6.Location = new System.Drawing.Point(524, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "18810310046";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.label7.Location = new System.Drawing.Point(320, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 31);
            this.label7.TabIndex = 10;
            this.label7.Text = "Lã Quốc Nghị";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.label8.Location = new System.Drawing.Point(524, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 31);
            this.label8.TabIndex = 11;
            this.label8.Text = "18810310051";
            // 
            // pnDrop12
            // 
            this.pnDrop12.Controls.Add(this.pnDrop13);
            this.pnDrop12.Location = new System.Drawing.Point(701, 175);
            this.pnDrop12.Name = "pnDrop12";
            this.pnDrop12.Size = new System.Drawing.Size(187, 56);
            this.pnDrop12.TabIndex = 130;
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
            this.btnBauDau.Text = "Go";
            this.btnBauDau.UseVisualStyleBackColor = false;
            this.btnBauDau.Click += new System.EventHandler(this.btnBauDau_Click);
            // 
            // pnDrop11
            // 
            this.pnDrop11.Location = new System.Drawing.Point(700, 174);
            this.pnDrop11.Name = "pnDrop11";
            this.pnDrop11.Size = new System.Drawing.Size(189, 58);
            this.pnDrop11.TabIndex = 131;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 62);
            this.label1.TabIndex = 132;
            this.label1.Text = "Đề tài: Áp dụng thuật toán A* Mô Phỏng Trò Chơi 8 số.\r\n\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.label9.Location = new System.Drawing.Point(201, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(483, 31);
            this.label9.TabIndex = 133;
            this.label9.Text = "Giáo viên đứng lớp : Cô Nguyễn Thị Thanh Tân.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_8So_WindowsForms.Properties.Resources.Untitled1;
            this.pictureBox1.Location = new System.Drawing.Point(15, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // fmThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(911, 236);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnDrop12);
            this.Controls.Add(this.pnDrop11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "fmThongTin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin";
            this.pnDrop12.ResumeLayout(false);
            this.pnDrop13.ResumeLayout(false);
            this.pnDrop14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnDrop12;
        private System.Windows.Forms.Panel pnDrop13;
        private System.Windows.Forms.Panel pnDrop14;
        private System.Windows.Forms.Button btnBauDau;
        private System.Windows.Forms.Panel pnDrop11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
namespace Kalkulator
{
    partial class Form1
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
            this.txtUtama = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBagi = new System.Windows.Forms.Button();
            this.btnKali = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnKurang = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnSD = new System.Windows.Forms.Button();
            this.btnPM = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnKoma = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUtama
            // 
            this.txtUtama.Location = new System.Drawing.Point(12, 38);
            this.txtUtama.Name = "txtUtama";
            this.txtUtama.ReadOnly = true;
            this.txtUtama.Size = new System.Drawing.Size(331, 31);
            this.txtUtama.TabIndex = 0;
            this.txtUtama.Text = "\r\n";
            this.txtUtama.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTemp
            // 
            this.txtTemp.BackColor = System.Drawing.SystemColors.Control;
            this.txtTemp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemp.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTemp.Location = new System.Drawing.Point(13, 13);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.ReadOnly = true;
            this.txtTemp.Size = new System.Drawing.Size(330, 19);
            this.txtTemp.TabIndex = 1;
            this.txtTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Black;
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(13, 89);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 37);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Black;
            this.btnHapus.ForeColor = System.Drawing.Color.Lime;
            this.btnHapus.Location = new System.Drawing.Point(181, 89);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(78, 37);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "<";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnBagi
            // 
            this.btnBagi.BackColor = System.Drawing.Color.Black;
            this.btnBagi.ForeColor = System.Drawing.Color.Lime;
            this.btnBagi.Location = new System.Drawing.Point(265, 89);
            this.btnBagi.Name = "btnBagi";
            this.btnBagi.Size = new System.Drawing.Size(78, 37);
            this.btnBagi.TabIndex = 5;
            this.btnBagi.Text = ":";
            this.btnBagi.UseVisualStyleBackColor = false;
            this.btnBagi.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnKali
            // 
            this.btnKali.BackColor = System.Drawing.Color.Black;
            this.btnKali.ForeColor = System.Drawing.Color.Lime;
            this.btnKali.Location = new System.Drawing.Point(265, 132);
            this.btnKali.Name = "btnKali";
            this.btnKali.Size = new System.Drawing.Size(78, 37);
            this.btnKali.TabIndex = 9;
            this.btnKali.Text = "X";
            this.btnKali.UseVisualStyleBackColor = false;
            this.btnKali.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(181, 132);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(78, 37);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(97, 132);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(78, 37);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(13, 132);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(78, 37);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnKurang
            // 
            this.btnKurang.BackColor = System.Drawing.Color.Black;
            this.btnKurang.ForeColor = System.Drawing.Color.Lime;
            this.btnKurang.Location = new System.Drawing.Point(265, 175);
            this.btnKurang.Name = "btnKurang";
            this.btnKurang.Size = new System.Drawing.Size(78, 37);
            this.btnKurang.TabIndex = 13;
            this.btnKurang.Text = "-";
            this.btnKurang.UseVisualStyleBackColor = false;
            this.btnKurang.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(181, 175);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(78, 37);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(97, 175);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(78, 37);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(13, 175);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(78, 37);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.Black;
            this.btnTambah.ForeColor = System.Drawing.Color.Lime;
            this.btnTambah.Location = new System.Drawing.Point(265, 218);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(78, 37);
            this.btnTambah.TabIndex = 17;
            this.btnTambah.Text = "+";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(181, 218);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(78, 37);
            this.btn3.TabIndex = 16;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(97, 218);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(78, 37);
            this.btn2.TabIndex = 15;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(13, 218);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(78, 37);
            this.btn1.TabIndex = 14;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnSD
            // 
            this.btnSD.BackColor = System.Drawing.Color.Black;
            this.btnSD.ForeColor = System.Drawing.Color.Lime;
            this.btnSD.Location = new System.Drawing.Point(265, 261);
            this.btnSD.Name = "btnSD";
            this.btnSD.Size = new System.Drawing.Size(78, 37);
            this.btnSD.TabIndex = 21;
            this.btnSD.Text = "=";
            this.btnSD.UseVisualStyleBackColor = false;
            this.btnSD.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnPM
            // 
            this.btnPM.Location = new System.Drawing.Point(181, 261);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(78, 37);
            this.btnPM.TabIndex = 20;
            this.btnPM.Text = "+/-";
            this.btnPM.UseVisualStyleBackColor = true;
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(97, 261);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(78, 37);
            this.btn0.TabIndex = 19;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnKoma
            // 
            this.btnKoma.Location = new System.Drawing.Point(13, 261);
            this.btnKoma.Name = "btnKoma";
            this.btnKoma.Size = new System.Drawing.Size(78, 37);
            this.btnKoma.TabIndex = 18;
            this.btnKoma.Text = ",";
            this.btnKoma.UseVisualStyleBackColor = true;
            this.btnKoma.Click += new System.EventHandler(this.btnKoma_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.Black;
            this.btnCE.ForeColor = System.Drawing.Color.Lime;
            this.btnCE.Location = new System.Drawing.Point(97, 89);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(78, 37);
            this.btnCE.TabIndex = 4;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(353, 310);
            this.Controls.Add(this.btnSD);
            this.Controls.Add(this.btnPM);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnKoma);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnKurang);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnKali);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnBagi);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.txtUtama);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUtama;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBagi;
        private System.Windows.Forms.Button btnKali;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnKurang;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnSD;
        private System.Windows.Forms.Button btnPM;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnKoma;
        private System.Windows.Forms.Button btnCE;
    }
}


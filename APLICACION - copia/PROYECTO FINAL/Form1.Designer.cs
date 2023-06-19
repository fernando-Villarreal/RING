namespace PROYECTO_FINAL
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.firstCustomerControl1 = new PROYECTO_FINAL.FirstCustomerControl();
            this.pedidoEstado1 = new PROYECTO_FINAL.PedidoEstado();
            this.secondCustomerControl1 = new PROYECTO_FINAL.SecondCustomerControl();
            this.thirdControlUser1 = new PROYECTO_FINAL.ThirdControlUser();
            this.fourthControlUser1 = new PROYECTO_FINAL.FourthControlUser();
            this.ayudaCU1 = new PROYECTO_FINAL.ayudaCU();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 538);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(25, 449);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 80);
            this.button5.TabIndex = 7;
            this.button5.Text = "AYUDA";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(25, 363);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 80);
            this.button4.TabIndex = 6;
            this.button4.Text = "FARMACIA";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(25, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 80);
            this.button3.TabIndex = 5;
            this.button3.Text = "BEBIDA";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(25, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 80);
            this.button2.TabIndex = 4;
            this.button2.Text = "COMIDA";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(25, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 80);
            this.button1.TabIndex = 2;
            this.button1.Text = "INICIO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(67, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ring!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROYECTO_FINAL.Properties.Resources.final;
            this.pictureBox1.Location = new System.Drawing.Point(46, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(191, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(698, 100);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // firstCustomerControl1
            // 
            this.firstCustomerControl1.Location = new System.Drawing.Point(189, 97);
            this.firstCustomerControl1.Name = "firstCustomerControl1";
            this.firstCustomerControl1.Size = new System.Drawing.Size(697, 441);
            this.firstCustomerControl1.TabIndex = 7;
            this.firstCustomerControl1.Load += new System.EventHandler(this.firstCustomerControl1_Load_2);
            // 
            // pedidoEstado1
            // 
            this.pedidoEstado1.Location = new System.Drawing.Point(189, 97);
            this.pedidoEstado1.Name = "pedidoEstado1";
            this.pedidoEstado1.Size = new System.Drawing.Size(697, 441);
            this.pedidoEstado1.TabIndex = 6;
            // 
            // secondCustomerControl1
            // 
            this.secondCustomerControl1.Location = new System.Drawing.Point(189, 96);
            this.secondCustomerControl1.Name = "secondCustomerControl1";
            this.secondCustomerControl1.Size = new System.Drawing.Size(700, 439);
            this.secondCustomerControl1.TabIndex = 5;
            // 
            // thirdControlUser1
            // 
            this.thirdControlUser1.Location = new System.Drawing.Point(189, 97);
            this.thirdControlUser1.Name = "thirdControlUser1";
            this.thirdControlUser1.Size = new System.Drawing.Size(700, 441);
            this.thirdControlUser1.TabIndex = 4;
            // 
            // fourthControlUser1
            // 
            this.fourthControlUser1.Location = new System.Drawing.Point(189, 97);
            this.fourthControlUser1.Name = "fourthControlUser1";
            this.fourthControlUser1.Size = new System.Drawing.Size(700, 441);
            this.fourthControlUser1.TabIndex = 3;
            // 
            // ayudaCU1
            // 
            this.ayudaCU1.Location = new System.Drawing.Point(192, 97);
            this.ayudaCU1.Name = "ayudaCU1";
            this.ayudaCU1.Size = new System.Drawing.Size(697, 441);
            this.ayudaCU1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(239, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "AFEL TECH";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 538);
            this.Controls.Add(this.firstCustomerControl1);
            this.Controls.Add(this.pedidoEstado1);
            this.Controls.Add(this.secondCustomerControl1);
            this.Controls.Add(this.thirdControlUser1);
            this.Controls.Add(this.fourthControlUser1);
            this.Controls.Add(this.ayudaCU1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Ring!";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private ayudaCU ayudaCU1;
        private FourthControlUser fourthControlUser1;
        private ThirdControlUser thirdControlUser1;
        private SecondCustomerControl secondCustomerControl1;
        private PedidoEstado pedidoEstado1;
        private FirstCustomerControl firstCustomerControl1;
        private System.Windows.Forms.Label label2;
    }
}


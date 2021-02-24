namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.dlAbrir = new System.Windows.Forms.OpenFileDialog();
            this.dlCarpeta = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.txtdestinocie = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtorigenpdfcie = new System.Windows.Forms.TextBox();
            this.txtorigentxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDestinopdf = new System.Windows.Forms.TextBox();
            this.TxtPathOrigen = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.boton3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.labellisto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ComboBanco = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "TXT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dlAbrir
            // 
            this.dlAbrir.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.txtdestinocie);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.txtorigenpdfcie);
            this.groupBox2.Controls.Add(this.txtorigentxt);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(44, 26);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fichero txt y PDF a dividir:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Seleccione carpeta destino:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Seleccione el archivo PDF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Seleccione el archivo TXT:";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(377, 159);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(34, 20);
            this.button6.TabIndex = 13;
            this.button6.Text = "...";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtdestinocie
            // 
            this.txtdestinocie.Enabled = false;
            this.txtdestinocie.Location = new System.Drawing.Point(17, 160);
            this.txtdestinocie.Name = "txtdestinocie";
            this.txtdestinocie.Size = new System.Drawing.Size(355, 20);
            this.txtdestinocie.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(377, 90);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(34, 20);
            this.button5.TabIndex = 11;
            this.button5.Text = "...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(377, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 20);
            this.button4.TabIndex = 9;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtorigenpdfcie
            // 
            this.txtorigenpdfcie.Enabled = false;
            this.txtorigenpdfcie.Location = new System.Drawing.Point(17, 91);
            this.txtorigenpdfcie.Name = "txtorigenpdfcie";
            this.txtorigenpdfcie.Size = new System.Drawing.Size(355, 20);
            this.txtorigenpdfcie.TabIndex = 10;
            // 
            // txtorigentxt
            // 
            this.txtorigentxt.Enabled = false;
            this.txtorigentxt.Location = new System.Drawing.Point(15, 39);
            this.txtorigentxt.Name = "txtorigentxt";
            this.txtorigentxt.Size = new System.Drawing.Size(357, 20);
            this.txtorigentxt.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccione el archivo PDF:";
            // 
            // TxtDestinopdf
            // 
            this.TxtDestinopdf.Enabled = false;
            this.TxtDestinopdf.Location = new System.Drawing.Point(17, 172);
            this.TxtDestinopdf.Name = "TxtDestinopdf";
            this.TxtDestinopdf.Size = new System.Drawing.Size(380, 20);
            this.TxtDestinopdf.TabIndex = 6;
            // 
            // TxtPathOrigen
            // 
            this.TxtPathOrigen.Enabled = false;
            this.TxtPathOrigen.Location = new System.Drawing.Point(17, 108);
            this.TxtPathOrigen.Name = "TxtPathOrigen";
            this.TxtPathOrigen.Size = new System.Drawing.Size(380, 20);
            this.TxtPathOrigen.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(403, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 20);
            this.button3.TabIndex = 7;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // boton3
            // 
            this.boton3.Location = new System.Drawing.Point(403, 108);
            this.boton3.Name = "boton3";
            this.boton3.Size = new System.Drawing.Size(34, 20);
            this.boton3.TabIndex = 3;
            this.boton3.Text = "...";
            this.boton3.UseVisualStyleBackColor = true;
            this.boton3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seleccione carpeta destino::";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(17, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "Inicia";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.Controls.Add(this.ComboBanco);
            this.GroupBox1.Controls.Add(this.labellisto);
            this.GroupBox1.Controls.Add(this.pictureBox1);
            this.GroupBox1.Controls.Add(this.button2);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.boton3);
            this.GroupBox1.Controls.Add(this.button3);
            this.GroupBox1.Controls.Add(this.TxtPathOrigen);
            this.GroupBox1.Controls.Add(this.TxtDestinopdf);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(456, 279);
            this.GroupBox1.TabIndex = 9;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Fichero PDF a dividir ";
            // 
            // labellisto
            // 
            this.labellisto.AutoSize = true;
            this.labellisto.ForeColor = System.Drawing.Color.DarkGreen;
            this.labellisto.Location = new System.Drawing.Point(97, 236);
            this.labellisto.Name = "labellisto";
            this.labellisto.Size = new System.Drawing.Size(47, 13);
            this.labellisto.TabIndex = 10;
            this.labellisto.Text = ".....Listo!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(172, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 37);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ComboBanco
            // 
            this.ComboBanco.FormattingEnabled = true;
            this.ComboBanco.Items.AddRange(new object[] {
            "----Seleccione----",
            "Bancomer",
            "Banorte"});
            this.ComboBanco.Location = new System.Drawing.Point(316, 19);
            this.ComboBanco.Name = "ComboBanco";
            this.ComboBanco.Size = new System.Drawing.Size(121, 21);
            this.ComboBanco.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 302);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Name = "Form1";
            this.Text = "Solo Transferencias";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog dlAbrir;
        private System.Windows.Forms.FolderBrowserDialog dlCarpeta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtdestinocie;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtorigenpdfcie;
        private System.Windows.Forms.TextBox txtorigentxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDestinopdf;
        private System.Windows.Forms.TextBox TxtPathOrigen;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button boton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labellisto;
        private System.Windows.Forms.ComboBox ComboBanco;
    }
}


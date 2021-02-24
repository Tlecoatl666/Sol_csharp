namespace WindowsFormsApplication1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labellisto = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.txtdestinocie = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtorigenpdfcie = new System.Windows.Forms.TextBox();
            this.txtorigentxt = new System.Windows.Forms.TextBox();
            this.dlAbrir = new System.Windows.Forms.OpenFileDialog();
            this.dlCarpeta = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labellisto);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.txtdestinocie);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.txtorigenpdfcie);
            this.groupBox2.Controls.Add(this.txtorigentxt);
            this.groupBox2.Location = new System.Drawing.Point(11, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 310);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fichero txt y PDF a dividir:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // labellisto
            // 
            this.labellisto.AutoSize = true;
            this.labellisto.ForeColor = System.Drawing.Color.DarkGreen;
            this.labellisto.Location = new System.Drawing.Point(83, 284);
            this.labellisto.Name = "labellisto";
            this.labellisto.Size = new System.Drawing.Size(47, 13);
            this.labellisto.TabIndex = 18;
            this.labellisto.Text = ".....Listo!";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(158, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 46);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(10, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 39);
            this.button2.TabIndex = 16;
            this.button2.Text = "Inicia";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Seleccione carpeta destino:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Seleccione el archivo PDF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Seleccione el archivo TXT:";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(368, 214);
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
            this.txtdestinocie.Location = new System.Drawing.Point(8, 215);
            this.txtdestinocie.Name = "txtdestinocie";
            this.txtdestinocie.Size = new System.Drawing.Size(355, 20);
            this.txtdestinocie.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(368, 145);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(34, 20);
            this.button5.TabIndex = 11;
            this.button5.Text = "...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(368, 94);
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
            this.txtorigenpdfcie.Location = new System.Drawing.Point(8, 146);
            this.txtorigenpdfcie.Name = "txtorigenpdfcie";
            this.txtorigenpdfcie.Size = new System.Drawing.Size(355, 20);
            this.txtorigenpdfcie.TabIndex = 10;
            // 
            // txtorigentxt
            // 
            this.txtorigentxt.Enabled = false;
            this.txtorigentxt.Location = new System.Drawing.Point(6, 94);
            this.txtorigentxt.Name = "txtorigentxt";
            this.txtorigentxt.Size = new System.Drawing.Size(357, 20);
            this.txtorigentxt.TabIndex = 9;
            // 
            // dlAbrir
            // 
            this.dlAbrir.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 334);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form2";
            this.Text = "Solo CIE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.OpenFileDialog dlAbrir;
        private System.Windows.Forms.FolderBrowserDialog dlCarpeta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labellisto;
    }
}
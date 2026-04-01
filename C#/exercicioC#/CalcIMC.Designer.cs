namespace exercicioC_
{
    partial class CalcIMC
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
            this.button1 = new System.Windows.Forms.Button();
            this.labtitulo = new System.Windows.Forms.Label();
            this.txtAlt = new System.Windows.Forms.TextBox();
            this.labaltura = new System.Windows.Forms.Label();
            this.labpeso = new System.Windows.Forms.Label();
            this.txtkg = new System.Windows.Forms.TextBox();
            this.bttcalc = new System.Windows.Forms.Button();
            this.labResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(612, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labtitulo
            // 
            this.labtitulo.AutoSize = true;
            this.labtitulo.BackColor = System.Drawing.Color.Transparent;
            this.labtitulo.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labtitulo.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labtitulo.Location = new System.Drawing.Point(12, 20);
            this.labtitulo.Name = "labtitulo";
            this.labtitulo.Size = new System.Drawing.Size(371, 60);
            this.labtitulo.TabIndex = 3;
            this.labtitulo.Text = "Calcular IMC";
            // 
            // txtAlt
            // 
            this.txtAlt.Location = new System.Drawing.Point(93, 117);
            this.txtAlt.Name = "txtAlt";
            this.txtAlt.Size = new System.Drawing.Size(255, 20);
            this.txtAlt.TabIndex = 4;
            // 
            // labaltura
            // 
            this.labaltura.AutoSize = true;
            this.labaltura.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labaltura.Location = new System.Drawing.Point(18, 117);
            this.labaltura.Name = "labaltura";
            this.labaltura.Size = new System.Drawing.Size(69, 20);
            this.labaltura.TabIndex = 5;
            this.labaltura.Text = "Altura";
            // 
            // labpeso
            // 
            this.labpeso.AutoSize = true;
            this.labpeso.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labpeso.Location = new System.Drawing.Point(37, 159);
            this.labpeso.Name = "labpeso";
            this.labpeso.Size = new System.Drawing.Size(50, 20);
            this.labpeso.TabIndex = 6;
            this.labpeso.Text = "Peso";
            // 
            // txtkg
            // 
            this.txtkg.Location = new System.Drawing.Point(93, 159);
            this.txtkg.Name = "txtkg";
            this.txtkg.Size = new System.Drawing.Size(144, 20);
            this.txtkg.TabIndex = 7;
            // 
            // bttcalc
            // 
            this.bttcalc.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttcalc.Location = new System.Drawing.Point(247, 148);
            this.bttcalc.Name = "bttcalc";
            this.bttcalc.Size = new System.Drawing.Size(101, 36);
            this.bttcalc.TabIndex = 10;
            this.bttcalc.Text = "Calcular";
            this.bttcalc.UseVisualStyleBackColor = true;
            this.bttcalc.Click += new System.EventHandler(this.bttcalc_Click);
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.BackColor = System.Drawing.Color.Bisque;
            this.labResult.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labResult.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labResult.Location = new System.Drawing.Point(17, 219);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(168, 27);
            this.labResult.TabIndex = 11;
            this.labResult.Text = "placeholder";
            this.labResult.Visible = false;
            // 
            // CalcIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::exercicioC_.Properties.Resources.IMC;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 584);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.bttcalc);
            this.Controls.Add(this.txtkg);
            this.Controls.Add(this.labpeso);
            this.Controls.Add(this.labaltura);
            this.Controls.Add(this.txtAlt);
            this.Controls.Add(this.labtitulo);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "CalcIMC";
            this.Text = "CalcIMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labtitulo;
        private System.Windows.Forms.TextBox txtAlt;
        private System.Windows.Forms.Label labaltura;
        private System.Windows.Forms.Label labpeso;
        private System.Windows.Forms.TextBox txtkg;
        private System.Windows.Forms.Button bttcalc;
        private System.Windows.Forms.Label labResult;
    }
}
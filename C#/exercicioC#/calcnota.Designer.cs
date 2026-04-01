namespace exercicioC_
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
            this.button1 = new System.Windows.Forms.Button();
            this.labtitulo = new System.Windows.Forms.Label();
            this.labnome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnota1 = new System.Windows.Forms.TextBox();
            this.txtnota2 = new System.Windows.Forms.TextBox();
            this.txtnota3 = new System.Windows.Forms.TextBox();
            this.bttcalc = new System.Windows.Forms.Button();
            this.LabResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(672, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labtitulo
            // 
            this.labtitulo.AutoSize = true;
            this.labtitulo.BackColor = System.Drawing.Color.Transparent;
            this.labtitulo.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labtitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labtitulo.Location = new System.Drawing.Point(40, 55);
            this.labtitulo.Name = "labtitulo";
            this.labtitulo.Size = new System.Drawing.Size(276, 40);
            this.labtitulo.TabIndex = 1;
            this.labtitulo.Text = "Calcular Nota";
            // 
            // labnome
            // 
            this.labnome.AutoSize = true;
            this.labnome.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labnome.Location = new System.Drawing.Point(43, 137);
            this.labnome.Name = "labnome";
            this.labnome.Size = new System.Drawing.Size(56, 20);
            this.labnome.TabIndex = 2;
            this.labnome.Text = "Nome";
            this.labnome.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(117, 137);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(255, 20);
            this.txtnome.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nota 1 ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nota 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nota 2";
            // 
            // txtnota1
            // 
            this.txtnota1.Location = new System.Drawing.Point(117, 174);
            this.txtnota1.Name = "txtnota1";
            this.txtnota1.Size = new System.Drawing.Size(49, 20);
            this.txtnota1.TabIndex = 6;
            // 
            // txtnota2
            // 
            this.txtnota2.Location = new System.Drawing.Point(117, 210);
            this.txtnota2.Name = "txtnota2";
            this.txtnota2.Size = new System.Drawing.Size(49, 20);
            this.txtnota2.TabIndex = 7;
            // 
            // txtnota3
            // 
            this.txtnota3.Location = new System.Drawing.Point(291, 174);
            this.txtnota3.Name = "txtnota3";
            this.txtnota3.Size = new System.Drawing.Size(49, 20);
            this.txtnota3.TabIndex = 8;
            // 
            // bttcalc
            // 
            this.bttcalc.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttcalc.Location = new System.Drawing.Point(271, 210);
            this.bttcalc.Name = "bttcalc";
            this.bttcalc.Size = new System.Drawing.Size(101, 36);
            this.bttcalc.TabIndex = 9;
            this.bttcalc.Text = "Calcular";
            this.bttcalc.UseVisualStyleBackColor = true;
            this.bttcalc.Click += new System.EventHandler(this.bttcalc_Click);
            // 
            // LabResult
            // 
            this.LabResult.AutoSize = true;
            this.LabResult.BackColor = System.Drawing.Color.DimGray;
            this.LabResult.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabResult.Location = new System.Drawing.Point(42, 307);
            this.LabResult.Name = "LabResult";
            this.LabResult.Size = new System.Drawing.Size(168, 27);
            this.LabResult.TabIndex = 10;
            this.LabResult.Text = "placeholder";
            this.LabResult.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::exercicioC_.Properties.Resources.calcular;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabResult);
            this.Controls.Add(this.bttcalc);
            this.Controls.Add(this.txtnota3);
            this.Controls.Add(this.txtnota2);
            this.Controls.Add(this.txtnota1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.labnome);
            this.Controls.Add(this.labtitulo);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labtitulo;
        private System.Windows.Forms.Label labnome;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnota1;
        private System.Windows.Forms.TextBox txtnota2;
        private System.Windows.Forms.TextBox txtnota3;
        private System.Windows.Forms.Button bttcalc;
        private System.Windows.Forms.Label LabResult;
    }
}
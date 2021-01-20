namespace prj_Ex04
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
            this.rdBFeminino = new System.Windows.Forms.RadioButton();
            this.rdBMasculino = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btnPesoIdeal = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdBFeminino
            // 
            this.rdBFeminino.AutoSize = true;
            this.rdBFeminino.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdBFeminino.Location = new System.Drawing.Point(31, 34);
            this.rdBFeminino.Name = "rdBFeminino";
            this.rdBFeminino.Size = new System.Drawing.Size(92, 24);
            this.rdBFeminino.TabIndex = 0;
            this.rdBFeminino.TabStop = true;
            this.rdBFeminino.Text = "Feminino";
            this.rdBFeminino.UseVisualStyleBackColor = true;
            // 
            // rdBMasculino
            // 
            this.rdBMasculino.AutoSize = true;
            this.rdBMasculino.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdBMasculino.Location = new System.Drawing.Point(31, 78);
            this.rdBMasculino.Name = "rdBMasculino";
            this.rdBMasculino.Size = new System.Drawing.Size(98, 24);
            this.rdBMasculino.TabIndex = 1;
            this.rdBMasculino.TabStop = true;
            this.rdBMasculino.Text = "Masculino";
            this.rdBMasculino.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.rdBMasculino);
            this.groupBox1.Controls.Add(this.rdBFeminino);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(29, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 157);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.txtAltura);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(244, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 157);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Altura";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(33, 64);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(123, 26);
            this.txtAltura.TabIndex = 0;
            this.txtAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumero);
            // 
            // btnPesoIdeal
            // 
            this.btnPesoIdeal.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnPesoIdeal.Location = new System.Drawing.Point(104, 247);
            this.btnPesoIdeal.Name = "btnPesoIdeal";
            this.btnPesoIdeal.Size = new System.Drawing.Size(106, 37);
            this.btnPesoIdeal.TabIndex = 4;
            this.btnPesoIdeal.Text = "Peso Ideal";
            this.btnPesoIdeal.UseVisualStyleBackColor = false;
            this.btnPesoIdeal.Click += new System.EventHandler(this.BtnPesoIdeal);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnNovo.Location = new System.Drawing.Point(244, 247);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(106, 37);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.lblPeso);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(29, 314);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(396, 157);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seu Peso Ideal";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPeso.Location = new System.Drawing.Point(154, 54);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(0, 20);
            this.lblPeso.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 592);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnPesoIdeal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Peso Ideal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdBFeminino;
        private System.Windows.Forms.RadioButton rdBMasculino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btnPesoIdeal;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblPeso;
    }
}


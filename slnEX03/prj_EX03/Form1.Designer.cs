namespace prj_EX03
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
            this.rdB5a7 = new System.Windows.Forms.RadioButton();
            this.rdB8a11 = new System.Windows.Forms.RadioButton();
            this.rdB12a13 = new System.Windows.Forms.RadioButton();
            this.rdB14a17 = new System.Windows.Forms.RadioButton();
            this.rdB18ouMais = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClassificar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdB5a7
            // 
            this.rdB5a7.AutoSize = true;
            this.rdB5a7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdB5a7.Location = new System.Drawing.Point(43, 47);
            this.rdB5a7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdB5a7.Name = "rdB5a7";
            this.rdB5a7.Size = new System.Drawing.Size(126, 24);
            this.rdB5a7.TabIndex = 0;
            this.rdB5a7.TabStop = true;
            this.rdB5a7.Text = "De 5 a 7 anos";
            this.rdB5a7.UseVisualStyleBackColor = true;
            // 
            // rdB8a11
            // 
            this.rdB8a11.AutoSize = true;
            this.rdB8a11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdB8a11.Location = new System.Drawing.Point(43, 78);
            this.rdB8a11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdB8a11.Name = "rdB8a11";
            this.rdB8a11.Size = new System.Drawing.Size(135, 24);
            this.rdB8a11.TabIndex = 1;
            this.rdB8a11.TabStop = true;
            this.rdB8a11.Text = "De 8 a 11 anos";
            this.rdB8a11.UseVisualStyleBackColor = true;
            // 
            // rdB12a13
            // 
            this.rdB12a13.AutoSize = true;
            this.rdB12a13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdB12a13.Location = new System.Drawing.Point(43, 110);
            this.rdB12a13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdB12a13.Name = "rdB12a13";
            this.rdB12a13.Size = new System.Drawing.Size(144, 24);
            this.rdB12a13.TabIndex = 2;
            this.rdB12a13.TabStop = true;
            this.rdB12a13.Text = "De 12 a 13 anos";
            this.rdB12a13.UseVisualStyleBackColor = true;
            // 
            // rdB14a17
            // 
            this.rdB14a17.AutoSize = true;
            this.rdB14a17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdB14a17.Location = new System.Drawing.Point(43, 141);
            this.rdB14a17.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdB14a17.Name = "rdB14a17";
            this.rdB14a17.Size = new System.Drawing.Size(144, 24);
            this.rdB14a17.TabIndex = 3;
            this.rdB14a17.TabStop = true;
            this.rdB14a17.Text = "De 14 a 17 anos";
            this.rdB14a17.UseVisualStyleBackColor = true;
            // 
            // rdB18ouMais
            // 
            this.rdB18ouMais.AutoSize = true;
            this.rdB18ouMais.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdB18ouMais.Location = new System.Drawing.Point(43, 173);
            this.rdB18ouMais.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdB18ouMais.Name = "rdB18ouMais";
            this.rdB18ouMais.Size = new System.Drawing.Size(104, 24);
            this.rdB18ouMais.TabIndex = 4;
            this.rdB18ouMais.TabStop = true;
            this.rdB18ouMais.Text = "18 ou mais";
            this.rdB18ouMais.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdB18ouMais);
            this.groupBox1.Controls.Add(this.rdB14a17);
            this.groupBox1.Controls.Add(this.rdB12a13);
            this.groupBox1.Controls.Add(this.rdB8a11);
            this.groupBox1.Controls.Add(this.rdB5a7);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(31, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 248);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione o idade do nadador";
            // 
            // btnClassificar
            // 
            this.btnClassificar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnClassificar.Location = new System.Drawing.Point(371, 100);
            this.btnClassificar.Name = "btnClassificar";
            this.btnClassificar.Size = new System.Drawing.Size(96, 36);
            this.btnClassificar.TabIndex = 6;
            this.btnClassificar.Text = "Classificar";
            this.btnClassificar.UseVisualStyleBackColor = false;
            this.btnClassificar.Click += new System.EventHandler(this.BtnClassificar);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnNovo.Location = new System.Drawing.Point(371, 143);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(96, 36);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnSair.Location = new System.Drawing.Point(371, 186);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(96, 36);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.BtnSair);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Categoria";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(233, 325);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(51, 20);
            this.lblCategoria.TabIndex = 10;
            this.lblCategoria.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 396);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnClassificar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Nadador ++";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdB5a7;
        private System.Windows.Forms.RadioButton rdB8a11;
        private System.Windows.Forms.RadioButton rdB12a13;
        private System.Windows.Forms.RadioButton rdB14a17;
        private System.Windows.Forms.RadioButton rdB18ouMais;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClassificar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCategoria;
    }
}


namespace prj_EX02
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.gpDadosFuncionarios = new System.Windows.Forms.GroupBox();
            this.gpResultados = new System.Windows.Forms.GroupBox();
            this.lblSalarioTotal = new System.Windows.Forms.Label();
            this.lblSalarioExcedente = new System.Windows.Forms.Label();
            this.lblHorasExcesso = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gpDadosFuncionarios.SuspendLayout();
            this.gpResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(20, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(20, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horas Trabalhadas";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(180, 43);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 26);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumero);
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(180, 83);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(100, 26);
            this.txtHoras.TabIndex = 3;
            this.txtHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumero);
            // 
            // gpDadosFuncionarios
            // 
            this.gpDadosFuncionarios.Controls.Add(this.txtHoras);
            this.gpDadosFuncionarios.Controls.Add(this.txtCodigo);
            this.gpDadosFuncionarios.Controls.Add(this.label2);
            this.gpDadosFuncionarios.Controls.Add(this.label1);
            this.gpDadosFuncionarios.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gpDadosFuncionarios.Location = new System.Drawing.Point(34, 37);
            this.gpDadosFuncionarios.Name = "gpDadosFuncionarios";
            this.gpDadosFuncionarios.Size = new System.Drawing.Size(388, 176);
            this.gpDadosFuncionarios.TabIndex = 4;
            this.gpDadosFuncionarios.TabStop = false;
            this.gpDadosFuncionarios.Text = "Dados do Funcionário";
            // 
            // gpResultados
            // 
            this.gpResultados.Controls.Add(this.lblSalarioTotal);
            this.gpResultados.Controls.Add(this.lblSalarioExcedente);
            this.gpResultados.Controls.Add(this.lblHorasExcesso);
            this.gpResultados.Controls.Add(this.label5);
            this.gpResultados.Controls.Add(this.label3);
            this.gpResultados.Controls.Add(this.label4);
            this.gpResultados.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gpResultados.Location = new System.Drawing.Point(34, 250);
            this.gpResultados.Name = "gpResultados";
            this.gpResultados.Size = new System.Drawing.Size(388, 176);
            this.gpResultados.TabIndex = 5;
            this.gpResultados.TabStop = false;
            this.gpResultados.Text = "Resultados";
            // 
            // lblSalarioTotal
            // 
            this.lblSalarioTotal.AutoSize = true;
            this.lblSalarioTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSalarioTotal.Location = new System.Drawing.Point(253, 111);
            this.lblSalarioTotal.Name = "lblSalarioTotal";
            this.lblSalarioTotal.Size = new System.Drawing.Size(0, 20);
            this.lblSalarioTotal.TabIndex = 5;
            // 
            // lblSalarioExcedente
            // 
            this.lblSalarioExcedente.AutoSize = true;
            this.lblSalarioExcedente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSalarioExcedente.Location = new System.Drawing.Point(253, 74);
            this.lblSalarioExcedente.Name = "lblSalarioExcedente";
            this.lblSalarioExcedente.Size = new System.Drawing.Size(0, 20);
            this.lblSalarioExcedente.TabIndex = 4;
            // 
            // lblHorasExcesso
            // 
            this.lblHorasExcesso.AutoSize = true;
            this.lblHorasExcesso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHorasExcesso.Location = new System.Drawing.Point(253, 43);
            this.lblHorasExcesso.Name = "lblHorasExcesso";
            this.lblHorasExcesso.Size = new System.Drawing.Size(0, 20);
            this.lblHorasExcesso.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(20, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Sálario Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(20, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sálario Excedente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(20, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Horas em excesso";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnCalcular.Location = new System.Drawing.Point(449, 182);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 31);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnSair.Location = new System.Drawing.Point(449, 255);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 31);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.BtnSair);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnLimpar.Location = new System.Drawing.Point(449, 219);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 31);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 457);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gpResultados);
            this.Controls.Add(this.gpDadosFuncionarios);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Horas Extras";
            this.gpDadosFuncionarios.ResumeLayout(false);
            this.gpDadosFuncionarios.PerformLayout();
            this.gpResultados.ResumeLayout(false);
            this.gpResultados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.GroupBox gpDadosFuncionarios;
        private System.Windows.Forms.GroupBox gpResultados;
        private System.Windows.Forms.Label lblSalarioTotal;
        private System.Windows.Forms.Label lblSalarioExcedente;
        private System.Windows.Forms.Label lblHorasExcesso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
    }
}


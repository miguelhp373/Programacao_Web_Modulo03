
namespace Exemplo_POO
{
    partial class FrInterface_Poupanca
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.saldo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tip02 = new System.Windows.Forms.RadioButton();
            this.tip01 = new System.Windows.Forms.RadioButton();
            this.cliente = new System.Windows.Forms.TextBox();
            this.valor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.conta = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.agencia = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Coral;
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.tip02);
            this.panel4.Controls.Add(this.tip01);
            this.panel4.Controls.Add(this.cliente);
            this.panel4.Controls.Add(this.valor);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(1, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(436, 376);
            this.panel4.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(241, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 20);
            this.button2.TabIndex = 13;
            this.button2.Text = "Criar Conta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MistyRose;
            this.panel3.Controls.Add(this.saldo);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(197, 337);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 32);
            this.panel3.TabIndex = 12;
            // 
            // saldo
            // 
            this.saldo.AutoSize = true;
            this.saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saldo.Location = new System.Drawing.Point(113, 3);
            this.saldo.Name = "saldo";
            this.saldo.Size = new System.Drawing.Size(50, 25);
            this.saldo.TabIndex = 15;
            this.saldo.Text = "0,00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(13, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Saldo:  R$";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Concluir Operação";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo de Operação:";
            // 
            // tip02
            // 
            this.tip02.AutoSize = true;
            this.tip02.Location = new System.Drawing.Point(31, 108);
            this.tip02.Name = "tip02";
            this.tip02.Size = new System.Drawing.Size(67, 17);
            this.tip02.TabIndex = 9;
            this.tip02.Text = "Depósito";
            this.tip02.UseVisualStyleBackColor = true;
            // 
            // tip01
            // 
            this.tip01.AutoSize = true;
            this.tip01.Location = new System.Drawing.Point(31, 85);
            this.tip01.Name = "tip01";
            this.tip01.Size = new System.Drawing.Size(56, 17);
            this.tip01.TabIndex = 8;
            this.tip01.Text = "Saque";
            this.tip01.UseVisualStyleBackColor = true;
            // 
            // cliente
            // 
            this.cliente.Location = new System.Drawing.Point(31, 29);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(204, 20);
            this.cliente.TabIndex = 6;
            // 
            // valor
            // 
            this.valor.Location = new System.Drawing.Point(31, 154);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(149, 20);
            this.valor.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Controls.Add(this.conta);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.agencia);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 63);
            this.panel2.TabIndex = 3;
            // 
            // conta
            // 
            this.conta.Location = new System.Drawing.Point(294, 24);
            this.conta.Name = "conta";
            this.conta.Size = new System.Drawing.Size(100, 20);
            this.conta.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 369);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Conta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agência:";
            // 
            // agencia
            // 
            this.agencia.Location = new System.Drawing.Point(80, 24);
            this.agencia.Name = "agencia";
            this.agencia.Size = new System.Drawing.Size(100, 20);
            this.agencia.TabIndex = 4;
            // 
            // FrInterface_Poupanca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 436);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "FrInterface_Poupanca";
            this.Text = "Conta Poupança";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label saldo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton tip02;
        private System.Windows.Forms.RadioButton tip01;
        private System.Windows.Forms.TextBox cliente;
        private System.Windows.Forms.TextBox valor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox conta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox agencia;
    }
}
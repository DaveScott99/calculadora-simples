namespace TesteComTela
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            txtTotal = new TextBox();
            btnSomar = new Button();
            btnSubtrair = new Button();
            btnMultiplicar = new Button();
            txtDividir = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 52);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 0;
            label1.Text = "Calculadora Simples";
            label1.Click += c;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 101);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "1 Valor: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 136);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 2;
            label3.Text = "2 Valor: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 173);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 3;
            label4.Text = "Total:";
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(90, 100);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(172, 23);
            txtValor1.TabIndex = 4;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(90, 136);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(172, 23);
            txtValor2.TabIndex = 5;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(90, 170);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(172, 23);
            txtTotal.TabIndex = 6;
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(37, 222);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(75, 39);
            btnSomar.TabIndex = 7;
            btnSomar.Text = "Somar";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // btnSubtrair
            // 
            btnSubtrair.Location = new Point(118, 222);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(75, 39);
            btnSubtrair.TabIndex = 8;
            btnSubtrair.Text = "Subtrair";
            btnSubtrair.UseVisualStyleBackColor = true;
            btnSubtrair.Click += btnSubtrair_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(199, 222);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(75, 39);
            btnMultiplicar.TabIndex = 9;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // txtDividir
            // 
            txtDividir.Location = new Point(37, 267);
            txtDividir.Name = "txtDividir";
            txtDividir.Size = new Size(75, 37);
            txtDividir.TabIndex = 10;
            txtDividir.Text = "Dividir";
            txtDividir.UseVisualStyleBackColor = true;
            txtDividir.Click += txtDividir_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(118, 267);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 37);
            btnSair.TabIndex = 11;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 364);
            Controls.Add(btnSair);
            Controls.Add(txtDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnSubtrair);
            Controls.Add(btnSomar);
            Controls.Add(txtTotal);
            Controls.Add(txtValor2);
            Controls.Add(txtValor1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtValor1;
        private TextBox txtValor2;
        private TextBox txtTotal;
        private Button btnSomar;
        private Button btnSubtrair;
        private Button btnMultiplicar;
        private Button txtDividir;
        private Button btnSair;
    }
}
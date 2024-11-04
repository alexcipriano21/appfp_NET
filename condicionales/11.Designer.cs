namespace appfp_NET.condicionales
{
    partial class _11
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
            btnCalcular = new Button();
            txtSigno = new TextBox();
            txtNumero = new TextBox();
            lblSuma = new Label();
            lblNumero = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.AccessibleName = "btnCalcular";
            btnCalcular.Location = new Point(122, 147);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 14;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtSigno
            // 
            txtSigno.AccessibleName = "txtSigno";
            txtSigno.Location = new Point(126, 97);
            txtSigno.Name = "txtSigno";
            txtSigno.ReadOnly = true;
            txtSigno.Size = new Size(100, 23);
            txtSigno.TabIndex = 12;
            // 
            // txtNumero
            // 
            txtNumero.AccessibleName = "txtNumero";
            txtNumero.AccessibleRole = AccessibleRole.None;
            txtNumero.Location = new Point(126, 40);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 13;
            // 
            // lblSuma
            // 
            lblSuma.AccessibleName = "lblSigno";
            lblSuma.AutoSize = true;
            lblSuma.Location = new Point(59, 105);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(40, 15);
            lblSuma.TabIndex = 10;
            lblSuma.Text = "Signo:";
            // 
            // lblNumero
            // 
            lblNumero.AccessibleName = "lblNumero";
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(59, 43);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(59, 15);
            lblNumero.TabIndex = 11;
            lblNumero.Text = "Numeros:";
            // 
            // _11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 211);
            Controls.Add(btnCalcular);
            Controls.Add(txtSigno);
            Controls.Add(txtNumero);
            Controls.Add(lblSuma);
            Controls.Add(lblNumero);
            Name = "_11";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "_11";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private TextBox txtSigno;
        private TextBox txtNumero;
        private Label lblSuma;
        private Label lblNumero;
    }
}
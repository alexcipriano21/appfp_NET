namespace appfp_NET.secuenciales
{
    partial class _09
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
            txtSuma = new TextBox();
            txtNumero = new TextBox();
            lblSuma = new Label();
            lblNumero = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.AccessibleName = "btnCalcular";
            btnCalcular.Location = new Point(106, 151);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtSuma
            // 
            txtSuma.AccessibleName = "txtSuma";
            txtSuma.Location = new Point(110, 101);
            txtSuma.Name = "txtSuma";
            txtSuma.ReadOnly = true;
            txtSuma.Size = new Size(100, 23);
            txtSuma.TabIndex = 7;
            // 
            // txtNumero
            // 
            txtNumero.AccessibleName = "txtNumero";
            txtNumero.AccessibleRole = AccessibleRole.None;
            txtNumero.Location = new Point(110, 44);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 8;
            // 
            // lblSuma
            // 
            lblSuma.AccessibleName = "lblSuma";
            lblSuma.AutoSize = true;
            lblSuma.Location = new Point(43, 109);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(40, 15);
            lblSuma.TabIndex = 4;
            lblSuma.Text = "Suma:";
            // 
            // lblNumero
            // 
            lblNumero.AccessibleName = "lblNumero";
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(43, 47);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(59, 15);
            lblNumero.TabIndex = 6;
            lblNumero.Text = "Numeros:";
            // 
            // _09
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 211);
            Controls.Add(btnCalcular);
            Controls.Add(txtSuma);
            Controls.Add(txtNumero);
            Controls.Add(lblSuma);
            Controls.Add(lblNumero);
            Name = "_09";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "_09";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private TextBox txtSuma;
        private TextBox txtNumero;
        private Label lblSuma;
        private Label lblNumero;
    }
}
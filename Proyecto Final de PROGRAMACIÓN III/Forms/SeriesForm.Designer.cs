namespace Proyecto_Final_de_PROGRAMACIÓN_III.Forms
{
    partial class SeriesForm
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
            label4 = new Label();
            txtInput = new TextBox();
            lblResultado = new Label();
            btnSumaSerie2 = new Button();
            btnSerie2 = new Button();
            btnSumaSerie = new Button();
            btnSerie1 = new Button();
            btnFibonacci = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label4.Location = new Point(217, 80);
            label4.Name = "label4";
            label4.Size = new Size(84, 30);
            label4.TabIndex = 22;
            label4.Text = "SERIES:";
            // 
            // txtInput
            // 
            txtInput.Anchor = AnchorStyles.Top;
            txtInput.BorderStyle = BorderStyle.FixedSingle;
            txtInput.Location = new Point(352, 87);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(160, 23);
            txtInput.TabIndex = 19;
            txtInput.Text = " ";
            // 
            // lblResultado
            // 
            lblResultado.Anchor = AnchorStyles.Top;
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(390, 172);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 17;
            // 
            // btnSumaSerie2
            // 
            btnSumaSerie2.Anchor = AnchorStyles.Top;
            btnSumaSerie2.FlatStyle = FlatStyle.Flat;
            btnSumaSerie2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSumaSerie2.Location = new Point(549, 285);
            btnSumaSerie2.Name = "btnSumaSerie2";
            btnSumaSerie2.Size = new Size(106, 39);
            btnSumaSerie2.TabIndex = 16;
            btnSumaSerie2.Text = "Suma de Serie 2";
            btnSumaSerie2.UseVisualStyleBackColor = true;
            btnSumaSerie2.Click += btnSumaSerie2_Click;
            // 
            // btnSerie2
            // 
            btnSerie2.Anchor = AnchorStyles.Top;
            btnSerie2.FlatStyle = FlatStyle.Flat;
            btnSerie2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSerie2.Location = new Point(422, 285);
            btnSerie2.Name = "btnSerie2";
            btnSerie2.Size = new Size(106, 39);
            btnSerie2.TabIndex = 15;
            btnSerie2.Text = "Serie 2";
            btnSerie2.UseVisualStyleBackColor = true;
            btnSerie2.Click += btnSerie2_Click;
            // 
            // btnSumaSerie
            // 
            btnSumaSerie.Anchor = AnchorStyles.Top;
            btnSumaSerie.FlatStyle = FlatStyle.Flat;
            btnSumaSerie.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSumaSerie.Location = new Point(294, 285);
            btnSumaSerie.Name = "btnSumaSerie";
            btnSumaSerie.Size = new Size(106, 39);
            btnSumaSerie.TabIndex = 14;
            btnSumaSerie.Text = "Suma de Serie";
            btnSumaSerie.UseVisualStyleBackColor = true;
            btnSumaSerie.Click += btnSumaSerie_Click;
            // 
            // btnSerie1
            // 
            btnSerie1.Anchor = AnchorStyles.Top;
            btnSerie1.FlatStyle = FlatStyle.Flat;
            btnSerie1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSerie1.Location = new Point(172, 285);
            btnSerie1.Name = "btnSerie1";
            btnSerie1.Size = new Size(106, 39);
            btnSerie1.TabIndex = 13;
            btnSerie1.Text = "Serie 1";
            btnSerie1.UseVisualStyleBackColor = true;
            btnSerie1.Click += btnSerie1_Click;
            // 
            // btnFibonacci
            // 
            btnFibonacci.Anchor = AnchorStyles.Top;
            btnFibonacci.FlatStyle = FlatStyle.Flat;
            btnFibonacci.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnFibonacci.Location = new Point(47, 285);
            btnFibonacci.Name = "btnFibonacci";
            btnFibonacci.Size = new Size(106, 39);
            btnFibonacci.TabIndex = 12;
            btnFibonacci.Text = "Fibonacci";
            btnFibonacci.UseVisualStyleBackColor = true;
            btnFibonacci.Click += btnFibonacci_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(217, 167);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 17;
            label1.Text = "  RESULTADO   ";
            // 
            // SeriesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 462);
            Controls.Add(label4);
            Controls.Add(txtInput);
            Controls.Add(label1);
            Controls.Add(lblResultado);
            Controls.Add(btnSumaSerie2);
            Controls.Add(btnSerie2);
            Controls.Add(btnSumaSerie);
            Controls.Add(btnSerie1);
            Controls.Add(btnFibonacci);
            Name = "SeriesForm";
            Text = "SERIES";
            Load += SeriesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private TextBox txtInput;
        private Label lblResultado;
        private Button btnSumaSerie2;
        private Button btnSerie2;
        private Button btnSumaSerie;
        private Button btnSerie1;
        private Button btnFibonacci;
        private Label label1;
    }
}
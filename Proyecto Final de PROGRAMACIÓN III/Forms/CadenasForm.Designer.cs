namespace Proyecto_Final_de_PROGRAMACIÓN_III.Forms
{
    partial class CadenasForm
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
            btnEjercicio5 = new Button();
            btnEjercicio4 = new Button();
            btnEjercicio3 = new Button();
            btnEjercicio2 = new Button();
            btnEjercicio1 = new Button();
            txtInput = new TextBox();
            CALCULAR = new Label();
            label2 = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // btnEjercicio5
            // 
            btnEjercicio5.Anchor = AnchorStyles.Top;
            btnEjercicio5.FlatStyle = FlatStyle.Flat;
            btnEjercicio5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnEjercicio5.Location = new Point(80, 333);
            btnEjercicio5.Name = "btnEjercicio5";
            btnEjercicio5.Size = new Size(164, 45);
            btnEjercicio5.TabIndex = 11;
            btnEjercicio5.Text = "Invertir Cadena";
            btnEjercicio5.UseVisualStyleBackColor = true;
            btnEjercicio5.Click += btnEjercicio5_Click;
            // 
            // btnEjercicio4
            // 
            btnEjercicio4.Anchor = AnchorStyles.Top;
            btnEjercicio4.FlatStyle = FlatStyle.Flat;
            btnEjercicio4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnEjercicio4.Location = new Point(369, 267);
            btnEjercicio4.Name = "btnEjercicio4";
            btnEjercicio4.Size = new Size(260, 45);
            btnEjercicio4.TabIndex = 10;
            btnEjercicio4.Text = "Eliminar 1ra Letra";
            btnEjercicio4.UseVisualStyleBackColor = true;
            btnEjercicio4.Click += btnEjercicio4_Click;
            // 
            // btnEjercicio3
            // 
            btnEjercicio3.Anchor = AnchorStyles.Top;
            btnEjercicio3.FlatStyle = FlatStyle.Flat;
            btnEjercicio3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnEjercicio3.Location = new Point(455, 333);
            btnEjercicio3.Name = "btnEjercicio3";
            btnEjercicio3.Size = new Size(174, 45);
            btnEjercicio3.TabIndex = 9;
            btnEjercicio3.Text = "Cadena más larga";
            btnEjercicio3.UseVisualStyleBackColor = true;
            btnEjercicio3.Click += btnEjercicio3_Click;
            // 
            // btnEjercicio2
            // 
            btnEjercicio2.Anchor = AnchorStyles.Top;
            btnEjercicio2.FlatStyle = FlatStyle.Flat;
            btnEjercicio2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnEjercicio2.Location = new Point(263, 333);
            btnEjercicio2.Name = "btnEjercicio2";
            btnEjercicio2.Size = new Size(173, 45);
            btnEjercicio2.TabIndex = 8;
            btnEjercicio2.Text = "Eliminar Vocal";
            btnEjercicio2.UseVisualStyleBackColor = true;
            btnEjercicio2.Click += btnEjercicio2_Click;
            // 
            // btnEjercicio1
            // 
            btnEjercicio1.Anchor = AnchorStyles.Top;
            btnEjercicio1.FlatStyle = FlatStyle.Flat;
            btnEjercicio1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnEjercicio1.Location = new Point(79, 267);
            btnEjercicio1.Name = "btnEjercicio1";
            btnEjercicio1.Size = new Size(265, 45);
            btnEjercicio1.TabIndex = 7;
            btnEjercicio1.Text = "Cant. de Palabras";
            btnEjercicio1.UseVisualStyleBackColor = true;
            btnEjercicio1.Click += btnEjercicio1_Click;
            // 
            // txtInput
            // 
            txtInput.Anchor = AnchorStyles.Top;
            txtInput.BorderStyle = BorderStyle.FixedSingle;
            txtInput.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInput.Location = new Point(345, 90);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(158, 27);
            txtInput.TabIndex = 15;
            // 
            // CALCULAR
            // 
            CALCULAR.Anchor = AnchorStyles.Top;
            CALCULAR.AutoSize = true;
            CALCULAR.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CALCULAR.Location = new Point(205, 89);
            CALCULAR.Name = "CALCULAR";
            CALCULAR.Size = new Size(113, 28);
            CALCULAR.TabIndex = 12;
            CALCULAR.Text = "CALCULAR:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(227, 158);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 13;
            label2.Text = "Resultado:";
            // 
            // lblResult
            // 
            lblResult.Anchor = AnchorStyles.Top;
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(345, 159);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 21);
            lblResult.TabIndex = 14;
            // 
            // CadenasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 462);
            Controls.Add(txtInput);
            Controls.Add(CALCULAR);
            Controls.Add(label2);
            Controls.Add(lblResult);
            Controls.Add(btnEjercicio5);
            Controls.Add(btnEjercicio4);
            Controls.Add(btnEjercicio3);
            Controls.Add(btnEjercicio2);
            Controls.Add(btnEjercicio1);
            Name = "CadenasForm";
            Text = "CADENAS";
            Load += CadenasForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEjercicio2;
        private Button btnEjercicio1;
        private Button btnEjercicio3;
        private Button btnEjercicio4;
        private Button btnEjercicio5;
        private TextBox txtInput;
        private Label CALCULAR;
        private Label label2;
        private Label lblResult;
    }
}
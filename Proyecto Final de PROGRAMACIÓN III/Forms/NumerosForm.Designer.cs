namespace Proyecto_Final_de_PROGRAMACIÓN_III.Forms
{
    partial class NumerosForm
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
            txtInput = new TextBox();
            label1 = new Label();
            lblResultado = new Label();
            label2 = new Label();
            ejercicio1 = new Button();
            ejercicio2 = new Button();
            ejercicio3 = new Button();
            ejercicio4 = new Button();
            ejercicio5 = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Anchor = AnchorStyles.Top;
            txtInput.BorderStyle = BorderStyle.FixedSingle;
            txtInput.Location = new Point(342, 84);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(155, 23);
            txtInput.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(190, 83);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 3;
            label1.Text = "CALCULAR:";
            // 
            // lblResultado
            // 
            lblResultado.Anchor = AnchorStyles.Top;
            lblResultado.AutoSize = true;
            lblResultado.FlatStyle = FlatStyle.Flat;
            lblResultado.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(377, 160);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 19);
            lblResultado.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(220, 157);
            label2.Name = "label2";
            label2.Size = new Size(101, 21);
            label2.TabIndex = 3;
            label2.Text = "RESULTADO:";
            // 
            // ejercicio1
            // 
            ejercicio1.Anchor = AnchorStyles.Top;
            ejercicio1.FlatStyle = FlatStyle.Flat;
            ejercicio1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            ejercicio1.Location = new Point(199, 269);
            ejercicio1.Name = "ejercicio1";
            ejercicio1.Size = new Size(155, 37);
            ejercicio1.TabIndex = 0;
            ejercicio1.Text = "Mayor Dígito";
            ejercicio1.UseVisualStyleBackColor = true;
            ejercicio1.Click += ejercicio1_Click;
            // 
            // ejercicio2
            // 
            ejercicio2.Anchor = AnchorStyles.Top;
            ejercicio2.FlatStyle = FlatStyle.Flat;
            ejercicio2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            ejercicio2.Location = new Point(390, 269);
            ejercicio2.Name = "ejercicio2";
            ejercicio2.Size = new Size(155, 37);
            ejercicio2.TabIndex = 0;
            ejercicio2.Text = "Suma de Pares";
            ejercicio2.UseVisualStyleBackColor = true;
            ejercicio2.Click += ejercicio2_Click;
            // 
            // ejercicio3
            // 
            ejercicio3.Anchor = AnchorStyles.Top;
            ejercicio3.AutoSize = true;
            ejercicio3.FlatStyle = FlatStyle.Flat;
            ejercicio3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            ejercicio3.Location = new Point(113, 339);
            ejercicio3.Name = "ejercicio3";
            ejercicio3.Size = new Size(157, 37);
            ejercicio3.TabIndex = 0;
            ejercicio3.Text = "Mover num Mayor";
            ejercicio3.UseVisualStyleBackColor = true;
            ejercicio3.Click += ejercicio3_Click;
            // 
            // ejercicio4
            // 
            ejercicio4.Anchor = AnchorStyles.Top;
            ejercicio4.AutoSize = true;
            ejercicio4.FlatStyle = FlatStyle.Flat;
            ejercicio4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            ejercicio4.Location = new Point(293, 339);
            ejercicio4.Name = "ejercicio4";
            ejercicio4.Size = new Size(160, 37);
            ejercicio4.TabIndex = 0;
            ejercicio4.Text = "Está ordenado?";
            ejercicio4.UseVisualStyleBackColor = true;
            ejercicio4.Click += ejercicio4_Click;
            // 
            // ejercicio5
            // 
            ejercicio5.Anchor = AnchorStyles.Top;
            ejercicio5.AutoSize = true;
            ejercicio5.FlatStyle = FlatStyle.Flat;
            ejercicio5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            ejercicio5.Location = new Point(480, 339);
            ejercicio5.Name = "ejercicio5";
            ejercicio5.Size = new Size(141, 37);
            ejercicio5.TabIndex = 0;
            ejercicio5.Text = "Cantidad de Pares";
            ejercicio5.UseVisualStyleBackColor = true;
            ejercicio5.Click += ejercicio5_Click;
            // 
            // NumerosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 462);
            Controls.Add(label2);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Controls.Add(txtInput);
            Controls.Add(ejercicio5);
            Controls.Add(ejercicio4);
            Controls.Add(ejercicio3);
            Controls.Add(ejercicio2);
            Controls.Add(ejercicio1);
            Name = "NumerosForm";
            Text = "NUMEROS";
            Load += NumerosForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtInput;
        private Label label1;
        private Label lblResultado;
        private Label label2;
        private Button ejercicio1;
        private Button ejercicio2;
        private Button ejercicio3;
        private Button ejercicio4;
        private Button ejercicio5;
    }
}
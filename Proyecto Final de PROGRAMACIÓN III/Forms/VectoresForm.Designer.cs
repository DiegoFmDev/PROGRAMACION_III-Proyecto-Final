namespace Proyecto_Final_de_PROGRAMACIÓN_III.Forms
{
    partial class VectoresForm
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
            btnContarPares = new Button();
            btnMergeSort = new Button();
            btnInsertionSort = new Button();
            btnEliminarX = new Button();
            btnInvertir = new Button();
            lblResult = new Label();
            txtVectorInput = new TextBox();
            txtParameterA = new TextBox();
            txtParameterB = new TextBox();
            txtParameter = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnContarPares
            // 
            btnContarPares.Anchor = AnchorStyles.Top;
            btnContarPares.FlatStyle = FlatStyle.Flat;
            btnContarPares.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnContarPares.Location = new Point(119, 357);
            btnContarPares.Name = "btnContarPares";
            btnContarPares.Size = new Size(131, 45);
            btnContarPares.TabIndex = 0;
            btnContarPares.Text = "Contar Pares";
            btnContarPares.UseVisualStyleBackColor = true;
            btnContarPares.Click += btnContarPares_Click;
            // 
            // btnMergeSort
            // 
            btnMergeSort.Anchor = AnchorStyles.Top;
            btnMergeSort.FlatStyle = FlatStyle.Flat;
            btnMergeSort.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnMergeSort.Location = new Point(290, 296);
            btnMergeSort.Name = "btnMergeSort";
            btnMergeSort.Size = new Size(131, 45);
            btnMergeSort.TabIndex = 1;
            btnMergeSort.Text = "Merge Sort";
            btnMergeSort.UseVisualStyleBackColor = true;
            btnMergeSort.Click += btnMergeSort_Click;
            // 
            // btnInsertionSort
            // 
            btnInsertionSort.Anchor = AnchorStyles.Top;
            btnInsertionSort.FlatStyle = FlatStyle.Flat;
            btnInsertionSort.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnInsertionSort.Location = new Point(291, 357);
            btnInsertionSort.Name = "btnInsertionSort";
            btnInsertionSort.Size = new Size(131, 45);
            btnInsertionSort.TabIndex = 2;
            btnInsertionSort.Text = "Insertion Sort";
            btnInsertionSort.UseVisualStyleBackColor = true;
            btnInsertionSort.Click += btnInsertionSort_Click;
            // 
            // btnEliminarX
            // 
            btnEliminarX.Anchor = AnchorStyles.Top;
            btnEliminarX.FlatStyle = FlatStyle.Flat;
            btnEliminarX.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnEliminarX.Location = new Point(460, 296);
            btnEliminarX.Name = "btnEliminarX";
            btnEliminarX.Size = new Size(131, 45);
            btnEliminarX.TabIndex = 3;
            btnEliminarX.Text = "Eliminar X";
            btnEliminarX.UseVisualStyleBackColor = true;
            btnEliminarX.Click += btnEliminarX_Click;
            // 
            // btnInvertir
            // 
            btnInvertir.Anchor = AnchorStyles.Top;
            btnInvertir.FlatStyle = FlatStyle.Flat;
            btnInvertir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnInvertir.Location = new Point(460, 357);
            btnInvertir.Name = "btnInvertir";
            btnInvertir.Size = new Size(131, 45);
            btnInvertir.TabIndex = 4;
            btnInvertir.Text = "Invertir";
            btnInvertir.UseVisualStyleBackColor = true;
            btnInvertir.Click += btnInvertir_Click;
            // 
            // lblResult
            // 
            lblResult.Anchor = AnchorStyles.Top;
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(472, 66);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(87, 15);
            lblResult.TabIndex = 5;
            lblResult.Text = "  RESULTADO   ";
            // 
            // txtVectorInput
            // 
            txtVectorInput.Anchor = AnchorStyles.Top;
            txtVectorInput.BorderStyle = BorderStyle.FixedSingle;
            txtVectorInput.Location = new Point(269, 58);
            txtVectorInput.Name = "txtVectorInput";
            txtVectorInput.Size = new Size(160, 23);
            txtVectorInput.TabIndex = 6;
            txtVectorInput.Text = " ";
            // 
            // txtParameterA
            // 
            txtParameterA.Anchor = AnchorStyles.Top;
            txtParameterA.BorderStyle = BorderStyle.FixedSingle;
            txtParameterA.Location = new Point(300, 182);
            txtParameterA.Name = "txtParameterA";
            txtParameterA.Size = new Size(112, 23);
            txtParameterA.TabIndex = 7;
            txtParameterA.Text = " ";
            // 
            // txtParameterB
            // 
            txtParameterB.Anchor = AnchorStyles.Top;
            txtParameterB.BorderStyle = BorderStyle.FixedSingle;
            txtParameterB.Location = new Point(301, 211);
            txtParameterB.Name = "txtParameterB";
            txtParameterB.Size = new Size(111, 23);
            txtParameterB.TabIndex = 8;
            txtParameterB.Text = " ";
            // 
            // txtParameter
            // 
            txtParameter.Anchor = AnchorStyles.Top;
            txtParameter.BorderStyle = BorderStyle.FixedSingle;
            txtParameter.Location = new Point(300, 153);
            txtParameter.Name = "txtParameter";
            txtParameter.Size = new Size(112, 23);
            txtParameter.TabIndex = 6;
            txtParameter.Text = " ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F);
            label1.Location = new Point(153, 157);
            label1.Name = "label1";
            label1.Size = new Size(76, 19);
            label1.TabIndex = 9;
            label1.Text = "Parametro:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F);
            label2.Location = new Point(153, 186);
            label2.Name = "label2";
            label2.Size = new Size(89, 19);
            label2.TabIndex = 10;
            label2.Text = "Parametro A:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F);
            label3.Location = new Point(153, 215);
            label3.Name = "label3";
            label3.Size = new Size(88, 19);
            label3.TabIndex = 11;
            label3.Text = "Parametro B:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label4.Location = new Point(149, 56);
            label4.Name = "label4";
            label4.Size = new Size(89, 28);
            label4.TabIndex = 9;
            label4.Text = "VECTOR:";
            // 
            // VectoresForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 462);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtParameterB);
            Controls.Add(txtParameterA);
            Controls.Add(txtParameter);
            Controls.Add(txtVectorInput);
            Controls.Add(lblResult);
            Controls.Add(btnInvertir);
            Controls.Add(btnEliminarX);
            Controls.Add(btnInsertionSort);
            Controls.Add(btnMergeSort);
            Controls.Add(btnContarPares);
            Name = "VectoresForm";
            Text = "VECTORES";
            Load += VectoresForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnContarPares;
        private Button btnMergeSort;
        private Button btnInsertionSort;
        private Button btnEliminarX;
        private Button btnInvertir;
        private Label lblResult;
        private TextBox txtVectorInput;
        private TextBox txtParameterA;
        private TextBox txtParameterB;
        private TextBox txtParameter;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
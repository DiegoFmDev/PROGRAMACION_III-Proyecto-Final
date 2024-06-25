namespace Proyecto_Final_de_PROGRAMACIÓN_III
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
            panelMenu = new Panel();
            btnMatrices = new Button();
            btnVectores = new Button();
            btnCadenas = new Button();
            btnSeries = new Button();
            btnNumeros = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            panelTitleBar = new Panel();
            btnMaximize = new Button();
            btnMinimize = new Button();
            btnClose = new Button();
            btnCloseChildForm = new Button();
            lblTitle = new Label();
            panelDesktopPane = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btnMatrices);
            panelMenu.Controls.Add(btnVectores);
            panelMenu.Controls.Add(btnCadenas);
            panelMenu.Controls.Add(btnSeries);
            panelMenu.Controls.Add(btnNumeros);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(210, 581);
            panelMenu.TabIndex = 0;
            // 
            // btnMatrices
            // 
            btnMatrices.Dock = DockStyle.Top;
            btnMatrices.FlatAppearance.BorderSize = 0;
            btnMatrices.FlatStyle = FlatStyle.Flat;
            btnMatrices.ImageAlign = ContentAlignment.MiddleLeft;
            btnMatrices.Location = new Point(0, 320);
            btnMatrices.Name = "btnMatrices";
            btnMatrices.Padding = new Padding(12, 0, 0, 0);
            btnMatrices.Size = new Size(210, 60);
            btnMatrices.TabIndex = 4;
            btnMatrices.Text = "  Matrices";
            btnMatrices.TextAlign = ContentAlignment.MiddleLeft;
            btnMatrices.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMatrices.UseVisualStyleBackColor = true;
            btnMatrices.Click += btnMatrices_Click;
            // 
            // btnVectores
            // 
            btnVectores.Dock = DockStyle.Top;
            btnVectores.FlatAppearance.BorderSize = 0;
            btnVectores.FlatStyle = FlatStyle.Flat;
            btnVectores.ImageAlign = ContentAlignment.MiddleLeft;
            btnVectores.Location = new Point(0, 260);
            btnVectores.Name = "btnVectores";
            btnVectores.Padding = new Padding(12, 0, 0, 0);
            btnVectores.Size = new Size(210, 60);
            btnVectores.TabIndex = 3;
            btnVectores.Text = "  Vectores";
            btnVectores.TextAlign = ContentAlignment.MiddleLeft;
            btnVectores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVectores.UseVisualStyleBackColor = true;
            btnVectores.Click += btnVectores_Click;
            // 
            // btnCadenas
            // 
            btnCadenas.Dock = DockStyle.Top;
            btnCadenas.FlatAppearance.BorderSize = 0;
            btnCadenas.FlatStyle = FlatStyle.Flat;
            btnCadenas.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadenas.Location = new Point(0, 200);
            btnCadenas.Name = "btnCadenas";
            btnCadenas.Padding = new Padding(12, 0, 0, 0);
            btnCadenas.Size = new Size(210, 60);
            btnCadenas.TabIndex = 2;
            btnCadenas.Text = "  Cadenas";
            btnCadenas.TextAlign = ContentAlignment.MiddleLeft;
            btnCadenas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCadenas.UseVisualStyleBackColor = true;
            btnCadenas.Click += btnCadenas_Click;
            // 
            // btnSeries
            // 
            btnSeries.Dock = DockStyle.Top;
            btnSeries.FlatAppearance.BorderSize = 0;
            btnSeries.FlatStyle = FlatStyle.Flat;
            btnSeries.ImageAlign = ContentAlignment.MiddleLeft;
            btnSeries.Location = new Point(0, 140);
            btnSeries.Name = "btnSeries";
            btnSeries.Padding = new Padding(12, 0, 0, 0);
            btnSeries.Size = new Size(210, 60);
            btnSeries.TabIndex = 1;
            btnSeries.Text = "  Series";
            btnSeries.TextAlign = ContentAlignment.MiddleLeft;
            btnSeries.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSeries.UseVisualStyleBackColor = true;
            btnSeries.Click += btnSeries_Click;
            // 
            // btnNumeros
            // 
            btnNumeros.Dock = DockStyle.Top;
            btnNumeros.FlatAppearance.BorderSize = 0;
            btnNumeros.FlatStyle = FlatStyle.Flat;
            btnNumeros.ImageAlign = ContentAlignment.MiddleLeft;
            btnNumeros.Location = new Point(0, 80);
            btnNumeros.Name = "btnNumeros";
            btnNumeros.Padding = new Padding(12, 0, 0, 0);
            btnNumeros.Size = new Size(210, 60);
            btnNumeros.TabIndex = 0;
            btnNumeros.Text = "  Números\r\n";
            btnNumeros.TextAlign = ContentAlignment.MiddleLeft;
            btnNumeros.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNumeros.UseVisualStyleBackColor = true;
            btnNumeros.Click += btnNumeros_Click_1;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(210, 80);
            panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(24, 30);
            label1.Name = "label1";
            label1.Size = new Size(157, 21);
            label1.TabIndex = 0;
            label1.Text = "PROGRAMACION III";
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(btnCloseChildForm);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(210, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(724, 80);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Montserrat", 15F);
            btnMaximize.ForeColor = Color.White;
            btnMaximize.Location = new Point(657, 4);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(30, 30);
            btnMaximize.TabIndex = 4;
            btnMaximize.Text = "O";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Montserrat", 15F);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(623, 4);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(30, 30);
            btnMinimize.TabIndex = 3;
            btnMinimize.Text = "O";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Montserrat", 15F);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(689, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 2;
            btnClose.Text = "O";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.Dock = DockStyle.Left;
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.Image = Properties.Resources.cross_out__2_;
            btnCloseChildForm.Location = new Point(0, 0);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(75, 80);
            btnCloseChildForm.TabIndex = 1;
            btnCloseChildForm.UseVisualStyleBackColor = true;
            btnCloseChildForm.Click += btnCloseChildForm_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(316, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(81, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOME";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(210, 80);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(724, 501);
            panelDesktopPane.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 581);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            ForeColor = Color.Gainsboro;
            MinimumSize = new Size(950, 570);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Minimized;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnNumeros;
        private Panel panelLogo;
        private Button btnVectores;
        private Button btnCadenas;
        private Button btnSeries;
        private Button btnMatrices;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Label label1;
        private Panel panelDesktopPane;
        private Button btnCloseChildForm;
        private Button btnMaximize;
        private Button btnMinimize;
        private Button btnClose;
    }
}

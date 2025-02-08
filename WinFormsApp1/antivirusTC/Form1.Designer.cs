namespace antivirusTC
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
            lblTitulo = new Label();
            lblSeleccionar = new Label();
            btnSeleccionar = new Button();
            lblResultados = new Label();
            btnEscanear = new Button();
            openFileDialog1 = new OpenFileDialog();
            txtResultados = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F);
            lblTitulo.Location = new Point(320, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(87, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Heimdall";
            // 
            // lblSeleccionar
            // 
            lblSeleccionar.AutoSize = true;
            lblSeleccionar.Location = new Point(55, 60);
            lblSeleccionar.Name = "lblSeleccionar";
            lblSeleccionar.Size = new Size(111, 15);
            lblSeleccionar.TabIndex = 1;
            lblSeleccionar.Text = "Seleccionar Archivo";
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Location = new Point(55, 88);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(66, 26);
            btnSeleccionar.TabIndex = 2;
            btnSeleccionar.Text = "seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // lblResultados
            // 
            lblResultados.AutoSize = true;
            lblResultados.Location = new Point(593, 99);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(64, 15);
            lblResultados.TabIndex = 4;
            lblResultados.Text = "Resultados";
            // 
            // btnEscanear
            // 
            btnEscanear.Location = new Point(160, 91);
            btnEscanear.Name = "btnEscanear";
            btnEscanear.Size = new Size(75, 23);
            btnEscanear.TabIndex = 5;
            btnEscanear.Text = "Escanear";
            btnEscanear.UseVisualStyleBackColor = true;
            btnEscanear.Click += btnEscanear_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtResultados
            // 
            txtResultados.AutoSize = true;
            txtResultados.Location = new Point(593, 128);
            txtResultados.Name = "txtResultados";
            txtResultados.Size = new Size(0, 15);
            txtResultados.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResultados);
            Controls.Add(btnEscanear);
            Controls.Add(lblResultados);
            Controls.Add(btnSeleccionar);
            Controls.Add(lblSeleccionar);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSeleccionar;
        private Button btnSeleccionar;
        private Label lblResultados;
        private Button btnEscanear;
        private OpenFileDialog openFileDialog1;
        private Label txtResultados;
    }
}

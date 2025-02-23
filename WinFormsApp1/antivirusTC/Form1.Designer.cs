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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTitulo = new Label();
            lblSeleccionar = new Label();
            btnSeleccionar = new Button();
            lblResultados = new Label();
            btnEscanear = new Button();
            openFileDialog1 = new OpenFileDialog();
            txtBytes = new TextBox();
            txtResultados = new TextBox();
            lblEstado = new Label();
            txtEstado = new TextBox();
            pbxAutomata = new PictureBox();
            lblAutomata = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxAutomata).BeginInit();
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
            lblResultados.Location = new Point(332, 99);
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
            // txtBytes
            // 
            txtBytes.Location = new Point(55, 120);
            txtBytes.Multiline = true;
            txtBytes.Name = "txtBytes";
            txtBytes.ReadOnly = true;
            txtBytes.Size = new Size(230, 255);
            txtBytes.TabIndex = 7;
            // 
            // txtResultados
            // 
            txtResultados.Location = new Point(320, 120);
            txtResultados.Multiline = true;
            txtResultados.Name = "txtResultados";
            txtResultados.ReadOnly = true;
            txtResultados.Size = new Size(100, 112);
            txtResultados.TabIndex = 8;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(322, 258);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(98, 15);
            lblEstado.TabIndex = 9;
            lblEstado.Text = "Estado De Parada";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(320, 291);
            txtEstado.Name = "txtEstado";
            txtEstado.ReadOnly = true;
            txtEstado.Size = new Size(100, 23);
            txtEstado.TabIndex = 10;
            // 
            // pbxAutomata
            // 
            pbxAutomata.BackColor = SystemColors.ActiveCaptionText;
            pbxAutomata.Image = (Image)resources.GetObject("pbxAutomata.Image");
            pbxAutomata.Location = new Point(445, 108);
            pbxAutomata.Name = "pbxAutomata";
            pbxAutomata.Size = new Size(322, 298);
            pbxAutomata.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxAutomata.TabIndex = 11;
            pbxAutomata.TabStop = false;
            // 
            // lblAutomata
            // 
            lblAutomata.AutoSize = true;
            lblAutomata.Location = new Point(570, 88);
            lblAutomata.Name = "lblAutomata";
            lblAutomata.Size = new Size(60, 15);
            lblAutomata.TabIndex = 12;
            lblAutomata.Text = "Automata";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAutomata);
            Controls.Add(pbxAutomata);
            Controls.Add(txtEstado);
            Controls.Add(lblEstado);
            Controls.Add(txtResultados);
            Controls.Add(txtBytes);
            Controls.Add(btnEscanear);
            Controls.Add(lblResultados);
            Controls.Add(btnSeleccionar);
            Controls.Add(lblSeleccionar);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbxAutomata).EndInit();
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
        private TextBox txtBytes;
        private TextBox txtResultados;
        private Label lblEstado;
        private TextBox txtEstado;
        private PictureBox pbxAutomata;
        private Label lblAutomata;
    }
}

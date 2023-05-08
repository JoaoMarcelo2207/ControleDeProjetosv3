namespace Controle.APPv3
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
            butaoListarProjetos = new Button();
            label1 = new Label();
            listarProjetos = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // butaoListarProjetos
            // 
            butaoListarProjetos.Location = new Point(34, 350);
            butaoListarProjetos.Name = "butaoListarProjetos";
            butaoListarProjetos.Size = new Size(250, 47);
            butaoListarProjetos.TabIndex = 0;
            butaoListarProjetos.Text = "Cadastro de Projetos";
            butaoListarProjetos.UseVisualStyleBackColor = true;
            butaoListarProjetos.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(250, 30);
            label1.Name = "label1";
            label1.Size = new Size(304, 37);
            label1.TabIndex = 2;
            label1.Text = "Cadastrador de projetos";
            // 
            // listarProjetos
            // 
            listarProjetos.Location = new Point(34, 170);
            listarProjetos.Name = "listarProjetos";
            listarProjetos.Size = new Size(250, 47);
            listarProjetos.TabIndex = 3;
            listarProjetos.Text = "Listar Projetos";
            listarProjetos.UseVisualStyleBackColor = true;
            listarProjetos.Click += listarProjetos_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(558, 153);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 265);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(listarProjetos);
            Controls.Add(label1);
            Controls.Add(butaoListarProjetos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrador de Projetos";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button butaoListarProjetos;
        private Label label1;
        private Button listarProjetos;
        private PictureBox pictureBox1;
    }
}
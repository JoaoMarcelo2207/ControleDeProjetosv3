namespace Controle.APPv3
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label2 = new Label();
            nomeGerente = new TextBox();
            label4 = new Label();
            label7 = new Label();
            label5 = new Label();
            status = new TextBox();
            label8 = new Label();
            label6 = new Label();
            resumo = new TextBox();
            nomeProjeto = new TextBox();
            cadastrar = new Button();
            TelaIncial = new Button();
            dataInicio = new DateTimePicker();
            dataFim = new DateTimePicker();
            editarProjetos = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 29);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 4;
            label2.Text = "Nome do projeto";
            // 
            // nomeGerente
            // 
            nomeGerente.Location = new Point(149, 66);
            nomeGerente.MaxLength = 100;
            nomeGerente.Name = "nomeGerente";
            nomeGerente.Size = new Size(173, 23);
            nomeGerente.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 71);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 7;
            label4.Text = "Nome do gerente";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 117);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 10;
            label7.Text = "Data Inicio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(410, 29);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 15;
            label5.Text = "STATUS";
            // 
            // status
            // 
            status.Location = new Point(483, 26);
            status.MaxLength = 20;
            status.Name = "status";
            status.Size = new Size(130, 23);
            status.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(410, 117);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 17;
            label8.Text = "Data Final";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(184, 238);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 19;
            label6.Text = "Resumo";
            // 
            // resumo
            // 
            resumo.Location = new Point(266, 186);
            resumo.MaxLength = 500;
            resumo.Multiline = true;
            resumo.Name = "resumo";
            resumo.Size = new Size(283, 142);
            resumo.TabIndex = 20;
            // 
            // nomeProjeto
            // 
            nomeProjeto.Location = new Point(149, 26);
            nomeProjeto.MaxLength = 100;
            nomeProjeto.Name = "nomeProjeto";
            nomeProjeto.Size = new Size(173, 23);
            nomeProjeto.TabIndex = 22;
            // 
            // cadastrar
            // 
            cadastrar.Location = new Point(175, 366);
            cadastrar.Name = "cadastrar";
            cadastrar.Size = new Size(196, 61);
            cadastrar.TabIndex = 23;
            cadastrar.Text = "Cadastrar";
            cadastrar.UseVisualStyleBackColor = true;
            cadastrar.Click += cadastrar_Click;
            // 
            // TelaIncial
            // 
            TelaIncial.Location = new Point(662, 14);
            TelaIncial.Name = "TelaIncial";
            TelaIncial.Size = new Size(104, 35);
            TelaIncial.TabIndex = 26;
            TelaIncial.Text = "Tela Inicial";
            TelaIncial.UseVisualStyleBackColor = true;
            TelaIncial.Click += TelaIncial_Click;
            // 
            // dataInicio
            // 
            dataInicio.Location = new Point(149, 111);
            dataInicio.Name = "dataInicio";
            dataInicio.Size = new Size(200, 23);
            dataInicio.TabIndex = 28;
            // 
            // dataFim
            // 
            dataFim.Location = new Point(483, 111);
            dataFim.Name = "dataFim";
            dataFim.Size = new Size(200, 23);
            dataFim.TabIndex = 29;
            // 
            // editarProjetos
            // 
            editarProjetos.Location = new Point(487, 366);
            editarProjetos.Name = "editarProjetos";
            editarProjetos.Size = new Size(196, 61);
            editarProjetos.TabIndex = 30;
            editarProjetos.Text = "Editar Projetos";
            editarProjetos.UseVisualStyleBackColor = true;
            editarProjetos.Click += editarProjetos_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(editarProjetos);
            Controls.Add(dataFim);
            Controls.Add(dataInicio);
            Controls.Add(TelaIncial);
            Controls.Add(cadastrar);
            Controls.Add(nomeProjeto);
            Controls.Add(resumo);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(status);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(nomeGerente);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            FormClosed += Form2_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox nomeGerente;
        private Label label4;
        private Label label7;
        private Label label5;
        private TextBox status;
        private Label label8;
        private Label label6;
        private TextBox resumo;
        private TextBox nomeProjeto;
        private Button cadastrar;
        private Button TelaIncial;
        private DateTimePicker dataInicio;
        private DateTimePicker dataFim;
        private Button editarProjetos;
    }
}
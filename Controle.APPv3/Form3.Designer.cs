namespace Controle.APPv3
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            telaInicial = new Button();
            dataGridView1 = new DataGridView();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeGerenteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            resumoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataFDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            projetoBindingSource = new BindingSource(components);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)projetoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // telaInicial
            // 
            telaInicial.Location = new Point(657, 12);
            telaInicial.Name = "telaInicial";
            telaInicial.Size = new Size(131, 38);
            telaInicial.TabIndex = 0;
            telaInicial.Text = "Tela Inicial";
            telaInicial.UseVisualStyleBackColor = true;
            telaInicial.Click += telaInicial_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nomeDataGridViewTextBoxColumn, nomeGerenteDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, resumoDataGridViewTextBoxColumn, dataIDataGridViewTextBoxColumn, dataFDataGridViewTextBoxColumn });
            dataGridView1.DataSource = projetoBindingSource;
            dataGridView1.Location = new Point(59, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(646, 264);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeGerenteDataGridViewTextBoxColumn
            // 
            nomeGerenteDataGridViewTextBoxColumn.DataPropertyName = "NomeGerente";
            nomeGerenteDataGridViewTextBoxColumn.HeaderText = "NomeGerente";
            nomeGerenteDataGridViewTextBoxColumn.Name = "nomeGerenteDataGridViewTextBoxColumn";
            nomeGerenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resumoDataGridViewTextBoxColumn
            // 
            resumoDataGridViewTextBoxColumn.DataPropertyName = "Resumo";
            resumoDataGridViewTextBoxColumn.HeaderText = "Resumo";
            resumoDataGridViewTextBoxColumn.Name = "resumoDataGridViewTextBoxColumn";
            resumoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataIDataGridViewTextBoxColumn
            // 
            dataIDataGridViewTextBoxColumn.DataPropertyName = "DataI";
            dataIDataGridViewTextBoxColumn.HeaderText = "DataI";
            dataIDataGridViewTextBoxColumn.Name = "dataIDataGridViewTextBoxColumn";
            dataIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataFDataGridViewTextBoxColumn
            // 
            dataFDataGridViewTextBoxColumn.DataPropertyName = "DataF";
            dataFDataGridViewTextBoxColumn.HeaderText = "DataF";
            dataFDataGridViewTextBoxColumn.Name = "dataFDataGridViewTextBoxColumn";
            dataFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // projetoBindingSource
            // 
            projetoBindingSource.DataSource = typeof(MODEL.Projeto);
            // 
            // button1
            // 
            button1.Location = new Point(324, 368);
            button1.Name = "button1";
            button1.Size = new Size(131, 38);
            button1.TabIndex = 2;
            button1.Text = "Listar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(telaInicial);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listagem De Projetos";
            FormClosed += Form3_FormClosed;
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)projetoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button telaInicial;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeGerenteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn resumoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataIDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataFDataGridViewTextBoxColumn;
        private BindingSource projetoBindingSource;
        private Button button1;
    }
}
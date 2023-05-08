using Controle.BLL;
using Controle.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Controle.APPv3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void telaInicial_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void excluirProjetoBotao_Click(object sender, EventArgs e)
        {
            Projeto p = new Projeto();
            p = ProjetoRepository.GetByNome(nomeProjetoTextBox.Text);
            if(p != null )
            {
                ProjetoRepository.Excluir(p);
                MessageBox.Show("Projeto excluido com sucesso");
            }
            else
            {
                MessageBox.Show("Nenhum projeto com esse nome foi encontrado!");
            }

        }

        private void editarProjetoButao_Click(object sender, EventArgs e)
        {
            DateTime dataInicioI = dataInicio.Value;
            DateTime dataFimI = dataFim.Value;
            Projeto p = new Projeto();
            p = ProjetoRepository.GetByNome(textBox1.Text);
            if(p != null )
            {
                p.Nome = textBox1.Text;
                p.NomeGerente = nomeGerente.Text;
                p.Status = status.Text;
                p.Resumo = resumo.Text;
                p.DataI = dataInicioI;
                p.DataF = dataFimI;
                ProjetoRepository.Update(p);
                MessageBox.Show("Projeto Atualizado com Sucesso!");
            }
            else
            {
                MessageBox.Show("Nenhum projeto com esse nome foi encontrado!");
            }

        }
    }
}

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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Controle.APPv3
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {

            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void cadastrar_Click(object sender, EventArgs e)
        {
            DateTime dataInicioI = dataInicio.Value;
            DateTime dataFimI = dataFim.Value;
            Projeto p = new Projeto();
            p.Nome = nomeProjeto.Text;
            p.NomeGerente = nomeGerente.Text;
            p.Status = status.Text;
            p.Resumo = resumo.Text;
            p.DataI = dataInicioI;
            p.DataF = dataFimI;

            ProjetoRepository.Add(p);
            MessageBox.Show("Projeto Cadastrado com Sucesso!");

        }

        private void TelaIncial_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void excluir_Click(object sender, EventArgs e)
        {

        }

        private void editarProjetos_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }
}

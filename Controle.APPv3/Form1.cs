using Controle.MODEL;
using Controle.BLL;
using Controle.MODEL;

namespace Controle.APPv3
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        Form3 form3 = new Form3();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void listarProjetos_Click(object sender, EventArgs e)
        {
            form3.Show();
            this.Hide();
        }


    }
}
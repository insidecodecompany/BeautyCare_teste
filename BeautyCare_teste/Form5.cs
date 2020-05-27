using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BeautyCare_teste
{
    public partial class Form5 : Form
    {
        Thread mt;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            string data = DateTime.Now.ToLongDateString();
            data = data.Substring(0, 1).ToUpper() + data.Substring(1, data.Length - 1);
            toolStripStatusLabel1.Text = data;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
            label17.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            mt = new Thread(voltar_home);
            mt.SetApartmentState(ApartmentState.STA);
            mt.Start();
        }

        private void voltar_home()
        {
            Application.Run(new Form2());
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja finalizar", "Confirme",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            Application.Exit();
        }

        private void agendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            mt = new Thread(novo_horario);
            mt.SetApartmentState(ApartmentState.STA);
            mt.Start();
        }

        private void novo_horario()
        {
            Application.Run(new Form3());
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            mt = new Thread(novo_cliente);
            mt.SetApartmentState(ApartmentState.STA);
            mt.Start();
        }

        private void novo_cliente()
        {
            Application.Run(new Form4());
        }

        private void colaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            mt = new Thread(novo_colaborador);
            mt.SetApartmentState(ApartmentState.STA);
            mt.Start();
        }

        private void novo_colaborador()
        {
            Application.Run(new Form5());
        }

        private void agendamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            mt = new Thread(consulta_agendamento);
            mt.SetApartmentState(ApartmentState.STA);
            mt.Start();
        }

        private void consulta_agendamento()
        {
            Application.Run(new Form6());
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            mt = new Thread(consulta_cliente);
            mt.SetApartmentState(ApartmentState.STA);
            mt.Start();
        }

        private void consulta_cliente()
        {
            Application.Run(new Form7());
        }

        private void colaboradorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            mt = new Thread(consulta_colaborador);
            mt.SetApartmentState(ApartmentState.STA);
            mt.Start();
        }

        private void consulta_colaborador()
        {
            Application.Run(new Form8());
        }
    }
}

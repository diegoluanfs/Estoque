using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroPessoas
{
    public partial class Form1 : Form
    {
        LinkedList<Pessoa> agenda = new LinkedList<Pessoa>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Pessoa ps = new Pessoa();

            ps.Cpf = txtCPF.Text;
            ps.Nome = txtNome.Text.ToUpper();
            ps.Email = txtEmail.Text;
            ps.Telefone = txtTelefone.Text;

            agenda.AddLast(ps);
            txtCPF.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();

            //MessageBox.Show("Quantidade na lista " + agenda.Count);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nomePesquisar = txtNome.Text.ToUpper();
            if(nomePesquisar.Equals(" ") || nomePesquisar == "")
            {
                MessageBox.Show("Entre com um nome para ser pesqusiado.");
            }
            else
            {
                foreach (Pessoa p in agenda)
                {
                    if (p.Nome.Equals(nomePesquisar))
                    {
                        //MessageBox.Show("Encontrou: " + p.Cpf);
                        txtNome.Text = p.Nome;
                        txtCPF.Text = p.Cpf;
                        txtEmail.Text = p.Email;
                        txtTelefone.Text = p.Telefone;
                        return;
                    }
                }
                MessageBox.Show("Nenhum nome encontrado.");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            String nomeAlterar = txtNome.Text;
            foreach(Pessoa p in agenda)
            {
                if (p.Nome.Equals(nomeAlterar))
                {
                    p.Nome = txtNome.Text;
                    p.Cpf = txtCPF.Text;
                    p.Email = txtEmail.Text;
                    p.Telefone = txtTelefone.Text;
                }
            }

            txtCPF.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();

            //MessageBox.Show("Quantidade na lista " + agenda.Count);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            String nomeExcluir = txtNome.Text;
            foreach (Pessoa p in agenda)
            {
                if (p.Nome.Equals(nomeExcluir))
                {
                    agenda.Remove(p);
                    MessageBox.Show("Pessoa excluída com sucesso.");
                }
            }

            MessageBox.Show("Quantidade na lista " + agenda.Count);

        }
    }
}

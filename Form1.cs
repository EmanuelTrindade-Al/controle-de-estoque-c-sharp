using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ControleEstoqueWin
{
    public partial class Form1 : Form
    {
        private List<Produto> estoque = new List<Produto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string nome = txtNome.Text;
            int qtd = int.Parse(txtQtd.Text);

            estoque.Add(new Produto(id, nome, qtd));
            AtualizarLista();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var p = estoque.Find(x => x.Id == id);
            if (p != null)
            {
                int qtd = int.Parse(txtQtd.Text);
                p.Entrada(qtd);
                AtualizarLista();
            }
            else
            {
                MessageBox.Show("Produto não encontrado");
            }
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var p = estoque.Find(x => x.Id == id);
            if (p != null)
            {
                int qtd = int.Parse(txtQtd.Text);
                p.Saida(qtd);
                AtualizarLista();
            }
            else
            {
                MessageBox.Show("Produto não encontrado");
            }
        }

        private void AtualizarLista()
        {
            listBox1.Items.Clear();
            foreach (var p in estoque)
                listBox1.Items.Add(p.ToString());
        }
    }
}

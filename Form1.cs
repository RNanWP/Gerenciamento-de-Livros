using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeLivros
{
    public partial class Form1 : Form
    {
        private List<Livro> livros = new List<Livro>();

        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Autor autor1 = new Autor("J.K. Rowling", "Reino Unido");
            Livro livro1 = new Livro("Harry Potter e a Pedra Filosofal", autor1);

            Autor autor2 = new Autor("George R.R. Martin", "EUA");
            Livro livro2 = new Livro("A Guerra dos Tronos", autor2);

            Autor autor3 = new Autor("J.R.R. Tolkien", "Reino Unido");
            Livro livro3 = new Livro("O Senhor dos Anéis", autor3);

            livros.Add(livro1);
            livros.Add(livro2);
            livros.Add(livro3);
        }

        private void btnMostrarLivro_Click(object sender, EventArgs e)
        {
            dataGridLivros.DataSource = null;

            var dataTable = new DataTable();
            dataTable.Columns.Add("Autor", typeof(string));
            dataTable.Columns.Add("Título", typeof(string));
            dataTable.Columns.Add("Nacionalidade", typeof(string));

            foreach (var livro in livros)
            {
                dataTable.Rows.Add(livro.Autor.Nome, livro.Titulo, livro.Autor.Nacionalidade);
            }

            dataGridLivros.DataSource = dataTable;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
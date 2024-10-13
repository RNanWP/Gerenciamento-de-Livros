using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeLivros
{
    public class Autor
    {
        public string Nome { get; set; }
        public string Nacionalidade { get; set; }

        public Autor(string nome, string nacionalidade)
        {
            Nome = nome;
            Nacionalidade = nacionalidade;
        }
    }

    public class Livro
    {
        public string Titulo { get; set; }
        public Autor Autor { get; set; }

        public Livro(string titulo, Autor autor)
        {
            Titulo = titulo;
            Autor = autor;
        }

        public string ExibirInformacoes()
        {
            return $"Título: {Titulo}\nAutor: {Autor.Nome}\nNacionalidade: {Autor.Nacionalidade}";
        }
    }
}
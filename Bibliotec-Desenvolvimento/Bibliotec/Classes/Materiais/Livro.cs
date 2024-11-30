using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Bibliotec.Classes.Materiais
{
    internal class Livro : Leitura
    {
        private String autor {  get; set; }
        private String editora { get; set; }
        private String aquisicao { get; set; }
        private String isbn {  get; set; }
        private String edicao { get; set; }
        private String genero { get; set; }
        private String subtitulo { get; set; }

        public Livro() { }

        public Livro (String titulo, String palavraChave, String assunto, String localPublicacao,
                        String dataPublicacao, string autor, string editora, string isbn, string edicao, 
                        string genero, string subtitulo)
        {
            this.autor = autor;
            this.editora = editora;
            this.isbn = isbn;
            this.edicao = edicao;
            this.genero = genero;
            this.subtitulo = subtitulo;
            this.titulo = titulo;
            this.palavraChave = palavraChave;
            this.assunto = assunto;
            this.localPublicacao = localPublicacao;
            this.dataPublicacao = dataPublicacao;
        }

        public Livro(int id, String titulo, String palavraChave, String assunto, String localPublicacao,
                        String dataPublicacao, string autor, string editora,
                        string isbn, string edicao, string genero, string subtitulo)
        {
            this.autor = autor;
            this.editora = editora;
            this.isbn = isbn;
            this.edicao = edicao;
            this.genero = genero;
            this.subtitulo = subtitulo;
            this.id = id;
            this.titulo = titulo;
            this.palavraChave = palavraChave;
            this.assunto = assunto;
            this.localPublicacao = localPublicacao;
            this.dataPublicacao = dataPublicacao;
        }

        //métodos CRUD
        public String cadastrarLivro()
        {
            if(dataPublicacao == null)
            {
                return $"INSERT INTO tb_livros(titulo, palavra_chave, assunto, local_publicacao, ano_publicacao, autor, editora, isbn, edicao, genero, subtitulo) VALUES ('{titulo}', '{palavraChave}', '{assunto}', '{localPublicacao}', null, '{autor}', '{editora}', {isbn}, '{edicao}', '{genero}', '{subtitulo}')";
            }
            return $"INSERT INTO tb_livros(titulo, palavra_chave, assunto, local_publicacao, ano_publicacao, autor, editora, isbn, edicao, genero, subtitulo) VALUES ('{titulo}', '{palavraChave}', '{assunto}', '{localPublicacao}', '{dataPublicacao}', '{autor}', '{editora}', {isbn}, '{edicao}', '{genero}', '{subtitulo}')";
        }

        public String getTitulo()
        {
            return titulo;
        }
    }
}

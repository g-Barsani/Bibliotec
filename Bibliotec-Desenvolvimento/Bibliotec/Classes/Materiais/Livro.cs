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
                        String dataPublicacao, bool disponivel, bool tarjaVermelha, string autor, string editora, 
                        string aquisicao, string isbn, string edicao, string genero, string subtitulo)
        {
            this.autor = autor;
            this.editora = editora;
            this.aquisicao = aquisicao;
            this.isbn = isbn;
            this.edicao = edicao;
            this.genero = genero;
            this.subtitulo = subtitulo;
            this.titulo = titulo;
            this.palavraChave = palavraChave;
            this.assunto = assunto;
            this.localPublicacao = localPublicacao;
            this.dataPublicacao = dataPublicacao;
            this.disponivel = disponivel;
            this.tarjaVermelha = tarjaVermelha;
        }

        public Livro(int id, String titulo, String palavraChave, String assunto, String localPublicacao,
                        String dataPublicacao, bool disponivel, bool tarjaVermelha, string autor, string editora,
                        string aquisicao, string isbn, string edicao, string genero, string subtitulo)
        {
            this.autor = autor;
            this.editora = editora;
            this.aquisicao = aquisicao;
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
            this.disponivel = disponivel;
            this.tarjaVermelha = tarjaVermelha;
        }

        //métodos CRUD
        public String cadastrarLivro()
        {
            return $"INSERT INTO tb_livros(titulo, palavra_chave, assunto, local_publicacao, ano_publicacao, disponibilidade, tarja_vermelha, autor, editora, aquisicao, isbn, edicao, genero, subtitulo) VALUES ('{titulo}', '{palavraChave}', '{assunto}', '{localPublicacao}', '{dataPublicacao}', {disponivel}, {tarjaVermelha}, '{autor}', '{editora}', '{aquisicao}', {isbn}, '{edicao}', '{genero}', '{subtitulo}')";
        }

        public String getTitulo()
        {
            return titulo;
        }
    }
}

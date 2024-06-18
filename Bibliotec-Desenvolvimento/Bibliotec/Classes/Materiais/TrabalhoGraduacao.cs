using Bibliotec.Classes.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Classes.Materiais
{
    internal class TrabalhoGraduacao : Leitura
    {
        private Aluno autor {  get; set; }
        private String subtitulo { get; set; }

        //Métodos Construtores
        public TrabalhoGraduacao() { }

        //Construtor para cadastro
        public TrabalhoGraduacao(String titulo, String palavraChave, String assunto, String localPublicacao, String dataPublicacao,
            bool disponivel, bool tarjaVermelha, Aluno autor, String subtitulo)
        {
            this.autor = autor;
            this.subtitulo = subtitulo;
            this.titulo = titulo;
            this.palavraChave = palavraChave;
            this.assunto = assunto;
            this.localPublicacao = localPublicacao;
            this.dataPublicacao = dataPublicacao;
            this.disponivel = disponivel;
            this.tarjaVermelha = tarjaVermelha;
        }

        //Construtor para leitura
        public TrabalhoGraduacao(int id, String titulo, String palavraChave, String assunto, String localPublicacao, String dataPublicacao,
            bool disponivel, bool tarjaVermelha, Aluno autor, String subtitulo)
        {
            this.autor = autor;
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
    }
}

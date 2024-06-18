using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Classes.Materiais
{
    internal class Revista : Leitura
    {
        private String editora {  get; set; }
        private String aquisicao { get; set; }
        private String edicao { get; set; }
        private String genero { get; set; }

        public Revista() { }

        //Construtor para cadastro
        public Revista(String titulo, String palavraChave, String assunto, String localPublicacao, String dataPublicacao, 
            bool disponivel, bool tarjaVermelha, string editora, string aquisicao, string edicao, string genero)
        {
            this.editora = editora;
            this.aquisicao = aquisicao;
            this.edicao = edicao;
            this.genero = genero;
            this.titulo = titulo;
            this.palavraChave = palavraChave;
            this.assunto = assunto;
            this.localPublicacao = localPublicacao;
            this.dataPublicacao = dataPublicacao;
            this.disponivel = disponivel;
            this.tarjaVermelha = tarjaVermelha;
        }

        //Construtor para leitura
        public Revista(int id, String titulo, String palavraChave, String assunto, String localPublicacao, String dataPublicacao,
            bool disponivel, bool tarjaVermelha, string editora, string aquisicao, string edicao, string genero)
        {
            this.editora = editora;
            this.aquisicao = aquisicao;
            this.edicao = edicao;
            this.genero = genero;
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

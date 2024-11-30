using System;

namespace Bibliotec.Classes.Materiais
{
    internal class ExemplarLivro
    {
        private int numeroExemplar { get; set; }
        private long isbn { get; set; }
        private bool tarjaVermelha { get; set; }
        private bool disponivel { get; set; }
        private string formaAquisicao { get; set; }

        // Construtor vazio
        public ExemplarLivro() { }
        
        // Construtor completo
        public ExemplarLivro(int numeroExemplar, long isbn, bool tarjaVermelha, bool disponivel, string formaAquisicao)
        {
            this.numeroExemplar = numeroExemplar;
            this.isbn = isbn;
            this.tarjaVermelha = tarjaVermelha;
            this.disponivel = disponivel;
            this.formaAquisicao = formaAquisicao;
        }

        // Métodos CRUD
        public string CadastrarExemplarLivro()
        {
            return $"INSERT INTO tb_exemplar_livro (numero_exemplar, isbn, tarja_vermelha, disponivel, forma_aquisicao) " +
                   $"VALUES ({numeroExemplar}, {isbn}, {tarjaVermelha}, {disponivel}, '{formaAquisicao}')";
        }

        public string AtualizarDisponibilidade(bool novaDisponibilidade)
        {
            return $"UPDATE tb_exemplar_livro SET disponivel = {novaDisponibilidade} WHERE numero_exemplar = {numeroExemplar}";
        }

        public string RemoverExemplarLivro()
        {
            return $"DELETE FROM tb_exemplar_livro WHERE numero_exemplar = {numeroExemplar}";
        }

        public string RemoverTodosExemplares()
        {
            return $"DELETE FROM tb_exemplar_livro";
        }

         // Métodos de consulta
        public string ConsultarTodosExemplares()
        {
            return $"SELECT * FROM tb_exemplar_livro";
        }

        public string ConsultarPorISBN(long isbn)
        {
            return $"SELECT * FROM tb_exemplar_livro WHERE isbn = {isbn}";
        }

        // Método de consulta por numeroExemplar
        public string ConsultarPorNumeroExemplar(int numeroExemplar)
        {
            return $"SELECT * FROM tb_exemplar_livro WHERE numero_exemplar = {numeroExemplar}";
        }

        // Getters
        public int GetNumeroExemplar()
        {
            return numeroExemplar;
        }

        public long GetIsbn()
        {
            return isbn;
        }

        public bool IsDisponivel()
        {
            return disponivel;
        }

        public bool HasTarjaVermelha()
        {
            return tarjaVermelha;
        }

        public string GetFormaAquisicao()
        {
            return formaAquisicao;
        }
    }
}

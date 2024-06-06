using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bibliotec.Classes.Usuarios
{
    internal class Aluno : Usuario
    {
        private string ra { get; set; }

        //Métodos Construtores
        public Aluno() { }

        //Construtor para cadastro
        public Aluno(string nome, string email, string celular, string ra)
        {
            this.nome = nome;
            this.email = email;
            this.celular = celular;
            this.ra = ra;
            quantidadeEmprestimo = 2;
            tempoEmprestimoSemanas = 1;

        }

        //Construtor para leitura
        public Aluno(int id, string nome, string email, string celular, string ra)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.celular = celular;
            this.ra = ra;
            quantidadeEmprestimo = 2;
            tempoEmprestimoSemanas = 1;
        }

        //métodos CRUD
        public String cadastrarAluno()
        {
            return $"INSERT INTO tb_alunos(nome, email, celular, ra, quantidade_emprestimo, tempo_emprestimo_semanas) VALUES ('{nome}', '{email}', '{celular}', '{ra}', '{quantidadeEmprestimo}', '{tempoEmprestimoSemanas}')";
        }
    }
}

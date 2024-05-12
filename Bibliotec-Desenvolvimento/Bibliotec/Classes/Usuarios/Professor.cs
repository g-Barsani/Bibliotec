using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Classes.Usuarios
{
    internal class Professor : Usuario
    {
        private string registro { get; set; }

        //Métodos Construtores
        public Professor() { }

        public Professor(string nome, string email, string celular, string registro) //Construtor para cadastro
        {
            this.nome = nome;
            this.email = email;
            this.celular = celular;
            this.registro = registro;
            quantidadeEmprestimo = 3;
            tempoEmprestimoSemanas = 2;
        }

        public Professor(int id, string nome, string email, string celular, string registro) //Construtor para leitura
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.celular = celular;
            this.registro = registro;
            quantidadeEmprestimo = 3;
            tempoEmprestimoSemanas = 2;
        }

        //métodos CRUD
        public String cadastrarProfessor()
        {
            return $"INSERT INTO tb_professores(nome, email, celular, registro) VALUES ('{nome}', '{email}', '{celular}', '{registro}')";
        }
    }
}

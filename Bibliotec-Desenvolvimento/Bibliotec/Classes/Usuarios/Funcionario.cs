using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Classes.Usuarios
{
    internal class Funcionario : Usuario
    {
        private string registro { get; set; }

        //Métodos Construtores
        public Funcionario() { }

        public Funcionario(string nome, string email, string celular, string registro) //Construtor para cadastro
        {
            this.nome = nome;
            this.email = email;
            this.celular = celular;
            this.registro = registro;
            quantidadeEmprestimo = 3;
            tempoEmprestimoSemanas = 2;
        }

        public Funcionario(int id, string nome, string email, string celular, string registro) //Construtor para leitura
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
        public String cadastrarFuncionario()
        {
            return $"INSERT INTO tb_funcionarios(nome, email, celular, registro, quantidade_emprestimo, tempo_emprestimo_semanas) VALUES ('{nome}', '{email}', '{celular}', '{registro}', '{quantidadeEmprestimo}', '{tempoEmprestimoSemanas}')";
        }
    }
}

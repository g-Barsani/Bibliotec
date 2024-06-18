using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Classes.Usuarios
{
    internal class Usuario
    {
        protected int id { get; set; }
        protected string nome { get; set; }
        protected string email { get; set; }
        protected string celular { get; set; }
        protected int quantidadeEmprestimo { get; set; }
        protected int tempoEmprestimoSemanas { get; set; }

    }
}

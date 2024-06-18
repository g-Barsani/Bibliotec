using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Classes.Materiais
{
    internal class Leitura
    {
        protected int id { get; set; }
        protected String titulo { get; set; }
        protected String palavraChave { get; set; }
        protected String assunto { get; set; }
        protected String localPublicacao { get; set; }
        protected String dataPublicacao { get; set; }
        protected bool disponivel { get; set; }
        protected bool tarjaVermelha { get; set; }
    }
}

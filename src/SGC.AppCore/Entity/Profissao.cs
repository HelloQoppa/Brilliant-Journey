using System;
using System.Collections.Generic;
using System.Text;

namespace SGC.AppCore.Entity
{
    public class Profissao
    {
        public Profissao()
        {

        }
        public int ProfissaoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        //Classificação brasileira de ocupaçoes
        public string CBO { get; set; }
        public ICollection<ProfissaoCliente> ProfissoesClientes { get; set; }
    }
}

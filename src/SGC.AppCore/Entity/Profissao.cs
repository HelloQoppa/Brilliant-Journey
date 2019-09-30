using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SGC.AppCore.Entity
{
    public class Profissao
    {
        public Profissao()
        {
            ProfissoesClientes = new Collection<ProfissaoCliente>();
        }
        public int ProfissaoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        //Classificação brasileira de ocupaçoes
        public string CBO { get; set; }
        public virtual ICollection<ProfissaoCliente> ProfissoesClientes { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SGC.AppCore.Entity
{
    public class Cliente
    {

        public Cliente()
        {
            ProfissoesClientes = new Collection<ProfissaoCliente>();
        }
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public virtual ICollection<Contato> Contatos { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual ICollection<ProfissaoCliente> ProfissoesClientes { get; set; }


    }

}

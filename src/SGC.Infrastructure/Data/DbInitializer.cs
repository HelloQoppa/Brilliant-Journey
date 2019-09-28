using SGC.AppCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGC.Infrastructure.Data
{
    public static class DbInitializer
    {
        //Povoação automatica :P morri na praia
        public static void Initialize(ClienteContext context)
        {
            if (context.Clientes.Any())
            {
                return;
            }
            var clientes = new Cliente[]
            {
                new Cliente
                {
                    Nome="fulano de tal",
                    CPF ="12345678910"
                },
                   new Cliente
                {
                    Nome="Beltrano de tal",
                    CPF ="12345678911"
                }
            };
            context.AddRange(clientes);

            var contatos = new Contato[]
          {
                new Contato
                {
                    Nome="Contato 1",
                    Telefone ="41561515",
                    Email ="fulano@teste.com",
                    Cliente =clientes[0],
                },
                   new Contato
                {
                    Nome="Contato 2",
                    Telefone ="92907648",
                    Email ="Beltrano@teste.com",
                    Cliente =clientes[1],
                }
          };
            context.AddRange(clientes);
            context.SaveChanges();

        }

        public static void Initialize(object context)
        {
            throw new NotImplementedException();
        }
    }
}

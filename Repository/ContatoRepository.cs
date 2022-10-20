using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDMVC_PROJECT.Models;
using CRUDMVC_PROJECT.Data;

namespace CRUDMVC_PROJECT.Repository
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly ContatoContext contato_Context;
        public ContatoRepository(ContatoContext contatoContext)
        {
            contato_Context = contatoContext;
        }
        public ContatoModel adicionar (ContatoModel contato)
        {
            contato_Context.Contato.Add(contato);
            contato_Context.SaveChanges();
            return contato;
        }

        public List<ContatoModel> listarContatos()
        {
            return contato_Context.Contato.ToList();
        }
    }
}
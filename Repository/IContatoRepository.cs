using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDMVC_PROJECT.Models;

namespace CRUDMVC_PROJECT.Repository
{
    public interface IContatoRepository
    {
        ContatoModel adicionar (ContatoModel contato);
        ContatoModel atualizar (ContatoModel contato);
        ContatoModel buscarId (int id);
        List<ContatoModel> listarContatos();
    }
}

using CRUDMVC_PROJECT.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDMVC_PROJECT.Data
{
    public class ContatoContext : DbContext
    {
        public ContatoContext(DbContextOptions<ContatoContext> options) : base(options)
        {
        }
        public DbSet<ContatoModel> Contato {get;set;}
    }
}
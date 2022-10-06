using CRUDMVC_PROJECT.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDMVC_PROJECT.Data
{
    public class ContatoContext : DbContext
    {
        public ContatoContext(DbContextOptions options) : base(options)
        {
        }
    }
}
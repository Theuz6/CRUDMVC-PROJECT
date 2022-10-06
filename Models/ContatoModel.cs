using System.ComponentModel.DataAnnotations;

namespace CRUDMVC_PROJECT.Models
{
    public class ContatoModel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}
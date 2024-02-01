using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDTEST.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string? userName { get; set; }
        public string? clave { get; set; }

        [NotMapped]
        public bool MantenerActivo { get; set; }
    }
}

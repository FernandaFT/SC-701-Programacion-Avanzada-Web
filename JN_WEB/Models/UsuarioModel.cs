using System.ComponentModel.DataAnnotations;

namespace JN_WEB.Models
{
    public class UsuarioModel
    {
        [Required]
        public string Identificacion {  get; set; } = string.Empty;

        [Required]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        public string CorreoElectronico { get; set; } = string.Empty;

        [Required]
        public string Contrasenna { get; set; } = string.Empty;
    }
}

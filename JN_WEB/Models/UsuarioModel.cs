using System.ComponentModel.DataAnnotations;

namespace JN_WEB.Models
{
    public class UsuarioModel
    {
        public int Consecutivo { get; set; }
        public string Identificacion { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string CorreoElectronico { get; set; } = string.Empty;
        public string Contrasenna { get; set; } = string.Empty;
        public Boolean Estado { get; set; }
        public Boolean UsaContrasennaTemp { get; set; }
        public string ConfirmarContrasenna { get; set; } = string.Empty;

    }
}

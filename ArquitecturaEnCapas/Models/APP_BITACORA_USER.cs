using System.ComponentModel.DataAnnotations;

namespace ArquitecturaEnCapas.Models
{
    public class APP_BITACORA_USER
    {
        [Key]
        public decimal idpk { get; set; }
        public string opcion { get; set; }
        public string apps { get; set; }

        public string ip { get; set; }

        public string creadoPor { get; set; }

        public DateTime creadoDate { get; set; }

    }
}

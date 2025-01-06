using ArquitecturaEnCapas.Models;
using Microsoft.EntityFrameworkCore;

namespace ArquitecturaEnCapas.Data
{
    public class BitacoraContexto:DbContext
    {
        public BitacoraContexto(DbContextOptions<BitacoraContexto> options):base(options) { 
            
        }
        public DbSet<APP_BITACORA_USER> APP_BITACORA_USER { get; set; }
    }
}

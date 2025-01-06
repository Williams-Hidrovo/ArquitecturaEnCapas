using ArquitecturaEnCapas.Models;

namespace ArquitecturaEnCapas.Repositories.IRepositories
{
    public interface IBitacoraRepository
    {
        Task<IEnumerable<APP_BITACORA_USER>> GetAllAsync();
        Task<APP_BITACORA_USER> GetByIdAsync(decimal id);
        Task<APP_BITACORA_USER> AddAsync(APP_BITACORA_USER user);
        Task<APP_BITACORA_USER> UpdateAsync(APP_BITACORA_USER user);
        Task<bool> DeleteAsync(decimal id);
    }
}

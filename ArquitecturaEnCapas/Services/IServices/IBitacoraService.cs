using ArquitecturaEnCapas.Dtos;
using ArquitecturaEnCapas.Models;

namespace ArquitecturaEnCapas.Services.IServices
{
    public interface IBitacoraService
    {
        Task<ICollection<BitacoraUserDto>> GetAllAsync();
        Task<BitacoraUserDto> GetByIdAsync(decimal id);
        Task<BitacoraUserDto> AddAsync(BitacoraUserDto user);
        Task<BitacoraUserDto> UpdateAsync(BitacoraUserDto user);
        Task<bool> DeleteAsync(decimal id);
    }
}

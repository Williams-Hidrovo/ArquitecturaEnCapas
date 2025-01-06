using ArquitecturaEnCapas.Data;
using ArquitecturaEnCapas.Models;
using ArquitecturaEnCapas.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace ArquitecturaEnCapas.Repositories
{
    public class BitacoraRepository : IBitacoraRepository
    {
        private readonly BitacoraContexto _contexto;
        public BitacoraRepository(BitacoraContexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<APP_BITACORA_USER> AddAsync(APP_BITACORA_USER user)
        {
            try
            {
                await _contexto.APP_BITACORA_USER.AddAsync(user);
                await _contexto.SaveChangesAsync();
                return user; // Indica que la operación fue exitosa
            }
            catch(Exception ex) {
                throw new Exception("Error al agregar registro", ex);
            }
        }

        public async Task<bool> DeleteAsync(decimal idpk)
        {
            try
            {
                var obj = await _contexto.APP_BITACORA_USER.FindAsync(idpk);


                _contexto.APP_BITACORA_USER.Remove(obj);
                await _contexto.SaveChangesAsync(); 
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al eliminar Registro");
            }
        }

        public async Task<IEnumerable<APP_BITACORA_USER>> GetAllAsync()
        {
            try
            {
                var list= await _contexto.APP_BITACORA_USER.Take(100).ToListAsync();
                return list;
            }
            catch (Exception ex) {
                throw new Exception("No se pudo obtener la lista",ex);
            }
            
        }

        public async Task<APP_BITACORA_USER> GetByIdAsync(decimal idpk)
        {
            var obj= await _contexto.APP_BITACORA_USER.FindAsync(idpk);
            return obj;
        }

        public async Task<APP_BITACORA_USER> UpdateAsync(APP_BITACORA_USER user)
        {
            var existingUser = await _contexto.APP_BITACORA_USER.FindAsync(user.idpk);
            if (existingUser == null)
            {
                throw new KeyNotFoundException($"No se encontró el usuario con ID {user.idpk}");
            }

            //actualiza solo los campos necesarios que se envio
            _contexto.Entry(existingUser).CurrentValues.SetValues(user);

            await _contexto.SaveChangesAsync();

            return existingUser;

        }
    }
}

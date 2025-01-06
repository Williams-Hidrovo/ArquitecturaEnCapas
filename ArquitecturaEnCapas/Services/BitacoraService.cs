using ArquitecturaEnCapas.Dtos;
using ArquitecturaEnCapas.Models;
using ArquitecturaEnCapas.Repositories.IRepositories;
using ArquitecturaEnCapas.Services.IServices;
using AutoMapper;

namespace ArquitecturaEnCapas.Services
{
    public class BitacoraService : IBitacoraService
    {
        private readonly IBitacoraRepository _repository;
        private readonly IMapper _mapper;
        public BitacoraService(IBitacoraRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }
        public async Task<BitacoraUserDto> AddAsync(BitacoraUserDto user)
        {
            var model = _mapper.Map<APP_BITACORA_USER>(user);
            var resp= await _repository.AddAsync(model);
            var respDto=_mapper.Map<BitacoraUserDto>(resp);
            return respDto;
        }

        public Task<bool> DeleteAsync(decimal id)
        {
            return _repository.DeleteAsync(id);
        }

        public async Task<ICollection<BitacoraUserDto>> GetAllAsync()
        {
            var list=await _repository.GetAllAsync();
            var listDto = _mapper.Map<ICollection<BitacoraUserDto>>(list);
            return listDto;
        }

        public async Task<BitacoraUserDto> GetByIdAsync(decimal id)
        {
            var resp= await _repository.GetByIdAsync(id);
            var respDto = _mapper.Map<BitacoraUserDto>(resp);
            return respDto;
        }

        public async Task<BitacoraUserDto> UpdateAsync(BitacoraUserDto user)
        {
            var resp =await _repository.UpdateAsync(_mapper.Map<APP_BITACORA_USER>(user));
            var respDto = _mapper.Map<BitacoraUserDto>(resp);
            return respDto;
        }
    }
}

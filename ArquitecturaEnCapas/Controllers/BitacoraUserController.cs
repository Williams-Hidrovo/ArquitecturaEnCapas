using ArquitecturaEnCapas.Dtos;
using ArquitecturaEnCapas.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArquitecturaEnCapas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BitacoraUserController : ControllerBase
    {
        private readonly IBitacoraService _Iservice;
        public BitacoraUserController(IBitacoraService Iservice) {
            _Iservice = Iservice;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() {
            var list= await _Iservice.GetAllAsync();
            return Ok(list);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(decimal id)
        {
            var producto = await _Iservice.GetByIdAsync(id);
            if (producto == null)
            {
                return NotFound();
            }
            return Ok(producto);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] BitacoraUserDto user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var resp=await _Iservice.AddAsync(user);
            return Ok(resp);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] BitacoraUserDto user)
        {
            //validar el objeto enviado
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var objUpdate=await _Iservice.UpdateAsync(user);

            return Ok(objUpdate);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(decimal id )
        {
            var resp= await _Iservice.DeleteAsync(id);
            return Ok(resp);
        }

    }
}

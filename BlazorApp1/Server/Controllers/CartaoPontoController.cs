using BlazorApp1.Client.Service.Interfaces;
using BlazorApp1.Server.Context;
using BlazorApp1.Server.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;

namespace BlazorApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartaoPontoController : Controller
    {
        private readonly ApplicationDbContext _app;
        public CartaoPontoController(ApplicationDbContext app)
        {
            _app = app;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CartaoPonto cartaoPonto)
        {
            try
            {
                _app.CartaoPonto.Add(cartaoPonto);
                await _app.SaveChangesAsync();

                return Ok(cartaoPonto);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var registro = _app.CartaoPonto.FirstOrDefault(f => f.Id == id);

                _app.CartaoPonto.Remove(registro);
                await _app.SaveChangesAsync();
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
                
            }
        }
        [HttpPut]
        public async Task<IActionResult> Edit(CartaoPonto obj)
        {
            try
            {
                var registro = _app.CartaoPonto.FirstOrDefault(x => x.Id == obj.Id);

                registro.Saida1 = obj.Saida1;
                registro.Saida2 = obj.Saida2;
                registro.Entrada1 = obj.Entrada1;
                registro.Entrada2 = obj.Entrada2;

                _app.CartaoPonto.Update(registro);
                await _app.SaveChangesAsync();
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCartaoPonto()
        {
            try
            {
                var list = await _app.CartaoPonto.ToListAsync();

                return Ok(list);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetByIdCartaoPonto(int id)
        {
            try
            {
                var obj = await _app.CartaoPonto.FirstOrDefaultAsync(f => f.Id == id);

                return Ok(obj);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }
    }
}

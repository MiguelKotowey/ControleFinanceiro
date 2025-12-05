using ControleFinanceiro.Core.Entidades;
using ControleFinanceiro.Core.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ControleFinanceiro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoDespesaController : ControllerBase
    {
        private readonly IRepository<TipoDespesa> _repository;

        public TipoDespesaController(IRepository<TipoDespesa> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var tiposDespesa = await _repository.GetAllAsync();
            return Ok(tiposDespesa);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var tipoDespesa = await _repository.GetByIdAsync(id);
            if (tipoDespesa == null)
                return NotFound();

            return Ok(tipoDespesa);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TipoDespesa tipoDespesa)
        {
            var created = await _repository.CreateAsync(tipoDespesa);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] TipoDespesa tipoDespesa)
        {
            if (id != tipoDespesa.Id)
                return BadRequest();

            var existing = await _repository.GetByIdAsync(id);
            if (existing == null)
                return NotFound();

            await _repository.UpdateAsync(tipoDespesa);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var existing = await _repository.GetByIdAsync(id);
            if (existing == null)
                return NotFound();

            await _repository.DeleteAsync(id);
            return NoContent();
        }

        [HttpGet("ativos")]
        public async Task<IActionResult> GetAtivos()
        {
            var ativos = await _repository.GetManyAsync(t => t.Ativo);
            return Ok(ativos);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using revisaoProjeto.Data;
using revisaoProjeto.Models;

namespace revisaoProjeto.Controllers
{
    [ApiController]
    [Route("api/humano")]
    public class HumanoController : ControllerBase
    {
        private readonly AppDataContext _context;

        public HumanoController(AppDataContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            try
            {
                List<Humano> humanos = _context.Humanos.ToList();
                return Ok(humanos);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Humano humano)
        {
            try
            {
                _context.Add(humano);
                _context.SaveChanges();
                return Created("", humano);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
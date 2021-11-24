using System.Linq;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/formadepagamento")]
    public class FormaDePagamentoController : ControllerBase
    {
        private readonly DataContext _context;
        public FormaDePagamentoController(DataContext context)
        {
            _context = context;
        }

        //POST: api/formadepagamento/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] FormasDePagamento forma)
        {
            _context.FormasDePagamentos.Add(forma);
            _context.SaveChanges();
            return Created("", forma);
        }

        //GET: api/formadepagamento/list
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.FormasDePagamentos.ToList());

    }
}
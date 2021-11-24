using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/inicializar")]
    public class InicializarDadosController : ControllerBase
    {
        private readonly DataContext _context;
        public InicializarDadosController(DataContext context)
        {
            _context = context;
        }

        //POST: api/inicializar/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create()
        {
            _context.Categorias.AddRange(new Categoria[]
                {
                    new Categoria { CategoriaId = 1, Nome = "Roupas" },
                }
            );
            _context.Produtos.AddRange(new Produto[]
                {
                    new Produto { ProdutoId = 1, Nome = "Camiseta", Preco = 40, Quantidade = 5, CategoriaId = 3},
                    new Produto { ProdutoId = 2, Nome = "Bermuda", Preco = 30, Quantidade = 10, CategoriaId = 3 },
                    new Produto { ProdutoId = 3, Nome = "Calça Moletom", Preco = 90, Quantidade = 15, CategoriaId = 3 },
                }
            );
           _context.FormasDePagamentos.AddRange(new FormasDePagamento[]
                {
                    new FormasDePagamento { FormasDePagamentoId = 1, OpcaoPagamento = "Crédito", ParcelaPagamento = "3x" },
                    new FormasDePagamento { FormasDePagamentoId = 2, OpcaoPagamento = "Débito", ParcelaPagamento = "À vista" },
                    new FormasDePagamento { FormasDePagamentoId = 3, OpcaoPagamento = "Pix", ParcelaPagamento = "À vista" }
                }
            );
            _context.SaveChanges();
            return Ok(new { message = "Dados inicializados com sucesso!" });
        }
    }
}
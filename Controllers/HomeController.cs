using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProductApi.Models;
using ProductApi.Repositories.Contracts;

namespace ProductApi.Controllers;

[ApiController]
public class HomeController : ControllerBase
{
    private readonly IProdutoRepository _produtoRepository;
    private readonly ICategoriaRepository _categoriaRepository;

    public HomeController(IProdutoRepository produtoRepository,
        ICategoriaRepository categoriaRepository)
    {
        _produtoRepository = produtoRepository;
        _categoriaRepository = categoriaRepository;
    }
    
    [HttpGet]
    [Route("produtos")]
    public async Task<ActionResult<dynamic>> TodosProdutos()
    {
        var produtos = _produtoRepository.TodosProdutos();
        
        return Ok(produtos);
    }

    [HttpGet]
    [Route("produtos/{id:int}")]
    public async Task<ActionResult<dynamic>> ProdutoPorId(int id)
    {
        var produto = _produtoRepository.ObterProdutoPorId(id);
        
        return Ok(produto);
    }
    
    [HttpPost]
    [Route("produtos")]
    public async Task<ActionResult<dynamic>> AdicionarProduto(Produto produto)
    {
        _produtoRepository.AdicionarProduto(produto);
        
        return StatusCode(201, produto);
    }

    [HttpPut]
    [Route("produtos/{id:int}")]
    public async Task<ActionResult<dynamic>> AtualizarProduto(Produto produto)
    {
        _produtoRepository.AtualizarProduto(produto);
        return Ok(produto);
    }

    [HttpDelete]
    [Route("produtos/{id:int}")]
    public async Task<ActionResult<dynamic>> RemoverProduto(int id)
    {
        _produtoRepository.RemoverProduto(id);
        return NoContent();
    }
}
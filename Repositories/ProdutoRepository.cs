using ProductApi.Models;
using ProductApi.Repositories.Contracts;

namespace ProductApi.Repositories;

public class ProdutoRepository : IProdutoRepository
{
    List<Produto> produtos = new List<Produto>();
    public List<Produto> TodosProdutos()
    {
        try
        {
            return produtos;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public Produto ObterProdutoPorId(int id)
    {
        try
        {
            Produto produto = produtos.FirstOrDefault(p => p.Id == id);
            
            return produto;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void AdicionarProduto(Produto produto)
    {
        try
        {
            produtos.Add(produto);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void AtualizarProduto(Produto produto)
    {
        try
        {
            Produto produtoAtualizado = produtos.FirstOrDefault(p => p.Id == produto.Id);
            
            produtoAtualizado.Nome = produto.Nome;
            produtoAtualizado.Preco = produto.Preco;
            produtoAtualizado.Categoria = produto.Categoria;
            produtoAtualizado.Quantidade = produto.Quantidade;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void RemoverProduto(int id)
    {
        try
        {
            Produto produto = produtos.FirstOrDefault(p => p.Id == id);
            produtos.Remove(produto);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
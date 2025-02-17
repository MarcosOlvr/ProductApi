using ProductApi.Models;

namespace ProductApi.Repositories.Contracts;

public interface IProdutoRepository
{
    List<Produto> TodosProdutos();
    Produto ObterProdutoPorId(int id);
    void AdicionarProduto(Produto produto);
    void AtualizarProduto(Produto produto);
    void RemoverProduto(int id);
}
using ProductApi.Models;

namespace ProductApi.Repositories.Contracts;

public interface ICategoriaRepository
{
    List<Categoria> TodasCategorias();
    Categoria BuscarCategoriaPorId(int id);
    void AdicionarCategoria(Categoria categoria);
    void AtualizarCategoria(Categoria categoria);
    void RemoverCategoria(int id);
    
}
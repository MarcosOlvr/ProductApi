using ProductApi.Models;
using ProductApi.Repositories.Contracts;

namespace ProductApi.Repositories;

public class CategoriaRepository : ICategoriaRepository
{
    List<Categoria> categorias = new List<Categoria>();
    
    public List<Categoria> TodasCategorias()
    {
        try
        {
            return categorias;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public Categoria BuscarCategoriaPorId(int id)
    {
        try
        {
            Categoria categoria = categorias.FirstOrDefault(c => c.Id == id);
            
            return categoria;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void AdicionarCategoria(Categoria categoria)
    {
        try
        {
            categorias.Add(categoria);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void AtualizarCategoria(Categoria categoria)
    {
        try
        {
            Categoria categoriaAtual = categorias.FirstOrDefault(c => c.Id == categoria.Id);
            categoriaAtual.Nome = categoria.Nome;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void RemoverCategoria(int id)
    {
        try
        {
            Categoria categoria = categorias.FirstOrDefault(c => c.Id == id);
            categorias.Remove(categoria);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
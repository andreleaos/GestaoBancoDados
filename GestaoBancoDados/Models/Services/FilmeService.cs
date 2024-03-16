using GestaoBancoDados.Models.Domain.Entities;
using GestaoBancoDados.Models.Domain.Interfaces;

namespace GestaoBancoDados.Models.Services;
public class FilmeService : IFilmeService
{
    private readonly IFilmeRepository _filmeRepository;

    public FilmeService(IFilmeRepository filmeRepository)
    {
        _filmeRepository = filmeRepository;
    }

    public void Create(Filme entity)
    {
        try
        {
            _filmeRepository.Create(entity);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public void Delete(int id)
    {
        try
        {
            _filmeRepository.Delete(id);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public List<Filme> GetAll()
    {
        try
        {
            var result = _filmeRepository.GetAll();
            return result;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public Filme GetById(int id)
    {
        try
        {
            var result = _filmeRepository.GetById(id);
            return result;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public void Update(Filme entity)
    {
        try
        {
            _filmeRepository.Update(entity);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}

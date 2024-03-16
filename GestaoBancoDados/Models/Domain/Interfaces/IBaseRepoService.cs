namespace GestaoBancoDados.Models.Domain.Interfaces;
public interface IBaseRepoService<T, Y>
{
    void Create(T entity);
    void Update(T entity);
    void Delete(Y id);
    T GetById(Y id);
    List<T> GetAll();
}

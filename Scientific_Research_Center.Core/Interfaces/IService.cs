namespace Scientific_Research_Center.Core.Interfaces;

public interface IService<T>
    where T : class
{
    public T? Get(int id);
    public IEnumerable<T> Get();
    public IEnumerable<T> Get(Func<T, bool> predicate);
    public Task Add(T entity);
    public Task Delete(int id);
    public Task Update(T entity);
}
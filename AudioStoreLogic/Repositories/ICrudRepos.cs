namespace AudioStoreLogic.Repositories;

internal interface ICrudRepos<T>
{
    public void Add(T obj);
    public bool Remove(T obj);
    public void Remove(int index);
    public T? Find(Predicate<T> predicate);
    public T At(int index);
}
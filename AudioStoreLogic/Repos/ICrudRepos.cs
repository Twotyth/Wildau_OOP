namespace AudioStoreLogic.Repos;

internal interface ICrudRepos<T>
{
    public void Add(T obj);
    public void Remove(T obj);
    public void Remove(int index);
    public T? Find(Predicate<T> predicate);
    public T At(int index);
}
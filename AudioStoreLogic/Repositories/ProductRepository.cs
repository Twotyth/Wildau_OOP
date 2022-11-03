using AudioStoreLogic.Model.Product;

namespace AudioStoreLogic.Repositories;

internal sealed class ProductRepository : ICrudRepos<Product>
{
    private readonly List<Product> _arr = new();

    public void Add(Product obj) => _arr.Add(obj);
    
    public bool Remove(Product obj) => _arr.Remove(obj);
    
    public void Remove(int index) => _arr.RemoveAt(index);
    
    public Product? Find(Predicate<Product> predicate) => _arr.Find(predicate);
    
    public Product At(int index) => _arr[index];
}
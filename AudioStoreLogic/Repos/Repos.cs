using AudioStoreLogic.Model;

namespace AudioStoreLogic.Repos;

internal sealed class Repos : ICrudRepos<AudioProduct>
{
    private readonly List<AudioProduct> _arr = new();

    public void Add(AudioProduct obj) => _arr.Add(obj);
    
    public void Remove(AudioProduct obj) => _arr.Remove(obj);
    
    public void Remove(int index) => _arr.RemoveAt(index);
    
    public AudioProduct? Find(Predicate<AudioProduct> predicate) => _arr.Find(predicate);
    
    public AudioProduct At(int index) => _arr[index];
}
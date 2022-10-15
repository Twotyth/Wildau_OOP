using AudioStoreLogic.Model.Review;

namespace AudioStoreLogic.Repositories;

internal sealed class ProductReviewRepository : ICrudRepos<Review>
{
    private readonly List<Review> _arr = new();
    public void Add(Review obj) => _arr.Add(obj);

    public bool Remove(Review obj) => _arr.Remove(obj);

    public void Remove(int index) => _arr.RemoveAt(index);

    public Review Find(Predicate<Review> predicate) => _arr.Find(predicate);

    public Review At(int index) => _arr[index];
}
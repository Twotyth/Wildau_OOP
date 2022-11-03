using System.Drawing;

namespace AudioStoreLogic.Model.Product;

public abstract class Product
{
    internal Guid Id = Guid.NewGuid();
    protected double _price;
    protected int _discount;
    protected IEnumerable<MaterialTypes> _materials;
    protected IEnumerable<Review.Review> _reviews;
    protected IEnumerable<Color> _colors;

    public double Price
    {
        get => _price;
        internal set => _price = value > 0 
            ? value 
            : throw new ArgumentOutOfRangeException(nameof(Price));
    }
    
    public int Discount
    {
        get => _discount;
        internal set => _discount = value is >= 0 and < 100 
            ? value 
            : throw new ArgumentOutOfRangeException(nameof(Discount));
    }
    


    public double RealPrice => Math.Round(Price * Discount / 100.0, 2);
    public string Brand { get; internal set; }
    public string Description { get; internal set; }

    public string ColorsAsString
    {
        get
        {
            string toReturn = "";

            for (int i = 0; i < _colors.Count() - 1; i++)
            {
                toReturn += _colors.ElementAt(i) + ", ";
            }

            return toReturn + _colors.Last();
        }
    }
    
    public string MaterialsAsString
    {
        get
        {
            string toReturn = "";

            for (var i = 0; i < _materials.Count() - 1; i++) 
                toReturn += Enum.GetName(_materials.ElementAt(i)) + ", ";

            toReturn += Enum.GetName(_materials.ElementAt(^1));

            return toReturn;
        }
    }
    
}
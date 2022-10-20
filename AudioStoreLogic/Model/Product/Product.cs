namespace AudioStoreLogic.Model.Product;

public abstract class Product
{
    internal Guid Id = Guid.NewGuid();
    protected double _price;
    protected int _discount;
    protected IEnumerable<MaterialTypes> _materials;
    protected IEnumerable<Review.Review> _reviews;

    internal double Price
    {
        get => _price;
        set => _price = value > 0 
            ? value 
            : throw new ArgumentOutOfRangeException(nameof(Price));
    }
    
    internal int Discount
    {
        get => _discount;
        set => _discount = value is >= 0 and < 100 
            ? value 
            : throw new ArgumentOutOfRangeException(nameof(Discount));
    }

    public double RealPrice => Math.Round(Price * Discount / 100.0, 2);
    public string Brand { get; internal set; }
    public string Description { get; internal set; }
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

/* TODO implement Speakers
 * AUDIO HI-FI STORE (proj)
 * 
 * CLASS HIERARCHY
 * 
 * (Product) Accessory,
 * (Product) MixingProduct,
 * (AudioProduct) RecordingSoundProduct -> RecordingProductType
 * 
 * 
 * (AudioProduct) ReproducingSoundProduct ->
 *      ReproducingDriver[] drivers,
 *      
 *      DriversAsString(),
 *      
 * {
 *      ReproducingDriver -> size, type
 * }
 * 
 * 
 * ^ (abstracts to) ^
 * 
 * 
 * (abstract) AudioIOProduct -> Ohmpedance, HzRange, ConnectorType[] IO, HzRangeAsString(), IOAsString()
 * ^
 * (abstract) Product -> ID, Price, Dicsount, Brand, Description, MaterialType[] Materials
 *      {
 *          (enum) MaterialType: Wood, Plastic, Metal, Leather, Glass, Gold,
 *      }
 */
namespace AudioStoreLogic.Model.Product;

internal abstract class Product
{
    internal string Id = Guid.NewGuid().ToString();
    private float _price;
    private float _discount;

    internal float Price
    {
        get => _price;
        set => _price = value > 0 
            ? value 
            : throw new ArgumentOutOfRangeException(nameof(Price));
    }
    internal float Discount
    {
        get => _discount;
        set => _discount = value is >= 0 and < 100 
            ? value 
            : throw new ArgumentOutOfRangeException(nameof(Discount));
    }
    internal abstract string Brand { get; set; }
    internal abstract string Description { get; set; }
    internal static ProductTypes Type;
}

/* TODO implement Class hierarchy
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
 * (abstract) AudioProduct -> Ohmpedance, HzRange, ConnectorType[] IO, HzRangeAsString(), IOAsString()
 * ^
 * (abstract) Product -> ID, Price, Dicsount, Brand, Description, MaterialType[] Materials
 *      {
 *          (enum) MaterialType: Wood, Plastic, Metal, Leather, Glass, Gold,
 *      }
 */
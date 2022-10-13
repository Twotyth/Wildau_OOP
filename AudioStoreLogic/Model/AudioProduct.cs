namespace AudioStoreLogic.Model;

internal abstract class AudioProduct
{
    protected internal string _id = Guid.NewGuid().ToString();
    public float Price { get; protected internal set; }
    public string Brand { get; protected internal set; }
}

/*
 * AUDIO HI-FI STORE (proj)
 *
 * (Product) Accessory,
 * (Product) MixingProduct
 * (extends AudioProduct) RecordingSoundProduct, 
 * (extends AudioProduct) ReproducingSoundProduct,
 * 
 * ^ (abstracts) ^
 * 
 * (abstract) AudioProduct -> ohmpedance, hzRange
 * ^
 * (abstract) Product -> ID, Price, Brand
 */
namespace AudioStoreLogic.Model.Headphones;

public class Headphones : AudioIoProduct.AudioIoProduct
{
    public HeadphonesType Type { get; internal set; }
    public AttachmentMethod Attachment { get; internal set; }
    public SoundSchemeFormat SchemeFormat { get; internal set; }
    internal bool IsAnc;
    internal ILookup<int, Driver> Drivers;

    internal Headphones (HeadphonesType type, SoundSchemeFormat schemeFormat, 
        AttachmentMethod attachment, bool isAnc, ILookup<int, Driver> drivers)
    {
        (Type, SchemeFormat, Attachment, IsAnc, Drivers) = (type, schemeFormat, attachment, isAnc, drivers);
    }
}
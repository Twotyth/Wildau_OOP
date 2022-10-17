namespace AudioStoreLogic.Model.Headphones;

public class Headphones
{
    public HeadphonesType Type { get; internal set; }
    public AttachmentMethod Attachment { get; internal set; }
    public SoundSchemeFormat SchemeFormat { get; internal set; }
    internal bool IsAnc;

    internal Headphones(HeadphonesType type, SoundSchemeFormat schemeFormat, 
        AttachmentMethod attachment, bool isAnc)
        => 
                (Type, SchemeFormat, Attachment, IsAnc) = (type, schemeFormat, attachment, isAnc);
    
}
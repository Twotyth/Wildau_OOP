namespace AudioStoreLogic.Model.Microphone;

using AudioIoProduct;

public class Microphone : AudioIoProduct
{
    protected int _sensitivity;
    
    public MicrophoneType Type { get; internal set; }
    public MicrophoneTypeOperation OperationType { get; internal set; }
    internal IEnumerable<SoundPickingPattern> PickingPattern { get; set; }

    public int Sensitivity
    {
        get => _sensitivity;
        internal set
        {
            if (value is > -6 or < -120) 
                throw new ArgumentOutOfRangeException(nameof(_sensitivity), value, "was out of range");
            _sensitivity = value;
        }
    }

    internal Microphone(MicrophoneType type, MicrophoneTypeOperation operationType,
        IEnumerable<SoundPickingPattern> pickingPattern, int sensitivity)
        =>
            (Type, OperationType, PickingPattern, Sensitivity) = (type, operationType, pickingPattern, sensitivity);
}
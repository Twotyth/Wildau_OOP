using System.Diagnostics.CodeAnalysis;

namespace AudioStoreLogic.Model.Microphone;

using AudioIoProduct;

public class Microphone : AudioIoProduct
{
    private int _sensitivity;
    
    public MicrophoneType Type { get; internal set; }
    public MicrophoneTypeOperation OperationType { get; internal set; }
    [NotNull]
    public IEnumerable<SoundPickingPattern> PickingPattern { get; internal set; }

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

    public Microphone(MicrophoneType type, MicrophoneTypeOperation operationType,
        IEnumerable<SoundPickingPattern> pickingPattern, int sensitivity)
        =>
            (Type, OperationType, PickingPattern, Sensitivity) = (type, operationType, pickingPattern, sensitivity);
}
namespace AudioStoreLogic.Model.AudioIoProduct;

public abstract class AudioIoProduct : Product.Product
{
    public int Ohmpedance { get; internal set; }
    public Range HzRange { get; internal set; }
    public ConnectionType ConnectionType { get; internal set; }
    public IEnumerable<ConnectorTypes> Io { get; internal set; }
    public string HzRangeAsString => HzRange.Start + " - " + HzRange.End;
    public string IoAsString
    {
        get
        {
            string toReturn = "";

            for (var i = 0; i < Io.Count() ; i++) 
                toReturn += IOConverter(Io.ElementAt(i)) + ", ";

            toReturn += IOConverter(Io.ElementAt(^1));
            
            return toReturn;
        }
    }

    protected string IOConverter(ConnectorTypes type) => type switch
    {
        ConnectorTypes.Adat => "ADAT",
        ConnectorTypes.Aux => "AUX",
        ConnectorTypes.Bnc => "BNC",
        ConnectorTypes.AC220V => "Circuit",
        ConnectorTypes.Mmcx => "MMCX",
        ConnectorTypes.Xlr => "XLR",
        ConnectorTypes.BPin => "B-Pin",
        ConnectorTypes.CPin => "C-Pin",
        ConnectorTypes.MiniJack => "3.5 mm Jack",
        ConnectorTypes.FourthInchJack => "1/4\" Jack",
        ConnectorTypes.Bluetooth => "Bluetooth",
        ConnectorTypes.GHz2_4 => "2.4 GHz",
        ConnectorTypes.Usb => "USB",
        ConnectorTypes.UsbB => "USB-B",
        ConnectorTypes.UsbC => "USB-C"
    };
}
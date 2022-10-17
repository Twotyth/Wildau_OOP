namespace AudioStoreLogic.Model.AudioProduct;

public abstract class AudioIoProduct : Product.Product
{
    internal int Ohmpedance { get; set; }
    internal Range HzRange { get; set; }
    internal ConnectionType ConnectionType { get; set; }
    internal IEnumerable<ConnectorTypes> Io { get; set; }

    internal string HzRangeAsString => HzRange.Start + " - " + HzRange.End;

    internal string IoAsString
    {
        get
        {
            string toReturn = "";

            for (var i = 0; i < Io.Count() - 1; i++) 
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
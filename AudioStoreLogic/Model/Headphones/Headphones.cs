using System.Diagnostics.CodeAnalysis;

namespace AudioStoreLogic.Model.Headphones;

using AudioIoProduct;

public class Headphones : AudioIoProduct
{
    public HeadphonesType Type { get; internal set; }
    public AttachmentMethod Attachment { get; internal set; }
    public SoundSchemeFormat SchemeFormat { get; internal set; }
    internal bool IsAnc;
    [NotNull]
    protected IEnumerable<(Driver, float, int)> _drivers;

    public string DriversAsString
    {
        get
        {
            string toReturn = "";
            for (int i = 0; i < _drivers.Count() - 1; i++)
                toReturn += DriverConverter(_drivers.ElementAt(i)) + ", ";
            return toReturn + DriverConverter(_drivers.Last());
        }
    }
    
    public Headphones (HeadphonesType type, SoundSchemeFormat schemeFormat, 
        AttachmentMethod attachment, bool isAnc, IEnumerable<(Driver,float, int)> drivers)
    {
        (Type, SchemeFormat, Attachment, IsAnc, _drivers) = (type, schemeFormat, attachment, isAnc, drivers);
    }

    protected string DriverConverter((Driver, float, int) driver) =>
        driver.Item3 + " " + driver.Item1 switch
        {
            Driver.BalancedArmature => "BA ",
            Driver.Dynamic => "DD ",
            Driver.Electret => "Electret ",
            Driver.Piezoelectric => "PE ",
            Driver.Planar => "Planar ",
            Driver.BoneConductor => "BC "
        } + driver.Item2 + " mm";

}
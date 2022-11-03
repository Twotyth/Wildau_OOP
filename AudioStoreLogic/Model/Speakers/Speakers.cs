namespace AudioStoreLogic.Model.Speakers;

using AudioIoProduct;

public class Speakers : AudioIoProduct
{
    public bool IsWaterResistant { get; internal set; }
    public bool IsSmart { get; internal set; }
    public SpeakersTypes Type { get; internal set; }
    public IEnumerable<(Driver, float, int)> _drivers;
    
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

    public Speakers(bool isWaterResistant, bool isSmart, SpeakersTypes type, IEnumerable<(Driver, float, int)> drivers)
        => (IsWaterResistant, IsSmart, Type, _drivers) = (isWaterResistant, isSmart, type, drivers);

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


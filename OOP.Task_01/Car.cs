namespace OOP.Task_01;
internal sealed class Car
{
    // Id
    // Plate (letters,numbers)
    // LicenseExpirationDate
    // LicenseCreationDate
    // IsLicenseValid
    // Model
    // Color
    // Speed
    // Price
    private string letters;
    private string numbers;
    internal int Id { get; set; }
    internal string Letters
    {
        set { letters = value; }
        private get { return letters; }
    }

    internal string Numbers
    {
        set { numbers = value; }
        private get { return numbers; }
    }
    internal string Plate
    {
        get
        {
            return $"[{Letters},{Numbers}]";
        }
    }
    internal DateTime LicenseExpirationDate
    {
        get
        {
            return LicenseCreationDate.AddYears(10);
        }
    }
    internal bool IsLicenseValid
    {
        get
        {
            return DateTime.Now < LicenseExpirationDate;
        }
    }
    internal string Model { get; set; }
    internal string Color { get; set; }
    internal DateTime LicenseCreationDate { private get; set; }
    internal double Speed { get; set; } // km/h
    internal decimal Price { get; set; }
    public override string ToString()
    {
        return $" id:{Id}\n color: {Color}\n plate: {Plate}\n model: {Model}\n license expiration date: {DateOnly.FromDateTime(LicenseExpirationDate)}\n License validation: {IsLicenseValid}\n speed: {Speed}\n price: {Price}";
    }
}

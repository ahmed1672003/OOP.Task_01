using OOP.Task_01;

Car car = new Car();
car.Id = 1;
car.Letters = "asdc";
car.Numbers = "123654";
car.Color = "red";
car.Model = "BMW";
try
{
    car.LicenseCreationDate = new DateTime(2013, 11, 31);
}
catch (ArgumentOutOfRangeException argumentOutOfRangeException)
{
    car.LicenseCreationDate = DateTime.Now;
    Console.WriteLine($" warning!! => license creation date is not valid date or month, day\n license creation date take {DateTime.Now}\n go to change it if you need.");
    Console.WriteLine("========================================");
    Console.Clear();
}
car.Speed = 400;
car.Price = 15000.5M;
Console.WriteLine(car.ToString());

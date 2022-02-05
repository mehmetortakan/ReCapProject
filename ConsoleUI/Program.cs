
using Business.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());

foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.Id+" "+car.DailyPrice);
}


Car car1 = new Car();
car1.Id = 8;
car1.BrandId = 3;
car1.ColorId = 5;
car1.DailyPrice = 0;
car1.ModelYear = 2022;
car1.Description = "Araç Açıklama 8";

carManager.Add(car1);
    
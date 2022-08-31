// See https://aka.ms/new-console-template for more information
using Business.Concreate;
using DataAccess.Concreate.InMemory;
using Entities.Concreate;
Car car = new Car();
car.Id = 7;
car.BrandId = 5;
car.ColorId = 4;
car.ModelYear = 2021;
car.DailyPrice = 7800;
car.Description = "mitsubishi";
CarManager cm = new CarManager(new InMemoryCarDal());
foreach (var  item in cm.GetAll())
{
    Console.WriteLine(item.Id+" "+item.Description + " " +item.ModelYear);
   
}
foreach (var item in cm.GetById(2))
{
    Console.WriteLine("GetByID yapıldıktan sonra");
    Console.WriteLine("_____________________________________________________________");
   
    Console.WriteLine("id si "+ item.Id +" olan ürün"+ item.Description);
    Console.WriteLine("_____________________________________________________________");

}



cm.Add(car);
foreach (var item in cm.GetAll())
{
    Console.WriteLine("Ekle yapıldıktan sonra");
  
   
    Console.WriteLine(item.Id + " " + item.Description + " " + item.ModelYear);

}
Console.WriteLine("_____________________________________________________________");

Console.WriteLine("Güncelleme yapıldıktan sonra");
foreach (var item in cm.GetById(2))
{



    item.Id = 100;
    item.BrandId = 0;
    item.ColorId = 0;
    item.ModelYear = 0;
    item.DailyPrice = 0;
    item.Description = "id si 2 olan güncellendi";

}


foreach (var item in cm.GetAll())
{
   


    Console.WriteLine(item.Id + " " + item.Description + " " + item.ModelYear);

}
Console.WriteLine("_____________________________________________________________");
cm.Delete(car);

Console.WriteLine("silme gerçeklerşti");

foreach (var item in cm.GetAll())
{

 
    Console.WriteLine(item.Id + " " + item.Description + " " + item.ModelYear);

}
Console.ReadKey();

using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concreate.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=1500,ModelYear=1984,Description="Ford Marka Bir Arabadır."}, 
                new Car{Id=2,BrandId=2,ColorId=2,DailyPrice=1700,ModelYear=2000,Description="Chevrolet Marka Bir Arabadır."}, 
                new Car{Id=3,BrandId=3,ColorId=2,DailyPrice=1200,ModelYear=2017,Description="Massarati Marka Bir Arabadır."}, 
                new Car{Id=4,BrandId=2,ColorId=4,DailyPrice=1000,ModelYear=2013,Description="Renault Marka Bir Arabadır."}, 
                new Car{Id=5,BrandId=1,ColorId=3,DailyPrice=2500,ModelYear=1990,Description="Ferrari Marka Bir Arabadır."}, 
                new Car{Id=6,BrandId=2,ColorId=1,DailyPrice=5500,ModelYear=2084,Description="Tesla Marka Bir Arabadır."}
            };
        }

        public void Add(Car car)
        {


           
              _cars.Add(car);
            
        }

        public void Delete(Car car)
        {
            Car productToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
 _cars.Remove(productToDelete);
        }

        public List<Car> GetAll()
        {
           return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(p => p.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car productToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            productToUpdate.Id = car.Id;
            productToUpdate.BrandId = car.BrandId;
            productToUpdate.ColorId = car.ColorId;
            productToUpdate.DailyPrice = car.DailyPrice;
            productToUpdate.ModelYear = car.ModelYear;
                productToUpdate.Description = car.Description;
         

        }
    }
}

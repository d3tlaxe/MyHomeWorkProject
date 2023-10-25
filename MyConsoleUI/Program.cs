using MyBusiness.Concrete;
using MyDataAccess.Concrete.EntityFramework;
using MyDataAccess.Concrete.InMemory;
using MyEntities.Concrete;

namespace MyConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            UserManager userManager = new UserManager(new EfUserDal());

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            RentalManager rentalManager = new RentalManager(new EfRentalDal()); 




            User user1 = new User() {Id = 1, FirstName = "Test", LastName = "Test", Email = "Test", Password = "12345"};

            Console.WriteLine(userManager.Add(user1).Message);

            Customer customer1 = new Customer() { UserId = user1.Id, CompanyName = "deneme" };

            Console.WriteLine(customerManager.Add(customer1).Message);


            Console.WriteLine(rentalManager.Add(new Rental() { Id = 1, CarId = 2, CustomerId = 1, RentDate = new DateTime(2023, 10, 25, 11, 0, 0)}).Message);











        }

        private static void CarDetails(CarManager carManager)
        {
            var result = carManager.GetCarDetails();
            foreach (var item in result.Data)
            {
                Console.WriteLine("|   " + item.Id + "   |" + item.BrandName + "   |" + item.ColorName + "   |" + item.ModelYear + "   |" + item.DailyPrice + "   |");
            }
        }
    }
}
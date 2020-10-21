using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            person insan = new person(); // initilalization , insan bir obje
            insan.run();

            CustomService customService = new CustomService();
            customService.Add();
            customService.Update();
            customService.Delete();
            CustomService customService1;

            var ProductService = new ProductService();
            ProductService.Add();
            ProductService.Update();
            ProductService.Delete();
            EmployerService employersService = new EmployerService();
            
            Classes.Students.Student student  = new Classes.Students.Student();
            student.List();

            Customer customer = new Customer();
            customer.Name = "Naci";
            customer.Surname = "Yirik";
            customer.SetAge(28);
            customer.City ="Ankara";
            customer.Id = 1;
            Console.WriteLine("Id: " + customer.Id + "\nName: " + customer.Name + " " + 
                              customer.Surname + "\nAge: " + customer.GetAge() + "\nCity: " + customer.City);









            Console.ReadLine();
        }
    }

    
    class person
    {
        public void run() // behavlor yeni davranış
        {
            Console.Write("Person is running...");
        }

    }

    class CustomService // müşteri ile ilgili yapılacak işlemler
    {
        public void Add()
        {
            Console.WriteLine("Added");
        }

        public void Update()
        {
            Console.Write("Updated");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted");
        }

    }

    class ProductService
    {
        public void Add()
        {
            Console.WriteLine("Added");
        }

        public void Update()
        {
            Console.Write("Updated");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted");
        }

        public void AddUpdateDelete()
        {
            this.Add();
            this.Update();
            this.Delete();
        }
    }
}

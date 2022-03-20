using AutoShop1.Controller;
using AutoShop1.Data.Models;
using AutoShop1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoShop1.Views
{
   public class Display
    {
        CarController carController = new CarController();
        private int closeOperationId;
        ShopController shopController = new ShopController();

        public Display()
    {
        Input();
    }

    private void Add()
    {
        AutoShop autoshop = new AutoShop();
        Console.WriteLine("Enter name: ");
        autoshop.CarName = Console.ReadLine();
        Console.WriteLine("Enter price: ");
        autoshop.CarPrice = Console.ReadLine();
        Console.WriteLine("Enter horsepower: ");
        autoshop.CarPower = Console.ReadLine();
        Console.WriteLine("Enter transmission type: ");
        autoshop.CarTransmission = Console.ReadLine();
        Console.WriteLine("Enter location: ");
        autoshop.CarLocation = Console.ReadLine();
        carController.Add(autoshop);
    }

        private void AddShop()
        {
            Shop shop = new Shop();
            Console.WriteLine("Enter name for shop: ");
            shop.nameShop = Console.ReadLine();
            Console.WriteLine("Enter city for shop: ");
            shop.cityShop = Console.ReadLine();
            shopController.Add(shop);
        }
        private void ListAll()
    {
        Console.WriteLine(new string('-' ,40));
        Console.WriteLine(new string (' ', 16)+"PRODUCTS" +new string (' ', 16));
        Console.WriteLine(new string ('-', 40));
        Console.WriteLine(new string ('-', 40));
        Console.WriteLine(new string('-', 40));
        var autoshop = carController.GetAll();
        foreach (var item in autoshop)
        {
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}",item.IdCar, item.CarLocation, item.CarName, item.CarPrice , item.CarColor , item.CarPower , item.CarTransmission);
        }
            
    }
    
    private void Update()
    {
        Console.WriteLine("Enter ID to update: ");
        int id = int.Parse(Console.ReadLine());
        AutoShop autoshop = carController.Get(id);
        if (autoshop != null)
        {

                Console.WriteLine("Enter name: ");
                autoshop.CarName = Console.ReadLine();
                Console.WriteLine("Enter price: ");
                autoshop.CarPrice = Console.ReadLine();
                Console.WriteLine("Enter horsepower: ");
                autoshop.CarPower = Console.ReadLine();
                Console.WriteLine("Enter transmission type: ");
                autoshop.CarTransmission = Console.ReadLine();
                Console.WriteLine("Enter location: ");
                autoshop.CarLocation = Console.ReadLine();

                carController.Add(autoshop);

            }
        else
        {
            Console.WriteLine("Car not found");
        }
    }
    
    private void Fetch()
    {
        Console.WriteLine("Enter ID to fetch");
        int id = int.Parse(Console.ReadLine());
        AutoShop autoshop = carController.Get(id);
        if (autoshop !=null)
        {
            Console.WriteLine(new string ('-', 40 ));
            Console.WriteLine("ID: " +autoshop.IdCar);
            Console.WriteLine("Name: " + autoshop.CarName);
            Console.WriteLine("Price: " + autoshop.CarPrice);
            Console.WriteLine("Location: " + autoshop.CarLocation);
            Console.WriteLine("Manifacture: " + autoshop.Manifacture);
            Console.WriteLine("Transmission: " + autoshop.CarTransmission);
            Console.WriteLine(new string('-', 40));
        }

    }

    private void Delete()
    {
        Console.WriteLine("Enter ID to delete ");
        int id = int.Parse(Console.ReadLine());
        carController.Delete(id);
        Console.WriteLine("Done.");
    }
    private void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "MENU" + new string(' ', 18));
            Console.WriteLine("1. List all cars");
            Console.WriteLine("2. Add new cars");
            Console.WriteLine("3. Fetch cars by ID");
            Console.WriteLine("4. Delete cars by ID");
            Console.WriteLine("5. Exit");
        }
        private void Input()
        {
            
            var operation = -1;
            do
            {
                ShowMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        ListAll();
                        break;
                    case 2:
                        Add();
                        break;
                    
                    case 3:
                        Fetch();
                        break;
                    case 4:
                        Delete();
                        break;
                    case 5:
                        
                        break;
                    default:
                        break;
                }
            } while (operation != closeOperationId);

      
        }
    }
}
         
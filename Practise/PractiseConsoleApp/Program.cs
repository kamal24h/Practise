
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using static PractiseConsoleApp.Utility;

namespace PractiseConsoleApp
{
    public class Program
    {

        //public List<int> myList = [10, 20, 30];
        //public IReadOnlyList<int> readOnlyList = new(myList); 
               

        public static void Main(string[] args)
        {
            List<string> dinosaurs = ["Tyrannosaurus", "Amargasaurus", "Deinonychus"];
            IReadOnlyList<string> readOnlyDinosaurs = dinosaurs.AsReadOnly();
            ImmutableList<string> immutableList = ["", "", ""];

            for (int i = 0; i < readOnlyDinosaurs.Count; i++)
            {
                Console.WriteLine($" {i + 1} - Dinosaur's Name is {readOnlyDinosaurs[i]}.");
            }


            var employee1 = new Employee(1, "John Doe", "Engineering");
            var employee2 = new Employee(2, "Jane Doe", "Engineering");

            bool areEqual = employee1.Equals(employee2);

            employee2.Deconstruct(out int id1, out string name1, out string major1);

            Console.WriteLine($"Are employee1 and employee2 equal? {areEqual}");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($" The deconstructed record data; Id: {id1}, Name: {name1}, Makor: {major1}");

            var myDictionary = new Dictionary<int, string>
            {
                { 1, "John Doe" },
                { 2, "Jane Doe" }
            };
            Console.WriteLine($"Dictionary's first value is: {myDictionary[1]}");

            _ = myDictionary.TryGetValue(2, out var secondDictionaryValue);
            Console.WriteLine($"Dictionary's second value is: {secondDictionaryValue}");



            // Create currency instances
            Currency usd = new() { Amount = 1000.50m, Symbol = "$" };
            Currency eur = new() { Amount = 750.75m, Symbol = "€" };
            
            // Display currency amounts
            Console.WriteLine("USD: " + usd.Amount + usd.Symbol);
            Console.WriteLine("EUR: " + eur.Amount + eur.Symbol);
            
            // Perform currency conversion
            decimal conversionRate = 0.85m; // 1 USD = 0.85 EUR
            Currency convertedAmount = ConvertCurrency(usd, conversionRate);

            // Display converted currency amount
            Console.WriteLine("Converted Amount With Conversion Rate of 0.85m is: " + convertedAmount.Amount + convertedAmount.Symbol);
            // Keep the console window open
            Console.ReadKey();

            // Create customers
            Customer customer1 = new Customer { CustomerId = 1, Name = "John Doe", ShippingAddress = "123 Main St", Email = "john.doe@example.com", Orders = new List<Order>() };
            Customer customer2 = new Customer { CustomerId = 2, Name = "Jane Smith", ShippingAddress = "456 Elm St", Email = "jane.smith@example.com", Orders = new List<Order>() };
            // Create orders
            Order order1 = new Order(99.99m);
            Order order2 = new Order(149.99m);
            // Place orders
            customer1.PlaceOrder(order1);
            customer2.PlaceOrder(order2);
            // Display customer details and orders
            Console.WriteLine($"Customer: {customer1.Name}, Orders: {customer1.Orders.Count}");
            Console.WriteLine($"Customer: {customer2.Name}, Orders: {customer2.Orders.Count}");
            // Keep the console window open
            Console.ReadKey();
        }
    }
}

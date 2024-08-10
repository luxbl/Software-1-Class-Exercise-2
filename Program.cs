using System;

namespace PetStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var productLogic = new ProductLogic(); // Create an instance of ProductLogic
            string userInput = string.Empty;

            

            while (userInput.ToLower() != "exit")
            {
                Console.WriteLine("Press 1 to add a product");
                Console.WriteLine("Press 2 to view a dog leash by name");
                Console.WriteLine("Type 'exit' to quit");
                userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    var product = new DogLeash();
                    Console.WriteLine("Enter Product Name:");
                    product.Name = Console.ReadLine();

                    Console.WriteLine("Enter Description:");
                    product.Description = Console.ReadLine();

                    Console.WriteLine("Enter Material:");
                    product.Material = Console.ReadLine();

                    productLogic.AddProduct(product); // Add the product
                    Console.WriteLine("Product added successfully.");
                }
                else if (userInput == "2")
                {
                    Console.WriteLine("Enter the name of the Dog Leash:");
                    string name = Console.ReadLine();

                    try
                    {
                        var dogLeash = productLogic.GetDogLeashByName(name);
                        Console.WriteLine($"Dog Leash: {dogLeash.Name}, Material: {dogLeash.Material}");
                    }
                    catch (KeyNotFoundException)
                    {
                        Console.WriteLine("No product found with that name.");
                    }
                }
            }
        }
    }
}

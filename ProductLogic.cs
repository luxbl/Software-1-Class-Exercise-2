using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetStore
{
     class ProductLogic
    {
        private List<Product> _products; // List to store all products
        private Dictionary<string, DogLeash> _dogLeashes; // Dictionary to store DogLeash products
        private Dictionary<string, CatFood> _catFoods; // Dictionary to store CatFood products

        // Constructor
        public ProductLogic()
        {
            _products = new List<Product>(); // Initialize the list
            _dogLeashes = new Dictionary<string, DogLeash>(); // Initialize the DogLeash dictionary
            _catFoods = new Dictionary<string, CatFood>(); // Initialize the CatFood dictionary
        }

        // Method to add a product
        public void AddProduct(Product product)
        {
            _products.Add(product); // Add product to the list

            // Add to respective dictionary based on the product type
            if (product is DogLeash dogLeash)
            {
                _dogLeashes.Add(dogLeash.Name, dogLeash); // Add DogLeash to the dictionary
            }
            else if (product is CatFood catFood)
            {
                _catFoods.Add(catFood.Name, catFood); // Add CatFood to the dictionary
            }
        }

        // Method to get all products
        public List<Product> GetAllProducts()
        {
            return _products;
        }

        // Method to get a DogLeash by its name
        public DogLeash GetDogLeashByName(string name)
        {
            return _dogLeashes[name]; // Return the DogLeash from the dictionary
        }
    }
}
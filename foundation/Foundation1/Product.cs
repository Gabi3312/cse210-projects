using System;
using System.Collections.Generic;

namespace Foundation2
{
    public class Product
    {
        private string name;
        private string productId;
        private decimal price;
        private int quantity;

        public Product(string name, string productId, decimal price, int quantity)
        {
            this.name = name;
            this.productId = productId;
            this.price = price;
            this.quantity = quantity;
        }

        public decimal GetTotalCost()
        {
            return price * quantity;
        }

        public string GetProductDetails()
        {
            return $"{name} (ID: {productId}) - Quantity: {quantity} - Total: ${GetTotalCost()}";
        }
    }

    public class Address
    {
        private string street;
        private string city;
        private string state;
        private string country;

        public Address(string street, string city, string state, string country)
        {
            this.street = street;
            this.city = city;
            this.state = state;
            this.country = country;
        }

        public bool IsInUSA()
        {
            return country.Equals("USA", StringComparison.OrdinalIgnoreCase);
        }

        public string GetFullAddress()
        {
            return $"{street}\n{city}, {state}\n{country}";
        }
    }

    public class Customer
    {
        private string name;
        private Address address;

        public Customer(string name, Address address)
        {
            this.name = name;
            this.address = address;
        }

        public bool IsInUSA()
        {
            return address.IsInUSA();
        }

        public string GetName()
        {
            return name;
        }

        public Address GetAddress()
        {
            return address;
        }
    }

    public class Order
    {
        private List<Product> products;
        private Customer customer;

        public Order(Customer customer)
        {
            this.customer = customer;
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public decimal CalculateTotal()
        {
            decimal totalCost = 0;

            foreach (var product in products)
            {
                totalCost += product.GetTotalCost();
            }

            // Determinar el costo de envío
            decimal shippingCost = customer.IsInUSA() ? 5m : 35m;
            return totalCost + shippingCost;
        }

        public string GetPackingLabel()
        {
            string packingLabel = "Packing Label:\n";
            foreach (var product in products)
            {
                packingLabel += product.GetProductDetails() + "\n";
            }
            return packingLabel;
        }

        public string GetShippingLabel()
        {
            return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear Direcciones (donde vive)
            Address address1 = new Address("123 Main St", "New York", "NY", "USA");
            Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

            // Crear Customers
            Customer customer1 = new Customer("Alice Johnson", address1);
            Customer customer2 = new Customer("Bob Smith", address2);

            // Crear Ordenes 
            Order order1 = new Order(customer1);
            order1.AddProduct(new Product("Laptop", "P001", 999.99m, 1));
            order1.AddProduct(new Product("Mouse", "P002", 25.50m, 2));

            Order order2 = new Order(customer2);
            order2.AddProduct(new Product("Phone", "P003", 499.99m, 1));
            order2.AddProduct(new Product("Headphones", "P004", 89.99m, 1));

            
            Console.WriteLine($"Order 1 Total: ${order1.CalculateTotal()}");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine();

            Console.WriteLine($"Order 2 Total: ${order2.CalculateTotal()}");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
        }
    }
}

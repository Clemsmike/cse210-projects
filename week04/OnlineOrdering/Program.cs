using System;

class Program
{
    static void Main(string[] args)
    {
        // FIRST CUSTOMER: Lives in the USA
        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        // Create products for the first order
        Product product1 = new Product("Laptop", "P001", 850.00, 1);
        Product product2 = new Product("Mouse", "P002", 25.00, 2);
        Product product3 = new Product("Keyboard", "P003", 45.00, 1);

        Order order1 = new Order(customer1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        // SECOND CUSTOMER: Lives outside the USA
        Address address2 = new Address(
            "15 New Market Road",
            "Onitsha",
            "Anambra",
            "Nigeria"
        );

        Customer customer2 = new Customer("Clement Enukaorah", address2);

        // Create products for the second order
        Product product4 = new Product("Smartphone", "P004", 500.00, 1);
        Product product5 = new Product("Headphones", "P005", 60.00, 2);
        Product product6 = new Product("Charger", "P006", 20.00, 3);

        Order order2 = new Order(customer2);

        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        // Display the first order
        Console.WriteLine("==================================");
        Console.WriteLine("ORDER 1");
        Console.WriteLine("==================================");

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");

        // Display the second order
        Console.WriteLine("\n==================================");
        Console.WriteLine("ORDER 2");
        Console.WriteLine("==================================");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}
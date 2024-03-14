namespace inventry_system
{

    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Laptop", 968.00);
            Product product2 = new Product("Smartphone", 475.00);
            Product product3 = new Product("Headphone", 59.00);


            Console.WriteLine("Product1 :");
            Console.WriteLine(product1.Name);
            Console.WriteLine(product1.Price);
            Console.WriteLine("\n");


            Console.WriteLine("Product2 :");
            Console.WriteLine(product2.Name);
            Console.WriteLine(product2.Price);
            Console.WriteLine("\n");


            Console.WriteLine("Product3 :");
            Console.WriteLine(product3.Name);
            Console.WriteLine(product3.Price);

            Console.ReadLine();

        }
    }
}

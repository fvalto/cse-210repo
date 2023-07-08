using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Order order1 = new Order("Fabian Valdés", "18 Norte", "Talca", "Maule", "Chile");
        Product o1product1 = new Product("Computer", 0052, 2500.00, 1);
        order1.AddProductToOrder(o1product1);
        Product o1product2 = new Product("Mouse", 0005, 5.00, 2);
        order1.AddProductToOrder(o1product2);
        Product o1product3 = new Product("Keyboard", 0011, 10.00, 2);
        order1.AddProductToOrder(o1product3);
        orders.Add(order1);

        Order order2 = new Order("Mark Rivers", "W Lucy Ave", "Salt Lake City", "Utah", "USA");
        Product o2product1 = new Product("Laptop", 0100, 3000.00, 1);
        order2.AddProductToOrder(o2product1);
        Product o2product2 = new Product("Laptop bag", 0505, 15.00, 1);
        order2.AddProductToOrder(o2product2);
        Product o2product3 = new Product("Earphone", 0553, 10.00, 3);
        order2.AddProductToOrder(o2product3);
        Product o2product4 = new Product("Cooler pad", 0509, 20.00, 2);
        order2.AddProductToOrder(o2product4);
        orders.Add(order2);

        int orderNumber = 1;
        foreach (Order order in orders)
        {
            Console.WriteLine($"########## ORDER N°{orderNumber} ##########");
            order.Display();
            Console.WriteLine();
            orderNumber++;
        }
    }
}
namespace Part1_ProceduralToOOP;
class Program
{
    static void Main()
    {
        OrderSystem system = new OrderSystem();

        // Sample Data
        system.AddCustomer(new Customer(1, "Mona Ali", "mona@example.com", "Cairo", true));
        system.AddCustomer(new Customer(2, "Omar Hassan", "omar@example.com", "Alexandria", false));
        system.AddCustomer(new Customer(3, "Sara Nabil", "sara@example.com", "Giza", false));

        system.AddProduct(new Product(101, "USB Cable", 50.0, 100));
        system.AddProduct(new Product(102, "Wireless Mouse", 250.0, 40));
        system.AddProduct(new Product(103, "Mechanical Keyboard", 1200.0, 15));
        system.AddProduct(new Product(104, "Laptop Stand", 400.0, 25));

        // Demo Scenario
        system.CreateOrder(1001, 1, "2026-09-15");
        system.AddLineToOrder(1001, 101, 2);
        system.AddLineToOrder(1001, 102, 1);
        system.MarkOrderPaid(1001);

        system.CreateOrder(1002, 2, "2026-09-15");
        system.AddLineToOrder(1002, 103, 1);
        system.AddLineToOrder(1002, 104, 1);

        system.CreateOrder(1003, 3, "2026-09-16");
        system.AddLineToOrder(1003, 101, 5);
        system.MarkOrderPaid(1003);

        // Menu
        int choice = -1;

        while (choice != 0)
        {
            Console.WriteLine("\n---------- MENU ----------");
            Console.WriteLine("1) Print customers");
            Console.WriteLine("2) Print products");
            Console.WriteLine("3) Print all orders");
            Console.WriteLine("4) Print one order by id");
            Console.WriteLine("5) Create order");
            Console.WriteLine("6) Add line to order");
            Console.WriteLine("7) Mark order paid");
            Console.WriteLine("8) Show paid sales total");
            Console.WriteLine("0) Exit");
            Console.Write("Choice: ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                system.PrintCustomers();
            }
            else if (choice == 2)
            {
                system.PrintProducts();
            }
            else if (choice == 3)
            {
                system.PrintAllOrders();
            }
            else if (choice == 4)
            {
                Console.Write("Order id: ");
                int orderId = int.Parse(Console.ReadLine());

                Order order = system.FindOrderById(orderId);

                if (order != null)
                    order.PrintOrder();
            }
            else if (choice == 5)
            {
                Console.Write("Order id: ");
                int orderId = int.Parse(Console.ReadLine());

                Console.Write("Customer id: ");
                int customerId = int.Parse(Console.ReadLine());

                Console.Write("Date (YYYY-MM-DD): ");
                string date = Console.ReadLine();

                system.CreateOrder(orderId, customerId, date);
            }
            else if (choice == 6)
            {
                Console.Write("Order id: ");
                int orderId = int.Parse(Console.ReadLine());

                Console.Write("Product id: ");
                int productId = int.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                system.AddLineToOrder(orderId, productId, quantity);
            }
            else if (choice == 7)
            {
                Console.Write("Order id: ");
                int orderId = int.Parse(Console.ReadLine());

                system.MarkOrderPaid(orderId);
            }
            else if (choice == 8)
            {
                Console.WriteLine(
                    $"Paid sales total: {system.TotalSalesPaidOnly():F2}");
            }
            else if (choice == 0)
            {
                Console.WriteLine("Bye.");
            }
            else
            {
                Console.WriteLine("Unknown choice.");
            }
        }
    }
}
namespace Part1_ProceduralToOOP;

public class OrderSystem
{
    private List<Customer> customers = new List<Customer>();
    private List<Product> products = new List<Product>();
    private List<Order> orders = new List<Order>();

    public void AddCustomer(Customer customer)
    {
        foreach (Customer c in customers)
        {
            if (c.Id == customer.Id)
                return;
        }

        customers.Add(customer);
    }

    public Customer FindCustomerById(int id)
    {
        foreach (Customer customer in customers)
        {
            if (customer.Id == id)
                return customer;
        }

        return null;
    }

    public void AddProduct(Product product)
    {
        foreach (Product p in products)
        {
            if (p.Id == product.Id)
                return;
        }

        products.Add(product);
    }

    public Product FindProductById(int id)
    {
        foreach (Product product in products)
        {
            if (product.Id == id)
                return product;
        }

        return null;
    }

    public void CreateOrder(int orderId, int customerId, string date)
    {
        foreach (Order order in orders)
        {
            if (order.Id == orderId)
                return;
        }

        Customer customer = FindCustomerById(customerId);

        if (customer == null)
            return;

        Order newOrder = new Order(orderId, customer, date);

        orders.Add(newOrder);
    }

    public Order FindOrderById(int id)
    {
        foreach (Order order in orders)
        {
            if (order.Id == id)
                return order;
        }

        return null;
    }

    public void AddLineToOrder(int orderId, int productId, int quantity)
    {
        Order order = FindOrderById(orderId);

        if (order == null)
            return;

        Product product = FindProductById(productId);

        if (product == null)
            return;

        order.AddLine(product, quantity);
    }

    public void PrintCustomers()
    {
        foreach (Customer customer in customers)
        {
            Console.WriteLine(
                $"ID: {customer.Id}, Name: {customer.Name}, Email: {customer.Email}, City: {customer.City}, VIP: {customer.IsVip}");
        }
    }

    public void PrintProducts()
    {
        foreach (Product product in products)
        {
            Console.WriteLine(
                $"ID: {product.Id}, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
        }
    }

    public void PrintAllOrders()
    {
        foreach (Order order in orders)
        {
            order.PrintOrder();
            Console.WriteLine();
        }
    }
    
    public void MarkOrderPaid(int orderId)
    {
        Order order = FindOrderById(orderId);
    
        if (order == null)
            return;
    
        order.MarkOrderPaid();
    }
    
    public double TotalSalesPaidOnly()
    {
        double total = 0;
    
        foreach (Order order in orders)
        {
            if (order.IsPaid)
                total += order.CalculateTotal();
        }
    
        return total;
    }
    
   
}
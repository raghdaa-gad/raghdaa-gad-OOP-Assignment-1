namespace Part1_ProceduralToOOP;

public class Order
{
    public int Id { get; set; }
    public Customer Customer { get; set; }
    public string Date { get; set; }
    public bool IsPaid { get; set; }

    public List<OrderLine> OrderLines { get; set; }

    public Order(int id, Customer customer, string date)
    {
        Id = id;
        Customer = customer;
        Date = date;
        IsPaid = false;
        OrderLines = new List<OrderLine>();
    }

    public void AddLine(Product product, int quantity)
    {
        if (IsPaid)
            return;

        if (!product.HasEnoughStock(quantity))
            return;

        product.ReduceStock(quantity);
        OrderLines.Add(new OrderLine(product, quantity));
    }

    public double CalculateTotal()
    {
        double total = 0;

        foreach (OrderLine line in OrderLines)
        {
            total += line.CalculateTotal();
        }

        if (Customer.IsVip)
        {
            total *= 0.9;
        }

        return total;
    }

    public void MarkOrderPaid()
    {
        if (OrderLines.Count == 0)
            return;

        IsPaid = true;
    }
    
    public void PrintOrder()
    {
        Console.WriteLine($"Order ID: {Id}");
        Console.WriteLine($"Customer: {Customer.Name}");
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Paid: {IsPaid}");
    
        foreach (OrderLine line in OrderLines)
        {
            Console.WriteLine(
                $"{line.Product.Name} x {line.Quantity} = {line.CalculateTotal()}");
        }
    
        Console.WriteLine($"Total: {CalculateTotal()}");
    }
}
namespace Part3_BuilderPattern;

public class Program
{
    public static void Main()
    {
        var billingAddress = new AddressBuilder()
            .WithStreet("Main Street")
            .WithCity("Zagazig")
            .WithState("Sharqia")
            .WithZipCode("44511")
            .WithCountry("Egypt");

        var shippingAddress = new AddressBuilder()
            .WithStreet("Another Street")
            .WithCity("Zagazig")
            .WithState("Sharqia")
            .WithZipCode("44512")
            .WithCountry("Egypt");

        var order = new OrderBuilder()
            .WithOrderDate(DateTime.Now)
            .WithPayment("Visa", "EGP")
            .WithSubTotal(1000)
            .WithDiscount(100)
            .WithTax(50)
            .WithTotalAmount(950);

        var invoice = new InvoiceBuilder()
            .WithInvoiceId(1001)
            .WithCustomer(
                "Raghda Gad",
                "raghda@example.com",
                "01111111111")
            .WithBillingAddress(billingAddress)
            .WithShippingAddress(shippingAddress)
            .WithOrder(order)
            .Build();

        Console.WriteLine($"Invoice ID: {invoice.InvoiceId}");
        Console.WriteLine($"Customer: {invoice.CustomerName}");
        Console.WriteLine($"Billing City: {invoice.BillingAddress.City}");
        Console.WriteLine($"Payment: {invoice.Order.PaymentMethod}");
        Console.WriteLine($"Total: {invoice.Order.TotalAmount}");
    }
}
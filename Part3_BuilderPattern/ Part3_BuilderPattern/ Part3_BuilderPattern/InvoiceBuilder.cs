namespace Part3_BuilderPattern;

public class InvoiceBuilder
{
    private int _invoiceId;

    private string? _customerName;
    private string? _customerEmail;
    private string? _customerPhone;

    private Address? _billingAddress;
    private Address? _shippingAddress;

    private Order? _order;

    public InvoiceBuilder WithInvoiceId(int invoiceId)
    {
        _invoiceId = invoiceId;
        return this;
    }

    public InvoiceBuilder WithCustomer(
        string customerName,
        string customerEmail,
        string? customerPhone = null)
    {
        _customerName = customerName;
        _customerEmail = customerEmail;
        _customerPhone = customerPhone;

        return this;
    }

    public InvoiceBuilder WithBillingAddress(AddressBuilder addressBuilder)
    {
        _billingAddress = addressBuilder.Build();
        return this;
    }

    public InvoiceBuilder WithShippingAddress(AddressBuilder addressBuilder)
    {
        _shippingAddress = addressBuilder.Build();
        return this;
    }

    public InvoiceBuilder WithOrder(OrderBuilder orderBuilder)
    {
        _order = orderBuilder.Build();
        return this;
    }

    public Invoice Build()
    {
        if (_invoiceId <= 0)
            throw new InvalidOperationException("Invoice ID is required.");
        
        if (string.IsNullOrWhiteSpace(_customerName))
            throw new InvalidOperationException("Customer name is required.");

        if (string.IsNullOrWhiteSpace(_customerEmail))
            throw new InvalidOperationException("Customer email is required.");

        if (_billingAddress is null)
            throw new InvalidOperationException("Billing address is required.");

        if (_order is null)
            throw new InvalidOperationException("Order is required.");

        return new Invoice(
            _invoiceId,
            _customerName,
            _customerEmail,
            _customerPhone,
            _billingAddress,
            _shippingAddress,
            _order);
    }
}
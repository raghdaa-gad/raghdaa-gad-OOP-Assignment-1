namespace Part3_BuilderPattern;

public class OrderBuilder
{
    private DateTime? _orderDate;
    private string? _paymentMethod;
    private string? _currency;
    private decimal? _subTotal;
    private decimal? _discountAmount;
    private decimal? _taxAmount;
    private decimal? _totalAmount;

    public OrderBuilder WithOrderDate(DateTime orderDate)
    {
        _orderDate = orderDate;
        return this;
    }

    public OrderBuilder WithPayment(
        string paymentMethod,
        string currency)
    {
        _paymentMethod = paymentMethod;
        _currency = currency;
        return this;
    }

    public OrderBuilder WithSubTotal(decimal subTotal)
    {
        _subTotal = subTotal;
        return this;
    }

    public OrderBuilder WithDiscount(decimal discountAmount)
    {
        _discountAmount = discountAmount;
        return this;
    }

    public OrderBuilder WithTax(decimal taxAmount)
    {
        _taxAmount = taxAmount;
        return this;
    }

    public OrderBuilder WithTotalAmount(decimal totalAmount)
    {
        _totalAmount = totalAmount;
        return this;
    }

    public Order Build()
    {
        if (_orderDate is null)
            throw new InvalidOperationException("Order date is required.");

        if (string.IsNullOrWhiteSpace(_paymentMethod))
            throw new InvalidOperationException("Payment method is required.");

        if (string.IsNullOrWhiteSpace(_currency))
            throw new InvalidOperationException("Currency is required.");

        if (_subTotal is null)
            throw new InvalidOperationException("Subtotal is required.");

        if (_totalAmount is null)
            throw new InvalidOperationException("Total amount is required.");

        return new Order(
            _orderDate.Value,
            _paymentMethod,
            _currency,
            _subTotal.Value,
            _discountAmount,
            _taxAmount,
            _totalAmount.Value);
    }
}
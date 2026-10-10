namespace Part2_HotelReservationSystem;

public class Guest
{
    public int GuestId { get; }
    public string FullName { get; }
    public string PhoneNumber { get; }

    private List<Reservation> _reservations = new();
    public IReadOnlyList<Reservation> Reservations => _reservations;

    public Guest(int guestId, string fullName, string phoneNumber)
    {
        if (string.IsNullOrWhiteSpace(fullName))
            throw new ArgumentException("full name can not be empty");
        if (string.IsNullOrWhiteSpace(phoneNumber))
            throw new ArgumentException("phone number can not be empty");
        GuestId = guestId;
        FullName = fullName;
        PhoneNumber = phoneNumber;
    }

    public void AddReservation(Reservation reservation)
    {
        _reservations.Add(reservation);
    }

}
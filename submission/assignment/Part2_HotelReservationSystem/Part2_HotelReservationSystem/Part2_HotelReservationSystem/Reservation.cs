namespace Part2_HotelReservationSystem;

public class Reservation
{
    public int ReservationId { get; }
    public DateTime CheckInDate { get; }
    public DateTime CheckOutDate { get; }
    public Room Room { get; }
    public ReservationStatus Status { get; private set; }
}
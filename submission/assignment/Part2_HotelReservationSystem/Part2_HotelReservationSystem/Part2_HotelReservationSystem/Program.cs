namespace Part2_HotelReservationSystem;

class Program
{
    static void Main()
    {
        // Create Room
        var room = new Room(101, RoomType.Double, 1000);

        Console.WriteLine($"Room: {room.RoomNumber}");
        Console.WriteLine($"Type: {room.RoomType}");
        Console.WriteLine($"Nightly Rate: {room.NightlyRate}");

        // Create Guest
        var guest = new Guest(1, "Raghda Gad", "01000000000");

        // Create Reservation
        var reservation = new Reservation(
            1,
            new DateTime(2026, 10, 10),
            new DateTime(2026, 10, 13),
            room);

        guest.AddReservation(reservation);

        Console.WriteLine($"\nReservation Status: {reservation.Status}");
        Console.WriteLine($"Total Cost: {reservation.TotalCost}");

        // Status transitions
        reservation.Confirm();
        Console.WriteLine($"After Confirm: {reservation.Status}");

        reservation.CheckIn();
        Console.WriteLine($"After Check-In: {reservation.Status}");

        reservation.CheckOut();
        Console.WriteLine($"After Check-Out: {reservation.Status}");

        // Maintenance
        room.StartMaintenance();
        Console.WriteLine($"\nUnder Maintenance: {room.IsUnderMaintenance}");

        room.EndMaintenance();
        Console.WriteLine($"Under Maintenance: {room.IsUnderMaintenance}");

        // Change price
        room.ChangePrice(1200);
        Console.WriteLine($"New Nightly Rate: {room.NightlyRate}");
    }
}
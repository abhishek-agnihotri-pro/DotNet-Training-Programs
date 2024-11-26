namespace WebAPI_Flight.Model
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string? Start { get; set; }
        public string? Destination { get; set; }
        public string? Start_time { get; set; }
        public string? Destination_time { get; set; }
    }
}
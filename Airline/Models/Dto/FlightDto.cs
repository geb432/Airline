namespace Airline.Models.Dto
{
    public class FlightDto
    {

        public int FlightId { get; set; }
        public string FlightNo { get; set; }
        public string Date { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public decimal Price { get; set; }
        public int AvailableSeats { get; set; }
    }
}

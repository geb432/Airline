namespace Airline.Models.Dto
{
    public class QueryWithPagingDto
    {
        const int maxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        private int _pageSize = 10;
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value > maxPageSize) ? maxPageSize : value;
            }
        }
    }

    public class BookingDto
    {
        public int BookingId { get; set; }
        public int FlightId { get; set; }
        public string FullName { get; set; }

    }

    public class TicketQueryResultDto 
    {
        public DateTime date { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int AvailableSeats { get; set; }


    }

    public class TicketBuyResultDto : APIResultDto
    {
        public DateTime date { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int PassengerName { get; set; }

    }

    public class APIResultDto
    {
        public APIResultDto()
        {
            Status = "SUCCESS";
        }
        public string Status { get; set; }

    }

}

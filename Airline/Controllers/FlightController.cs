using Airline.Models;
using Airline.Models.Dto;
using Airline.Source.Svc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Airline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private IFlightService _flightService;

        public FlightController(IFlightService courseService)
        {
            _flightService = courseService;
        }

        private FlightDto createDto(Flight flight)
        {
            FlightDto dto = new FlightDto()
            {
                FlightId = flight.FlightId,
                FlightNo = flight.FlightNo,
                Date = flight.Date,
                From = flight.From,
                To = flight.To,
                Price = flight.Price,
                AvailableSeats = flight.AvailableSeats

            };
            return dto;
        }


        // GET: api/<FlightController>
        [HttpGet]
        public IEnumerable<FlightDto> Get()
        {
            List<Flight> datas = _flightService.getFlights();
            List<FlightDto> ret = new List<FlightDto>();
            datas.ForEach(data => ret.Add(createDto(data)));
            return ret;
        }

        // GET api/<FlightController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            Flight data = _flightService.getFlightById(id);
            return createDto(data);
        }


        // POST api/<FlightController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            BookingResultDto ret = new BookingResultDto();
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            try
            {
                _flightService.insertFlight(createFlight(flightDto));

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            return Ok();
        }

        // PUT api/<FlightController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FlightController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }



        [HttpPost]
        public IEnumerable<Flight> GetFlights(DateTime date, string from, string to, int passengers)
        {
            return Flight
                .Where(f => f.Date == date && f.From == from && f.To == to && f.AvailableSeats >= passengers)
                .OrderBy(f => f.Price)
                .ToList();
        }
        public IFlightService GetFlights(DateTime date, string from, string to, int passengers, int page = 1, int pageSize = 10)
        {
            var flights = db.Flights
                .Where(f => f.Date == date && f.From == from && f.To == to && f.AvailableSeats >= passengers)
                .OrderBy(f => f.Price)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            var totalCount = db.Flights
                .Count(f => f.Date == date && f.From == from && f.To == to && f.AvailableSeats >= passengers);

            var response = new
            {
                flights = flights,
                totalCount = totalCount,
                currentPage = page,
                pageSize = pageSize
            };

            return Ok(response);
        }
    }
}

using Airline.Models;
using Airline.Model;
using Airline.Models.Dto;
using Airline.Source.Svc;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Airline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        // GET: api/<BookingController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            List<Booking> datas = BookingService.getFlights();
            List<BookingDto> ret = new List<BookingDto>();
            datas.ForEach(data => ret.Add(createDto(data)));
            return ret;
        }

        // GET api/<BookingController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            Booking data = _courseService.getCourseById(id);
            return createDto(data);
        }

        // POST api/<BookingController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BookingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BookingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

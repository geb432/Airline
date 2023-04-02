using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System.Collections.Generic;
using System;
using Airline.Model;
using Airline.Source.Db;
using System.Threading.Tasks;
using Airline.Models;

namespace Airline.Source.Svc
{
    public interface IFlightService
    {
        public List<Flight> getFlights();
        public Flight getFlightById(int Id);
        public List<Flight> searchFlight(Flight flight);
    }
}
using Microsoft.Extensions.Caching.Memory;
using System.Collections.Generic;
using Airline.Context;
using Airline.Model;
using Airline.Source.Db;
using Airline.Models;

namespace Airline.Source.Svc
{
    public class FlightService
    {
        public Flight getFlightById(int id)
        {
            return new FlightAccess().getFlightById(id);
        }

        public List<Flight> getFlights()
        {
            return new FlightAccess().getFlights();
        }

        public void insertFlight(Flight flight)
        {
            new FlightAccess().insertFlight(flight);
        }

        public List<Flight> getFlights(string flightno)
        {
            List<Flight> Flights = new FlightAccess().getFlights();
            return Flights.FindAll(c => c.FlightNo.Equals(flightno));
        }

        public void updateFlight(Flight flight)
        {
            new FlightAccess().updateFlight(flight);
        }

        public List<Flight> searchFlight(Flight flightSearch)
        {
            return new FlightAccess().searchFlight(flightSearch);
        }
    }
}


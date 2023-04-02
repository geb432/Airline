using Airline.Models;
using System;
using System.Collections.Generic;
using Airline.Model;
using Microsoft.EntityFrameworkCore;

namespace Airline.Source.Db
{
    public class FlightAccess
    {
        private static List<Flight> sample = new List<Flight>(new Flight[]
        {
            new Flight() { FlightId = 12345, FlightNo = "A1010", Date="12-05-2023", From = "Istanbul", To="Izmir",Price=230, AvailableSeats=20 },
            new Flight() { FlightId = 12344, FlightNo = "A1015", Date="12-05-2023", From = "Istanbul", To="Ankara",Price=240, AvailableSeats=5 },
            new Flight() { FlightId = 12343, FlightNo = "A1013", Date="12-05-2023", From = "Istanbul", To="Erzurum",Price=220, AvailableSeats=25 },
            new Flight() { FlightId = 12342, FlightNo = "A1018", Date="12/05/2023", From = "Izmir", To="Ankara", Price=280, AvailableSeats=10 }
        });

        public List<Flight> getFlights()
        {
            return sample;
        }

        public Flight getFlightById(int id)
        {
            return sample.Find(c => c.FlightId == id);
        }

        public void insertFlight(Flight flight)
        {
            validateFlight(flight);
            sample.Add(flight);
        }

        public int deleteFlight(int id)
        {
            return sample.RemoveAll(c => c.FlightId == id);
        }

        public void updateFlight(Flight flight)
        {
            validateFlight(flight);
            Flight flightEx = getFlightById(flight.FlightId);
            if (flightEx != null)
            {
                flightEx.FlightNo = flight.FlightNo;
                flightEx.FlightId = flight.FlightId;
                flightEx.Date = flight.Date;
                flightEx.From = flight.From;
                flightEx.To = flightEx.To;
                flightEx.Price = flight.Price;
                flightEx.AvailableSeats = flight.AvailableSeats;
            }
        }

        public List<Flight> searchFlight(Flight flight)
        {
            List<Flight> ret = getFlights().FindAll(c => c.FlightNo.StartsWith(flight.FlightNo));

            return ret;
        }


        private void validateFlight(Flight flight)
        {
            if (flight.FlightId == null)
            {
                throw new Exception("Flight code cannot be empty");
            }

        }

        public IEnumerable<Flight> getAllFlights()
        {
            return sample;
        }

    }
}

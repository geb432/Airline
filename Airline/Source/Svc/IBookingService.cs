using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System.Collections.Generic;
using System;
using Airline.Model;
using Airline.Source.Db;
using System.Threading.Tasks;
using Airline.Models;

namespace  Airline.Source.Svc

{
    public interface IBookingService
        {
            public List<Booking> getBookings();
            public List<Booking> getBookingWithCache();
            public Booking requestBookingsById(string Bookingid);
            public Booking createBooking(Booking booking);

        }
    }
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Airline.Models
{
    public class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [MaxLength(5), MinLength(5)]
        public int BookingId { get; set; }
        [Required]
        [MaxLength(5), MinLength(5)]
        public int FlightId { get; set; }
        [Required]
        [StringLength(20)]
        public string PassengerName { get; set; }
        [Required]
        [StringLength(20)]
        public String BookingStatuss { get; set; }
    }
}

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
    [Table("Flight")]
    [Index(nameof(FlightNo), IsUnique = true)]
    public class Flight
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        [Required]
        [MaxLength(5), MinLength(5)]
        public int FlightId { get; set; }
         [Required]
        [StringLength(5)]
        public string FlightNo { get; set; }
        [Required]
        [StringLength(20)]
        public string Date { get; set; }
        [Required]
        [StringLength(20)]
        public string From { get; set; }
        [Required]
        [StringLength(20)]
        public string To { get; set; }
        [Required]
        [MaxLength(4), MinLength(4)]
        public decimal Price { get; set; }
        [Required]
        [MaxLength(30), MinLength(30)]
        public int AvailableSeats { get; set; }

    }
}

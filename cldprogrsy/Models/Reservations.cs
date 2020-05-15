using System.ComponentModel.DataAnnotations;
using System.Globalization;
namespace cldprogrsy.Models
{
    public class Reservations
    {
        public int ReservationId { get; set; }
        public int NumberOfPeople { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }
    }
}
using System;
namespace HairSalon.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        public int StylistId { get; set; }
        public virtual Stylist Stylist { get; set; }
        public DateTime DateTime { get; set; }
    }
}
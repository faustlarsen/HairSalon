using System;

namespace HairSalon.Models

{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        // public DateTime Appointment { get; set; }
        // public int Time { get; set; }
        public int StylistId { get; set; }
        public virtual Stylist Stylist { get; set; }
    }
}
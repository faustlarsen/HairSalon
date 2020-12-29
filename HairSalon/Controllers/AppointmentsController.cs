using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HairSalon.Controllers
{
    public class AppointmentsController : Controller
    {
        private readonly HairSalonContext _db;
        public AppointmentsController(HairSalonContext db) => _db = db;

        public ActionResult Index(int id)
        {
            List<Appointment> model = _db.Appointments.Include(clients => clients.Stylist).Include(clients => clients.Client).ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            ViewBag.StylistList = new SelectList(_db.Stylists, "StylistId", "Name");
            ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
            ViewBag.ClientList = new SelectList(_db.Clients, "ClientId", "Name");
            ViewBag.ClientId = new SelectList(_db.Clients, "ClientId", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Appointment newAppointment)
        {
            _db.Appointments.Add(newAppointment);
            _db.SaveChanges();
            return RedirectToAction("Index", new {id = newAppointment.StylistId});
        }

        public ActionResult Details(int id)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Appointment thisAppointment = _db.Appointments.FirstOrDefault(appointment => appointment.AppointmentId == id);
            var stylistClients = _db.Clients.Where(clients => clients.StylistId == id).ToList();
            model.Add("appointment", thisAppointment);
            return View(model);
        }

        public ActionResult DeleteAll()
        {
            var allAppointments = _db.Appointments.ToList();
            return View();
        }

        [HttpPost, ActionName("DeleteAll")]
            public ActionResult DeleteAllConfirmed()
        {
            var allAppointments = _db.Appointments.ToList();

        foreach (var appointment in allAppointments)
        {
            _db.Appointments.Remove(appointment);
        }
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
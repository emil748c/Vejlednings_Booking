using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vejledningsbooking.Models
{
    public class VejledningsBookingDataContext : DbContext
    {
        public VejledningsBookingDataContext(DbContextOptions<VejledningsBookingDataContext> options)
                                                : base(options)
        {

        }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<Hold> Holds { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherCalendar> TeacherCalendars { get; set; }
        public DbSet<Timeslot> Timeslots { get; set; }
        public DbSet<StudentHold> StudentHolds { get; set; }
    }
}

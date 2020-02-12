using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vejledningsbooking.Models
{
    public class Student
    {
        public Guid StudentId { get; set; }
        public string StudentName { get; set; }
        public List<Booking> Bookings { get; set; }
        public List<StudentHold> StudentHolds { get; set; }


        public Student(string studentName)
        {
            StudentName = studentName;
            Bookings = new List<Booking>();
        }
        public void CreateBooking(Booking booking, Timeslot timeslot)
        {
            if(Bookings.Count < 2)
            {
                bool bookingOccupied = false;
                foreach (var bk in timeslot.Bookings)
                {
                    
                    bool StudentOccupiedBooking = (booking.BookingStartDateTime <= bk.BookingEndDateTime) && (booking.BookingEndDateTime >= bk.BookingStartDateTime);
                    if (StudentOccupiedBooking == true)
                    {
                        bookingOccupied = true;
                        break;
                    }
                }

                if (!bookingOccupied == true)
                {
                    Bookings.Add(booking);
                }

            }
        }

    }
}

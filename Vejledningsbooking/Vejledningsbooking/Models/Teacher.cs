using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vejledningsbooking.Models
{
    public class Teacher
    {
        public Guid TeacherId { get; set; }
        public string TeacherName { get; set; }
        public List<Timeslot> Timeslots { get; set; }
        public List<TeacherCalendar> TeacherCalendars { get; set; }
        public List<Hold> Holds { get; set; }

        public Teacher(string teacherName)
        {
            TeacherName = teacherName;
            Timeslots = new List<Timeslot>();
            TeacherCalendars = new List<TeacherCalendar>();
        }

        public void CreateCalendar(Calendar calendar)
        {
            var TeacherCalendar = new TeacherCalendar { Calendar = calendar, Teacher = this };
            TeacherCalendars.Add(TeacherCalendar);
            calendar.TeacherCalendars.Add(TeacherCalendar);
        }
        public void CreateTimeslot(Timeslot timeslot, Calendar calendar)
        {
            bool teacherOccupied = false;
            foreach (var ts in   Timeslots)
            {
                bool teacherOccupiedTimeslot = (timeslot.TimeslotStartDateTime <= ts.TimeslotEndDateTime) && (timeslot.TimeslotEndDateTime >= ts.TimeslotStartDateTime); 
                if(teacherOccupiedTimeslot == true)
                {
                    teacherOccupied = true;
                    break;
                }
            }
            if(!teacherOccupied == true)
            {
                calendar.Timeslots.Add(timeslot);
                Timeslots.Add(timeslot);
            }
            
        }

    }
}

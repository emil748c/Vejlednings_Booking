using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vejledningsbooking.Models
{
    public class TeacherCalendar
    {
        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public Guid CalendarId { get; set; }
        public Calendar Calendar { get; set; }
    }
}

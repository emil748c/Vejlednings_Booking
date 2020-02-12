using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vejledningsbooking.Models
{
    public class StudentHold
    {
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
        public Guid HoldId { get; set; }
        public Hold Hold { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models.Date
{
    public class TaskS
    {
        public int Id { get; set; }
        public string Summary { get; set; }
        public bool Status { get; set; }
        public int DayId { get; set; }
        public Day Day { get; set; }


    }
}

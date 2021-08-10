using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models.Date
{
    public class Day
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int MounthId { get; set; }
        public Month Month { get; set; }
        public List<TaskS> Tasks { get; set; }


    }
}

using System.Collections.Generic;

namespace ToDoList.Models.Date
{
    public class Month
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public List<Day> Days { get; set; }
    }
}

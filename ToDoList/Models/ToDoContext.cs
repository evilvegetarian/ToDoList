﻿using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext( DbContextOptions options) : base(options)
        {
        }
    }
}

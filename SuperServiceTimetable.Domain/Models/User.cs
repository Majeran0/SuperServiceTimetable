using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperServiceTimetable.Domain.Models
{
    public sealed class User
    {
        public User() { }

        public User(int id, string username)
        {
            Id = id;
            Username = username;
        }
        public int Id { get; init; }
        public string Username { get; init; }
    }
}

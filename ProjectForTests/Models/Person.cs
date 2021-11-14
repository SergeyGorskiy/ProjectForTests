using System;

namespace ProjectForTests.Models
{
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Gender { get; set; }

        public bool IsMember { get; set; }

        public int Age { get; set; }

        public int Weight { get; set; }

        public Country Country { get; set; }

        public DateTime MemberFromDate { get; set; }

    }
}
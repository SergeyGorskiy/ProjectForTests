using System;
using System.Collections.Generic;

namespace ProjectForTests.Models
{
    public class People
    {
        public static List<Person> GetPeople()
        {
            return new List<Person>
            {
                new Person
                {
                    Id = 1,
                    MemberFromDate = new DateTime(2001, 12, 1),
                    Country = Country.Ukraine,
                    IsMember = true,
                    Name = "Tom",
                    Description = "Cook",
                    Age = 44,
                    Weight = 224,
                    Gender = "M"
                },
                new Person
                {
                    Id = 36,
                    MemberFromDate = new DateTime(1988, 2, 12),
                    Country = Country.Russia,
                    IsMember = true,
                    Name = "Олеся",
                    Description = "Инженер",
                    Age = 38,
                    Weight = 75,
                    Gender = "F"
                },
                
                // Omitted for brevity ...
                //...more than 30 items 
            };
        }

        public static List<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Salary = 1000,
                    DepartmentId = 1,
                    Country = Country.Germany,
                    IsMember = false,
                    Name = "Bob",
                    Description = "Student",
                    Age = 13,
                    Weight = 114,
                    Gender = "M"
                },
                new Employee
                {
                    Salary = 2220,
                    DepartmentId = 2,
                    Country = Country.Germany,
                    IsMember = false,
                    Name = "Robert",
                    Description = "Student",
                    Age = 12,
                    Weight = 99,
                    Gender = "M"
                },
               
               // Omitted for brevity
               // ... more than 10 item ...
            };
        }

        public static List<Department> GetDepartments()
        {
            return new List<Department>
            {
                new Department {
                            Id = 1,
                            Name = "Global",
                            Description = "Simple description number one"
                        },
                new Department {
                            Id = 2,
                            Name = "Entertaiment",
                            Description = "Simple description number two"
                        },
                new Department {
                            Id = 3,
                            Name = "Office",
                            Description = "Simple description number one"
                        }
            };
        }
    }
}
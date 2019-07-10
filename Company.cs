using System;
using System.Collections.Generic;

namespace Job
{
    public class Company
    {
        public DateTime dateFounded { get; set; }
        public string companyName { get; set; }
        public List<Employee> employees { get; set; } = new List<Employee>();

        public Company(string name)
        {
            companyName = name;
            dateFounded = DateTime.Now;
        }

        public void HireEmployee(Employee name, string title)
        {
            employees.Add(name);
            name.startDate = DateTime.Now;
            name.title = title;
        }

        public void ListEmployees()
        {
            foreach (Employee person in employees)
            {
                System.Console.WriteLine($"{person.firstName} {person.lastName} works for {companyName} as a {person.title} since {person.startDate}");
            }
        }
    }
}
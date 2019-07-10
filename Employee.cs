using System;

namespace Job
{
    public class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public string title { get; set; }
        public DateTime startDate { get; set; }

        public Employee(string nameFirst, string nameLast)
        {
            firstName = nameFirst;
            lastName = nameLast;
        }

        public void Hired()
        {
            startDate = DateTime.Now;
        }
    }
}
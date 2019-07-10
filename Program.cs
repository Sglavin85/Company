using System;

namespace Job
{
    class Program
    {
        static void Main(string[] args)
        {
            var BestBuy = new Company("Best Buy");

            var Sean = new Employee("Sean", "Glavin");
            var Joey = new Employee("Joey", "Driscol");
            var Dan = new Employee("Dan", "Storm");
            var Deep = new Employee("Deep", "Patel");

            BestBuy.HireEmployee(Sean, "CEO");
            BestBuy.HireEmployee(Joey, "CTO");
            BestBuy.HireEmployee(Dan, "CFO");
            BestBuy.HireEmployee(Deep, "COO");

            BestBuy.ListEmployees();
        }
    }
}

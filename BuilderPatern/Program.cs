using System;
using System.Collections.Generic;

namespace BuilderPatern
{
    class Program
    {
        static void Main(string[] args)
        {
            BurgerBuilder burgerBuilder = new BurgerBuilder();
            Burger burger = burgerBuilder.WithBacon().WithCheese().WithPatties(2).Build();
            Burger burger1 = burgerBuilder.WithBacon().Build();

            var builder = new EmployeeInfoBuilder();

            builder.SetName("").Build();
        }
    }

    public class Burger
    {
        public int NumPatties { get; set; }
        public bool Cheese { get; set; }
        public bool Bacon { get; set; }
        public bool Pickles { get; set; }
        public bool Letuce { get; set; }
        public bool Tomato { get; set; }
        public Burger(int numPatties = 1)
        {
            NumPatties = numPatties;
        }
      
    }
    public class BurgerBuilder
    {
        private Burger _burger = new Burger();
        public Burger Build() => _burger;
        public BurgerBuilder WithPatties(int num)
        {
            _burger.NumPatties = num;
            return this;
        }
        public BurgerBuilder WithCheese()
        {
            _burger.Cheese = true;
            return this;
        }
        public BurgerBuilder WithBacon()
        {
            _burger.Bacon = true;
            return this;
        }
       
}

    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}, Position: {Position}, Salary: {Salary}";
        }
    }

    public class EmployeeInfoBuilder
    {
        private Employee employee = new Employee();
        public Employee Build() => employee;
        public EmployeeInfoBuilder SetName(string name)
        {
            employee.Name = name;
            return this;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    public class Bakery
    {
        private readonly List<Employee> data;

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return this.data.Count; } }

        public Bakery(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.data = new List<Employee>();
        }

        public void Add(Employee employee)
        {
            if (this.Count < this.Capacity)
                this.data.Add(employee);
        }

        public bool Remove(string name)
            => this.data.Remove(this.data.Find(e => e.Name == name));

        public Employee GetOldestEmployee()
            => this.data.OrderByDescending(e => e.Age).First();

        public Employee GetEmployee(string name)
            => this.data.Find(e => e.Name == name);

        public string Report()
            => $"Employees working at Bakery {this.Name}:" +
               Environment.NewLine +
               string.Join(Environment.NewLine, this.data);
    }
}

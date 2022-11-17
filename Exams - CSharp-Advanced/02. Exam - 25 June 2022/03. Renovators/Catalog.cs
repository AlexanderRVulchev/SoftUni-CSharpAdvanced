using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        public List<Renovator> Renovators { get; set; }
        public string Name { get; set; }
        public int NeededRenovators { get; set; }
        public string Project { get; set; }
        public int Count { get { return this.Renovators.Count; } }

        public Catalog(string name, int neededRenovators, string project)
        {
            this.Name = name;
            this.NeededRenovators = neededRenovators;
            this.Project = project;
            this.Renovators = new List<Renovator>();
        }

        public string AddRenovator(Renovator renovator)
        {
            if (string.IsNullOrEmpty(renovator.Name) || string.IsNullOrEmpty(renovator.Type))
                return "Invalid renovator's information.";
            if (this.Count >= this.NeededRenovators)
                return "Renovators are no more needed.";
            if (renovator.Rate > 350)
                return "Invalid renovator's rate.";
            this.Renovators.Add(renovator);
            return $"Successfully added {renovator.Name} to the catalog.";
        }

        public bool RemoveRenovator(string name)
            => this.Renovators.Remove(this.Renovators.Find(r => r.Name == name));

        public int RemoveRenovatorBySpecialty(string type)
            => this.Renovators.RemoveAll(r => r.Type == type);

        public Renovator HireRenovator(string name)
        {
            Renovator renovator = this.Renovators.Find(r => r.Name == name);
            if (renovator != null) renovator.Hired = true;
            return renovator;
        }

        public List<Renovator> PayRenovators(int days)
            => this.Renovators.Where(r => r.Days >= days).ToList();

        public string Report()
            => $"Renovators available for Project {this.Project}:" +
               Environment.NewLine +
               string.Join(Environment.NewLine, this.Renovators.FindAll(r => !r.Hired));
    }
}

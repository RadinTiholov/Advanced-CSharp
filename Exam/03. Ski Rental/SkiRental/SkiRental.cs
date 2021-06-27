using System;
using System.Collections.Generic;
using System.Text;

namespace SkiRental
{
    public class SkiRental
    {
        public SkiRental(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Ski>();
        }
        private readonly List<Ski> data;
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => data.Count;
        public void Add(Ski ski) 
        {
            if (data.Count < Capacity)
            {
                data.Add(ski);
            }
        }
        public bool Remove(string manufacturer, string model) 
        {
            int count = 0;
            if (SkiExist(manufacturer, model, count))
            {
                data.RemoveAt(count);
                return true;
            }
            return false;
        }
        public Ski GetNewestSki() 
        {
            int maxYear = int.MinValue;
            Ski maxSki = null;
            foreach (var ski in data)
            {
                if (ski.Year > maxYear)
                {
                    maxYear = ski.Year;
                    maxSki = ski;
                }
            }
            return maxSki;
        }
        public Ski GetSki(string manufacturer, string model) 
        {
            foreach (var ski in data)
            {
                if (ski.Manufacturer == manufacturer && ski.Model == model)
                {
                    return ski;
                }
            }
            return null;
        }
        public string GetStatistics() 
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine($"The skis stored in {Name}:");
            foreach (var ski in data)
            {
                text.AppendLine(ski.ToString());
            }
            return text.ToString().Trim();

        }

        private bool SkiExist(string manufacturer, string model, int count)
        {
            foreach (var ski in data)
            {
                if (ski.Manufacturer == manufacturer && ski.Model == model)
                {
                    return true;
                }
                count++;
            }
            return false;
        }
    }
}

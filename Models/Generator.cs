using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NahodneCislo.Models
{
    public class Generator
    {       
        private Random random = new Random();
        private List<int> seznam = new List<int>();        
        public List<int> GenerujCislo()
        {
            for (int i = 0; i < 6; i++)
            {
                int temp = random.Next(1, 50);
                while (seznam.Contains(temp))
                    temp = random.Next(1, 50);
                seznam.Add(temp);
            }
            seznam.Sort();
            return seznam;
        }
    }
}

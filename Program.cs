using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Country");
            string country = Console.ReadLine();
            
            
            List<Capital> capitals = new List<Capital>
            {
                new Capital{name = "Bulgaria", capital = "Sofia"},
                new Capital{name = "England", capital = "London"},
                new Capital{name = "France", capital = "Paris"},
                new Capital{name = "Spain", capital = "Madrid"},
                new Capital{name = "Romania", capital = "Bucharest"},
                new Capital{name = "Italy", capital = "Rome"},
                new Capital{name = "Greece", capital = "Athens"},
                new Capital{name = "Germany", capital = "Berlin"},
                new Capital{name = "Portugal", capital = "Lisbon"},
                new Capital{name = "Czechia", capital = "Prague"},
                new Capital{name = "Slovakia", capital = "Bratislava"},
                new Capital{name = "Austria", capital = "Vienna"},
                new Capital{name = "Turkey", capital = "Ankara"},
                new Capital{name = "Ireland", capital = "Dublin"},
                new Capital{name = "Switzerland", capital = "Bern"},
                new Capital{name = "Serbia", capital = "Belgrade"},
                new Capital{name = "Albania", capital = "Tirana"},
                new Capital{name = "Denmark", capital = "Copenhagen"},
                new Capital{name = "Finland", capital = "Helsinki"},
                new Capital{name = "Estonia", capital = "Tallinn"},
                new Capital{name = "Latvia", capital = "Riga"},
                new Capital{name = "Colombia", capital = "Bogota"},
                new Capital{name = "Japan", capital = "Tokyo"}
            };
            foreach (Capital cap in capitals)
            {
                if (country == cap.name)
                {
                    Console.WriteLine("Capital is " + cap.capital);
                }
            }
        }
    }
}

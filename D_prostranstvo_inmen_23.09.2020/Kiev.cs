using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukraine
{
    class Kiev
    {
        uint city​_population;

        public Kiev()
        {
            this.city_population = 0;
        }

        public uint Set_get_kiev
        {
            get { return this.city_population; }
            set { this.city_population = value;}
        }

        public void Show_population_Kiev()
        {
            Console.WriteLine("Population of the city Kiev is: " + city_population);
        }

    }
}

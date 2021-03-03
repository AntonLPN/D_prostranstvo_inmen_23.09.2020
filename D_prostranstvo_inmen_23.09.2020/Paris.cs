using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace France
{
    class Paris
    {

        uint city​_population;

        public Paris()
        {
            this.city_population = 0;
        }

        public uint Set_get_Paris
        {
            get { return this.city_population; }
            set { this.city_population = value; }
        }

        public void Show_population_Paris()
        {
            Console.WriteLine("Population of the city Paris is: " + city_population);
        }

    }
}

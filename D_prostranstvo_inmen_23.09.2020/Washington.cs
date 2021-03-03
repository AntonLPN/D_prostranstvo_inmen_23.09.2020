using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USA
{
    class Washington
    {

        uint city​_population;

        public Washington()
        {
            this.city_population = 0;
        }

        public uint Set_get_Washington
        {
            get { return this.city_population; }
            set { this.city_population = value; }
        }

        public void Show_population_Washington()
        {
            Console.WriteLine("Population of the city Washington is: " + city_population);
        }


    }
}

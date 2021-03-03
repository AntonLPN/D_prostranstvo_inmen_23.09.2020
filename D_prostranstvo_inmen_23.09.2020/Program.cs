using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Тема: Пространства имен
//Задание №1
//Разработать приложение, в котором бы сравнивалось население трёх столиц из разных стран.
//Причём страна бы обозначалась пространством имён, а город — классом в данном пространстве.


namespace D_prostranstvo_inmen_23._09._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Ukraine.Kiev kiev=new Ukraine.Kiev();
            kiev.Set_get_kiev = 2967000;
            kiev.Show_population_Kiev();

            Console.WriteLine("------------------------------------------------------");
            France.Paris paris = new France.Paris();
            paris.Set_get_Paris = 2148000;
            paris.Show_population_Paris();

            Console.WriteLine("------------------------------------------------------");
            USA.Washington washington = new USA.Washington();
            washington.Set_get_Washington = 705749;

            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine("\tComparison of the population of the three capitals of the world\n");
            if (kiev.Set_get_kiev>paris.Set_get_Paris && kiev.Set_get_kiev>washington.Set_get_Washington)
            {
                Console.WriteLine("The population of Kiev is the largest of the three capitals");
            }
            else if(paris.Set_get_Paris>kiev.Set_get_kiev && paris.Set_get_Paris>washington.Set_get_Washington)
            {

                Console.WriteLine("The population of Paris is the largest of the three capitals");
            }
            else if(washington.Set_get_Washington>kiev.Set_get_kiev && washington.Set_get_Washington>paris.Set_get_Paris)
            {
                Console.WriteLine("The population of Washington is the largest of the three capitals");
            }
            Console.WriteLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Th10
{
    class Program
    {
        static void Main(string[] args)
        {

            Faculty f1 = new Faculty("Karim", "112");
            Faculty f2 = new Faculty("Rahim", "113");
            Faculty f3 = new Faculty("Rakhi", "114");
            Faculty f4 = new Faculty("Borna", "115");
            Department d = new Department("CSE", "001");
            d.AddFaculty(f1, f2, f3, f4);
            d.ShowAllFaculty();
            Console.WriteLine();
            Console.WriteLine("Deleting a Faculty");
            var faculty = d.SearchFaculty("114");
            if (faculty != null)
            {
                d.DeleteFaculty(faculty);
            }
            d.ShowAllFaculty();

        }
    }
}

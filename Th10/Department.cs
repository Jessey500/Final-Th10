using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Th10
{
    class Department
    {
        public string Name { get; set; }
        public string Id { get; set; }

        ArrayList faculty;


        public Department()
        {
            faculty = new ArrayList();
        }
        public Department(string name, string id)
        {
            Name = name;
            Id = id;
            faculty = new ArrayList();
        }
        public void AddFaculty(params Faculty[] faculty)
        {
            foreach (Faculty f in faculty)
            {
                this.faculty.Add(f);
            }
        }
        public Faculty SearchFaculty(string id)
        {
            Faculty temp = null;
            foreach (Faculty f in this.faculty)
            {
                if (f.Id.Equals(id))
                {
                    temp = f;
                }
            }
            return temp;
        }
        public void DeleteFaculty(Faculty f)
        {
            Console.WriteLine("Deleting");
            faculty.Remove(f);
        }
        public void ShowAllFaculty()
        {
            foreach (Faculty f in this.faculty)
            {
                f.Show();
            }

        }
    }
}
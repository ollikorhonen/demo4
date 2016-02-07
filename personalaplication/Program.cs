using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personaplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //create one student object 
            Student student = new Student("Kirsi", "Kernel", "Piippukatu 2", "K1938");
            Console.WriteLine("student : " + student.ToString());
            student.StudentMethod();
            student.PersonMethod();

            Teacher teacher = new Teacher("Teppo", "Terävä", "Kielokuja 3", "D566");
            Console.WriteLine("Teacher: " + teacher.ToString());
            teacher.TeacherMethod();
            teacher.PersonMethod();
            Console.ReadLine();
        }
    }
}


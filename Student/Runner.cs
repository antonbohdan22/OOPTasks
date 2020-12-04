using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeveloperArray;

namespace Student
{
    class Runner
    {
        static void Main(string[] args)
        {
            DeveloperArray<string> skills = new DeveloperArray<string>();
            skills.AddLast("C#");
            skills.AddLast("OOP");

            Student student = new Student("John", "Doe", skills);
            student.AddSkill("SOLID");
            student.AddSkill("SQL");
            student.AddSkill("Linux");

            Console.WriteLine("Skills:");

            for(int i = 0; i < student.Skills.DevArray.Length; i++) 
            {
                Console.WriteLine(student.Skills.DevArray[i]);
            }

            Console.WriteLine("Student understands SOLID - {0}", student.HasSkill("SOLID"));
            Console.ReadKey();


        }
    }
}

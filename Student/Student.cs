using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeveloperArray;

namespace Student
{
    class Student
    {
        string name;
        string surname;
        DeveloperArray<string> skills;

        public Student() { }

        public Student(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
            skills = new DeveloperArray<string>();
        } 
        
        public Student(string name, string surname, DeveloperArray<string> skills)
        {
            this.name = name;
            this.surname = surname;
            this.skills = skills;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public DeveloperArray<string> Skills
        {
            get { return skills; }
            set { skills = value; }
        }

        public void AddSkill(string value)
        {
            skills.AddLast(value);
        }

        public bool HasSkill(string value)
        {
            for (int i = 0; i < skills.DevArray.Length; i++)
            {
                if (skills.DevArray[i].Equals(value)) return true;
            }
            return false;
        }

    }
}

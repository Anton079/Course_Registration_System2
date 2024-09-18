using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System2
{
    public class Student
    {
        private int _id;
        private string _name;
        private string _courses;

        private Student(int id, string name, string courses)
        {
            _id = id;
            _name = name;
            _courses = courses;
        }

        public int Id 
        { 
            get { return _id; } 
            set { _id = value; }
        }

        public string Name 
        { 
            get { return _name; } 
            set { _name = value; }
        }

        public string Courses
        {
            get { return _courses; }
            set { _courses = value; }
        }

        public string StudentInfo()
        {
            string text = " ";

            text += "Id " + Id + "\n";
            text += "Name " + Name + "\n";
            text += "Courses" + Courses + "\n";
            return text;
        }

        public string ToSave()
        {
            return Id + "," + Name + "," + Courses;
        }
    }
}

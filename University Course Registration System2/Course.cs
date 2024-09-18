using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System2
{
    public class Course
    {
        private int _id;
        private string _name;
        private string _schedule;
        private string _instructor;
        private int _freeSpot;

        public Course(int id, string name, string schedule, string instructor, int freeSpot)
        {
            _id = id;
            _name = name;
            _schedule = schedule;
            _instructor = instructor;
            _freeSpot = freeSpot;
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

        public string Schedule
        {
            get { return _schedule; }
            set { _schedule = value; }
        }

        public string Instructor
        {
            get { return _instructor; }
            set { _instructor = value; }
        }

        public int FreeSpot
        {
            get { return _freeSpot; }
            set { _freeSpot = value; }
        }

        public string InfoCourses()
        {
            string text = " ";

            text += "Id " + Id + "\n";
            text += "Name " + Name + "\n";
            text += "Schedule " + Schedule + "\n";
            text += "Istructor " + Instructor + "\n";
            text += "Free Spot " + FreeSpot + "\n";
            return text;
        }

        public string ToSave()
        {
            return Id + Name + Schedule + Instructor + FreeSpot;
        }
    }
}

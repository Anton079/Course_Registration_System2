using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System2
{
    public class Registration
    {
        private List<Course> course;

        public Registration()
        {
            course = new List<Course>();
            LoadData();
        }

        public void LoadData()
        {
            course.Add(new Course(1,"dwada","12-19","dwqdwq",3));
            course.Add(new Course(2, "wadawd", "12-19", "zvcxvc",12));
            course.Add(new Course(3, "xcbvx", "12-19", "nyutdn",4));
        }

        public void AfisareCourses()
        {
            foreach(Course x in course)
            {
                Console.WriteLine(x.InfoCourses());
            }
        }

        public bool SearchCourse(int idCourse)
        {
            foreach (Course x in course)
            {
                if (x.Id == idCourse)
                {
                    return true;
                }
            }
            return false;
        }

        public Course DropCourseById(int idCourse)
        {
            foreach(Course x in course)
            {
                if(x.Id == idCourse)
                {
                    return x;
                }
            }
            return null;
        }


    }
}

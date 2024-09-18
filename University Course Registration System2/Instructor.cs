using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System2
{
    public class Instructor : Actions
    {
        private Registration registration;

        private Instructor()
        {
            registration = new Registration();
        }


        public override void RegistreForCourse()
        {
            registration.AfisareCourses();
        }

        public override void DropCoruse(int idCourse)
        {
            Course x = registration.DropCourseById(idCourse);

            if(registration.SearchCourse(idCourse))
            {
                Console.WriteLine("Un student a eliberat un curs si un loc e liber");
                x.FreeSpot += 1;
            }
        }

        public override void ViewCourse(int idCourse)
        {
            Course x = registration.DropCourseById(idCourse);

            if (registration.SearchCourse(idCourse))
            {
                Console.WriteLine("Un student a ocupat un curs si un loc e ocupat");
                x.FreeSpot -= 1;
            }
        }
    }
}

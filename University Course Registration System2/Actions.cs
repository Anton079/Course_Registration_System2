using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System2
{
    public class Actions
    {
        public virtual void RegistreForCourse()
        {
            Console.WriteLine("base");
        }

        public virtual void DropCoruse(int idCourse)
        {
            Console.WriteLine("base");
        }

        public virtual void ViewCourse()
        {
            Console.WriteLine("base");
        }
    }
}

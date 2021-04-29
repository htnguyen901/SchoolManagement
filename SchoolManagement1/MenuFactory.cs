using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement1
{
    class MenuFactory
    {

        public Menu createMenu(String person)
        {
            Menu menu = null;

            if (person == "Students")
            {
                return new StudentMenu();
            }
            if (person =="Lecturers")
            {
                return new LecturerMenu();
            }
            else { return null; }
        }
    }
}

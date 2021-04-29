using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement1
{
    class LecturerMenu : Menu
    {

        public override String type
        {
            get { return "Lecturer"; }
        }

        public LecturerMenu()
        {
            LecturerManage lec = new LecturerManage();
            int ok;
            do
            {
                //StudentManage stu = null;
                Console.Clear();
                Console.WriteLine("1. Add new " + type);
                Console.WriteLine("2. Update " + type);
                Console.WriteLine("3. Delete " + type);
                Console.WriteLine("4. Search " + type);
                Console.WriteLine("5. Search " + type + " by name");
                Console.WriteLine("6. View all " + type);
                Console.WriteLine("7. Back to main menu");
                Console.WriteLine("---------------------");
                Console.Write("Choose function from 1 to 7:");
                ok = int.Parse(Console.ReadLine());
                switch (ok)
                {
                    case 1: lec.Add(); break;
                    case 2: lec.Update(); break;
                    case 3: lec.Delete(); break;
                    case 4: lec.Search(); break;
                    case 5: lec.SearchByName(); break;
                    case 6: lec.View(); break;
                    case 7: break;
                    default: Console.WriteLine("Invalid"); break;
                }
                Console.ReadKey();
            } while (ok != 7);
        }
    }
}

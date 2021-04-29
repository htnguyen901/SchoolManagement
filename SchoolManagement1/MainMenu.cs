using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement1
{
    class MainMenu
    {

        public MainMenu()
        {
            MenuFactory menufactory = new MenuFactory();
            Menu menu = null;
            int choice;
            do
            {

                Console.Clear();
                Console.WriteLine("======MENU==========");
                Console.WriteLine("1. Students");
                Console.WriteLine("2. Lecturer");
                Console.WriteLine("3. Exit");
                Console.WriteLine("--------------------");
                Console.WriteLine("Choose funtion:");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        menu = menufactory.createMenu("Students");
                        break;
                    case 2:
                        menu = menufactory.createMenu("Lecturers");
                        break;
                    case 3: break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
            } while (choice != 3);
        }
    }
}

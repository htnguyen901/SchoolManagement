using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement1
{
    class LecturerManage : Person
    {

        static private List<Lecturer> list;

        public LecturerManage()
        {
            list = new List<Lecturer>();
            list.Add(new Lecturer("12345678", "Nguyen Thi Ngoc Ha", "22081997", "hanguyen@gmail.com", "123 Empire St.", "Computer Science"));
            list.Add(new Lecturer("87654321", "Nguyen Quang Hieu", "17012000", "hieunguyen@gmail.com", "900 Empire St.", "Graphic Design"));
        }

        public override void Add()
        {
            String idNumeric = "";
            Console.Write("Please input ID: ");
            idNumeric = Check.CheckIdNumMaxDigit(idNumeric, 8);
            String id = idNumeric;
            Console.WriteLine();
            Console.WriteLine("Please input name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Please input date of birth: ");
            String dob = Console.ReadLine();
            if (Check.ValidateDob(dob) == true && Check.DateOfBirthString(dob) == true)
            {
                Console.WriteLine("Please input Email: ");
                String email = Console.ReadLine();
                Console.WriteLine("Please input Address: ");
                String address = Console.ReadLine();
                Console.WriteLine("Please input Department: ");
                String dept = Console.ReadLine();
                list.Add(new Lecturer(id, name, dob, email, address, dept));
            }
        }
        public override void Update()
        {
            Console.WriteLine("Input the Lecturer ID you want to Update: ");
            String id = Console.ReadLine();
            Console.WriteLine("Which info do you want to Update? (Name / DoB / Address / Email / Department)");
            String command = Console.ReadLine();
            String newInfo = "";
            if (command == "Name")
            {
                Console.WriteLine("Please input new " + command);
                newInfo = Console.ReadLine();
                list.First(s => s.Id == id).Name = newInfo;
            }
            else if (command == "DoB")
            {
                Console.WriteLine("Please input new " + command);
                newInfo = Console.ReadLine();
                list.First(s => s.Id == id).DoB = newInfo;
            }
            else if (command == "Address")
            {
                Console.WriteLine("Please input new " + command);
                newInfo = Console.ReadLine();
                list.First(s => s.Id == id).Address = newInfo;
            }
            else if (command == "Email")
            {
                Console.WriteLine("Please input new " + command);
                newInfo = Console.ReadLine();
                list.First(s => s.Id == id).Email = newInfo;
            }
            else if (command == "Department")
            {
                Console.WriteLine("Please input new " + command);
                newInfo = Console.ReadLine();
                list.First(s => s.Id == id).Dept = newInfo;
            }
            else { Console.WriteLine("Invalid Request!!"); }
            Console.WriteLine("Updated information:");
            foreach (Lecturer l in list)
            {
                if (l.Id == id)
                {
                    Console.WriteLine(l.toString());
                }
            }
        }
        public override void Delete()
        {
            Console.WriteLine("Please input Lecturer ID to delete");
            String id = Console.ReadLine();
            var result = list.FirstOrDefault(x => x.Id == id);
            if (result != null)
            {
                var firstMatch = list.First(s => s.Id == id);
                list.Remove(firstMatch);
                Console.WriteLine("Lecturer with ID {0} has been deleted", id);
            }
            else
            {
                Console.WriteLine("Lecturer not found!!! Hit Enter to back to menu");
            }

        }

        public override void SearchByName()
        {
            Console.WriteLine("Please input Lecturer's name to search");
            String name = Console.ReadLine();
            foreach (Lecturer l in list)
            {
                if (l.Name.Contains(name))
                {
                    Console.WriteLine(l.toString());
                }
            }
        }

        public override void Search()
        {
            Console.WriteLine("Please input student ID to search");
            String id = Console.ReadLine();
            int check = 0;
            foreach (Lecturer l in list)
            {
                if (l.Id == id)
                {
                    Console.WriteLine(l.toString());
                    check = 1;
                    break;
                }
            }
            if (check == 0)
            {
                Console.WriteLine("Student not found!");
            }
        }
        public override void View()
        {
            foreach (Lecturer l in list)
            {
                Console.WriteLine(l.toString());
            }
        }

    }
}

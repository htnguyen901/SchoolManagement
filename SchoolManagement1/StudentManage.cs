using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement1
{
    class StudentManage : Person
    {

        static private List<Student> list;

        public StudentManage()
        {
            list = new List<Student>();
            list.Add(new Student("GC200117", "Nguyen Thi Ngoc Ha", "08/22/1997", "hanguyen@gmail.com", "123 Empire St.", 8));
            list.Add(new Student("GT123456", "Nguyen Quang Hieu", "01/17/2000", "hieunguyen@gmail.com", "900 Empire St.", 10));
        }

        public override void Add()
        {
            String dep = "";
            while (dep != "GT" && dep != "GC")
            {
                Console.WriteLine("Which department is the Student from? (GT or GC)");
                dep = Console.ReadLine();
            }
            String idNumeric = "";
            ConsoleKeyInfo key;
            Console.Write("Please input ID: " + dep);
            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace)
                {
                    double val = 0;
                    bool _x = double.TryParse(key.KeyChar.ToString(), out val);
                    if (_x)
                    {
                        idNumeric += key.KeyChar;
                        Console.Write(key.KeyChar);
                    }
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && idNumeric.Length > 0)
                    {
                        idNumeric = idNumeric.Substring(0, (idNumeric.Length - 1));
                        Console.Write("\b \b");
                    }
                }
            } while (key.Key != ConsoleKey.Enter);
            String id = dep + idNumeric;
            if (list.Exists(x => x.Id == id))
            {
                Console.WriteLine();
                Console.WriteLine("{0} already exists in the database. Hit Enter to back to Main Menu", id);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Please input name: ");
                String name = Console.ReadLine();
                Console.WriteLine("Please input date of birth: (MM/DD/YYYY) ");
                String dob = Console.ReadLine();
                Console.WriteLine("Please input Email: ");
                String email = Console.ReadLine();
                Console.WriteLine("Please input Address: ");
                String address = Console.ReadLine();
                Console.WriteLine("Please input batch: ");
                int batch = int.Parse(Console.ReadLine());
                list.Add(new Student(id, name, dob, email, address, batch));
            }
        }
        public override void Update()
        {
            Console.WriteLine("Input the Student ID you want to Update: ");
            String id = Console.ReadLine();
            Console.WriteLine("Which info do you want to Update? (Name / DoB / Address / Email / Batch)");
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
            else if (command == "Batch")
            {
                Console.WriteLine("Please input new " + command);
                newInfo = Console.ReadLine();
                list.First(s => s.Id == id).Batch = Convert.ToInt32(newInfo);
            }
            else { Console.WriteLine("Invalid Request!!"); }
            Console.WriteLine("Update information:");
            foreach (Student s in list)
            {
                if (s.Id == id)
                {
                    Console.WriteLine(s.toString());
                }
            }
        }
        public override void Delete()
        {
            Console.WriteLine("Please input student ID to delete");
            String id = Console.ReadLine();
            var result = list.FirstOrDefault(x => x.Id == id);
            if (result != null)
            {
                var firstMatch = list.First(s => s.Id == id);
                list.Remove(firstMatch);
                Console.WriteLine("Student with ID {0} has been deleted", id);
            }
            else {
                Console.WriteLine("Student not found!!! Hit Enter to back to menu");
            }

        }
        public override void SearchByName()
        {
            Console.WriteLine("Please input Student's name to search");
            String name = Console.ReadLine();
            foreach (Student s in list)
            {
                if (s.Name.Contains(name))
                {
                    Console.WriteLine(s.toString());
                }
            }
        }
        public override void Search()
        {
            Console.WriteLine("Please input Student ID to search");
            String id = Console.ReadLine();
            foreach (Student s in list)
            {
                if (s.Id == id)
                {
                    Console.WriteLine(s.toString());
                }
            }
        }
        public override void View()
        {
            foreach (Student s in list)
            {
                Console.WriteLine(s.toString());
            }
        }

    }
}

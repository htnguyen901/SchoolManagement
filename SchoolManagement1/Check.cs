using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement1
{
    static class Check
    {

        // Check input contains only numbers and digits are fixed
        public static String CheckIdNumMaxDigit(String idNumeric, int digit)
        {
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace)
                {
                    double val = 0;
                    bool _x = double.TryParse(key.KeyChar.ToString(), out val);
                    if (_x)
                    {
                        if (idNumeric.Length < digit)
                        {
                            idNumeric += key.KeyChar;
                            Console.Write(key.KeyChar);
                        }

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
            return idNumeric;
        }
        public static bool ValidateDob(string dob)
        {
            try
            {
                // format: MM/DD/YYY => split at /
                string[] dateParts = dob.Split('/');

                // create new date from the parts; if this does not fail
                // the method will return true and the date is valid
                DateTime testDate = new
                    DateTime(Convert.ToInt32(dateParts[2]),
                    Convert.ToInt32(dateParts[0]),
                    Convert.ToInt32(dateParts[1]));
                return true;
            }
            catch
            {
                Console.WriteLine("Invalid date!!! Hit Enter to back to menu");
                return false;
            }
        }
        public static bool DateOfBirthString(string dob) //assumes a valid date string
        {
            DateTime dtDOB = DateTime.Parse(dob);
            return ValidateAge(dtDOB);
        }
        public static bool ValidateAge(DateTime dtDoB) // validate the age
        {
            int age = GetAge(dtDoB);
            if (age < 18 || age > 100) 
            {
                Console.WriteLine("Age must be between 18 and 100");
                return false; 
            }
            return true;
        }

        public static int GetAge(DateTime birthDate)
        {
            DateTime today = DateTime.Now;
            int age = today.Year - birthDate.Year;
            if (today.Month < birthDate.Month || (today.Month == birthDate.Month && today.Day < birthDate.Day)) { age--; }
            return age;
        }
    }
}

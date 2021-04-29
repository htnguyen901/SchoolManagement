using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement1
{
    class Lecturer
    {
        private String lecId;
        private String lecName;
        private String lecDoB;
        private String lecEmail;
        private String lecAddress;
        private String lecDept;

        public Lecturer()
        {

        }

        public Lecturer(String lecId, String lecName, String lecDoB, String lecEmail, String lecAddress, String lecDept)
        {
            this.lecId = lecId;
            this.lecName = lecName;
            this.lecDoB = lecDoB;
            this.lecEmail = lecEmail;
            this.lecAddress = lecAddress;
            this.lecDept = lecDept;
        }

        public String Id
        {
            get { return lecId; }
            set { lecId = value; }
        }
        public String Name
        {
            get { return lecName; }
            set { lecName = value; }
        }
        public String DoB
        {
            get { return lecDoB; }
            set { lecDoB = value; }
        }
        public String Email
        {
            get { return lecEmail; }
            set { lecEmail = value; }
        }
        public String Address
        {
            get { return lecAddress; }
            set { lecAddress = value; }
        }
        public String Dept
        {
            get { return lecDept; }
            set { lecDept = value; }
        }
        public String toString()
        {
            return lecId + "\t" + lecName + "\t" + lecDoB + "\t" + lecAddress + "\t\t" + lecEmail + "\t" + lecDept;
        }
    }
}


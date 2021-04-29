using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement1
{
    class Student
    {
        private String stdId;
        private String stdName;
        private String stdDoB;
        private String stdEmail;
        private String stdAddress;
        private int stdBatch;

        public Student()
        {

        }

        public Student(String stdId, String stdName, String stdDoB, String stdEmail, String stdAddress, int stdBatch)
        {
            this.stdId = stdId;
            this.stdName = stdName;
            this.stdDoB = stdDoB;
            this.stdEmail = stdEmail;
            this.stdAddress = stdAddress;
            this.stdBatch = stdBatch;
        }

        public String Id
        {
            get { return stdId; }
            set { stdId = value; }
        }
        public String Name
        {
            get { return stdName; }
            set { stdName = value; }
        }
        public String DoB
        {
            get { return stdDoB; }
            set { stdDoB = value; }
        }
        public String Email
        {
            get { return stdEmail; }
            set { stdEmail = value; }
        }
        public String Address
        {
            get { return stdAddress; }
            set { stdAddress = value; }
        }
        public int Batch
        {
            get { return stdBatch; }
            set { stdBatch = value; }
        }
        public String toString()
        {
            return stdId + "\t" + stdName + "\t" + stdDoB + "\t" + stdAddress + "\t\t" + stdEmail + "\t" + stdBatch;
        }
    }
}

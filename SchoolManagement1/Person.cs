using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement1
{
    abstract class Person
    {

        public abstract void Add();
        public abstract void Update();
        public abstract void Delete();
        public abstract void Search();

        public abstract void SearchByName();
        public abstract void View();

    }
}


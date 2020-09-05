using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    abstract class Accounting:Director
    {
        public string Finance_for_development()
        {
            return "Выделить финансы на разработку";
        }
    }
}
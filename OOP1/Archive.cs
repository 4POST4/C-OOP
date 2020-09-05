using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    abstract class Archive : Design_department
    {
        public string Print()
        {
            return "Распечатать комплект КД, для сдачи в архив";
        }
    }
}
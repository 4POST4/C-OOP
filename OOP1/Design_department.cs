using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    abstract class Design_department : Scientific_research
    {
        public string Design()
        {
            return "Разработка КД, для запуска в производство";
        }
    }
}
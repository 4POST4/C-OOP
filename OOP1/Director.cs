using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    abstract class Director : OOO_METROL
    {
        public Boolean New_idea (Object unit)
        {
            return true;
        }

        public string Problem_solution()
        {
            return "Решение проблемы в работе станка рубки на КуАЭС";
        }
    }
}

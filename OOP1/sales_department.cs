using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    abstract class sales_department : Accounting
    {
        public string Implementation()
        {
            return "Реализация серийных изделий, получение прибыли";
        }
    }
}
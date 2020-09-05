using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    abstract class Scientific_research:Director
    {
        
            public void research(string status)
            {
                if (status.ToLower() == "Завершено")
                {
                    Console.WriteLine("Передать в разработку конструкторскому отделу");
                }
                else
                {
                    Console.WriteLine("Продолжить исследования");
                }
            }
            
        
    }
}
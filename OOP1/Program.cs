using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {

            
           
            Console.WriteLine("Работа предприятия METROL");

            Console.WriteLine("Решение проблемы в работе станка рубки на КуАЭС");

            Console.WriteLine("Поступило финансирование на проведеие исседований и разработку КД");
            
            New_device TestDevice = new New_device();

            Console.WriteLine(TestDevice.Design());
            Console.WriteLine(TestDevice.CreateNEW());
            Console.WriteLine(TestDevice.Print());


            Console.WriteLine(TestDevice.ToString());


            Console.ReadKey();
        }

        
        
    }
}

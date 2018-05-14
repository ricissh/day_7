using System;

namespace day_7
{
    class Program
    {
        static void Main(string[] args)
        {

            int mainigais;
            string ievade = Console.ReadLine();
            mainigais = Convert.ToInt16(ievade);
            string zvaigzne = "";
            for (int i = 1; i <= mainigais; i++)
            {
                
                zvaigzne = zvaigzne + "*";
                Console.WriteLine(zvaigzne);
                Console.ReadLine();
            }

        }
    }
}

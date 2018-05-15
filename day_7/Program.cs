using System;

namespace day_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Funkciju izsaukumi

            //ReizTabula();
            //UzLeju();
            //Zvaigznite();
            Faktorialis();
            Console.ReadLine();
        }

        static void ReizTabula()
        {
            Console.WriteLine("Ievadiet skaitli: "); //izvade
            string ievade = Console.ReadLine(); //ievade
            //int skaitlis = Convert.ToInt16(ievade);
            double skaitlis = Convert.ToDouble(ievade); //parkonverte uz skaitli ar komatu 

            for (int i = 1; i <= 10; i++) //cikls, cikls bus no 1 lidz, ieskaitot 10
            {
                Console.WriteLine(i + "*" + skaitlis + "=" + i * skaitlis);//izvade
            }
        }

        static void UzLeju()
        {
            for (int i = 10; i >= 1; i--) //cikls, kas skaota no 10 uz leju
            {
                Console.WriteLine(i); // izvada 10, 9, 8, 7,...utt
            }
        }

        static void Zvaigznite()
        {
            //i = i+1
            string zvaigzne = ""; //iveidojam mainigo
            for (int i = 1; i < 4; i++) //cikls, kas skaita no 1 lidz(neieskaitot) 4
            {
                zvaigzne = zvaigzne + "*"; //saglaba veco vertibu + pieliek klat zvaigzniti
                Console.WriteLine(zvaigzne);//izvade
            }
        }

        static void Faktorialis()
        {
            int vertiba = 0; // uztaisa jaunu mainigo, kura vertiba ir 0
            string ievade = Console.ReadLine(); //ievade ar readline
            int robeza = Convert.ToInt16(ievade); //uztaisa jaunu skaitli robeza un pieskir parveidoto simbolu virkni

            for (int i = 1; i <= robeza; i++) // pieskir skaitli robeza ka limitu ciklam
            {
                int OldVertiba = vertiba; //saglaba veco vertibu, lai izvaditu
                vertiba = vertiba + i;//pieskaita veco skaitli iteracijas vertibai
                Console.WriteLine(OldVertiba + "+" + i + "=" + vertiba);//izvade, izvada darbibu
            }
        }
    }
}
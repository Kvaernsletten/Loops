using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace kvaernsletten
{
    internal class Loops
    {
        public void Run()
        {
            Oppgave1();
            Console.WriteLine(" ");
            Oppgave2();
            Console.WriteLine(" ");
            Oppgave3();
        }

        public void Oppgave1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Terje er kul");
            }
        }

        public void Oppgave2()
        {
            string terje = "Terje er kul";

            foreach (var item in terje)
            {
                Console.WriteLine(item);
            }
        }

        public void Oppgave3()
        {
            bool boolean = true;
            int index = 0;

            while (boolean)
            {
                if (index < 10)
                {
                    index++;
                    Console.WriteLine("Runde nr " + index);
                }
                else
                {
                    boolean = false;
                }
            }
        }
    }
}

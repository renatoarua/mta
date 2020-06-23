using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            p.Idade = 3;
            int Idade = p.Idade;

            // stack
            if(Idade > 3)
            {

            }

            if (Idade > 3)
            {

            }

            if (Idade > 3)
            {

            }

            if (Idade > 3)
            {

            }


            // heap
            if (p.Idade > 3)
            {

            }

            if (p.Idade > 3)
            {

            }

            if (p.Idade > 3)
            {

            }

            if (p.Idade > 3)
            {

            }




            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        class Pessoa
        {
            public string Nome { get; set; }
            public int Idade { get; set; }
        }
    }
}

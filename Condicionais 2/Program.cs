using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeJoao = 16;
            int acompanhadopessoas = 1;
            bool acompanhado;

            if (acompanhadopessoas >= 2)
            {
                acompanhado = true;
            }
            else
            {
                acompanhado = false;
            }

            if (idadeJoao >= 18 || acompanhado )

            //  || = ou, && = E.
            {
                Console.WriteLine("pode entrar.");
            }

            else
            {
                Console.WriteLine("Não pode entrar");
            }
            Console.ReadLine();
        }

    }

}


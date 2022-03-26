using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeJoao = 16;
            int acompanhante = 0;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("pode entrar.");
            }

            else
            {

                if (acompanhante >= 1)
                {
                    Console.WriteLine("Pode entrar, você está acompanhado");
                }

                else
                {
                    Console.WriteLine("Não pode entrar, você é menor de idade.");
                }
            }
            Console.ReadLine();
        }
    }
}

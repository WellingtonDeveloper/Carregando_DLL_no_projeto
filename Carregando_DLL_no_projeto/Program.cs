using Criando_um_projeto_DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carregando_DLL_no_projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A soma de 5 e 6 é:" + Matematica.soma(5, 6));
            Console.WriteLine("A Multiplicação de 5 e 6 é:" + Matematica.Multiplica(5, 6));

            Console.ReadKey();
        }
    }
}

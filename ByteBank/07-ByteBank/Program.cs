﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(867, 86712540);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contaGabriela = new ContaCorrente(869, 86712541);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            Console.WriteLine(contaGabriela.Agencia);
            Console.WriteLine(contaGabriela.Numero);


            Console.ReadLine();
        }
    }
}

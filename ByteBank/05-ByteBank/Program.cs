﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Cliente gabriela = new Cliente();

             gabriela.nome = "Gabriela";
             gabriela.profissao = "Desenvolvedora C#";
             gabriela.cpf = "434.562.878-20";
            */


            ContaCorrente conta = new ContaCorrente();

            conta.titular = new Cliente();
            conta.titular.nome = "Gabriela";
            conta.titular.profissao = "Desenvolvedora C#";
            conta.titular.cpf = "434.562.878-20";

            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;

            //Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);

            Console.ReadLine();


        }
    }
}

using System;
using System.Collections.Generic;
namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
          

            int idade3 = 30;
            string nome2 = "";
            string sexo3 = "";
            string cidade3 = "";

            Console.WriteLine("Bom dia usuario :) ");
            Console.WriteLine("  ");

            Console.WriteLine("Por gentileza informe seu nome ? ");
            nome2 = Console.ReadLine();
            Console.WriteLine("  ");

            Console.WriteLine("Ola " + nome2 + " como vai ? ");
            Console.WriteLine("  ");
            Console.WriteLine("Agora insira sua idade por gentileza. ");
            idade3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("  ");
            Console.WriteLine("Sua idade é " + idade3 + " anos. ");
            Console.WriteLine("Por gentileza informe seu sexo. ");
            sexo3 = Console.ReadLine();

            if (idade3 >= 18 && sexo3 == "m")
            {
                Console.WriteLine("Parabéns você já pode dirigir ");
            }
            else if (idade3 >= 18 && sexo3 == "f")
            {
                Console.WriteLine("Parabéns você é do sexo feminino e pode dirigir porém tenha cuidado");
            }
            else
            {
                Console.WriteLine("Idade e sexo invalido. ");
            }

            Console.WriteLine("Em qual cidade você mora ? ");
            cidade3 = Console.ReadLine();

            if (cidade3 == "são paulo" || cidade3 == "recife")
            {
                Console.WriteLine("Parabéns você ira dirigir em uma bela cidade ");
            }
            else if (cidade3 == "")
            {
                Console.WriteLine("Você deve tomar cuidado no transito ");
            }
            else
            {
                Console.WriteLine("Você não pode dirigir. ");
            }


            Console.ReadLine();



            //int idade1 = 30;
            //string nome = "";
            //String sexo2 = "";
            //String cidade = "";

            //Console.WriteLine("Bom dia! ");
            //Console.WriteLine("  ");

            //Console.WriteLine("Informe seu nome ");
            //nome = Console.ReadLine();
            //Console.WriteLine("  ");

            //Console.WriteLine("Ola "  + nome + " Como vai ? ");
            //Console.WriteLine("  ");
            //Console.WriteLine("Agora pode inserir sua idade por gentileza. ");
            //idade1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("  ");

            //Console.WriteLine("Sua idade é de " + idade1 + " anos ");

            //if (idade1 >= 18 )
            //{



            //    Console.WriteLine("Você é do sexo masculino e está apto a dirigir ");
            //    Console.WriteLine("  ");
            //    Console.WriteLine("Você já pode dirigir porém tenha cuidado ");
            //    Console.WriteLine("  ");
            //}
            //else if  (idade1 <= 18)
            //{
            //    Console.WriteLine("Você não tem idade suficiente para tirar carta e você  provavelmente é do sexo feminino ");
            //}
            //Console.WriteLine("Agora por gentileza " + nome + " Em qual cidade você mora ? ");
            //cidade = Console.ReadLine();
            //Console.WriteLine("  ");

            //if (cidade == "São Paulo "|| cidade == "Recife ")
            //{
            //    Console.WriteLine("Parabés você ira dirigir em uma bela cidade ");

            //}
            //else if (idade1 >= 18)
            //{
            //    Console.WriteLine("Você deve tomar cuidado no transito ");
            //}
            //else
            //{
            //    Console.WriteLine("Você não pode dirigir ");
            //}


            //Console.ReadLine();

            //int idade = 25;
            //string sexo = "m";
            //int altura = 190;

            //if (idade >= 25 && sexo == "m" && altura == 190)
            //{
            //    Console.WriteLine("Compra ai");
            //}
            //else
            //{
            //    Console.WriteLine("não pode");
            //}



            //string escolhadopcão = "";


            //Console.WriteLine("Bom dia! ");
            //Console.WriteLine("Qual opção de sexo você se encaixa ? ");
            //Console.WriteLine(" Digite F para feminino e M para masculino ");
            //escolhadopcão = Console.ReadLine();

            //if (escolhadopcão == "F" || escolhadopcão == "f")
            //{
            //    Console.WriteLine("Feminino ");
            //}
            //else if (escolhadopcão == "M" || escolhadopcão == "m")
            //{
            //    Console.WriteLine("Masculino ");
            //}
            //else
            //{
            //    Console.WriteLine("Opção invalida ");
            //}


            //Console.ReadLine();

            ////programas robo liga tv



            //string opcaoEscolhida = "";

            //Console.WriteLine("Va até a tv");
            //Console.WriteLine("A tv está ligada?");
            //Console.WriteLine("digite 1 para sim e 2 para não");
            //opcaoEscolhida = Console.ReadLine();



            //if (opcaoEscolhida == "sim")
            //{
            //    Console.WriteLine("Assista");
            //}
            //else if (opcaoEscolhida == "não")
            //{
            //    Console.WriteLine("Lique a tv");
            //    Console.WriteLine("Ligando a tv");

            //    Console.WriteLine("tv ligada");
            //}
            //else
            //{
            //    Console.WriteLine("opcao invalida");
            //}


        }

        private static void InformacoesPessoais()
        {
            string nomeusuario = "Will Turner ";
            string cidadedenascimento = "São paulo ";
            double valordedinheiroqpossui = 1000.50;
            double quantoquerganhar = 2000.50;

            Console.WriteLine("Bem vindo  " + nomeusuario);
            Console.WriteLine(" Sua cidade natal é - " + cidadedenascimento);
            cidadedenascimento = Console.ReadLine();
            Console.WriteLine("Seu saldo atual é  - " + valordedinheiroqpossui);
            Console.WriteLine("O que deseja ganhar é   " + quantoquerganhar);

            Console.WriteLine("Bem Will Turner em qual cidade deseja morar  ");
            cidadedenascimento = Console.ReadLine();

            Console.WriteLine("Sua cidade agora é - " + cidadedenascimento);

            Console.WriteLine("Informe quanto dinheiro vc tem");
            valordedinheiroqpossui = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Seu novo saldo é " + valordedinheiroqpossui);

            Console.WriteLine("Informe sua pretenção salarial");
            quantoquerganhar = Convert.ToDouble(Console.ReadLine());

            valordedinheiroqpossui = valordedinheiroqpossui + quantoquerganhar;

            Console.WriteLine("O senhor " + nomeusuario, "que mora na cidade de " + cidadedenascimento);
            Console.WriteLine("Seu saldo atual é de " + valordedinheiroqpossui);
        }

        private static void VariaveisBanco()
        {
            string nomeUsuario = "Mirosmar";
            double saldoCliente = 950.21;
            double valorRetirar = 0;


            Console.WriteLine("Bem vindo " + nomeUsuario);
            Console.WriteLine("Seu saldo inicial é " + saldoCliente);

            Console.WriteLine("Digite seu novo nome");
            nomeUsuario = Console.ReadLine();

            Console.WriteLine("Bem vindo " + nomeUsuario);

            Console.WriteLine("Digite seu novo Saldo");
            saldoCliente = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Seu novo saldo é " + saldoCliente);

            Console.WriteLine("Informe quanto vc quer transferir");
            valorRetirar = Convert.ToDouble(Console.ReadLine());

            saldoCliente = saldoCliente - valorRetirar;

            Console.WriteLine("Seu novo saldo é " + saldoCliente);

            Console.WriteLine("Deseja fazer outra operação");
        }
    }
}


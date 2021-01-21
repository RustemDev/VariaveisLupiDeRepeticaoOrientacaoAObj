using System;
using OrientacaoObjetos.MeusObjetos;
using System.Collections.Generic;

namespace OrientacaoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool maiorDEidade = false;
            string opcao = "";

            Pessoa pp = new Pessoa();

            pp.Idade = 20;

            pp.EhDeMaior = pp.Idade > 18;


            if (pp.EhDeMaior)
            {
                Console.WriteLine("vc pode dirigir");
                Console.WriteLine("Voce continua sendo maior de idade? digite s para sim e n para não");
                opcao = Console.ReadLine();

                if (opcao == "s")
                {
                    pp.EhDeMaior = true;
                }
                else if(opcao =="n")
                {
                    pp.EhDeMaior = false;
                }
                
            }

            if (pp.EhDeMaior)
            {
                Console.WriteLine("Vc já pode viajar sozinho");
            }

            Console.WriteLine("Tem certeza que vc é maior de idade");
            opcao = Console.ReadLine();

            if (opcao == "s")
            {
                pp.EhDeMaior = true;
            }
            else if (opcao == "n")
            {
                pp.EhDeMaior = false;
            }


            if (pp.EhDeMaior)
            {
                Console.WriteLine("Vc já pode comprar bebida alcoolica");
            }



            if (pp.EhDeMaior)
            {
                Console.WriteLine("vc já pode se alistar");
            }

            int idiomaEscolhido = 0;

            //List<int> meusNumeros = new List<int>();
            //List<string> frutas = new List<string>();
            //List<bool> verdades = new List<bool>();
            //List<Pessoa> minhasGaleras = new List<Pessoa>();

            List<string> idiomas = new List<string>();



            Console.WriteLine("Bom dia usuario. Por favor informe quantos idiomas você sabe");
            int quantDeIdiomas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe os idiomas desejados ");

            for (int i = 0; i < quantDeIdiomas; i++)
            {
                idiomas.Add(Console.ReadLine());
            }

            Console.WriteLine("os idiomas escolhidos foram " + quantDeIdiomas);

            for (int i = 0; i < idiomas.Count; i++)
            {
                Console.WriteLine("digite " + i + " para o idioma " + idiomas[i]);
            }


            // guardar em uma variavel o idioma que o usuario informou, 

            Console.WriteLine("Agora digite o númedo do idioma que você mais gosta");

            idiomaEscolhido = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O idioma que você mais gosta é " + idiomas[idiomaEscolhido]);


            // passar a variavel como parametro do método falar


            Pessoa p = new Pessoa();
            Console.WriteLine(p.Falar());
            Console.WriteLine(p.Falar(idiomas[idiomaEscolhido]));


            Console.ReadLine();


            Console.WriteLine("Informe se o notbook está ligado ou desligado ");
            Notebook not = new Notebook();
            Console.WriteLine(not.Ligar());

            Console.WriteLine("OK, agora informe sua voltagen ");
            string voltagen = "";
            voltagen = Console.ReadLine();

            Console.WriteLine(not.Ligar(voltagen));






            Console.ReadLine();

        }
    }
}


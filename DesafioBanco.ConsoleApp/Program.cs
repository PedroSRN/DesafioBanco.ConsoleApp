using System;

namespace DesafioBanco.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
                           //1234567890123456789012345678901234567890
            string texto1 = "     __  __      __  __ __   __  __  __ \n" +
                            "  |  __| __||__||__ |__   | |__||__||  |\n" +
                            "  | |__  __|   | __||__|  | |__| __||__|\n";
            
            System.IO.StringReader leitorTexto = new System.IO.StringReader(texto1);

            string primeiraLinha = leitorTexto.ReadLine(); 

            string segundaLinha = leitorTexto.ReadLine();

            string terceiraLinha = leitorTexto.ReadLine();

            

            char[] linha1 = primeiraLinha.ToCharArray();
            
            char[] linha2 = segundaLinha.ToCharArray();

            char[] linha3 = terceiraLinha.ToCharArray();

            string strLinha1 = "";
            string strLinha2 = "";
            string strLinha3 = "";

            int contador = 0;

            for (int i = 0; i < 40; i++)
            {
                strLinha1 += linha1[i];
                strLinha2 += linha2[i];
                strLinha3 += linha3[i];

                if(strLinha1 == "    " &&  strLinha2 == "  | " &&  strLinha3 == "  | ")
                {
                    Console.Write("1");
                }

                if(strLinha1 == " __ " && strLinha2 == " __|" && strLinha3 == "|__ ")
                {
                    Console.Write("2");
                }

                if(strLinha1 == " __ " && strLinha2 == " __|" && strLinha3 == " __|")
                {
                    Console.Write("3");
                }

                if (strLinha1 == "    " && strLinha2 == "|__|" && strLinha3 == "   |")
                {
                    Console.Write("4");
                }

                if (strLinha1 == " __ " && strLinha2 == "|__ " && strLinha3 == " __|")
                {
                    Console.Write("5");
                }

                if (strLinha1 == " __ " && strLinha2 == "|__ " && strLinha3 == "|__|")
                {
                    Console.Write("6");
                }

                if (strLinha1 == " __ " && strLinha2 == "  | " && strLinha3 == "  | ")
                {
                    Console.Write("7");
                }

                if (strLinha1 == " __ " && strLinha2 == "|__|" && strLinha3 == "|__|")
                {
                    Console.Write("8");
                }

                if (strLinha1 == " __ " && strLinha2 == "|__|" && strLinha3 == " __|")
                {
                    Console.Write("9");
                }

                if (strLinha1 == " __ " && strLinha2 == "|  |" && strLinha3 == "|__|")
                {
                    Console.Write("0");
                }

                contador += 1;
                
                if(contador == 4)
                {
                     strLinha1 = "";
                     strLinha2 = "";
                     strLinha3 = "";


                    contador=0;
                }
            }

            Console.ReadLine();
        }
    }
}

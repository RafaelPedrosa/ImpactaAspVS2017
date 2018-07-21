using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNetVS2017.Capitulo01.Repeticao.Testes
{
    [TestClass]
    public class RepeticaoTeste
    {
        [TestMethod]
        public void ForAninhadoTeste()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 0; j <=10; j++)
                {   //O $ Permite ler as váriaveis dentro das aspas duplas
                    Console.WriteLine($"{i} * {j} = {i*j}");
                }
                Console.WriteLine(new string('-', 50));

            }

        }

        [TestMethod]
        public void EstruturaForTeste()
        {
            var i = 1;
            for (Console.WriteLine("Inicialização"); i <= 3; Console.WriteLine(i))
            {
                i++;
            }

            /*
             For(Inicialização; condição de execução; pós-execução)
            { 
               execução
            }
            */

        }

        [TestMethod]
        public void ForApenasComCondicaoTeste()
        {
            var i = 1;
            for ( ; i <= 3; )
            {
                Console.WriteLine(i++);
            }
        }

        [TestMethod]
        public void ContinueTeste()
        {
            for (int i = 1; i <=10; i++)
            {
                if (i <= 5) 
                {
                    continue;
                }

                Console.WriteLine(i);

            }
        }

        [TestMethod]
        public void BreakTeste()
        {
            for (int i = 1; i <=10; i++)
            {
                if (i>5)
                {
                    break;
                }

                Console.WriteLine(i);
            }
        }
    }
}

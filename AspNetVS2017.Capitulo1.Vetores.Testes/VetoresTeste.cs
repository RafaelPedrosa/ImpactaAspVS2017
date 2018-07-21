using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AspNetVS2017.Capitulo1.Vetores.Testes
{
    [TestClass]
    public class VetoresTeste
    {
        [TestMethod]
        public void InicializacaoTeste()
        {   //Criando Vetor de Strings
            var strings = new string[10]; //string[] strings = new string[10];

            strings[0] = "Rafael";
            //Criando Vetor de Decimais
            var decimais = new decimal[] {0.5m, 1, 1.63m};

            int[] inteiros = { 1, 20, 14, 66 };

            //Percorrendo uma lista

            foreach (var inteiro in inteiros)
            {
                Console.WriteLine(inteiro);
            }

            Console.WriteLine($"Tamanho do Vetor: {inteiros.Length}");
            var soma = inteiros.Where(i => i > 1).Sum(); //Esta linha possui Linq, que é manipula
            //sua lista com comandos sql, apenas foi necessário colocar a dll linq la em cima.
            Console.WriteLine(soma);
        }

        [TestMethod]
        public void RedimensionamentoTeste()
        {
            var decimais = new decimal[] { 0.5m, 1, 1.5m, 2 };

            Array.Resize(ref decimais, 5);
            decimais[4] = 2.5m;

        }

        [TestMethod]
        public void OrdenacaoTeste()
        {
            var decimais = new decimal[] { 0.5m, 8, 4.5m, 1 };

            Array.Sort(decimais);
            //Assert só Libera o teste se esse Assert foi verdadeiro
            //No caso se a posição do decimal 0 for 0.5 que é o menor valor.
            Assert.AreEqual(decimais[0], 0.5m);

        }

        [TestMethod]
        public void ParamsTeste()
        {
            var decimais = new decimal[] { 0.5m, 8, 4.5m, 1 };
            Console.WriteLine(Media(decimais));

        }
        ////Criação de um método onde vai receber dois valores e calcular a méida
        //private decimal Media(decimal valor1, decimal valor2)
        //{
        //    return (valor1 + valor2) / 2;
        //}

        //Criação de um método que recebe um número indertemiado de parametos.

        private decimal Media(params decimal[] decimais)
        { // a palavra params cria um vetor com os parametros que foram passados,
          // assim vc n precisa criar o vetor.
            var soma = 0m;

            foreach (var @decimal in decimais)
            {
                // soma = soma + @decimal;
                soma += @decimal;
            }

            return soma / decimais.Length;
            // return decimais.Average();
        }

        [TestMethod]
        public void TodaStringEhUmVetorTeste()
        {
            var nome = "Rafael";

            foreach (var caractere in nome)
            {
                Console.WriteLine(caractere);
            }
            Assert.AreEqual(nome[0], 'R');
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AspNetVS2017.Capitulo1.Vetores.Testes
{
    [TestClass]
    public class ColecoesTeste
    {
        [TestMethod]
        public void ListTeste()
        {
            var inteiros = new List<int>(50); //Esse 50 representa o tamanho inicial 
            inteiros.Add(10);
            inteiros.Add(30);
            inteiros.Add(40);
            inteiros.Add(50);

            var MaisInteiros = new List<int>() { 1, 2, 3, 9 };

            inteiros.AddRange(MaisInteiros);

            inteiros.Insert(0, 65);

            inteiros.Remove(3);
            inteiros.RemoveAt(0);//remove na posição que está o vetor.
            inteiros.Sort();

            var primeiro = inteiros[0];
            var ultimo = inteiros[inteiros.Count - 1];

            foreach (var inteiro in inteiros)
            {
                Console.WriteLine($"{inteiros.IndexOf(inteiro)}: {inteiro}");

            }
        }

        [TestMethod]
        public void DictionaryTeste()
        {
            var feriados = new Dictionary<DateTime, string>();
            feriados.Add(new DateTime(2018, 12, 25), "Natal");
            feriados.Add(new DateTime(2018, 12, 31), "Ano Novo");
            feriados.Add(new DateTime(2019, 01, 25), "Aniversário de SP");

            var natal = feriados[new DateTime(2018, 12, 25)];

            foreach (var feriado in feriados)
            {
                Console.WriteLine($"{feriado.Key.ToShortDateString()}:{feriado.Value}");
            }

            Console.WriteLine(feriados.ContainsKey(new DateTime(2018, 12, 25)));
            Console.WriteLine(feriados.ContainsValue("Ano Novo"));
        }

        [TestMethod]
        public void StackTeste()
        {                   //Pilha - Segue a ordem de tamanho
            var pilha = new Stack<int>();
            pilha.Push(1);
            pilha.Push(4);
            pilha.Push(7);

            Assert.AreEqual(pilha.Pop(), 7); //Pop retira o elemento da pilha 
            Assert.AreEqual(pilha.Peek(), 4);//Peek faz com que vc de uma olhada no primeiro item da fila

            Console.WriteLine($"A pilha está vazia? {pilha.Count == 0}");
        }

        [TestMethod]
        public void QueueTeste()
        {                   //Fila - Segue a ordem de chegada
            var fila = new Queue<int>();
            fila.Enqueue(1);
            fila.Enqueue(4);
            fila.Enqueue(2);

            Assert.AreEqual(fila.Dequeue(),1);//Dequeue, o primeiro a entrar é o primeiro a sair
            Assert.AreEqual(fila.Peek(), 4);//Peek faz com que vc de uma olhada no primeiro item da fila
        }

    }
}

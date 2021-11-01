using System;

namespace CursoEstruturasDados_OOP
{
    public class UsoListaVetor
    {
        public void Apresentacao()
        {
            int[] vetor1 = new int[20];
            ListaVetor lista = new ListaVetor(ref vetor1);
            
            lista.Inserir(ref vetor1, 1);
            lista.Inserir(ref vetor1, 3);
            lista.Inserir(ref vetor1, 4);
            lista.Inserir(ref vetor1, 2);

            lista.InserirNoElemento(ref vetor1, 1, 5);

            lista.EliminarDoElemento(ref vetor1, 1);

            lista.Inserir(ref vetor1, 1);

            Console.WriteLine("------------------------------------------------------------------");
            lista.Apresentar(vetor1);

            Console.WriteLine("Lista contém 5: " + lista.Contem(vetor1, 5)); 
            Console.WriteLine("Quantidade de valores 1 na Lista: " + lista.ContaValores(vetor1, 1));
            Console.WriteLine("Dimensão da Lista: " + lista.Dimensao);
            Console.WriteLine("Limite Superior do Vetor: " + lista.LimiteSuperior);
        }
    }
}
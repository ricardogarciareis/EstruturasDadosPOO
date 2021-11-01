using System;

namespace CursoEstruturasDados_OOP
{
    public class UsoFilaVetor
    {
        public void Apresentacao()
        {
            int[] vetor3 = new int[20];
            var filaVetor = new FilaVetor(ref vetor3);

            filaVetor.Inserir(ref vetor3, 100);
            filaVetor.Inserir(ref vetor3, 200);
            filaVetor.Inserir(ref vetor3, 300);
            filaVetor.Inserir(ref vetor3, 400);

            filaVetor.EliminarDoPrimeiroElemento(ref vetor3);
            filaVetor.EliminarDoPrimeiroElemento(ref vetor3);
            filaVetor.EliminarDoPrimeiroElemento(ref vetor3);
            filaVetor.EliminarDoPrimeiroElemento(ref vetor3);

            filaVetor.Inserir(ref vetor3, 100);
            filaVetor.Inserir(ref vetor3, 500);
            filaVetor.Inserir(ref vetor3, 200);
            filaVetor.Inserir(ref vetor3, 300);
            filaVetor.Inserir(ref vetor3, 400);

            // filaVetor.EliminarDoPrimeiroElemento(ref vetor3);
            // filaVetor.EliminarDoPrimeiroElemento(ref vetor3);
            // filaVetor.EliminarDoPrimeiroElemento(ref vetor3);
            // filaVetor.EliminarDoPrimeiroElemento(ref vetor3);
            // filaVetor.EliminarDoPrimeiroElemento(ref vetor3);

            // filaVetor.Inserir(ref vetor3, 100);
            // filaVetor.Inserir(ref vetor3, 200);
            // filaVetor.Inserir(ref vetor3, 300);
            // filaVetor.Inserir(ref vetor3, 400);

            filaVetor.Inserir(ref vetor3, 100);

            Console.WriteLine("------------------------------------------------------------------");
            filaVetor.Apresentar(vetor3);

            Console.WriteLine("Fila contém 500: " + filaVetor.Contem(vetor3, 500)); 
            Console.WriteLine("Quantidade de valores 100 na Fila: " + filaVetor.ContaValores(vetor3, 100)); 
            Console.WriteLine("Dimensão da Fila: " + filaVetor.Dimensao);
            Console.WriteLine("Limite Superior do Vetor: " + filaVetor.LimiteSuperior);
        }
        
    }
}
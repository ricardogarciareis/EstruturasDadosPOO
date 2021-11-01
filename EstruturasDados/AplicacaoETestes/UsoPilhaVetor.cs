using System;

namespace CursoEstruturasDados_OOP
{
    public class UsoPilhaVetor
    {
        public void Apresentacao()
        {
            int[] vetor2 = new int[20];
            var pilhaVetor = new PilhaVetor(ref vetor2);

            pilhaVetor.Inserir(ref vetor2, 10);
            pilhaVetor.Inserir(ref vetor2, 30);
            pilhaVetor.Inserir(ref vetor2, 40);
            pilhaVetor.Inserir(ref vetor2, 20);

            pilhaVetor.EliminarDoUltimoElemento(ref vetor2);
            pilhaVetor.EliminarDoUltimoElemento(ref vetor2);
            pilhaVetor.EliminarDoUltimoElemento(ref vetor2);

            pilhaVetor.Inserir(ref vetor2, 50);
            pilhaVetor.Inserir(ref vetor2, 30);
            pilhaVetor.Inserir(ref vetor2, 40);
            pilhaVetor.Inserir(ref vetor2, 20);

            // pilhaVetor.EliminarDoUltimoElemento(ref vetor2);
            // pilhaVetor.EliminarDoUltimoElemento(ref vetor2);
            // pilhaVetor.EliminarDoUltimoElemento(ref vetor2);
            // pilhaVetor.EliminarDoUltimoElemento(ref vetor2);

            // pilhaVetor.Inserir(ref vetor2, 30);
            // pilhaVetor.Inserir(ref vetor2, 40);
            // pilhaVetor.Inserir(ref vetor2, 20);

            pilhaVetor.Inserir(ref vetor2, 10);

            Console.WriteLine("------------------------------------------------------------------");
            pilhaVetor.Apresentar(vetor2);

            Console.WriteLine("Pilha contém 50: " + pilhaVetor.Contem(vetor2, 50));
            Console.WriteLine("Quantidade de valores 10 na Pilha: " + pilhaVetor.ContaValores(vetor2, 10)); 
            Console.WriteLine("Dimensão da Pilha: " + pilhaVetor.Dimensao);
            Console.WriteLine("Limite Superior do Vetor: " + pilhaVetor.LimiteSuperior);
        }
    }
}
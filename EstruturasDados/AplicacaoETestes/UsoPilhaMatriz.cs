using System;

namespace CursoEstruturasDados_OOP
{
    public class UsoPilhaMatriz
    {
        public void Apresentacao()
        {
            string[,] matriz2 = new string[10, 2];
            var pilhaMatriz = new PilhaMatriz(ref matriz2);

            pilhaMatriz.Inserir(ref matriz2, "0001", "Ricardo Alexandre Reis");
            pilhaMatriz.Inserir(ref matriz2, "0002", "Ana Isabel Costa");
            pilhaMatriz.Inserir(ref matriz2, "0003", "Maria Isabel Costa");
            pilhaMatriz.Inserir(ref matriz2, "0004", "António José Reis");
            pilhaMatriz.Inserir(ref matriz2, "0005", "Ana Maria Reis");

            pilhaMatriz.EliminarDoUltimoElemento(ref matriz2);
            pilhaMatriz.EliminarDoUltimoElemento(ref matriz2);
            pilhaMatriz.EliminarDoUltimoElemento(ref matriz2);
            pilhaMatriz.EliminarDoUltimoElemento(ref matriz2);

            pilhaMatriz.Inserir(ref matriz2, "0006", "Maria Josefina");

            pilhaMatriz.Inserir(ref matriz2, "0002", "Ana Isabel Costa");
            pilhaMatriz.Inserir(ref matriz2, "0003", "Maria Isabel Costa");
            pilhaMatriz.Inserir(ref matriz2, "0004", "António José Reis");
            pilhaMatriz.Inserir(ref matriz2, "0005", "Ana Maria Reis");

            Console.WriteLine("------------------------------------------------------------------");
            pilhaMatriz.Apresentar(matriz2);

            Console.WriteLine("Linhas da Matriz: " + pilhaMatriz.Linhas);
            Console.WriteLine("A matriz contém a entrada José: " + pilhaMatriz.Contem(matriz2, "José"));
            Console.WriteLine("Quantidade de valores Reis na matriz: " + pilhaMatriz.ContaValores(matriz2, "Reis"));
        }
        
    }
}
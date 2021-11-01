using System;

namespace CursoEstruturasDados_OOP
{
    public class UsoFilaMatriz
    {
        public void Apresentacao()
        {
            string[,] matriz3 = new string[10, 2];
            var filaMatriz = new FilaMatriz(ref matriz3);

            filaMatriz.Inserir(ref matriz3, "0001", "Ricardo Alexandre Reis");
            filaMatriz.Inserir(ref matriz3, "0002", "Ana Isabel Costa");
            filaMatriz.Inserir(ref matriz3, "0003", "Maria Isabel Costa");
            filaMatriz.Inserir(ref matriz3, "0004", "António José Reis");
            filaMatriz.Inserir(ref matriz3, "0005", "Ana Maria Reis");

            filaMatriz.EliminarDoPrimeiroElemento(ref matriz3);
            filaMatriz.EliminarDoPrimeiroElemento(ref matriz3);
            filaMatriz.EliminarDoPrimeiroElemento(ref matriz3);
            filaMatriz.EliminarDoPrimeiroElemento(ref matriz3);
            filaMatriz.EliminarDoPrimeiroElemento(ref matriz3);

            filaMatriz.Inserir(ref matriz3, "0001", "Ricardo Alexandre Reis");
            filaMatriz.Inserir(ref matriz3, "0006", "Maria Josefina");
            filaMatriz.Inserir(ref matriz3, "0002", "Ana Isabel Costa");
            filaMatriz.Inserir(ref matriz3, "0003", "Maria Isabel Costa");
            filaMatriz.Inserir(ref matriz3, "0004", "António José Reis");
            filaMatriz.Inserir(ref matriz3, "0005", "Ana Maria Reis");

            Console.WriteLine("------------------------------------------------------------------");
            filaMatriz.Apresentar(matriz3);

            Console.WriteLine("Linhas da Matriz: " + filaMatriz.Linhas);
            Console.WriteLine("A matriz contém a entrada José: " + filaMatriz.Contem(matriz3, "José"));
            Console.WriteLine("Quantidade de valores Reis na matriz: " + filaMatriz.ContaValores(matriz3, "Reis"));
        }
        
    }
}
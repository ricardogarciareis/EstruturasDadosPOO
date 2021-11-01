using System;

namespace CursoEstruturasDados_OOP
{
    public class UsoListaMatriz
    {
        public void Apresentacao()
        {
            string[,] matriz1 = new string[10, 2];
            var listaMatriz = new ListaMatriz(ref matriz1);

            listaMatriz.Inserir(ref matriz1, "0001", "Ricardo Alexandre Reis");
            listaMatriz.Inserir(ref matriz1, "0002", "Ana Isabel Costa");
            listaMatriz.Inserir(ref matriz1, "0003", "Maria Isabel Costa");
            listaMatriz.Inserir(ref matriz1, "0004", "António José Reis");
            listaMatriz.Inserir(ref matriz1, "0005", "Ana Maria Reis");

            listaMatriz.InserirNoElemento(ref matriz1, 1, "0006", "Maria Josefina");

            listaMatriz.EliminarDoElemento(ref matriz1, 1);

            //listaMatriz.EliminarDoUltimoElemento(ref matriz1);
      
            Console.WriteLine("------------------------------------------------------------------");
            listaMatriz.Apresentar(matriz1);

            Console.WriteLine("Linhas da Matriz: " + listaMatriz.Linhas);
            Console.WriteLine("A matriz contém a entrada José: " + listaMatriz.Contem(matriz1, "José"));
            Console.WriteLine("Quantidade de valores Reis na matriz: " + listaMatriz.ContaValores(matriz1, "Reis"));
        }
        
    }
}
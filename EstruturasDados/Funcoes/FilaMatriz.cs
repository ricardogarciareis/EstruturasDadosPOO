using System;

namespace CursoEstruturasDados_OOP
{
    public class FilaMatriz : EstruturasDadosMatriz
    {
        #region construtores
        public FilaMatriz(ref int[,] vet)
        {
            LimiteSuperior = vet.Length;
            Linhas = CalcLinhas(vet);
            Vazia = DefVazia(vet);
            Cheia = DefCheia(vet);
        }

        public FilaMatriz(ref string[,] vet)
        {
            LimiteSuperior = vet.Length;
            Linhas = CalcLinhas(vet);
            Vazia = DefVazia(vet);
            Cheia = DefCheia(vet);
        }
        #endregion

        #region eliminarDoPrimeiroElemento
        public void EliminarDoPrimeiroElemento(ref int[,] vet){
            Linhas = CalcLinhas(vet);
            Vazia = DefVazia(vet);
            if(!Vazia){
                int n = Linhas;
                for(int i = 0; i < n; i++){
                    vet[i, 0] = vet[i+1, 0];
                    vet[i, 1] = vet[i+1, 1];
                }
            vet[n, 0] = 0;
            vet[n, 1] = 0;
            }
        }

        public void EliminarDoPrimeiroElemento(ref string[,] vet){
            Linhas = CalcLinhas(vet);
            Vazia = DefVazia(vet);
            if(!Vazia){
                int n = Linhas;
                for(int i = 0; i < n; i++){
                    vet[i, 0] = vet[i+1, 0];
                    vet[i, 1] = vet[i+1, 1];
                }
            vet[n, 0] = null;
            vet[n, 1] = null;
            }
        }
        #endregion
        
    }
}
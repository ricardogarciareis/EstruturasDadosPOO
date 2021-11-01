using System;

namespace CursoEstruturasDados_OOP
{
    public class PilhaMatriz : EstruturasDadosMatriz
    {
        #region contrutores
        public PilhaMatriz(ref int[,] vet)
        {
            LimiteSuperior = vet.Length;
            Linhas = CalcLinhas(vet);
            Vazia = DefVazia(vet);
            Cheia = DefCheia(vet);
        }

        public PilhaMatriz(ref string[,] vet)
        {
            LimiteSuperior = vet.Length;
            Linhas = CalcLinhas(vet);
            Vazia = DefVazia(vet);
            Cheia = DefCheia(vet);
        }
        #endregion

        #region eliminarDoUltimoElemento
        public void EliminarDoUltimoElemento(ref int[,] vet){
            Linhas = CalcLinhas(vet);
            Vazia = DefVazia(vet);
            if(!Vazia){
                vet[Linhas - 1, 0] = 0;
                vet[Linhas - 1, 1] = 0;
            }
        }

        public void EliminarDoUltimoElemento(ref string[,] vet){
            Linhas = CalcLinhas(vet);
            Vazia = DefVazia(vet);
            if(!Vazia){
                vet[Linhas - 1, 0] = null;
                vet[Linhas - 1, 1] = null;
            }
        }
        #endregion
        
    }
}
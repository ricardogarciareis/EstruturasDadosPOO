using System;

namespace CursoEstruturasDados_OOP
{
    public class ListaMatriz : EstruturasDadosMatriz
    {
        #region contrutores
        public ListaMatriz(ref int[,] vet)
        {
            LimiteSuperior = vet.Length;
            Linhas = CalcLinhas(vet);
            Vazia = DefVazia(vet);
            Cheia = DefCheia(vet);
        }

        public ListaMatriz(ref string[,] vet)
        {
            LimiteSuperior = vet.Length;
            Linhas = CalcLinhas(vet);
            Vazia = DefVazia(vet);
            Cheia = DefCheia(vet);
        }
        #endregion

        #region inserirNoElemento
        public void InserirNoElemento(ref int[,] vet, int elemento, int valA, int valB){
            Linhas = CalcLinhas(vet);
            Cheia = DefCheia(vet);
            if(!Cheia && elemento >= 0 && elemento <= Linhas){
                for(int i = Linhas; i > elemento; i--){
                    vet[i, 0] = vet[i - 1, 0];
                    vet[i, 1] = vet[i - 1, 1];
                }
            }
            vet[elemento, 0] = valA;
            vet[elemento, 1] = valB;
        }

        public void InserirNoElemento(ref string[,] vet, int elemento, string valA, string valB){
            Linhas = CalcLinhas(vet);
            Cheia = DefCheia(vet);
            if(!Cheia && elemento >= 0 && elemento <= Linhas){
                for(int i = Linhas; i > elemento; i--){
                    vet[i, 0] = vet[i - 1, 0];
                    vet[i, 1] = vet[i - 1, 1];
                }
            }
            vet[elemento, 0] = valA;
            vet[elemento, 1] = valB;
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

        #region eliminarDoElemento
        public void EliminarDoElemento(ref int[,] vet, int elemento){
            Linhas = CalcLinhas(vet);
            Vazia = DefVazia(vet);
            if(!Vazia && elemento >= 0 && elemento < Linhas){
                vet[elemento, 0] = 0;
                for(int i = elemento; i < Linhas; i++){
                    vet[i, 0] = vet[i + 1, 0];
                    vet[i, 1] = vet[i + 1, 1];
                }
            }
        }

        public void EliminarDoElemento(ref string[,] vet, int elemento){
            Linhas = CalcLinhas(vet);
            Vazia = DefVazia(vet);
            if(!Vazia && elemento >= 0 && elemento < Linhas){
                vet[elemento, 0] = null;
                for(int i = elemento; i < Linhas; i++){
                    vet[i, 0] = vet[i + 1, 0];
                    vet[i, 1] = vet[i + 1, 1];
                }
            }
        }
        #endregion
        
    }
}
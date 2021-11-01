using System;

namespace CursoEstruturasDados_OOP
{
    public class ListaVetor : EstruturasDadosVetor
    {
        #region construtores
        public ListaVetor(ref int[] vet)
        {
            LimiteSuperior = vet.Length;
            Dimensao = CalcDimensao(vet);
            Vazia = DefVazia(vet);
            Cheia = DefCheia(vet);
        }

        public ListaVetor(ref string[] vet)
        {
            LimiteSuperior = vet.Length;
            Dimensao = CalcDimensao(vet);
            Vazia = DefVazia(vet);
            Cheia = DefCheia(vet);
        }
        #endregion

        #region inserirNoElemento
        public void InserirNoElemento(ref int[] vet, int elemento, int val){
            Dimensao = CalcDimensao(vet);
            Cheia = DefCheia(vet);
            if(!Cheia && elemento >= 0 && elemento <= Dimensao){
                for(int i = Dimensao; i > elemento; i--){
                    vet[i] = vet[i - 1];
                }
            }
            vet[elemento] = val;
        }

        public void InserirNoElemento(ref string[] vet, int elemento, string val){
            Dimensao = CalcDimensao(vet);
            Cheia = DefCheia(vet);
            if(!Cheia && elemento >= 0 && elemento <= Dimensao){
                for(int i = Dimensao; i > elemento; i--){
                    vet[i] = vet[i - 1];
                }
            }
            vet[elemento] = val;
        }
        #endregion

        #region eliminarDoUltimoElemento
        public void EliminarDoUltimoElemento(ref int[] vet){
            Dimensao = CalcDimensao(vet);
            Vazia = DefVazia(vet);
            if(!Vazia){
                vet[Dimensao - 1] = 0;
            }
        }

        public void EliminarDoUltimoElemento(ref string[] vet){
            Dimensao = CalcDimensao(vet);
            Vazia = DefVazia(vet);
            if(!Vazia){
                vet[Dimensao - 1] = null;
            }
        }
        #endregion

        #region eliminarDoElemento
        public void EliminarDoElemento(ref int[] vet, int elemento){
            Dimensao = CalcDimensao(vet);
            Vazia = DefVazia(vet);
            if(!Vazia && elemento >= 0 && elemento < Dimensao){
                vet[elemento] = 0;
                for(int i = elemento; i < Dimensao; i++){
                    vet[i] = vet[i + 1];
                }
            }
        }

        public void EliminarDoElemento(ref string[] vet, int elemento){
            Dimensao = CalcDimensao(vet);
            Vazia = DefVazia(vet);
            if(!Vazia && elemento >= 0 && elemento < Dimensao){
                vet[elemento] = null;
                for(int i = elemento; i < Dimensao; i++){
                    vet[i] = vet[i + 1];
                }
            }
        }
        #endregion
        
    }
}
using System;

namespace CursoEstruturasDados_OOP
{
    public class FilaVetor : EstruturasDadosVetor
    {
        #region construtores
        public FilaVetor(ref int[] vet)
        {
            LimiteSuperior = vet.Length;
            Dimensao = CalcDimensao(vet);
            Vazia = DefVazia(vet);
            Cheia = DefCheia(vet);
        }

        public FilaVetor(ref string[] vet)
        {
            LimiteSuperior = vet.Length;
            Dimensao = CalcDimensao(vet);
            Vazia = DefVazia(vet);
            Cheia = DefCheia(vet);
        }
        #endregion
        
        #region eliminarDoPrimeiroElemento
        public void EliminarDoPrimeiroElemento(ref int[] vet){
            Dimensao = CalcDimensao(vet);
            Vazia = DefVazia(vet);
            if(!Vazia){
                int n = Dimensao;
                for(int i = 0; i < n; i++){
                    vet[i] = vet[i+1];
                }
            vet[n] = 0;
            }
        }

        public void EliminarDoPrimeiroElemento(ref string[] vet){
            Dimensao = CalcDimensao(vet);
            Vazia = DefVazia(vet);
            if(!Vazia){
                int n = Dimensao;
                for(int i = 0; i < n; i++){
                    vet[i] = vet[i+1];
                }
            vet[n] = null;
            }
        }
        #endregion

    }
}
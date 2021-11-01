using System;

namespace CursoEstruturasDados_OOP
{
    public class PilhaVetor : EstruturasDadosVetor
    {
        #region construtores
        public PilhaVetor(ref int[] vet)
        {
            LimiteSuperior = vet.Length;
            Dimensao = CalcDimensao(vet);
            Vazia = DefVazia(vet);
            Cheia = DefCheia(vet);
        }

        public PilhaVetor(ref string[] vet)
        {
            LimiteSuperior = vet.Length;
            Dimensao = CalcDimensao(vet);
            Vazia = DefVazia(vet);
            Cheia = DefCheia(vet);
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

    }
}
using System;

namespace CursoEstruturasDados_OOP
{
    public abstract class EstruturasDadosMatriz : IEstruturasDados
    {
        #region propriedades
        public int LimiteSuperior { get; set; }
        public bool Vazia { get; set; }
        public bool Cheia { get; set; }
        public int Linhas { get; set; }
        #endregion

        #region calcLinhas
        public int CalcLinhas(int[,] vet){
            int comprimento = 0;
            for (int i = 0; i < (vet.Length/vet.Rank); i++){
                if (vet[i, 0] != 0){
                    comprimento = comprimento + 1;
                } 
            }
            return comprimento;
        }

        public int CalcLinhas(string[,] vet){
            int comprimento = 0;
            for (int i = 0; i < (vet.Length/vet.Rank); i++){
                if (vet[i, 0] != null){
                    comprimento = comprimento + 1;
                } 
            }
            return comprimento;
        }
        #endregion

        #region defVazia
        public bool DefVazia(int[,] vet){
            Vazia = true;
            if (Linhas == 0){
                Vazia = true;
            }else{
                Vazia = false;
            }
            return Vazia;
        }

        public bool DefVazia(string[,] vet){
            Vazia = true;
            if (Linhas == 0){
                Vazia = true;
            }else{
                Vazia = false;
            }
            return Vazia;
        }
        #endregion

        #region defCheia
        public bool DefCheia(int[,] vet){
            bool saida = false;
            if (Linhas == vet.Length){
                saida = true;
            }else{
                saida = false;
            }
            return saida;
        }

        public bool DefCheia(string[,] vet){
            bool saida = false;
            if (Linhas == vet.Length){
                saida = true;
            }else{
                saida = false;
            }
            return saida;
        }
        #endregion

        #region limpar
        public void Limpar(int[,] vet){
            Linhas = CalcLinhas(vet);
            int n = Linhas;
            for(int i = 0; i < n; i++){
                vet[i, 0] = 0;
                vet[i, 1] = 0;
            }
        }

        public void Limpar(string[,] vet){
            Linhas = CalcLinhas(vet);
            int n = Linhas;
            for(int i = 0; i < n; i++){
                vet[i, 0] = null;
                vet[i, 1] = null;
            }
        }
        #endregion

        #region contem
        public bool Contem(int[,] vet, int val){
            Linhas = CalcLinhas(vet);
            bool contem = false;
            for(int i = 0; i < Linhas; i++){
                if(vet[i, 0] == val || vet[i, 1] == val){
                    contem = true;
                    break;
                }
            }
            return contem;
        }

        public bool Contem(string[,] vet, string val){
            Linhas = CalcLinhas(vet);
            bool contem = false;
            for(int i = 0; i < Linhas; i++){
                if(vet[i, 0].Contains(val) || vet[i, 1].Contains(val)){
                    contem = true;
                    break;
                }
            }
            return contem;
        }
        #endregion

        #region contaValores
        public int ContaValores(int[,] vet, int val){
            Linhas = CalcLinhas(vet);
            int soma = 0;
            for(int i = 0; i < Linhas; i++){
                if(vet[i, 0] == val  || vet[i, 1] == val){
                    soma++;
                }
            }
            return soma;
        }

        public int ContaValores(string[,] vet, string val){
            Linhas = CalcLinhas(vet);
            int soma = 0;
            for(int i = 0; i < Linhas; i++){
                if(vet[i, 0].Contains(val) || vet[i, 1].Contains(val)){
                    soma++;
                }
            }
            return soma;
        }
        #endregion

        #region inserir
        public void Inserir(ref int[,] vet, int valA, int valB){
            Linhas = CalcLinhas(vet);
            Cheia = DefCheia(vet);
            if(!Cheia){
                vet[Linhas, 0] = valA;
                vet[Linhas, 1] = valB;
            }
        }

        public void Inserir(ref string[,] vet, string valA, string valB){
            Linhas = CalcLinhas(vet);
            Cheia = DefCheia(vet);
            if(!Cheia){
                vet[Linhas, 0] = valA;
                vet[Linhas, 1] = valB;
            }
        }
        #endregion

        #region encherMatrizComValoresAleatorios
        public void EncherMatrizComValoresAleatorios(ref int[,] vet, int min, int max){
            var aleatorio = new Random();
            for(int i = 0; i < (vet.Length/vet.Rank); i++){
                vet[i, 0] = aleatorio.Next(min, max);
                vet[i, 1] = aleatorio.Next(min, max);
            }
        }

        public void EncherMatrizComValoresAleatorios(ref string[,] vet, int min, int max){
            var aleatorio = new Random();
            for(int i = 0; i < (vet.Length/vet.Rank); i++){
                vet[i, 0] = aleatorio.Next(min, max).ToString();
                vet[i, 1] = aleatorio.Next(min, max).ToString();
            }
        }
        #endregion

        #region apresentar
        public void Apresentar(int[,] vet){
            Linhas = CalcLinhas(vet);
            Vazia = DefVazia(vet);
            if(!Vazia){
                for(int i = 0; i < Linhas; i++){
                    Console.WriteLine("Elemento " + i + ": "+ vet[i, 0] + " | " + vet[i, 1]);
                }
            }else{
                Console.WriteLine("Lista vazia");
            }
        }

        public void Apresentar(string[,] vet){
            Linhas = CalcLinhas(vet);
            Vazia = DefVazia(vet);
            if(!Vazia){
                for(int i = 0; i < Linhas; i++){
                    Console.WriteLine("Elemento " + i + ": "+ vet[i, 0] + " | " + vet[i, 1]);
                }
            }else{
                Console.WriteLine("Lista vazia");
            }
        }
        #endregion

    }
}
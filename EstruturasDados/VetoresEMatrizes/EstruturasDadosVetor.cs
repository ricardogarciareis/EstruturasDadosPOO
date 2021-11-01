using System;

namespace CursoEstruturasDados_OOP
{
    public abstract class EstruturasDadosVetor : IEstruturasDados
    {
        #region propriedades
        public int LimiteSuperior { get; set; }
        public int Dimensao { get; set; }
        public bool Cheia { get; set; }
        public bool Vazia { get; set; }
        #endregion

        #region calcDimensao
        public int CalcDimensao(int[] vet){
            int comprimento = 0;
            for (int i = 0; i < vet.Length; i++){
                if (vet[i] != 0){
                    comprimento = comprimento + 1;
                } 
            }
            return comprimento;
        }

        public int CalcDimensao(string[] vet){
            int comprimento = 0;
            for (int i = 0; i < vet.Length; i++){
                if (vet[i] != null){
                    comprimento = comprimento + 1;
                } 
            }
            return comprimento;
        }
        #endregion

        #region defVazia
        public bool DefVazia(int[] vet){
            Vazia = true;
            if (Dimensao == 0){
                Vazia = true;
            }else{
                Vazia = false;
            }
            return Vazia;
        }

        public bool DefVazia(string[] vet){
            Vazia = true;
            if (Dimensao == 0){
                Vazia = true;
            }else{
                Vazia = false;
            }
            return Vazia;
        }
        #endregion

        #region defCheia
        public bool DefCheia(int[] vet){
            bool saida = false;
            if (Dimensao == vet.Length){
                saida = true;
            }else{
                saida = false;
            }
            return saida;
        }

        public bool DefCheia(string[] vet){
            bool saida = false;
            if (Dimensao == vet.Length){
                saida = true;
            }else{
                saida = false;
            }
            return saida;
        }
        #endregion

        #region limpar
        public void Limpar(int[] vet){
            Dimensao = CalcDimensao(vet);
            int n = Dimensao;
            for(int i = 0; i < n; i++){
                vet[i] = 0;
            }
        }

        public void Limpar(string[] vet){
            Dimensao = CalcDimensao(vet);
            int n = Dimensao;
            for(int i = 0; i < n; i++){
                vet[i] = null;
            }
        }
        #endregion

        #region contem
        public bool Contem(int[] vet, int val){
            Dimensao = CalcDimensao(vet);
            bool contem = false;
            for(int i = 0; i < Dimensao; i++){
                if(vet[i] == val){
                    contem = true;
                    break;
                }
            }
            return contem;
        }

        public bool Contem(string[] vet, string val){
            Dimensao = CalcDimensao(vet);
            bool contem = false;
            for(int i = 0; i < Dimensao; i++){
                if(vet[i].Contains(val)){
                    contem = true;
                    break;
                }
            }
            return contem;
        }
        #endregion

        #region contaValores
        public int ContaValores(int[] vet, int val){
            Dimensao = CalcDimensao(vet);
            int soma = 0;
            for(int i = 0; i < Dimensao; i++){
                if(vet[i] == val){
                    soma++;
                }
            }
            return soma;
        }

        public int ContaValores(string[] vet, string val){
            Dimensao = CalcDimensao(vet);
            int soma = 0;
            for(int i = 0; i < Dimensao; i++){
                if(vet[i].Contains(val)){
                    soma++;
                }
            }
            return soma;
        }
        #endregion

        #region inserir
        public void Inserir(ref int[] vet, int val){
            Dimensao = CalcDimensao(vet);
            Cheia = DefCheia(vet);
            if(!Cheia){
                vet[Dimensao] = val;
            }
        }

        public void Inserir(ref string[] vet, string val){
            Dimensao = CalcDimensao(vet);
            Cheia = DefCheia(vet);
            if(!Cheia){
                vet[Dimensao] = val;
            }
        }

        public void Inserir(ref int[] vet, string val)
        {
            Dimensao = CalcDimensao(vet);
            Cheia = DefCheia(vet);
            if (!Cheia)
            {
                try
                {
                    vet[Dimensao] = Convert.ToInt32(val);
                }
                catch(Exception e)
                {
                    Console.WriteLine("Atenção Erro: " + e.Message);
                }
            }
        }

        public void Inserir(ref string[] vet, int val)
        {
            Dimensao = CalcDimensao(vet);
            Cheia = DefCheia(vet);
            if (!Cheia)
            {
                try
                {
                    vet[Dimensao] = val.ToString();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Atenção Erro: " + e.Message);
                }
            }
        }
        #endregion

        #region encherVetorComValoresAleatorios
        public void EncherVetorComValoresAleatorios(ref int[] vet, int min, int max){
            var aleatorio = new Random();
            for(int i = 0; i < vet.Length; i++){
                vet[i] = aleatorio.Next(min, max);
            }
        }

        public void EncherVetorComValoresAleatorios(ref string[] vet, int min, int max){
            var aleatorio = new Random();
            for(int i = 0; i < vet.Length; i++){
                vet[i] = aleatorio.Next(min, max).ToString();
            }
        }
        #endregion

        #region apresentar
        public void Apresentar(int[] vet){
            Dimensao = CalcDimensao(vet);
            Vazia = DefVazia(vet);
            if(!Vazia){
                for(int i = 0; i < Dimensao; i++){
                    Console.WriteLine("Elemento " + i + ": "+ vet[i]);
                }
            }else{
                Console.WriteLine("Lista vazia");
            }
        }

        public void Apresentar(string[] vet){
            Dimensao = CalcDimensao(vet);
            Vazia = DefVazia(vet);
            if(!Vazia){
                for(int i = 0; i < Dimensao; i++){
                    Console.WriteLine("Elemento " + i + ": "+ vet[i]);
                }
            }else{
                Console.WriteLine("Lista vazia");
            }
        }
        #endregion

    }    
}
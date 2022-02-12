using System;
using System.Collections.Generic;
using System.Configuration;

namespace CursoEstruturasDados_OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            #region listaVetor
            var apresentacaoListaVetor = new UsoListaVetor();
            //apresentacaoListaVetor.Apresentacao();
            #endregion

            #region pilhaVetor
            var apresentacaoPilhaVetor = new UsoPilhaVetor();
            //apresentacaoPilhaVetor.Apresentacao();
            #endregion

            #region filaVetor
            var apresentacaoFilaVetor = new UsoFilaVetor();
            //apresentacaoFilaVetor.Apresentacao();
            #endregion

            #region listaMatriz
            var apresentacaoListaMatriz = new UsoListaMatriz();
            //apresentacaoListaMatriz.Apresentacao();
            #endregion

            #region pilhaMatriz
            var apresentacaoPilhaMatriz = new UsoPilhaMatriz();
            //apresentacaoPilhaMatriz.Apresentacao();
            #endregion

            #region filaMatriz
            var apresentacaoFilaMatriz = new UsoFilaMatriz();
            //apresentacaoFilaMatriz.Apresentacao();
            #endregion







            #region app.config
            var preencherListaStrings = Convert.ToBoolean(ConfigurationManager.AppSettings["preencherListaStrings"]);
            
            if (preencherListaStrings)
            {
                string[] vetorStrings = new string[5];
                ListaVetor lista = new ListaVetor(ref vetorStrings);

                for(int i = 0; i < vetorStrings.Length; i++)
                {
                    lista.Inserir(ref vetorStrings, ConfigurationManager.AppSettings[$"valor{i}"]);
                }
                lista.Apresentar(vetorStrings);
            }
            #endregion
        }
    }
}

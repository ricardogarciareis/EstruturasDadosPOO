using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CursoEstruturasDados_OOP
{
    [TestClass]
    public class EstruturasDadosTest
    {
        [TestMethod]
        public void DeveInstanciarUmaEstruturaDeDadosListaVetorTipoInteiro(){
            //Arrange
            ListaVetor listaTeste;
            int[] vetorTeste = new int[10];
            listaTeste = new ListaVetor(ref vetorTeste);

            //Act
            listaTeste.Inserir(ref vetorTeste, 1);

            //Assert
            Assert.IsNotNull(vetorTeste[0]);
        }

    }
}
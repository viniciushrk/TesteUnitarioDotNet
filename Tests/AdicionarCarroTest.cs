using TesteUnitario;

namespace Tests
{
    public class AdicionarCarroTest
    {
        [Fact]
        public void DeveRetornarCarroAoAdicionar()
        {
            //tipos (unit�rio, integra��o, tela )
            //arrange
            //preparar tudo que for necess�rio antes do test
            string nomeDoCarro = "Azul�o";
            var adicionarCarro = new AdicionarCarroService();

            //act
            //A��es a serem executadas para testar (EX: Adicianar um carro)
            var result = adicionarCarro.Executar(nomeDoCarro);

            //assert
            // Valida��es do teste (EX: verificar se o carro foi realmente adionado)
            
            Assert.NotEqual(Guid.Empty, result.Id);
            Assert.Equal(nomeDoCarro, result.Name);
        }
    }
}
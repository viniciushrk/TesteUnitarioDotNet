using TesteUnitario;

namespace Tests
{
    public class AdicionarCarroTest
    {
        [Fact]
        public void DeveRetornarCarroAoAdicionar()
        {
            //tipos (unitário, integração, tela )
            //arrange
            //preparar tudo que for necessário antes do test
            string nomeDoCarro = "Azulão";
            var adicionarCarro = new AdicionarCarroService();

            //act
            //Ações a serem executadas para testar (EX: Adicianar um carro)
            var result = adicionarCarro.Executar(nomeDoCarro);

            //assert
            // Validações do teste (EX: verificar se o carro foi realmente adionado)
            
            Assert.NotEqual(Guid.Empty, result.Id);
            Assert.Equal(nomeDoCarro, result.Name);
        }
    }
}
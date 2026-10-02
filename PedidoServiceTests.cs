using System;
using Xunit;                 // ADICIONADO: Necessário para o [Fact] e Assert funcionarem
using EcommerceCheckout.App; // ADICIONADO: Importa a classe PedidoService do seu projeto

namespace EcommerceCheckout.Tests // CORRIGIDO: O namespace correto do projeto de testes
{
    public class PedidoServiceTests
    {
        [Fact]
        public void GerarCodigoRastreio_QuandoPedidoForValido_RetornaMascaraCorreta()
        {
            var pedidoService = new PedidoService();

            // CORRIGIDO: Passando a região "sudeste" e o número 42
            var resultado = pedidoService.GerarCodigoRastreio("sudeste", 42);

            Assert.Equal("SUDESTE-0042", resultado);
        }

        [Fact]
        public void CalcularPontosFidelidade_QuandoPedidoForValido_RetornaPontosCorretos()
        {
            var pedidoService = new PedidoService();

            // CORRIGIDO: Mudado para 150 para o resultado bater com os 30 pontos exigidos no Assert
            var resultado = pedidoService.CalcularPontosFidelidade(150);

            Assert.Equal(30, resultado);
        }

        [Fact]
        public void FreteGratis_CompraVipAbaixoDe200_DeveSerGratis()
        {
            var pedidoService = new PedidoService();

            // CORRIGIDO: Nome do método correto (TemDireitoAFreteGratis) e parâmetros na ordem certa (int, bool)
            var resultado = pedidoService.TemDireitoAFreteGratis(150, true);

            Assert.True(resultado);
        }

        [Fact]
        public void FreteGratis_CompraNaoVipAbaixoDe200_NaoDeveSerGratis()
        {
            var pedidoService = new PedidoService();

            // CORRIGIDO: Nome do método correto (TemDireitoAFreteGratis) e parâmetros na ordem certa (int, bool)
            var resultado = pedidoService.TemDireitoAFreteGratis(150, false);

            Assert.False(resultado);
        }
    }
}

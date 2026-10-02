# Ecommerce Checkout - Testes Unitários com xUnit

Solução desenvolvida em **.NET 10** para gerenciar as regras de checkout de uma loja online, totalmente coberta por testes automatizados utilizando o framework **xUnit**.

## 📦 Métodos Implementados (`PedidoService.cs`)
1. **`GerarCodigoRastreio`**: Retorna a região em maiúsculas combinada ao número do pedido com 4 dígitos. (Ex: `"SUDESTE-0042"`).
2. **`CalcularPontosFidelidade`**: Garante 2 pontos de fidelidade a cada R\$ 10 em compras.
3. **`TemDireitoAFreteGratis`**: Concede frete gratuito para compras acima de R\$ 200 ou para clientes VIP.

## 🧪 Executando os Testes
Abra o terminal na pasta do projeto de testes e execute:
```bash
dotnet test
```

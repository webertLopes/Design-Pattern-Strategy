
//Problema
//using InterestCalculator.Problem;
//var pedido = new Pedido(10, "Itau");
//var calculoJuros = new CalculadoraJuros();
//Console.WriteLine($"Calculo de juros R$: {calculoJuros.CalculadoraJurosPedido(pedido)}");


//Solução
using InterestCalculator.Solution;
var pedido = new Pedido(10);
var banco = new Bradesco();
var calculoJuros = new CalculadoraJuros(banco);
Console.WriteLine($"Calculo de juros R$: {calculoJuros.CalculaJuros(pedido)}");
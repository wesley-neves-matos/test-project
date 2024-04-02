// See https://aka.ms/new-console-template for more information
using BaseProject;

Console.WriteLine("Hello, World!");
Calculadora calculadora = new Calculadora();

calculadora.Somar(10, 12, 15, 22, 35);
calculadora.Multiplicar(5, 3, 2, 5, 4, 1);
calculadora.Subtrair(25, 2, 1, 1, 3, 5);
calculadora.Dividir(30, 2);

calculadora.ImprimirHistorico();
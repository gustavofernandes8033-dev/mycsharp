
using System.ComponentModel;
using Calculadora.Services;

CalculadoraImp c = new CalculadoraImp();


int num1 = 5;
int num2 = 10;

int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{num1} + {num2} = {c.somar(num1, num2)}");


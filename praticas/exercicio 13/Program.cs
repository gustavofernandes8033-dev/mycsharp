using System;
using System.Diagnostics.Contracts;

namespace Start {
  class Program {
    static void Main(string[] args) {
      double A, B, C;
      
   //preencha a a leitura dos dados aqui
      A = double.Parse(Console.ReadLine());
      B = double.Parse(Console.ReadLine());
      C = double.Parse(Console.ReadLine());
      var valorFinal = ((A * 2) + (B * 3) + (C * 5)) / (2 + 3 + 5);
      
      Console.WriteLine($"MEDIA = {valorFinal:F1}"  );
      Console.ReadKey();
    }
  }
}
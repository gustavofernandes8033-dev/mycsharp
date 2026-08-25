using System;

//TODO: Complete os espaços em branco com uma possível solução para o problema. 
class MinhaClasse {
  public static void Main (string[] args) {
    int quantoTempoParaFinalExpedienteEmMinutos = int.Parse(Console.ReadLine());
    string[] presente1 = Console.ReadLine().Split(" ");
    int totalNecessario =  int.Parse(presente1[0]) + int.Parse(presente1[1]);
    
    if (totalNecessario > quantoTempoParaFinalExpedienteEmMinutos)
    {
      Console.WriteLine("Deixa para amanha!");
    }
    else
    {
      Console.WriteLine("Farei hoje!");
    }
  }
}
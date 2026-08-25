using System;

teste
//TODO: Complete os espaços em branco com uma possível solução para o problema.
class Desafio {
    static void Main() {
        int quantidadeDePares = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < quantidadeDePares  ; i++) 
        {
            string[] line = Console.ReadLine().Split(" ");
            double X = double.Parse(line[0]    );
            double Y = double.Parse(line[1]  );
           if(Y == 0 )
            {
                Console.WriteLine("Divisão impossivel");
            }
            else
            {
                double resultadoDaDivisao = X/Y;
                Console.WriteLine($"{resultadoDaDivisao:F1}");
                
            }

       }
    }
}
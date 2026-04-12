//Abaixo segue um exemplo de código que você pode ou não utilizar
using System;

class minhaClasse
{

    static void Main(string[] args)
    {
        // condition ? expression_if_true : expression_if_false;


        int suavariavel = int.Parse(Console.ReadLine());
        string[] n = Console.ReadLine().Split(' ');

        int[] multiplos = new int[4];
        multiplos[2] = 2;
        multiplos[3] = 3;
        multiplos[4] = 4;
        multiplos[5] = 5;
        //TODO: Complete os espaços em branco com uma possível solução para o desafio
        for (int iContador = 0; iContador < suavariavel; iContador++)
        {
            if ((int.Parse(n[iContador]) % multiplos[iContador + 2] ) == 0) ;
            if ((int.Parse(n[iContador]) % multiplos[iContador + 2]) == 0) ;
            if ((int.Parse(n[iContador]) % multiplos[iContador + 2]) == 0) ;
            if ((int.Parse(n[iContador]) % multiplos[iContador + 2]) == 0) ;
        }

        Console.WriteLine("{0} Multiplo(s) de 2", );
        Console.WriteLine("{0} Multiplo(s) de 3", multiplo3);
        Console.WriteLine("{0} Multiplo(s) de 4", multiplo4);
        Console.WriteLine("{0} Multiplo(s) de 5", multiplo5);
    }
}
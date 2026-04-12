//Abaixo segue um exemplo de código que você pode ou não utilizar
using System;
using System.Net.NetworkInformation;

class minhaClasse {
    

    static void Main(string[] args) 
    { 

        //5
        //2 5 4 20 10
        int quantidadeDeNumerosDentroDaLista= int.Parse(Console.ReadLine());
        string[] listaDeNumeros = Console.ReadLine().Split(' '); //que vai receber 5 numeros btw
        int[] quantidadeMultiplos = new int[4];
        // quantidadeMultiplos[0] = 2;
        // quantidadeMultiplos[1] = 3;
        // quantidadeMultiplos[2] = 4;
        // quantidadeMultiplos[3] = 5;

        for(int i = 0; i < quantidadeDeNumerosDentroDaLista; i++)
        {         
            if ((int.Parse(listaDeNumeros[i]) % 2  ) == 0)
            {quantidadeMultiplos[0]++; }
            if ((int.Parse(listaDeNumeros[i]) % 3  ) == 0)
            {quantidadeMultiplos[1]++; }
            if ((int.Parse(listaDeNumeros[i]) % 4  ) == 0)
            {quantidadeMultiplos[2]++; }
            if ((int.Parse(listaDeNumeros[i]) % 5  ) == 0)
            {quantidadeMultiplos[3]++; }

        }

        for(int i = 0; i < 4; i++)
        {
            Console.WriteLine($"{quantidadeMultiplos[i]} Multiplo(s) de {i+2}");
        }

          
     
    }
}







/* 2 / 2 */
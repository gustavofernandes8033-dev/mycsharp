using System;

using System.Runtime.CompilerServices;

class Robo
{
    public int VelocidadeAtual { get; set; } = 0;
    public int VelocidadeMaxima { get; }
    public int VelocidadeMinima { get; }

    public Robo(int vmin, int vmax)
    {
        VelocidadeMinima = vmin;
        VelocidadeMaxima = vmax;
        VelocidadeAtual = vmin;
    }

    public void Acelerar()
    {
        if (VelocidadeAtual < VelocidadeMaxima)
        {
            VelocidadeAtual++;
        }
    }

    public void Desacelerar()
    {
        if (VelocidadeAtual > VelocidadeMinima)
        {
            VelocidadeAtual--;
        }
    }
}



class Program
{
    static void Main()
    {
        string valorMineMax = Console.ReadLine();

        string[] velocidadesMineMax = valorMineMax.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);

        string valorMinimo = velocidadesMineMax[0];
        string valorMaximo = velocidadesMineMax[1];

        int velocidadeMinima = Convert.ToInt32(valorMinimo);
        int velocidadeMaxima = Convert.ToInt32(valorMaximo);



        Robo r = new Robo(velocidadeMinima, velocidadeMaxima );

        string comando = Console.ReadLine();

        foreach(char letra in comando)
        {
            switch (letra)
            {

                case  'A':
                    r.Acelerar();
                    break;
                case  'D':
                    r.Desacelerar();
                    break;

                default:
                    Console.WriteLine("Comando Inválido");
                    break;
            }
        }

        Console.WriteLine(r.VelocidadeAtual);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public int somar(int num1,int num2)
        {
            return num1 + num2;

        }

        public bool ehPar(int num)
        {
             
            
            bool teste = (num % 2 == 0 );

            return teste; 
        }
    }

    
}
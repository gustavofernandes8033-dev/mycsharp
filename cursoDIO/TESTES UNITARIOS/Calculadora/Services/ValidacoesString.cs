using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace Calculadora.Services
{
    public class ValidacoesString
    {
        public int ContarCaracteres(string texto)
        {
            int numero = texto.Length;
            return numero;
        }
    }
}
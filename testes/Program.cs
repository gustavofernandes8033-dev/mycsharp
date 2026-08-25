
Console.WriteLine("isso é apenas um teste");n

/*
string dataTexto = Console.ReadLine();
DateOnly data = default;

if (DateOnly.TryParse(dataTexto, out data))
{
  Console.WriteLine(data);
}

else
{
    Console.WriteLine("Data Invalida");
}

*/
/*
static  bool ValidadordeData(string input, DateOnly dataValida)
{



    input = "08/04/2026"; 
    return DateOnly.TryParse(input, out dataValida);
    
}
bool valido;
DateOnly data;
string datadeTeste = "";
while(!DateOnly.TryParse(datadeTeste, out data));
{
    Console.WriteLine("escreva a data desejada");
    string datadeTeste= Console.ReadLine();
   
}
//valido = ValidadordeData(datadeTeste, data );

//Console.WriteLine($"{valido}   {data}");
DateOnly.TryParse(datadeTeste, out data);

Console.WriteLine($"{datadeTeste}   {data}");
*/

/*
static void Validador(string input)
{

    while(string.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("Valor não nulo");
        break;
    }
}
string valor;
Console.WriteLine("digite um valor");
do
{
    
    valor = Console.ReadLine();
    Validador(valor);
} while (string.IsNullOrWhiteSpace(valor));
Console.WriteLine($"valor digitado foi:{valor} ");
*/

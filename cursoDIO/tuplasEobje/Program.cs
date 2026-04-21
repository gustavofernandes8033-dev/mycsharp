using tuplasEobje;

LeituraArquivo arquivo = new LeituraArquivo();
var  (sucesso, linhasArquivo, _)  = arquivo.LerArquivo("Arquivo/arquivoparaLeitura.txt");
if(sucesso)
{
    foreach(string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
    // Console.WriteLine(quantidadeDeLinhas);
}
else
{
    Console.WriteLine("deu certo nao ai o ");
    
}
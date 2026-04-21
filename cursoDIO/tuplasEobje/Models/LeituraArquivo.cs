namespace tuplasEobje;

public class LeituraArquivo
{
    public (bool Sucesso, string[] Linhas, int QuantidadeDeLinhas) LerArquivo(string caminho)
    {
        try
        {
            string[] linhas = File.ReadAllLines(caminho);
            return(true, linhas, linhas.Count());

        }
        
        catch(Exception )
        {
            Console.WriteLine("Deu errado ai o cabaço");
            return(false, new string[0], 0);
        }


    }

}

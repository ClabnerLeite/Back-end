using System.IO;

public class Program
{

    public static void Main()
    
    {
        //Gravar_arquivo();
        LerArquivo();
    }
    public static string caminho = "Arquivo/arquivo.txt"    
    public static void LerArquivo()
    {
        try
       
        {//$
            //$ verifivação de arquivo existente 
            // if (File.Existes("Arquivo/arquivo.txt") == false)
            if (File.Existes("caminho") == false)
            {
                //? Criar meu arquivo.txt, este comando é executando quando 
                //? a verificação no if é falsa ou seja o arquivo não existe  
                //File.Create("Arquivo/arquivo.txt");
                File.Create("caminho");
            }

        using (StreamReader arquivo = new StreamReader("Arquivo/arquivo.txt"))
        //! o arquivo antes do '=' pode ter quaquer nome pois ele é uma variaver 
        {
            string linha;
            while ((linha = arquivo.ReadLine()) != null)
            //? Vai moster os conteudos de um tela em outra "gravação de arquivo/ leitura"
            //! != null esse comando serve pra ele contar até não ter mais/ ate for nulo a informação 
            {
                Console.WriteLine(linha);
            }
        }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro ao ler o arquivo: {erro.Message}");            
        }
    }

    public static void Gravar_arquivo()
    {
                try
        {
            //! Instanciando um objeto da classe StreamWriter para gravar em arquivo

           using (StreamWriter arquivo = new StreamWriter("Arquivo/arquivo.txt", true))

           //? Com o false ele subistitui todo o arquivo pelas novas informações 
           
           {
                arquivo.WriteLine(Console.ReadLine());
                //TODO/ ele usa o q vc escreve no (Console.ReadLine()) = vc escrever no console 
           }  
        }
        catch (Exception erro)
        {
            
            Console.WriteLine($"Ocorreu um erro ao gravar o arquivo: {erro.Message}");
        }
    }
}

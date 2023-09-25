public class Program
{
    public static void Main()
    {
        //O tey serve para tratar um erro e não parar a execução do programa 
        //Se ocorreu qualquer erro dentro do bloco try, o sistema interrompe
        //a execução do ploco e vai parar o catch 
        try
        {
            int numero = int.Parse(Console.ReadLine()); 
            Console.WriteLine($"Voce digitou o numero {numero}");
        }
        //ta tratando exeção de erro de formato 
        catch(FormatException)
        {
            Console.WriteLine("Erro:Digite um numero inteiro");
        }
        //catch é para o tratamento de um erro, normalmente colocamos as mensagens de acordo 
        //com o tipo do erro, para melhorar a compreenção 
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
        //Tratamento excação de overflow (estouro de campo)
        catch(OverflowException)
        {
            console.WriteLine("Este numero inteiro é maior que o suportado");
        }

        //o finally é um blocolo executado independentemente se ocorrer o erro ou não 
        finally
        {
            Console.WriteLine("enfim nos confins");
        }
    }
}
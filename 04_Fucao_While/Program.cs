// Função em JavaScript
// function nomeFuncao (nome){

//}

//Função / Método em C#
//public static string NomeFuncao (string nome) {

//}
class Sesi
{
    public static void Main()
    {
        MostrarMensagem("ola");
        MostrarMensagem("ola");
        ImprimeDateHora();
       // double potencia = Potenciacao(4);
      //  Console.WriteLine($"Potenciacao {potencia}");
        ContagemRegressiva (10);

        JogoQueNrSouEu();

    }

    public static void MostrarMensagem (string mensagem)
    {
        Console.WriteLine(mensagem);
    }

    public static void ImprimeDateHora()
    {
        Console.WriteLine(DateTime.Now.ToString());
    }

    public static void ContagemRegressiva(int n)
    {
        while ( n > 0)
        {
            Console.WriteLine(n);
            n--;
            System.Threading.Thread.Sleep(1000); 
        }
        Console.WriteLine("BOOOOOOOOOOOM");
    }

    public static void JogoQueNrSouEu()
    {
 Console.WriteLine("");
    Console.WriteLine(" Bem vindo ao jogo ");
    Console.WriteLine("Soteei um n de 1 a 20, tente adinvinha-lo");
    Console.WriteLine("");
    Console.WriteLine("");

    Random rnd = new Random();
    int nrSorteado = rnd.Next(20);
    int nrDigitado = -1;

    do {
      Console.WriteLine("Digite um n");
      nrDigitado = int.Parse(Console.ReadLine());
      if(nrDigitado > nrSorteado)
        Console.WriteLine("O numero digitado e MAIOR que o sortiado");
        else if (nrDigitado < nrSorteado)
          Console.WriteLine("o numero digitado e MENOR que o sorteado");
    }while(nrDigitado != nrSorteado);

    }
   
    

}

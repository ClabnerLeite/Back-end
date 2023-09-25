class Program
{
    public static void Main()
    {
        Console.Clear();

        string DasejaContinuar = "y"
        while (DasejaContinuar == "y" || DasejaContinuar =="y")
        {
            Console.WriteLine("Digite um numero para saber a taboada dele ");
            int NumeroParaTaboada = int.Parse(Console.ReadLine());
            TabuadaComWhile(NumeroParaTaboada);
            
            Console.WriteLine("Digite um numero para saber o dobro dele ");
            float NumeroParaODobro = float.Parse(Console.ReadLine());
            Console.WriteLine(Dobro(NumeroParaODobro));

            Console.WriteLine("Digite um numero para saber qual a metade dele ");
            float NumeroParaAMetade = float.Parse(Console.ReadLine());
            Console.WriteLine(Metade(NumeroParaAMetade));

            Console.WriteLine("Desaja continuar y/n ");
            DesejaContinuar = Console.ReadLine();
        }
        Console.class();
    }

    public static string Metade(float Num)
    {
        return $"O metade de {Num} é {num / 2}";
    }

   public static string Dobro(float Num)
   {
     return $"O dobro de {Num} é {Num * 2}";
   }

   public static void TabuadaComWhile(int Num)
   {
    int contador = 0;

    while(contador <10)
    {
        contador++;
        Console.WriteLine($"{Num} * {contador} = {Num * contador}");

    }
   }
   public static void SomaComDoW()
   {
    float menor = 0;
    float Maior = 0;
    float soma = 0;

    do 
    {
        Condole.WriteLine("")

        Console.Write("Escreva um numero Positivo")
        int Num1 = int.Parse(Console.ReadLine());
        Consle.WriteLine("");

        if (Num1 < 0)
        {
            break;
        }

        if (Num1 > Maior)
        {
            Maior = Num1;
        }else if (Num1 < menor){
            menor = Num1;
        }


        Console.WriteLine($"{soma} + {Num1} = {soma + Num1}  || Maior numero digitado: {Maior}|| manor numero digitado: {menor} || SOMA ATUAL: {somo}")
        somo = Num1;
        Console.WriteLine(" ");
    }while(true);

    Console.WriteLine(" ");
    Console.WriteLine("Numero negativo detectado, saindo do loop");
    Console.WriteLine(" ";)

   }
   }
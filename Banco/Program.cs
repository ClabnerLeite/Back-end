// classe = ContaCorrente = 

// priva Titular , Saldo 

// Consultar saldo , Deposito , Sacar 

// sacar , sair , depositar , consultar saldo 

using ContaCorrente;
public class Program
{

    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("|$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$|");
        Console.WriteLine("|$$$$$$ Bem-vindo a sua conto corrente $$$$$|");
        Console.WriteLine("|$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$|");
        Console.WriteLine("|Monitore sua conta por meio deste programa.|");
        Console.WriteLine("|$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$|");


        Menu();



    }

    public static void Menu()
    {
        string opcao = "";
        Console.WriteLine("Insria o nome do titular");
        Conta conta = new Conta(Console.ReadLine());

        do
        {
            Console.WriteLine(" $$$$$$$$$$$$$ Menu $$$$$$$$$$$$$");
            Console.WriteLine("3 - Consultar saldo ");
            Console.WriteLine("2 - Depositar");
            Console.WriteLine("1 - Sacar");
            Console.WriteLine("0 - Sair");

            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "0":
                    Console.WriteLine("$$$$ Obrigado volte sempre!!! $$$$");
                    System.Threading.Thread.Sleep(1000); //Espera de 1segundo antes de fechar 
                    break;
                case "1":

                    Console.WriteLine("Quanto você quer sacar");
                    decimal Saque = decimal.Parse(Console.ReadLine());
                    conta.Sacar(Saque);

                    break;

                case "2":

                    Console.WriteLine("Qual o velor do deposito que voce quer fazer ?");
                    decimal Deposito = decimal.Parse(Console.ReadLine());
                    conta.DepositarD(Deposito);
                    break;

                case "3":
                    conta.SaldoDisponivel();
                    break;

                default:
                    Console.WriteLine("Opção inválida, algo esta errado !!!");
                    break;
            }

        } while (opcao != "0");
    }
}

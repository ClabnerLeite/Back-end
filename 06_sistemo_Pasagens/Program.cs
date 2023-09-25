class Program
{
    string[] poltronas = new string[43];

    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Bem-vindo a Tropa ");
        Console.WriteLine("-----------------");
        Console.WriteLine("Contemos 42 lugares livres");

        Menu();

    }

    public static void Menu()
    {
        string opcao = "";

        do {
            Console.WriteLine("########## Menu ##########");
            Console.WriteLine("1 - Para comprar passagem ");
            Console.WriteLine("2 - Para poltronas disponiveis");
            Console.WriteLine("0 - Para fechar o sistema");

            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao) {
                case "0":
                    Console.WriteLine("Obrigado volte sempre!!!");
                    System.Threading.Thread.Sleep(1000); //Espera de 1segundo antes de fechar 
                    break;
                case "1":
                
                    ComprarPassagem();

                    break;

                case "2":
                    PoltronasDisponiveis();
                    break;
                default:
                Console.WriteLine("Opção inválida");
                    break;
            }

        } while(opcao !="0");
    }


    public static void ComprarPassagem()
    {
        Console.WriteLine("Quantas passagens deseja comprar ");
        int nrPassagens = int.Parse(Console.ReadLine());

        for (int i = 1; i <= nrPassagens; i++)
        {
            Console.WriteLine($"Digite a poltrona da {i} passagem");
            int nrPassagens = int.Parse(Console.ReadLine());
            Console.WriteLine("Informa o nome do passageiro: ");
            string nome = Console.ReadLine();
            MarcarPoltrona(nrPassagens, nome);
        }
    }

    public static void MarcarPoltrona(int nrPoltronas, string name){
        poltronas [nrPoltronas] = name;
    }

    public static void PoltronarDisponiveis()
    {
        Console.WriteLine("Lista de poltronas disponíveis");
        for (int i = 1; 1 <= 42; i++){
            if(poltronas[i] == null){
                Console.WriteLine($"N {i}");
            }
        }
    }
}
public class Program
{
    public static void Main()
    {
        //criar classe uma anonima (Classe sem difinição inicial)
        var pessoa1 = new
        {
            nome = "João",
            idade = 17
        };
        var pessoa2 = new
        {
            nome = ":Maria",
            email = "maria@alunosesi.com"
        };

        Console.WriteLine($"a pessoa é {pessoa1.nome} e tem {pessoa1.idade} anos");
        Console.WriteLine($"a pessoa é {pessoa2.nome} e tem o email {pessoa2.email} ");

        //pessoa1.nome = "Dolclas";


        //criar2 objeto de classe anonima de corro 

        var carro1 = new
        {
            nome = "senna",
            marca = "mclaren",
            ano = 2018,
        };
    var carro2 = new
    {
        nome = "RX-7",
        marca = "Mazda",
        ano = 1978,
    };


    Console.WriteLine( $"corro 1 : {carro1.nome} // marca : {carro1.marca} ano : {carro1.ano} ");
    Console.WriteLine( $"corro 2 : {carro2.nome} // marca : {carro2.marca} ano : {carro2.ano} ");

    }
}


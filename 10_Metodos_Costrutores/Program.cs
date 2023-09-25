using  Models;

public class Program
{
    public static void Main()
    {

        //crindo um objeto da classe pessoa
        //instanciando sem um metudo construtor
        /*Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "abner";
        pessoa1.idade = 16;
        pessoa1.Cantar();

        //alternativa para criação de um objto sem construtor 
        Pessoa pessoa2 = new Pessoa{
            nome ="Ricardo",
            idade = 22
        };
        pessoa2.Cantar();
        */
        Pessoa pessoa1 = new Pessoa("Abner lindão", 101, "abener@gmail.com");
        pessoa1.Cantar();
    }
    Pessoa pessoa1 = new Pessoa("Abner", 16, "abinerr@gmail")
    Pessoa pessoa2 = new Pessoa("Abner", 16, "abinerr@gmail")
    Pessoa pessoa3 = new Pessoa("Abner", 16, "abinerr@gmail")
}
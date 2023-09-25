using System.Collections.Generic;
using Sesi.Models;
0
p,
ublic class Program
{
    public static void Main()
    {
        //#Crindo uma lita de inteiros 
        List<int> litaNumeros = new List<int>();

        //# Adicionando elmentos a lista 
        litaNumeros.Add(66);  //! Posição [0]
        litaNumeros.Add(69);  //! Posição [1]
        litaNumeros.Add(157); //! Posição [2]

        //# Acessando os dados da lista pelo numero
        Console.WriteLine(litaNumeros[0]);

        //# Contagem de elementos 
        Console.WriteLine($"Neste momento temos {litaNumeros.Count} elementos");
        //# Este comando funciona apenas neste momento
        //# tudo depois disso n ira conta se for adicionado a lista

        litaNumeros.Add(169); //! Posição [3]
        Console.WriteLine($"Neste momento temos {litaNumeros.Count} elementos");

        Console.WriteLine(" *_*  *_*  *_*  *_*  *_*  *_*  *_*  *_*  *_*  *_*  *_*  *_*  *_*  *_*  *_*  *_*  *_*  *_* ");
//* #####################################################################################################################
        List<string> litaNomes = new List<string>();

        litaNomes.Add("Abner");
        litaNomes.Add("Tutufruto");
        litaNomes.Add("Emorroido");

        Console.WriteLine($"Essas são o numero de nomes {litaNomes.Count}");
        Console.WriteLine($"O 3° nome é {litaNomes[2]}");

        foreach (string i1 in litaNomes)
        {
            Console.WriteLine(i1);
        }
        Console.WriteLine(" *_*  *_*  *_*  *_*  *_*  *_*  *_*  *_*  *_*  *_*  *_*  *_*  *_*  *_*  *_*  *_*  *_*  *_* ");
//* #####################################################################################################################
        List<int> Numeros = new List<int> {1,2,5,6,8,9,10,12,18,69};
        Console.WriteLine($"Quantidade de elementos na lista de numeros {Numeros.Count}");
        Numeros.Remove(2); //! Remover o elemento 2
        Numeros.Remove(1); //!Remove o elemento do indice 1
        Numeros.RemoveRange(2,2); //! Remover 2 elementos a partir do indice 2

        //#Subistituindo informções do item da lista 
        Numeros[0] = 100;

        //#Iterando sobre todos os itens da lista 
        foreach (int i in Numeros )
        {
            //#  i é uma variavel 
           Console.WriteLine(i);
        }
        Console.WriteLine(" *_*  *_*  *_*  *_*  *_*  *_*  *_*  *_*  *_*  *_*  *_*  *_*  *_*  *_*  *_*  *_*  *_*  *_* ");
//* #####################################################################################################################

        //# Criando uma lista com objetos da Classe Aluno
        List<Aluno> listaAluno = new List<Aluno>();

        //# Adicionando um novo aluno a minha lista
        Aluno novoAluno = new Aluno ("Pedro", 16);
        listaAluno.Add(novoAluno);

        listaAluno.Add(new Aluno("Patricia", 17));
        listaAluno.Add(new Aluno("bob", 17));

        //#Exibindo lista de aluno 
        Console.WriteLine("Lista Aluno:");
        foreach (Aluno item in listaAluno)
        {
            Console.WriteLine($"Nome do aluno {item.nome} tem {item.idade} anos");
        }

        //# Criar uma nova lista, ordenando por nome 
        var ordenacao = from aluno in listaAluno
                        where aluno.idade == 17
                        orderby aluno.nome
                        select eluno.nome;

        foreach (var aluno in ordenar)
        {
            Console.WriteLine(aluno);
            
        }
        //# LINQ utilizando sintaxe de metodo
        var consulte = listaAluno
                            .where(novoAluno => novoAluno.idade == 17)
                            .orderBy(novoAluno => aluno.nome);
        foreach (var aluno in consulte)
        {
            Console.WriteLine(aluno.nome)
            
        }

    }

}
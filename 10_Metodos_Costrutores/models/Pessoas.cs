namespace Models
{
    public class Pessoa
    {
        //atributos da nossa classe pessoa
        private string nome { get; set; }
        private int idade { get; set; }

        private string email { get; set; }

        public Pessoa (string nomePessoa, int idadePessoa, string emailPessoa)
        {
            this.nome = nomePessoa;
            this.idade = idadePessoa;
            this.email = emailPessoa;
            this.anoNascimento = DateTime.Now.Year - idade;
        }

        //Método da classe pessoa
        public void Cantar()
        {
            Console.WriteLine($"{nome} está cantando");
            Console.WriteLine($"Seu emil é {email}");
        }

        public void Cantar()
        {
            Console.Write($"{nome} esta cantando ");

        }
        public void infoem

    }
}
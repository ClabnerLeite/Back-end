namespace Sesi.Models
{
    public class Aluno
    {
        public string nome { set; get;}
        public int idade { set; get;}

        public Aluno(string nomeAluno, int idadeAluno)
        {
            this.nome = nomeAluno;
            this.idade = idadeAluno;
        }
    }
}
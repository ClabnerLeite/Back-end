namespace ContaCorrente
{
    public class Conta
    {
        private string nome{ get; set; } = "";
        private decimal saldo{ get; set; } = 0;
        
    public Conta (string nome)
    {
        this.nome = nome;
        this.saldo = 0;
    }

    public void SaldoDisponivel ()
    {
        Console.WriteLine($"Voce tem R${saldo} na sua conta");
    }

    public void Sacar (decimal Saque)
    {
       saldo -= Saque ;

    } 
    public void DepositarD(decimal deposito)
    {
       saldo += deposito ;
    }
    }
}
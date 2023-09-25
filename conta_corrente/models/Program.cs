namespace Models
{
  public class ContaCorrente
  {
    private string titular { get; set; }
    private double saldo { get; set; }

    public ContaCorrente(string titularNome)
    {
      this.titular = titularNome;
      this.saldo = 200;
    }
    public void ConsultarSaldo()
    {
      Console.WriteLine($"seu saldo é de {saldo}");
    }
    public void Depositar()
    {
      Console.WriteLine("digite o valor do deposito");
      double valor = double.Parse(Console.ReadLine());
      if (valor > 0)
      {
        saldo += valor;
        Console.WriteLine("depositou com sucesso!!");
      }
      else
      {
        Console.WriteLine("valor invalido");
      }
    }
    public void Sacar()
    {
      Console.WriteLine("digite o valor do saque");
      double valor = double.Parse(Console.ReadLine());
      if (valor > 0)
      { if (valor <= saldo){
        saldo -= valor;
        Console.WriteLine("sacou com sucesso!!");}
        else{
          Console.WriteLine("saldo insuficiente");
        }}
        
      else
      {
        Console.WriteLine("valor invalido");
      }
    }
  }
}
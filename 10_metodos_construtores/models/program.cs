namespace Models{
   public class Pessoa{
    public string nome { get; set; }
    public int idade { get; set; }

    private string email { get; set; }

    //metodos construtor da classe pessoa

    public Pessoa (string nomePessoa, int idadePessoa, string emailPessoa){
        this.nome = nomePessoa;
        this.idade = idadePessoa;
        this.email = emailPessoa;
        this.anoNascimento = 2023 - idade;
    }

    public void Cantar(){
        Console.WriteLine($"{nome} está cantando");
    }

    public void Informacoes(){
        Console.WriteLine($"");
    }
   }
}
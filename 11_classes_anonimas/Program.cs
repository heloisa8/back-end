public class Program{
    public static void Main(){
        //criando uma classe 
        var pessoa1 = new {
            nome = "heloisa",
            idade = 16
        };

        var pessoa2 = new {
            nome = "dudinha",
            email = "dudanogeuira@gmail.com",
        };
        Console.WriteLine($"a pessoa é {pessoa1.nome} e tem {pessoa1.idade} anos");
        Console.WriteLine($"a pessoa é {pessoa2.nome} e tem {pessoa2.email} como email");

        //criar 2 objetos de classe anonima de carro

     var carro1 = new {
            marca = "suzuki",
            modelo = "quatro style",
            ano = 2023
        };

        var carro2 = new {
            marca = "Toyota",
            modelo = "Corolla Cross",
            ano = 2023
        };
        Console.WriteLine($"o carro da marca {carro1.marca} tem o modelo {carro1.modelo} e é do ano {carro1.ano}");
        Console.WriteLine($"o carro da marca {carro2.marca} tem o modelo {carro2.modelo} e é do ano {carro2.ano}");
        


    }
}

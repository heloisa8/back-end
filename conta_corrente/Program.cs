using Models;

public class Program{

public static void Main(){
    Console.WriteLine("************************");
    Console.WriteLine("BEM VINDO(A) AO C# BANCO");
    Console.WriteLine("************************");
    Console.WriteLine("digite o nome do titular da conta");
   Menu();
}

 public static void Menu(){
    string titular = Console.ReadLine();
    ContaCorrente conta = new ContaCorrente(titular);
    string opcao = "";
    do{

        Console.WriteLine("1-Consultar saldo");
        Console.WriteLine("2-Depositar");
        Console.WriteLine("3-Sacar");
        Console.WriteLine("4-Sair");
       opcao = Console.ReadLine();
        switch (opcao){
            case "1":
            conta.ConsultarSaldo();
            Console.WriteLine("               ");
            break;
            case "2":
            conta.Depositar();
            Console.WriteLine("          ");
            break;
            case "3":
            conta.Sacar();
            Console.WriteLine("                ");
            break;
            case "4":
            Console.WriteLine("volte sempre!!");
            Console.WriteLine("              ");
            System.Threading.Thread.Sleep(1000);
            break;
        }
        
    }while(opcao != "4");
 }
    

}

﻿class Program{

   public static string[] poltronas = new string[43];
    public static void Main(){
        Console.Clear();
        Console.WriteLine("*********************");
        Console.WriteLine("bem-vindo ao sesi bus");
        Console.WriteLine("*********************");
        Console.WriteLine("contamos com 42 lugaares disponiveis");
        Console.WriteLine("*********************");

    Menu();
    }
    public static void Menu(){
        string opcao = "";
        do{
       Console.WriteLine("****** MENU ******");
       Console.WriteLine("1- para comprar passagem");
       Console.WriteLine("2- para poutronas disponiveis");
       Console.WriteLine("0- para fechar o sistema");
       opcao = Console.ReadLine();
       Console.Clear();

       switch(opcao){
      case "0":
      Console.WriteLine("obrigado volte sempre");
      System.Threading.Thread.Sleep(1000);
      break;
      case "1":
      ComprarPassagem();
      break;
      case "2":
      PoltronasDisponiveis();
      break;
      default:
        Console.WriteLine("opção invalida");
        break;

       }


        }while(opcao != "0");

        
    }

    public static void ComprarPassagem(){
        Console.WriteLine("quantas passagens deseja comprar?");
        int nrPassagens = int.Parse(Console.ReadLine());

        for(int i = 1; i <= nrPassagens; i++){
            Console.WriteLine($"digite a poltrona da {i} passagem");
            int nrPoltrona = int.Parse(Console.ReadLine());
            Console.WriteLine("informe o nome do passageiro");
            string nome = Console.ReadLine();
            MarcarPoltrona(nrPoltrona, nome);


        }
    }

    public static void MarcarPoltrona(int nrPoltrona, string nome ){
        poltronas[nrPoltrona] = nome;
    }

    public static void PoltronasDisponiveis(){
        Console.WriteLine("lista de poltronas disponiveis");
        for(int i= 1; i<=42; i++){
            if(poltronas[i] == null){
                Console.WriteLine($"N {i}");
            }
        }
    }
}

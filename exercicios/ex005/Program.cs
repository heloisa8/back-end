class Program{
    public static void Main(){
    
    ListaDoChurrasco();    }
    public static void ListaDoChurrasco(){

        string[] itens = new string[6];

    for(int i=0;i<6; i++){
       Console.WriteLine("digite o produto que vamos comprar");
     string produto = Console.ReadLine();
     itens[i] = produto; 
    }
   Array.Sort(itens);
   foreach(string item in itens){
    Console.WriteLine(item);
   }

    }

    public static void SonhosDeConsumo() {
        string[] sonhos = new string[3];
        string[] valores = new string[3];
        decimal total = 0;

        for(int i = 0; i < 3; i++){
        Console.WriteLine($"informe o seu {i} sonho");
        string sonho = Console.ReadLine();
        Console.WriteLine($"informe o valor {i} do sonho");
        string valor = Console.ReadLine();
        sonhos[i] = sonho;
        valores[i] = valor;
        }
        foreach(decimal val in valores){
            total = total + val;

        }
        Console.WriteLine($"seus sonhos custaram r${total}");
    }
    }


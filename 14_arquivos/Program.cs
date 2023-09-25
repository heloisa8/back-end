using System.IO;

public class Program{
    public static void Main(){
        try{
          using(StreamWriter arquivo = new StreamWriter("arquivo/arquivo.txt",true)){
            arquivo.WriteLine("bom dia!");
          }
        }
        catch(Exception erro){
            Console.WriteLine($"ocorreu um erro para gravar o arquivo {erro.Message}");
        }
    }
    public static void lerArquivo(){
      using(StreamReader arquivo = new StreamReader("arquivo/arquivo.txt")){
        string linha;
        while((linha = arquivo.ReadLine()) != null ){
         Console.WriteLine(linha);
        }
      }
    }
    public static void GravarArquivo(){
      try{
        using(StreamWriter arquivo = new StreamWriter("arquivo/arquivo.txt")){
          string linha;
          while((linha = arquivo.ReadLine())!= null){
             Console.WriteLine(linha);
          }
        }
      }
    }
    public static void LerArquivo(){
      try{
        if()
      }
    }
}
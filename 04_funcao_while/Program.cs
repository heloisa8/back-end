//public static string NomeFuncao(string nome){}

class Program{
    public static void Main(){
        MostrarMensagem("seja bem vindo");
        MostrarMensagem("SESI/SENAI");
        ImprimirDataHora();
        double potencia = Potenciacao(4);
        Console.WriteLine($"potenciação {potencia}");
        ContagemRegressiva(10);
        JogoQueNrSouEu();
    }
public static double Potenciacao(int num){
    double resultado = Math.Pow(num, 2);
    return resultado;
}

    public static void ImprimirDataHora(){
        Console.WriteLine(DateTime.Now.ToString());
    }
public static void MostrarMensagem(string mensagem){
    Console.WriteLine(mensagem);
}

public static void ContagemRegressiva(int n){
while(n>=0){
Console.WriteLine(n);
n --;
System.Threading.Thread.Sleep(500);
}
Console.WriteLine("BOOOOOM");
}
public static void JogoQueNrSouEu(){
    Console.WriteLine("* * * * * * * * * * * * * * * * * * * *");
    Console.WriteLine("           Bem vindo ao jogo!          ");
    Console.WriteLine("Sorteie um n* de 1 a20, tente adivinhar");
    Console.WriteLine("* * * * * * * * * * * * * * * * * * * *");
    Console.WriteLine("");

    Random rnd = new Random();
    int nrSorteado = rnd.Next(20);
    int nrDigitado = -1;

    do {
        Console.Write("digite um numero");
        nrDigitado = int.Parse(Console.ReadLine());

        if(nrDigitado > nrSorteado)
        Console.WriteLine("o numero digitado é maior que o sorteado");
        else if(nrDigitado < nrSorteado)
        Console.WriteLine("o numero digitado é menor que o sorteado ");
    }while(nrDigitado != nrSorteado);

    Console.WriteLine("parabens você acertou!!");
}

}


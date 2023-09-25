
class Program{
    public static void Main(){
  int divisoes = Divisao(int.Parse(Console.ReadLine()));
  Console.WriteLine($"divisão {divisoes}");
  Tabuada(valor);
  ResumoSalarios();

  int multiplicacao = int.Parse(Console.ReadLine());
  double valor = Multiplicacao(multiplicacao);
  Console.WriteLine($"o dobro do {valor}");
    }
    public static int Divisao(int num){
        int resultado = num/2;
        return resultado;
    }

    public static double Multiplicacao(int num){
        double resultado = num*2;
        return resultado;
    }

    public static void Tabuada(int valor){
    int contador = 1;

    while(contador <=1000){
        Console.WriteLine($"{valor} x {contador} = {valor * contador}");
        contador ++;
    }
}

public static void ResumoSalarios(){
    int SomaSalarios = 0;
    int menorSalario = 100000;
    int maiorSalario = 0;
    int salarioEmpregado = 0;

    do{
     Console.WriteLine("digite o salario do empregado")
     salarioEmpregado = int.Parse(Console.ReadLine());

     SomaSalarios = SomaSalarios + salarioEmpregado;
     if(salarioEmpregado > maiorSalario){
        maiorSalario = salarioEmpregado;
     }
     if(salarioEmpregado < 0);
    }
    while(salarioEmpregado > 0);

    Console.WriteLine($"a soma dos {SomaSalarios} ");
}

}





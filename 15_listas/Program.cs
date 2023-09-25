using System.Collections.Generic;
using Sesi.Models;

public class Program{
    public static void Main(){
        //criando uma lista de inteiros
   List<int> listaNumeros = new List<int>();
   listaNumeros.Add(10); //posição 0
   listaNumeros.Add(20); //posição 1
   listaNumeros.Add(30); //posição 2

//acessando os dados da lista pelo indice
   Console.WriteLine(listaNumeros[0]);

Console.WriteLine($" neste momento temos {listaNumeros.Count} elementos");

listaNumeros.Add(55);
Console.WriteLine($"neste momento temos {listaNumeros.Count} elementos");

Console.WriteLine("*************************");
List<string> listaNomes = new List<string>();
listaNomes.Add("heloisa");
listaNomes.Add("maria");
listaNomes.Add("duda");

Console.WriteLine(listaNomes[2]);

Console.WriteLine($" neste momento temos {listaNomes.Count} adicionada");
Console.WriteLine("**************************");

List<int> numeros = new List<int>{1, 2, 5, 6, 9};
Console.WriteLine($"quantidade de elementos da lista numeros: {numeros.Count}");
numeros.Remove(2);
numeros.RemoveAt(1);
numeros.RemoveRange(2,2);

numeros[0] = 100;

foreach(int item in numeros){
    Console.WriteLine(item);
}

foreach(string item in listaNomes){
    Console.WriteLine(item);
}

//criando uma lista com objetos

List<Aluno> listaAlunos = new List<Aluno>();

Aluno novoAluno = new Aluno("pedro", 16);
listaAlunos.Add(novoAluno);
listaAlunos.Add(new Aluno("patricia", 17));
listaAlunos.Add(new Aluno("bob", 17));

Console.WriteLine("lista alunos:");
foreach(T item in listaAlunos){
    Console.WriteLine($"nome do aluno: {item.nome} tem {item.idade}anos");
}


var ordenacao = from aluno in listaAlunos
                where aluno.idade = 17;
                orderby aluno.nome
                select aluno.nome;
foreach(var aluno in ordenacao){
    Console.WriteLine(aluno)
}

    }
}
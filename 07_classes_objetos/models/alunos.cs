
//o namespace é um nome em que usaremos para fazer referencia quando usarmos emoutras classes 
namespace Sesi.Model{
    //declarando nossa classe aluno
public class Aluno{

    //declarando nossos atributos da classe
public string nome { get; set; }
public int idade { get; set; }
public string turma { get; set; }

//criando um metodo

public void Apresentar()
{
    Console.WriteLine($"Olá, meu nome é {nome}, eu tenho {idade} anos e estudo na turma {turma}");
}
public void AdicionarFaltas(int nr){
    nrFaltas = nrFaltas + nr;
}
public void ResumirFaltas(){
    Console.Write($"{nome} voce tem {nrFaltas} faltas");
}
public void SubtrairFaltas(int nr){
    nrFaltas = nrFaltas - nr;
}
}
}

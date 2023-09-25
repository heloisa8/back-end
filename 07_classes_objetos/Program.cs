using Sesi.Model;

class Program{
    public static void Main(){
    var Aluno1 = new Aluno();
    Aluno1.nome = "heloisa";
    Aluno1.idade = 16;
    Aluno1.turma = "2 EM";
    Aluno1.Apresentar();
    Aluno1.ResumirFaltas();
    Aluno1.AdicionarFaltas(10);
    Aluno1.ResumirFaltas();
    Aluno1.AdicionarFaltas(7);
    Aluno1.ResumirFaltas();
    Aluno1.ResumirFaltas(8);
    Aluno1.ResumirFaltas();

     var Aluno2 = new Aluno();
    Aluno2.nome = "Duda";
    Aluno2.idade = 17;
    Aluno2.turma = "2 EM";
    Aluno2.Apresentar();
    }
}
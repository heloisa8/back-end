public class Program
{
    public satatic void Main()
    {
        //O try serve para tratar um erro e não parar a execuçao do programa
        //Se ocorrer qualquer erro dentro do bloco try, o sistema interrompe
        //a execuçao do bloco e vai para o catch
        try
        {
            int numero = int.,Parse(Console.Writeline());
            Console.Writeline($"Voce digitou o n {numero}");
            int resultadp = 10 / numero;
            Console.Writeline($"O Resultado é: {resultado}")
        }
        //catch é o tratamento do erro, normalmente colocamos as mensagens de acordo
        //com o tipo do erro, para melhor compreensao do usuario
        catch (FormatException erro)
        {
            Console.WriteLine($"Ocorreu um erro {ex.Message} ");
        }
        //O finally é um bloco executado independentemente se ocorrer erro ou não
        finally
        {
          Console.WriteLine($"Entrando no finally");
        }
    }
}
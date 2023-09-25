using Animal.Model;

class Program{
    public static void Main()
    {
        var Pantera1 = new Pantera();
        Pantera1.corre = "correndo";
        Pantera1.alimentacao = "pequenos herbívoros, lebres, répteis, insetos, enguias, peixes e ocasionalmente carniça";
        Pantera1.reproducao = "tres a cinco";
        Pantera1.Correr();
        Pantera1.Alimentar();
        Pantera1.Reproduzir();
    }
}

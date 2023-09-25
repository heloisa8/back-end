class Animal{
    public string cor { get; set; }

    public override void EmitirSom(){
        Console.WriteLine("o gato está emitindo som");
    }
}

class Cachorro : Animal{

    public void Latir(){
        Console.WriteLine($"O cachorro {cor} está latindo ");
    }
    
}

class Pug : Cachorro{

}

class Gato : Animal{


}

class Program{
    public static void Main(){
        Animal animalGenerico = new Animal();
        animalGenerico.EmitirSom();
        Cachorro meuCachorro = new Cachorro();
        meuCachorro.cor = "caramelo";
        meuCachorro.EmitirSom();
        meuCachorro.Latir();

        Gato meuGato = new Gato();
        meuGato.EmitirSom();
    }
}

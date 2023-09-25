namespace Animal.Model{
    public class Pantera{
        public string corre { get; set; }
        public string alimentacao { get; set; }
        public string reproducao { get; set; }


        public void Correr(){
            Console.WriteLine($"pantera está {corre}");
        }

        public void Alimentar(){
            Console.WriteLine($"pantera se alimenta de {alimentacao}");
        }

        public void Reproduzir(){
            Console.WriteLine($"pantera tem um numero de reprodução de {reproducao} filhotes");
        }
    }
}
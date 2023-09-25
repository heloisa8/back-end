namespace Models{
    public class Cliente{
        public int idCliente { get; set; }
        public string nome { get; set;}
        public int cpf { get; set;}
        public string email { get; set;}
        public string senha  { get; set; }
        public string endereco{ get; set;}
        public int numero { get; set;}
        public int cep {get;set;}

        public Clientes(){
          this.idCliente = 1;
          this.nome = "heloisa";
          this.cpf = 46439915851;
          this.email = "heloisag172@gmail.com"
          this.senha = "helo"
          this.endereco = "rua nove de julho"
          this.numero = 1067
          this.cep = 10300
        }

        }
            public class Produto{
        public int idProduto { get; set; }
        public string descricao { get; set;}
        public int nome { get; set;}
        public decimal preco { get; set;}
        public string imagem  { get; set; }
       
       public Produtos(){
          this.idProduto = 1;
          this.nome = "heloisa";
          this.descricao = "Leite integral, vitaminas A e D, estabilizante citrado de sódio e/ou trifosfato de sódio, monofosfato monossódio e difosfato dissódio.";
          this.preco = 17,80
          this.imagem = "leite"
    }
    
            public class Pedido{
        public int idPedido { get; set; }
        public string nome { get; set;}
        public int numero { get; set;}
        public decimal preco { get; set;}
        public string endereco  { get; set; }
        public int cep { get; set;}
       
       public Pedidos(){
          this.idPedido = 1;
          this.nome = "heloisa";
          this.numero = 19;
          this.preco = 13,80;
          this.imagem = "rua nove de julho";
          this.cep = 18900;
       }
}
            }
           
            public class Categoria{
        public int idCategoria { get; set; }
        public string nome { get; set;}
       public Categorias(){
          this.idCategoria = 1;
          this.nome = "heloisa";
}
            }
}

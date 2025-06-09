namespace WebApiFinalEtecPrimeiroSemestre.Models
{
    public class Produtos : Base
    {
        public string? Nome{ get; set; }
        public string? Descricao{ get; set; }
        public int Quantidade{ get; set; }
        public decimal Valor{ get; set; }




        //tipo de dados 

        //string nome = "Etec"; //Tipo de referência
        //char letra = 'E';

        //int valor = 10; // Números inteiros
        //long valor1 = 10L; // Números inteiros
        //byte valorB = 127; //Números inteiros
        
        //float valorF = 10.5F; //Números reais
        //double valorD = 10.5; //Números reais

    }
}


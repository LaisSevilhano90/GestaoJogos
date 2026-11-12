
namespace GestaoJogos.Models
{
    public class Jogo
    {
        public int ID { get; set; }
        public string? Nome { get; set; } 
        public string? Desenvolvedora { get; set; }
        public string? Genero { get; set; }
        public int AnoLancamento { get; set; }
        public decimal Preco { get; set; }
    }
}
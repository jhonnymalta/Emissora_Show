namespace Emissora_Tv_Api.DTOs
{
    public class ProgramaDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Duracao { get; set; }
        public string Classificacao { get; set; }

        public DateTime DataInicial { get; set; }
        public bool Ativo { get; set; }
    }
}

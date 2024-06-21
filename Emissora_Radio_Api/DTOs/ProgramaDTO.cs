using Integrations;

namespace Emissora_Radio_Api.DTOs
{
    public class ProgramaDTO : BaseMessage
    {
        
        public string Nome { get; set; }
        public int Duracao { get; set; }
        public string Classificacao { get; set; }

        public DateTime DataInicial { get; set; }
        public bool Ativo { get; set; }
    }
}

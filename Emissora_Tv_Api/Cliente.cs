namespace Emissora_Tv_Api
{
    public class Cliente
    {
        public string CriarIdentificadorCliente(string primeiroNome, string ultimoNome)
        {
            return $"@{primeiroNome}{ultimoNome}123";
        }
    }
}


namespace UFRJ.MBA.Domain.Entity
{
    public class Endereco
    {
        public int IdEndereco { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public int Numero { get; set; }
        public Cidade oCidade { get; set; }

        public Endereco()
        {
            IdEndereco = 0;
            Logradouro = string.Empty;
            Complemento=string.Empty;
            CEP = string.Empty;
            Numero = 0;
            oCidade = new Cidade();
        }
    }
}

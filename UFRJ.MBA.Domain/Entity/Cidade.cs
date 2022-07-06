
namespace UFRJ.MBA.Domain.Entity
{
    public class Cidade
    {
        public int IdCidade { get; set; }
        public string NomeCidade { get; set; }
        public UF oUF { get; set; }

        public Cidade()
        {
            IdCidade=0; ;
            NomeCidade=string.Empty;
        }
    }
}

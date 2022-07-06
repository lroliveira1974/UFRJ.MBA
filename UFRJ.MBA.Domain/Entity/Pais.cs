
namespace UFRJ.MBA.Domain.Entity
{
    public class Pais
    {
        public int IdPais { get; set; }
        public string NomePais { get; set; }

        public Pais()
        {
            IdPais = 0;
            NomePais = string.Empty;
        }
    }
}

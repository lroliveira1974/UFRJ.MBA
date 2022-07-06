
namespace UFRJ.MBA.Domain.Entity
{
    public class Autor
    {
        public int IdAutor { get; set; }
        public string NomeAutor { get; set; }
        public string CPF { get; set; }
        public Endereco oEndereco { get; set; }

        public Autor()
        {
            IdAutor = 0;
            NomeAutor = string.Empty;
            CPF = string.Empty;
            oEndereco = new Endereco();
        }
    }
}

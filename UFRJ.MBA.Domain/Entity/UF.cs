namespace UFRJ.MBA.Domain.Entity
{
    public class UF
    {
        public int IdUF { get; set; }
        public string NomeUF { get; set; }
        public string SiglaUF { get; set; }
        public Pais oPais { get; set; }

        public UF()
        {
            IdUF = 0;
            NomeUF = string.Empty;
            SiglaUF = string.Empty;
            oPais = new Pais();
        }
    }
}

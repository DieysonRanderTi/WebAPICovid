namespace WebAPICovid.Model
{
    public class Pais
    {
        public string Nome { get; set; }
        public double NovosCasosConfirmados { get; set; }
        public double TotalCasosConfirmados { get; set; }
        public double TotalCasosRecuperados { get; set; }
        public double TotalCasosAtivos { get; set; }

        public double CalculaTotalDeCasosAtivos()
        {
            return TotalCasosConfirmados - TotalCasosRecuperados;
        }

    }
}

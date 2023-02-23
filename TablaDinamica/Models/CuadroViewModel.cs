namespace TablaDinamica.Models
{
    public class CuadroViewModel
    {
        public string DescCuadro { get; set; }
        public List<FilaModel> Filas { get; set; }

        public CuadroViewModel()
        {
            Filas = new List<FilaModel>();
        }
    }
}

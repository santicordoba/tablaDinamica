namespace TablaDinamica.Models
{
    public class FilaModel
    {
        public string Id { get; set; }
        public List<CeldaModel> Columnas { get; set; }
        public bool EsCabecera { get; set; }
        public bool EsTotal { get; set; }

        public FilaModel()
        {
            Columnas = new List<CeldaModel>();
        }
    }
}

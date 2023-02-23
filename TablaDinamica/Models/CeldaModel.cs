using TablaDinamica.Datos;

namespace TablaDinamica.Models
{
    public class CeldaModel
    {
        public string OrdenFila { get; set; }
        public string OrdenColumna { get; set; }
        public string Valor { get; set; }

        public static explicit operator CeldaModel(CuadroLista v)
        {
            var temp = new CeldaModel();
            temp.OrdenFila = v.OrdenFila;
            temp.OrdenColumna = v.OrdenColumna;
            temp.Valor = v.Valor;
            return temp;
        }
    }
}

namespace TablaDinamica.Datos
{
    public class BaseDatos
    {
        public Cuadro _cuadro { get; set; }

        public BaseDatos()
        {
            _cuadro = new Cuadro("Cuadro");

            // Llenado del cuadro

            _cuadro.cuadro[0] = new CuadroLista { OrdenFila = "0", OrdenColumna = "1", Valor = "Tramites" };
            _cuadro.cuadro[1] = new CuadroLista { OrdenFila = "0", OrdenColumna = "2", Valor = "Cant. Tramites" };
            _cuadro.cuadro[2] = new CuadroLista { OrdenFila = "0", OrdenColumna = "3", Valor = "Ingresos" };
            _cuadro.cuadro[3] = new CuadroLista { OrdenFila = "0", OrdenColumna = "4", Valor = "Egresos" };
            _cuadro.cuadro[4] = new CuadroLista { OrdenFila = "0", OrdenColumna = "5", Valor = "Saldo" };
            _cuadro.cuadro[5] = new CuadroLista { OrdenFila = "1", OrdenColumna = "1", Valor = "17" };
            _cuadro.cuadro[6] = new CuadroLista { OrdenFila = "1", OrdenColumna = "2", Valor = "18" };
            _cuadro.cuadro[7] = new CuadroLista { OrdenFila = "1", OrdenColumna = "3", Valor = "19" };
            _cuadro.cuadro[8] = new CuadroLista { OrdenFila = "1", OrdenColumna = "4", Valor = "20" };
            _cuadro.cuadro[9] = new CuadroLista { OrdenFila = "1", OrdenColumna = "5", Valor = "21" };
            _cuadro.cuadro[10] = new CuadroLista { OrdenFila = "2", OrdenColumna = "1", Valor = "22" };
            _cuadro.cuadro[11] = new CuadroLista { OrdenFila = "2", OrdenColumna = "2", Valor = "23" };
            _cuadro.cuadro[12] = new CuadroLista { OrdenFila = "2", OrdenColumna = "3", Valor = "24" };
            _cuadro.cuadro[13] = new CuadroLista { OrdenFila = "2", OrdenColumna = "4", Valor = "25" };
            _cuadro.cuadro[14] = new CuadroLista { OrdenFila = "2", OrdenColumna = "5", Valor = "26" };
            _cuadro.cuadro[15] = new CuadroLista { OrdenFila = "3", OrdenColumna = "1", Valor = "27" };
            _cuadro.cuadro[16] = new CuadroLista { OrdenFila = "3", OrdenColumna = "2", Valor = "28" };
            _cuadro.cuadro[17] = new CuadroLista { OrdenFila = "3", OrdenColumna = "3", Valor = "29" };
            _cuadro.cuadro[18] = new CuadroLista { OrdenFila = "3", OrdenColumna = "4", Valor = "30" };
            _cuadro.cuadro[19] = new CuadroLista { OrdenFila = "3", OrdenColumna = "5", Valor = "31" };
            _cuadro.cuadro[20] = new CuadroLista { OrdenFila = "3.50", OrdenColumna = "1", Valor = "Sub Total" };
            _cuadro.cuadro[21] = new CuadroLista { OrdenFila = "3.50", OrdenColumna = "2", Valor = "69" };
            _cuadro.cuadro[22] = new CuadroLista { OrdenFila = "3.50", OrdenColumna = "3", Valor = "72" };
            _cuadro.cuadro[23] = new CuadroLista { OrdenFila = "3.50", OrdenColumna = "4", Valor = "75" };
            _cuadro.cuadro[24] = new CuadroLista { OrdenFila = "3.50", OrdenColumna = "5", Valor = "78" };
            _cuadro.cuadro[25] = new CuadroLista { OrdenFila = "4", OrdenColumna = "1", Valor = "32" };
            _cuadro.cuadro[26] = new CuadroLista { OrdenFila = "4", OrdenColumna = "2", Valor = "33" };
            _cuadro.cuadro[27] = new CuadroLista { OrdenFila = "4", OrdenColumna = "3", Valor = "34" };
            _cuadro.cuadro[28] = new CuadroLista { OrdenFila = "4", OrdenColumna = "4", Valor = "35" };
            _cuadro.cuadro[29] = new CuadroLista { OrdenFila = "4", OrdenColumna = "5", Valor = "36" };
            _cuadro.cuadro[30] = new CuadroLista { OrdenFila = "5", OrdenColumna = "1", Valor = "37" };
            _cuadro.cuadro[31] = new CuadroLista { OrdenFila = "5", OrdenColumna = "2", Valor = "38" };
            _cuadro.cuadro[32] = new CuadroLista { OrdenFila = "5", OrdenColumna = "3", Valor = "39" };
            _cuadro.cuadro[33] = new CuadroLista { OrdenFila = "5", OrdenColumna = "4", Valor = "40" };
            _cuadro.cuadro[34] = new CuadroLista { OrdenFila = "5", OrdenColumna = "5", Valor = "41" };
            _cuadro.cuadro[35] = new CuadroLista { OrdenFila = "5.50", OrdenColumna = "1", Valor = "Total" };
            _cuadro.cuadro[36] = new CuadroLista { OrdenFila = "5.50", OrdenColumna = "2", Valor = "140" };
            _cuadro.cuadro[37] = new CuadroLista { OrdenFila = "5.50", OrdenColumna = "3", Valor = "145" };
            _cuadro.cuadro[38] = new CuadroLista { OrdenFila = "5.50", OrdenColumna = "4", Valor = "150" };
            _cuadro.cuadro[39] = new CuadroLista { OrdenFila = "5.50", OrdenColumna = "5", Valor = "155" };

        }
    }

    public class Cuadro
    {
        public CuadroLista[] cuadro { get; set; }
        public string descCuadro { get; set; }

        public Cuadro(string nombre)
        {
            descCuadro = nombre;
            cuadro = new CuadroLista[40];
        }

    }

    public class CuadroLista
    {
        public string OrdenFila { get; set; }
        public string OrdenColumna { get; set; }
        public string Valor { get; set; }
    }

}

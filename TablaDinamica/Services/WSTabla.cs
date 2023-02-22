using TablaDinamica.Datos;

namespace TablaDinamica.Services
{
    public class WSTabla : ITabla
    {
        private BaseDatos baseDatos { get; set; }

        public WSTabla()
        {
            baseDatos = new BaseDatos();
        }

        public Cuadro TraerCuadro()
        {
            try
            {
                var resultado = baseDatos._cuadro;
                return resultado;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}

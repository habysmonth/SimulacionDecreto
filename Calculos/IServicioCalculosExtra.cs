using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    public interface IServicioCalculosExtra
    {
        int calculosPuntos(string t, string medi, string tipoPos, int cantidadEsp, string carreraPos,
            int anoPs, string CEjercePos, string MaestPos, int anoMaesPos, int totalEsp, string carreraPre, 
            string escala);
        double totalPuntos(double s);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    public class calculosExtra : IServicioCalculosExtra
    {
        private static calculosExtra instancia = null;
        double suma = 0;
        int puntos = 0;
        
        public int calculosPuntos(string t, string medi, string tipoPos, int cantidadEsp,
            string carreraPos, int anoPs, string CEjercePos, string MaestPos, int anoMaesPos, 
            int totalEsp, string carreraPre, string escala)
        {
            switch (escala)
            {
                case "Instructor":
                    puntos += 37;
                    break;
                case "Profesor Auxiliar":
                    puntos += 37;
                    break;
                case "Instr.Asistente":
                    puntos += 37;
                    break;
                case "Prof.Asistente":
                    puntos += 58;
                    break;
                case "Prof.Asociado":
                    puntos += 74;
                    break;
                case "Prof.Titular":
                    puntos += 96;
                    break;
                case "Seleccionar...":
                    puntos += 0;
                    break;
                default:
                    break;
            }

            if (t == "POSGRADO")
            {
                puntos += 183;

                if (tipoPos == "Especilizacion")
                {
                    if (cantidadEsp == 0)
                    {
                        puntos += 0;
                    }
                    else if (cantidadEsp == 1)
                    {
                        puntos += 10 + (10 * totalEsp);
                    }
                    else if (cantidadEsp == 2)
                    {
                        puntos += 10 + (10 * totalEsp);
                    }
                }
                else if ((tipoPos == "Doctorado" || tipoPos == "Ph.D"))
                {
                    if (MaestPos == "SI" && (anoPs > anoMaesPos))
                    {
                        puntos += 120;
                    }
                    else if (MaestPos == "NO" || MaestPos == "Seleccionar...")
                    {
                        puntos += 80;
                    }

                }
                else if (tipoPos == "Maestría")
                {
                    puntos += 40;
                }
            }
            else if(t == "PREGRADO" && medi == "SI")
            {
                puntos += 183;
            }
            else if (t == "PREGRADO" && (medi == "Seleccionar..." || medi == "NO"))
            {
                puntos += 178;
            }

            return puntos;
        }

        public calculosExtra() { }

        public static calculosExtra ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new calculosExtra();
            return instancia;
        }

        public double totalPuntos(double s)
        {
            suma += s;

            return suma;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Operativo
{
    public class Proceso
    {
        //Atributos
        public int NumeroProceso { get; set; } 
        public int TiempoLlegada { get; set; }
        public int Estado { get; set; }
        public int NumeroPaginas { get; set; }
        //Columna 0= R
        //Columna 1= Llegada
        //Columna 2= Ultimo Acceso
        //Columna 3= Accesos
        //Columna 4= Nur 1
        //Columna 5= Nur 2
        public int[][] Paginas { get; set; }
        public double TiempoEstimado { get; set; }
        public double Envejecimiento { get; set; }
        public int CpuAsignado { get; set; }
        public int CpuRestante { get; set; }
        public int QuantumRestante { get; set; }
        public int TiempoBloqued { get; set; }
        public double Prioridad { get; set; }

        //Constructores
        public Proceso() {
            Envejecimiento = 0;
            CpuAsignado = 0;
        }

        //Métodos
        public void calcularPrioridad()
        {
            Prioridad = (Envejecimiento + TiempoEstimado) / TiempoEstimado;
        }

        public String toString()
        {
            return "Proceso " + NumeroProceso + " TiempoLlegada " + TiempoLlegada + " Estado " +Estado+ " Número de Páginas " + NumeroPaginas;
        }
    }
}

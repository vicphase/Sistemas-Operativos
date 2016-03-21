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
        public int NumeroPaginasCargadas { get; set; }
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
        public int NumeroTemporalAccesos { get; set; }

        //Constructores
        public Proceso() {
            Envejecimiento = 0;
            CpuAsignado = 0;
        }

        //Métodos

        //Calcular prioridad de HRRN
        public void calcularPrioridad()
        {
            Prioridad = (Envejecimiento + TiempoEstimado) / TiempoEstimado;
        }

        //Calcular cuantas páginas estan cargadas en memoria
        public void calcularNumeroPaginasCargadas()
        {
            int acum = 0;
            for (int i = 0; i < Paginas[0].Length; i++)
            {
                if (Paginas[0][i] == 1)
                    acum++;
            }
            NumeroPaginasCargadas = acum;
        }

        //Quita una página de acuerdo al menor tiempo de llegada
        public void quitarPaginaFifo()
        {
            int MenorTiempoLlegada;
            MenorTiempoLlegada = int.MaxValue;
            for (int i = 0; i < Paginas[1].Length; i++)
            {
                if (Paginas[1][i] < MenorTiempoLlegada && Paginas[0][i] == 1)
                    MenorTiempoLlegada = Paginas[1][i];
            }

            for (int i = 0; i < Paginas[1].Length; i++)
            {
                if (Paginas[1][i] == MenorTiempoLlegada && Paginas[0][i] == 1)
                    Paginas[0][i] = 0;
            }

        }

        //Quita una página de acuerdo al menor tiempo de ultimo acceso
        public void quitarPaginaLru()
        {
            int UltimoAccesoMenor;
            UltimoAccesoMenor = int.MaxValue;
            for (int i = 0; i < Paginas[2].Length; i++)
            {
                if (Paginas[2][i] < UltimoAccesoMenor && Paginas[0][i] == 1)
                    UltimoAccesoMenor = Paginas[2][i];
            }

            for (int i = 0; i < Paginas[2].Length; i++)
            {
                if (Paginas[2][i] == UltimoAccesoMenor && Paginas[0][i] == 1)
                    Paginas[0][i] = 0;
            }
        }

        //Quita una página de acuerdo al menor número de accesos
        public void quitarPaginaLfu()
        {
            int MenorNumeroDeAccesos;
            MenorNumeroDeAccesos = int.MaxValue;
            for (int i = 0; i < Paginas[3].Length; i++)
            {
                if (Paginas[3][i] < MenorNumeroDeAccesos && Paginas[0][i] == 1)
                    MenorNumeroDeAccesos = Paginas[3][i];
            }

            for (int i = 0; i < Paginas[3].Length; i++)
            {
                if (Paginas[3][i] == MenorNumeroDeAccesos && Paginas[0][i] == 1)
                    Paginas[0][i] = 0;
            }
        }

        //Quita una página de acuerdo al algoritmo de NUR
        public void quitarPaginaNur()
        {
            Boolean QuitePagina = false;
            for(int i = 0; i < Paginas[4].Length; i++)
            {
                if(Paginas[4][i]==0 && Paginas[0][i]==1 && !QuitePagina)
                {
                    Paginas[0][i] = 0;
                    QuitePagina = true;
                }
                    
            }
            for (int i = 0; i < Paginas[5].Length; i++)
            {
                if (Paginas[5][i] == 0 && Paginas[0][i] == 1 && !QuitePagina)
                {
                    Paginas[0][i] = 0;
                    QuitePagina = true;
                }

            }
        }
    
        //Pone todos los bits de nur en 0
        public void resetarBitsNur()
        {
            for(int i = 0; i < Paginas[4].Length; i++)
            {
                Paginas[4][i] = 0;
                Paginas[5][i] = 0;
            }
        }

 

        public String toString()
        {
            return "Proceso " + NumeroProceso + " TiempoLlegada " + TiempoLlegada + " Estado " +Estado+ " Número de Páginas " + NumeroPaginas;
        }
    }
}

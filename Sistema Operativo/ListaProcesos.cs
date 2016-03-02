using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Operativo
{
   public class Proceso
    {
        public Proceso Sig ;
        public Proceso Ant;
        public int NumeroProceso;
        public int TiempoLlegada;
        public int Estado;
        public int NumeroPaginas;
        public int[][] Paginas;
        public double TiempoEstimado;
        public double Envejecimiento;
        public int CpuAsignado;
        public int CpuRestante;
        public int QuantumRestante;



        public Proceso() { }



        public String toString()
        {
            return "Proceso " + NumeroProceso + " TiempoLlegada " + TiempoLlegada + " Estado " + " Número de Páginas "+ NumeroPaginas;
        }

    }




    public class ListaProcesos
    {
        Proceso Inicio, Fin;



        public ListaProcesos()
        {
            Inicio = null;
            Fin = null;
        }



        public void Agregar(Proceso proceso)
        {
            Proceso nuevo = new Proceso();

            nuevo = proceso;

            if (Inicio == null)
            {
                Inicio = nuevo;
                Fin = nuevo;

                nuevo.Ant = null;
                nuevo.Sig = null;
            }
            else
            {
                Proceso aux = Inicio;

                while (aux != null)
                {
                    aux = aux.Sig;
                }

                if (aux == null)
                {
                    nuevo.Ant = Fin;
                    Fin.Sig = nuevo;
                    nuevo.Sig = null;
                    Fin = nuevo;
                }
                else
                {
                    if (aux.Ant == null) Inicio = nuevo;
                    else aux.Ant.Sig = nuevo;

                    nuevo.Ant = aux.Ant;
                    aux.Ant = nuevo;
                    nuevo.Sig = aux;
                }
            }
        }


        public Proceso extraerPrimero()
        {
            Proceso nuevo = new Proceso();
            nuevo.NumeroProceso = Inicio.NumeroProceso;
            nuevo.TiempoLlegada = Inicio.TiempoLlegada;
            nuevo.Estado = Inicio.Estado;
            nuevo.NumeroPaginas = Inicio.NumeroPaginas;
            nuevo.Paginas = Inicio.Paginas;
            nuevo.TiempoEstimado= Inicio.TiempoEstimado;
            nuevo.Envejecimiento = Inicio.Envejecimiento;
            nuevo.CpuAsignado = Inicio.CpuAsignado;
            nuevo.CpuRestante = Inicio.CpuRestante;
            nuevo.QuantumRestante = Inicio.QuantumRestante;

            Inicio = Inicio.Sig;
            if (Inicio != null)
                Inicio.Ant = null;
            return nuevo;
        }

        public void imprimir()
        {
            Proceso aux = Inicio;
            System.Console.WriteLine("Imprimiendo Lista de Procesos");

            while (aux != null)
            {
                Console.WriteLine(aux.toString() + '\n');
                aux = aux.Sig;
            }
        }


    }
}

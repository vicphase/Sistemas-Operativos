using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Operativo
{
    public class Sistema
    {
        //Attributes
        public List Ready { get; set; }
        public Proceso Running { get; set; }
        public Queue Bloqued { get; set; }
        public Queue Finished { get; set; }
        public int TiempoActual { get; set; }
        public int QuantumActual { get; set; }
        public int NumeroPaginas { get; set; }
        public int NumeroSiguienteProceso { get; set; }


        //Constructors
        public Sistema() {
            Ready = new List();
            Bloqued = new Queue();
            Finished = new Queue();
            NumeroSiguienteProceso = 1;
        }

        //Methods

         //Método para actualizar los tiempos de todo el sistema cuando ocurre una ejecución
        public void aumentarUnidadDeTiempo()
        {
            TiempoActual++;
            if (Running != null)
            {
                Running.CpuAsignado = Running.CpuAsignado + 1;
                Running.CpuRestante = Running.CpuRestante - 1;
            }
            Bloqued.aumentarTiempoBloqued();
            Ready.aumentarEnvejecimiento();
        }
        //Fin del método aumentarUnidadDeTiempo

            //Método para mandar el proceso en running a la fila de finished
        public void terminarRunning()
        {
            Finished.add(Running);
        }
        //Fin del método terminarRunning


            //Métodos para procesas los algoritmos de scheduling del CPU
        public void cargarRunningRoundRobin()
        {
            if(Running!=null)
            terminarRunning();
            Running = Ready.removeFirst();
        }

        public void cargarRunningFifo()
        {
            if(Running != null)
            terminarRunning();
            Running = Ready.removeFifo();

        }
        public void cargarRunningSjf()
        {
            if(Running != null)
            terminarRunning();
            Running = Ready.removeSjf();
        }

        public void cargarRunningSrt()
        {
            Running = Ready.removeSrt();
        }

        public void cargarRunningHrrn()
        {
            Running = Ready.removeHrrn();
        }
        //Fin de los métodos para procesar algoritmos de scheduling

            //Método que regresa un string con los tiempos de llegada de todos los procesos para el algoritmo FIFO
        public string desplegarTiemposLlegada()
        {
            string Mensaje;
            Proceso [] ProcesosReady = new Proceso[Ready.size()];
            Mensaje = "Ha terminado la ejecución del proceso actual " + '\n';
            Mensaje += "Tiempo de Llegada Running "+ Running.TiempoLlegada+'\n';
            ProcesosReady= Ready.toArray();
            if (ProcesosReady.Length > 0)
            {
                Mensaje += "Tiempos de Llegada de Procesos en Ready "+'\n';
                for (int i = 0; i < ProcesosReady.Length; i++)
                {
                    Mensaje += "Proceso " + ProcesosReady[i].NumeroProceso + ": " + ProcesosReady[i].TiempoLlegada+'\n';
                }
            }          
            return Mensaje;      
        }
        //Fin del método desplegarTiemposLlegada

        //Método que regresa un string con los tiempos estimados de ejecución para el algoritmo de SJF
        public string desplegarTiemposEstimados()
        {
            string Mensaje;
            Proceso[] ProcesosReady = new Proceso[Ready.size()];
            Mensaje = "Ha terminado la ejecución del proceso actual " + '\n';
            Mensaje += "Tiempo Estimado de Ejecución de Running " + Running.TiempoEstimado + '\n';
            ProcesosReady = Ready.toArray();
            if (ProcesosReady.Length > 0)
            {
                Mensaje += "Tiempos Estimados de Ejecución de los Procesos en Ready " + '\n';
                for (int i = 0; i < ProcesosReady.Length; i++)
                {
                    Mensaje += "Proceso " + ProcesosReady[i].NumeroProceso + ": " + ProcesosReady[i].TiempoEstimado + '\n';
                }

            }
            return Mensaje;
        }
        //Fin del método desplegarTiemposEstimados

        //Método que regresa un string con los tiempos restantes de ejecución para el algoritmo SRT
        public string desplegarTiemposRestantes()
        {
            string Mensaje;
            Proceso[] ProcesosReady = new Proceso[Ready.size()];
            Mensaje = "Tiempo Estimado de Ejecución de Running " + Running.CpuRestante + '\n';
            ProcesosReady = Ready.toArray();
            if (ProcesosReady.Length > 0)
            {
                Mensaje += "Tiempos Estimados de Ejecución de los Procesos en Ready " + '\n';
                for (int i = 0; i < ProcesosReady.Length; i++)
                {
                    Mensaje += "Proceso " + ProcesosReady[i].NumeroProceso + ": " + ProcesosReady[i].CpuRestante + '\n';
                }

            }
            return Mensaje;
        }

        //Método que regresa un string con las prioridades para el algoritmo HRRN
        public string desplegarPrioridades()
        {
            string Mensaje;
            Proceso[] ProcesosReady = new Proceso[Ready.size()];
            Mensaje = "Prioridad Running " + Running.Prioridad + '\n';
            ProcesosReady = Ready.toArray();
            if (ProcesosReady.Length > 0)
            {
                Mensaje += "Prioridades de los Procesos en Ready " + '\n';
                for (int i = 0; i < ProcesosReady.Length; i++)
                {
                    Mensaje += "Proceso " + ProcesosReady[i].NumeroProceso + ": " + ProcesosReady[i].Prioridad + '\n';
                }

            }
            return Mensaje;
        }
    }
}

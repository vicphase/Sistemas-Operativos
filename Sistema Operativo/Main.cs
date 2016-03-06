using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Operativo
{
    public partial class Main : Form
    {
        //Atributos
        public Sistema SistemaOperativo { get; set; }

        //Constructor del main
        public Main()
        {
            InitializeComponent();
            SistemaOperativo = new Sistema();
            RadioButtonFifoCpu.Checked = true;
            RadioButtonFifoMemoria.Checked = true;
            NumericTamañoQuantum.Value = 5;
            NumericPaginas.Value = 4;
            NumericEjecucionTotal.Value = 15;
            SistemaOperativo.QuantumActual = 5;
            ComboBoxInterrupciones.SelectedItem = ComboBoxInterrupciones.Items[0];
        }

        //Metodo utilizado para que no se pueda escribir en la combo box de tipos de interrupciones
        private void ComboBoxInterrupciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        //Metodo para leer el archivo .txt
        private void ButtonCargarTxt_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            int NumeroProcesos;
            int[][] TablaMemoria;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Open Text File";
            openFileDialog1.Filter = "TXT files|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            //Obtener el archivo y crear el stream reader
                            string file = Path.GetFileName(openFileDialog1.FileName);
                            string file2 = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                            string path = Path.GetDirectoryName(openFileDialog1.FileName);

                            StreamReader reader = new StreamReader(myStream);

                            //Leer numero de paginas
                            SistemaOperativo.NumeroPaginas= Int32.Parse(reader.ReadLine());

                            //Leer numero de procesos en el archivo
                            NumeroProcesos = Int32.Parse(reader.ReadLine());

                            //Crear arreglo de procesos para almacenar los procesos en el archivo
                            Proceso [] procesos = new Proceso[NumeroProcesos];

                            //Este string se usa para leer una linea del archivo y extraer los números con una expresión regular
                            string[] numbers;
                            
                            //Ciclo para leer cada proceso
                            for(int i = 0; i < NumeroProcesos; i++)
                            { 
                                //Se crea el proceso
                                procesos[i] = new Proceso();
                                //Guardamos su nombre (numero)
                                procesos[i].NumeroProceso = SistemaOperativo.NumeroSiguienteProceso;
                                //Le decimos al sistema operativo cual será el nombre del siguiente proceso que creemos
                                SistemaOperativo.NumeroSiguienteProceso = i + 2;

                                //Guardamos los numeros de la linea que leimos en un arreglo de strings
                                numbers= Regex.Split(reader.ReadLine(), @"\D+");

                                //Guardamos los numeros que obtuvimos de la linea pero tenemos que convertirlos a enteros porque son strings
                                procesos[i].TiempoLlegada = Int32.Parse(numbers[0]);
                                procesos[i].TiempoEstimado = Int32.Parse(numbers[1]);
                                procesos[i].CpuRestante = (int) procesos[i].TiempoEstimado;
                                procesos[i].Estado = Int32.Parse(numbers[2]);
                                procesos[i].QuantumRestante = SistemaOperativo.QuantumActual;
                                procesos[i].TiempoBloqued = 0;
                                //Leemos la siguiente linea para saber el número de páginas del proceso
                                procesos[i].NumeroPaginas= Int32.Parse(reader.ReadLine());
                                TablaMemoria = new int[6][];
                                TablaMemoria[0] = new int[procesos[i].NumeroPaginas];
                                TablaMemoria[1] = new int[procesos[i].NumeroPaginas];
                                TablaMemoria[2] = new int[procesos[i].NumeroPaginas];
                                TablaMemoria[3] = new int[procesos[i].NumeroPaginas];
                                TablaMemoria[4] = new int[procesos[i].NumeroPaginas];
                                TablaMemoria[5] = new int[procesos[i].NumeroPaginas];
                                //Almacenamos los valores de la tabla de memoria en los siguientes ciclos
                                for (int j=0; j < procesos[i].NumeroPaginas; j++)
                                {         
                                    numbers = Regex.Split(reader.ReadLine(), @"\D+");
                                    for(int k = 0; k < 6; k++)
                                    {
                                        TablaMemoria[k][j] = Int32.Parse(numbers[k]);                                       
                                    }

                                }
                                procesos[i].Paginas = TablaMemoria;
                                //Decidimos a donde se va a ir el proceso dependiendo su estado
                                if (procesos[i].Estado == 1)
                                {
                                    SistemaOperativo.Running = procesos[i];
                                }
                                if (procesos[i].Estado == 2)
                                {
                                    SistemaOperativo.Bloqued.add(procesos[i]);
                                }
                                if(procesos[i].Estado== 3)
                                {
                                    SistemaOperativo.Ready.addLast(procesos[i]);
                                }
                            }

                            //Calcular tiempo de llegada
                            int resultado = procesos[0].Paginas[2][0];
                            for(int i = 0; i < NumeroProcesos; i++)
                            {
                                for(int j = 0; j < procesos[i].NumeroPaginas; j++)
                                {
                                    if (procesos[i].Paginas[2][j] > resultado)
                                        resultado = procesos[i].Paginas[2][j];
                                }
                            }

                            SistemaOperativo.TiempoActual = resultado;
                            SistemaOperativo.Running.calcularPrioridad();
                            actualizarInterfaz();
                          
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
        //Fin del método para leer el archivo

            //Método para crear un nuevo proceso y colocarlo en la fila de ready
        private void ButtonCrearProceso_Click(object sender, EventArgs e)
        {
            //Creamos un objeto proceso y le damos todos sus valores
            Proceso NuevoProceso = new Proceso();
            NuevoProceso.NumeroProceso = SistemaOperativo.NumeroSiguienteProceso;
            NuevoProceso.TiempoLlegada = SistemaOperativo.TiempoActual;
            NuevoProceso.TiempoEstimado = (double)NumericEjecucionTotal.Value;
            NuevoProceso.Estado = 3;
            NuevoProceso.NumeroPaginas = (int)NumericPaginas.Value;
            NuevoProceso.CpuRestante = (int)NumericEjecucionTotal.Value;
            NuevoProceso.QuantumRestante = SistemaOperativo.QuantumActual;
            int[][] TablaMemoria =new int [6][];
            TablaMemoria[0] = new int[NuevoProceso.NumeroPaginas];
            TablaMemoria[1] = new int[NuevoProceso.NumeroPaginas];
            TablaMemoria[2] = new int[NuevoProceso.NumeroPaginas];
            TablaMemoria[3] = new int[NuevoProceso.NumeroPaginas];
            TablaMemoria[4] = new int[NuevoProceso.NumeroPaginas];
            TablaMemoria[5] = new int[NuevoProceso.NumeroPaginas];
            //Llenar la tabla de memoria
            for (int j = 0; j < NuevoProceso.NumeroPaginas; j++)
            {
                for (int k = 0; k < 6; k++)
                {
                    TablaMemoria[k][j] = 0;
                }

            }
            NuevoProceso.Paginas = TablaMemoria;
            //El nuevo objeto proceso se añade al final de la fila de ready
            SistemaOperativo.Ready.addLast(NuevoProceso);
            SistemaOperativo.NumeroSiguienteProceso = SistemaOperativo.NumeroSiguienteProceso+1;
            //Si no hay ningun proceso en ejecución, carga el proceso que acabamos de crear
            if (SistemaOperativo.Running == null)
            {
                SistemaOperativo.cargarRunningRoundRobin();
            }
            actualizarInterfaz();
        }
        //Fin del método para crear un nuevo proceso

            //Método para ejecutar una unidad de procesamiento
        private void ButtonEjecutar_Click(object sender, EventArgs e)
        {
            SistemaOperativo.Ready.calcularMenorTiempoEjecucion();
            SistemaOperativo.aumentarUnidadDeTiempo();

            if (!SistemaOperativo.Bloqued.empty())
            {
                if (SistemaOperativo.Bloqued.Head.Data.TiempoBloqued == 5)
                {
                    Proceso TemporalProcess = SistemaOperativo.Bloqued.remove();
                    TemporalProcess.TiempoBloqued = 0;
                    SistemaOperativo.Ready.addLast(TemporalProcess);
                }
            }


            if (SistemaOperativo.Running != null)
            {
                //Ejecutar algoritmo de CPU Round Robin
                if (RadioButtonRoundRobin.Checked)
                    ejecutarRoundRobin();
                 //Ejecutar algoritmo de CPU FIFO
                if (RadioButtonFifoCpu.Checked)               
                    ejecutarFifoCpu();
                //Ejecutar algoritmo de CPU SJF
                if (RadioButtonSjf.Checked)
                    ejecutarSjf();
                //Ejecutar algoritmo de CPU SRT
                if(RadioButtonSrt.Checked)
                    ejecutarSrt();
                //Ejecutar algoritmo de CPU HRRN
                if (RadioButtonHrrn.Checked)
                    ejecutarHrrn();
            }
            else
            {   //Si no hay ningun proceso en running checa si hay alguno en ready para cargarlo
                if(!SistemaOperativo.Ready.empty())
                SistemaOperativo.cargarRunningRoundRobin();
                if (SistemaOperativo.Running != null)
                {
                    NumericPagina.Maximum = SistemaOperativo.Running.NumeroPaginas;
                }
            }

            //Muestra todos los valores del sistema en pantalla
            actualizarInterfaz();

        }
           
        //Evento del boton de Interrupciones
        private void ButtonInterrumpir_Click(object sender, EventArgs e)
        {
            SistemaOperativo.Ready.calcularMenorTiempoEjecucion();
            SistemaOperativo.aumentarUnidadDeTiempo();
            if (SistemaOperativo.Running != null)
            {
                SistemaOperativo.Running.CpuAsignado = SistemaOperativo.Running.CpuAsignado -1;
                SistemaOperativo.Running.CpuRestante = SistemaOperativo.Running.CpuRestante +1;
            }
            //SVC Terminación Normal, SVC Terminación Anormal y Fallo de Programa
            if (ComboBoxInterrupciones.SelectedIndex == 0 || ComboBoxInterrupciones.SelectedIndex==1 || ComboBoxInterrupciones.SelectedIndex == 4)
            {
                if (SistemaOperativo.Running != null)
                {
                    SistemaOperativo.Running.CpuRestante = 0;
                    if (RadioButtonRoundRobin.Checked)
                        ejecutarRoundRobin();

                    if (RadioButtonFifoCpu.Checked)
                        ejecutarFifoCpu();

                    if (RadioButtonSjf.Checked)
                        ejecutarSjf();

                    if (RadioButtonSrt.Checked)
                        ejecutarSrt();

                    if (RadioButtonHrrn.Checked)
                        ejecutarHrrn();
                }

            }
            //SVC Solicitud de I/O y Solicitud de Recurso
            if (ComboBoxInterrupciones.SelectedIndex == 2 || ComboBoxInterrupciones.SelectedIndex == 3)
            {
                if (SistemaOperativo.Running != null)
                {
                    SistemaOperativo.Bloqued.add(SistemaOperativo.Running);
                    SistemaOperativo.Running = null;
                    if (RadioButtonRoundRobin.Checked)
                        SistemaOperativo.cargarRunningRoundRobin();

                    if (RadioButtonFifoCpu.Checked)
                        SistemaOperativo.cargarRunningFifo();

                    if (RadioButtonSjf.Checked)
                        SistemaOperativo.cargarRunningSjf();

                    if (RadioButtonSrt.Checked)
                        SistemaOperativo.cargarRunningSrt();

                    if (RadioButtonHrrn.Checked)
                        SistemaOperativo.cargarRunningHrrn();
                }
            }

            //Interrupción Externa de Quantum Expirado
            if(ComboBoxInterrupciones.SelectedIndex == 5 && RadioButtonRoundRobin.Checked && SistemaOperativo.Running != null)
            {
                SistemaOperativo.Running.QuantumRestante =1;
                ejecutarRoundRobin();
            }

            //Interrupción Dispositivo de I/O
            if(ComboBoxInterrupciones.SelectedIndex == 6 && !SistemaOperativo.Bloqued.empty())
            {
                MessageBox.Show("El primer proceso de la fila bloqued pasa a la fila de ready");
                SistemaOperativo.Ready.addLast(SistemaOperativo.Bloqued.remove());
            }

            actualizarInterfaz();
        }

        //Evento cuando cambia el tamaño del quantum en la interfaz
        private void NumericTamañoQuantum_ValueChanged(object sender, EventArgs e)
        {
            SistemaOperativo.QuantumActual = (int) NumericTamañoQuantum.Value;
            if (SistemaOperativo.Running != null)
                SistemaOperativo.Running.QuantumRestante = SistemaOperativo.QuantumActual;
            actualizarInterfaz();
        }


        //Este metodo muestra los valores de la tabla de memoria en la interfaz
        public void actualizarTablaMemoria()
        {
            this.DataGridViewTablaPaginas.Rows.Clear();
            if (SistemaOperativo.Running != null)
            {
                for (int i = 0; i < SistemaOperativo.Running.NumeroPaginas; i++)
                {
                    this.DataGridViewTablaPaginas.Rows.Add(Convert.ToString(i), Convert.ToString(SistemaOperativo.Running.Paginas[0][i]),
                        Convert.ToString(SistemaOperativo.Running.Paginas[1][i]), Convert.ToString(SistemaOperativo.Running.Paginas[2][i]),
                        Convert.ToString(SistemaOperativo.Running.Paginas[3][i]), Convert.ToString(SistemaOperativo.Running.Paginas[4][i]) + " " + Convert.ToString(SistemaOperativo.Running.Paginas[5][i]));
                }
            }
        }
        //Fin del método actualizarTablaMemoria

        //Este metodo muestra los valores del proceso que se encuentra en running en la interfaz
        public void actualizarProcesoActual()
        {
            if (SistemaOperativo.Running != null)
            {
                //Si hay algun proceso en Running
                LabelDesplegarNombre.Text = Convert.ToString(SistemaOperativo.Running.NumeroProceso);
                LabelDesplegarLlegada.Text = Convert.ToString(SistemaOperativo.Running.TiempoLlegada);
                LabelDesplegarCpuAsignado.Text = Convert.ToString(SistemaOperativo.Running.CpuAsignado);
                LabelDesplegarEnvejecimiento.Text = Convert.ToString(SistemaOperativo.Running.Envejecimiento);
                LabelDesplegarCpuRestante.Text = Convert.ToString(SistemaOperativo.Running.CpuRestante);
                LabelDesplegarQuantumRestante.Text = Convert.ToString(SistemaOperativo.Running.QuantumRestante);

                //Maximo número de páginas que se pueden ejecutar del proceso actual
                    NumericPagina.Maximum = SistemaOperativo.Running.NumeroPaginas;
                
            }
            else
            {
                //Si no hay ningun proceso en Running
                LabelDesplegarNombre.Text ="0";
                LabelDesplegarLlegada.Text = "0";
                LabelDesplegarCpuAsignado.Text = "0";
                LabelDesplegarEnvejecimiento.Text = "0";
                LabelDesplegarCpuRestante.Text = "0";
                LabelDesplegarQuantumRestante.Text = "0";
            }
            
            //Este label se encuentra en la sección de nuevo proceso
            LabelDesplegarNombreProcesoNuevo.Text = Convert.ToString(SistemaOperativo.NumeroSiguienteProceso);

            //Este label es el de tiempo actual del sistema
            LabelCantidadTiempoActual.Text = Convert.ToString(SistemaOperativo.TiempoActual);
        }
        //Fin del método actualizarProcesoActual

        public void actualizarEstadosProcesos()
        {
            //Crea estos arreglos para llenar los combobox
            Proceso [] Ready  = new Proceso [SistemaOperativo.Ready.size()];
            Proceso[] Finished = new Proceso[SistemaOperativo.Finished.size()];
            Proceso[] Bloqued = new Proceso[SistemaOperativo.Bloqued.size()];
            //Vacia los combobox para volverlos a llenar
            ComboBoxReady.Items.Clear();
            ComboBoxBloqued.Items.Clear();
            ComboBoxFinished.Items.Clear();
            //Si hay algo en ready empieza a llenar el combobox
            if (SistemaOperativo.Ready.size() != 0)
            { 
                Ready = SistemaOperativo.Ready.toArray();
                for(int i = 0; i < Ready.Length; i++)
                {
                    ComboBoxReady.Items.Insert(i, Ready[i].NumeroProceso);
                }
            }
            //Si hay algo en bloqued empieza a llenar el combobox
            if (SistemaOperativo.Bloqued.size() != 0)
            {
                Bloqued = SistemaOperativo.Bloqued.toArray();
                for (int i = 0; i < Bloqued.Length; i++)
                {
                    ComboBoxBloqued.Items.Insert(i, Bloqued[i].NumeroProceso);
                }
            }
            //Si hay algo en finished empieza a llenar el combobox
            if (SistemaOperativo.Finished.size() != 0)
            {
                Finished = SistemaOperativo.Finished.toArray();
                for (int i = 0; i < Finished.Length; i++)
                {
                    ComboBoxFinished.Items.Insert(i, Finished[i].NumeroProceso);
                }
            }
            //Si hay algo en running muestralo en su label sino pone un 0
            if (SistemaOperativo.Running!=null)
            LabelRunning.Text = Convert.ToString(SistemaOperativo.Running.NumeroProceso);
            else
                LabelRunning.Text = "0";
        }
        //Fin del método actualizarEstadoProcesos

        //Metodo para actualizar todos los datos en nuestra interfaz
        public void actualizarInterfaz()
        {
            actualizarTablaMemoria();
            actualizarProcesoActual();
            actualizarEstadosProcesos();
        }
        //Fin del método actualizarInterfaz

        //Método para ejecutar un proceso bajo el algoritmo de scheduling Round Robin
        public void ejecutarRoundRobin()
        {
            SistemaOperativo.Running.QuantumRestante--; //Restar quantum si se ejecuta
            if (SistemaOperativo.Running.CpuRestante == 0) //Si ya termino de ejecutarse el proceso
            {//Si la fila de ready tiene procesos en espera manda a finished el actual y carga el primero en ready
                if (!SistemaOperativo.Ready.empty())
                {
                    MessageBox.Show("Se ha terminado de ejecutar el proceso actual, esta ira a la lista de finished");
                    SistemaOperativo.cargarRunningRoundRobin();
                    SistemaOperativo.Running.QuantumRestante = SistemaOperativo.QuantumActual;
                    
                }
                else
                {//Si ya no hay nada en ready se pone como nulo el proceso running
                    MessageBox.Show("No hay nada en la fila de ready, el CPU estará al pendiente por si llega otro proceso");
                    if (SistemaOperativo.Running != null)
                        SistemaOperativo.Finished.add(SistemaOperativo.Running);
                        SistemaOperativo.Running = null;
                }
            }
            else
            {
                if (SistemaOperativo.Running.QuantumRestante == 0)
                {   //Si el quantum expiró mando running al final de ready, cargo a running el primero en ready y le asigno su quantum
                    if(!SistemaOperativo.Ready.empty())
                    MessageBox.Show("Su Quantum ha expirado, regresar a la fila de Ready");
                    SistemaOperativo.Ready.addLast(SistemaOperativo.Running);
                    SistemaOperativo.Running = SistemaOperativo.Ready.removeFirst();
                    SistemaOperativo.Running.QuantumRestante = SistemaOperativo.QuantumActual;
                }
            }
        }
        //Fin del método ejecutarRoundRobin

        //Método para procesar una ejecución de acuerdo al algoritmo FIFO
        public void ejecutarFifoCpu()
        {
            if (SistemaOperativo.Running.CpuRestante == 0) //Si ya termino de ejecutarse el proceso
            {//Si la fila de ready tiene procesos en espera manda a finished el actual y carga el primero en ready
                if (!SistemaOperativo.Ready.empty())
                {
                    MessageBox.Show(SistemaOperativo.desplegarTiemposLlegada());
                    SistemaOperativo.cargarRunningFifo();
                    
                }
                else
                {//Si ya no hay nada en ready se pone como nulo el proceso running
                    MessageBox.Show("No hay nada en la fila de ready, el CPU estará al pendiente por si llega otro proceso");
                    if(SistemaOperativo.Running!=null)
                    SistemaOperativo.terminarRunning();
                    SistemaOperativo.Running = null;
                }
            }
        }
        //Fin del método ejecutarFifoCpu

        //Método para procesar una ejecución de acuerdo al algoritmo SJF
        public void ejecutarSjf()
        {
            if (SistemaOperativo.Running.CpuRestante == 0) //Si ya termino de ejecutarse el proceso
            {//Si la fila de ready tiene procesos en espera manda a finished el actual y carga el primero en ready
                if (!SistemaOperativo.Ready.empty())
                {
                    MessageBox.Show(SistemaOperativo.desplegarTiemposEstimados());
                    SistemaOperativo.cargarRunningSjf();

                }
                else
                {//Si ya no hay nada en ready se pone como nulo el proceso running
                    MessageBox.Show("No hay nada en la fila de ready, el CPU estará al pendiente por si llega otro proceso");
                    SistemaOperativo.terminarRunning();
                    SistemaOperativo.Running = null;
                }
            }

        }
        //Método para procesar una ejecución de acuerdo al algoritmo SRT
        public void ejecutarSrt()
        {
            if (SistemaOperativo.Running.CpuRestante == 0) //Si ya termino de ejecutarse el proceso
            {//Si la fila de ready tiene procesos en espera manda a finished el actual y carga el primero en ready
                if (!SistemaOperativo.Ready.empty())
                {
                    MessageBox.Show("Se ha terminado de ejecutar el proceso actual, esta ira a la lista de finished");             
                    if (SistemaOperativo.Running != null)
                        SistemaOperativo.terminarRunning();
                    MessageBox.Show(SistemaOperativo.desplegarTiemposRestantes());
                    SistemaOperativo.cargarRunningSrt();

                }
                else
                {//Si ya no hay nada en ready se pone como nulo el proceso running
                    MessageBox.Show("No hay nada en la fila de ready, el CPU estará al pendiente por si llega otro proceso");
                    if (SistemaOperativo.Running != null)
                        SistemaOperativo.terminarRunning();
                    SistemaOperativo.Running = null;
                }
            }
            else
            {
                if (SistemaOperativo.Ready.MenorTiempoEjecucion<SistemaOperativo.Running.CpuRestante)
                {   //Si el quantum expiró mando running al final de ready, cargo a running el primero en ready y le asigno su quantum
                    MessageBox.Show(SistemaOperativo.desplegarTiemposRestantes());
                    SistemaOperativo.Ready.addLast(SistemaOperativo.Running);
                    SistemaOperativo.cargarRunningSrt();                   
                }
            }
        }

        public void ejecutarHrrn()
        {
            if (!SistemaOperativo.Ready.empty())
                SistemaOperativo.Ready.calcularMayorPrioridad();
                        
            if(SistemaOperativo.Running!=null)
            SistemaOperativo.Running.calcularPrioridad();

            if (SistemaOperativo.Running.CpuRestante == 0) //Si ya termino de ejecutarse el proceso
            {//Si la fila de ready tiene procesos en espera manda a finished el actual y carga el primero en ready
                if (!SistemaOperativo.Ready.empty())
                {
                    MessageBox.Show("Se ha terminado de ejecutar el proceso actual, esta ira a la lista de finished");
                    if (SistemaOperativo.Running != null)
                        SistemaOperativo.terminarRunning();
                    actualizarInterfaz();
                    MessageBox.Show(SistemaOperativo.desplegarPrioridades());
                    SistemaOperativo.cargarRunningHrrn();

                }
                else
                {//Si ya no hay nada en ready se pone como nulo el proceso running
                    MessageBox.Show("No hay nada en la fila de ready, el CPU estará al pendiente por si llega otro proceso");
                    if (SistemaOperativo.Running != null)
                        SistemaOperativo.terminarRunning();
                    SistemaOperativo.Running = null;
                }
            }
            else
            {
                if (SistemaOperativo.Ready.MayorPrioridad > SistemaOperativo.Running.Prioridad)
                {   //Si el quantum expiró mando running al final de ready, cargo a running el primero en ready y le asigno su quantum
                    actualizarInterfaz();
                    MessageBox.Show("Un proceso con mayor prioridad en ready remplazara al proceso que se encuentra en running actualmente");
                    MessageBox.Show(SistemaOperativo.desplegarPrioridades());
                    SistemaOperativo.Ready.addLast(SistemaOperativo.Running);
                    SistemaOperativo.cargarRunningHrrn();
                }
            }
        }


    }

   

    }


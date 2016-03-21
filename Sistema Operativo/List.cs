using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Operativo
{
        public class List
        {
            //Attributes
            public Node Head { get; set; }
            public int MenorTiempoEjecucion { get; set; }
            public double MayorPrioridad{ get; set; }

        //Constructors
        public List()
            {
                Head = null;
            }

            //Methods
            //Insert a node at any Positionition of the list
            public void add(int Position, Proceso Data)
            {
                if (Position <= size() + 1)
                {
                    Node NewNode = new Node();
                    NewNode.Data = Data;
                    if (Position == 1)
                    {
                        NewNode.Next = Head;
                        Head = NewNode;
                    }
                    else
                    {
                        if (Position == size() + 1)
                        {
                            Node TemporalNode = Head;
                            while (TemporalNode.Next != null)
                                TemporalNode = TemporalNode.Next;

                            TemporalNode.Next = NewNode;
                            NewNode.Next = null;
                        }
                        else
                        {
                            Node TemporalNode = Head;
                            for (int f = 1; f <= Position - 2; f++)
                                TemporalNode = TemporalNode.Next;
                            Node NextNode = TemporalNode.Next;
                            TemporalNode.Next = NewNode;
                            NewNode.Next = NewNode;
                        }

                    }
                }
            }
            //End of insertAt method

            //Insert a node at the end of the list
            public void addLast(Proceso Data)
            {
            Node TemporalNode;
            Node NewNode = new Node() ;
            NewNode.Data = Data;
            NewNode.Next = null;
                //Empty List
                if (Head == null)
                {
                    Head = NewNode;
                    Head.Next = null;
                }
                else //List with at least 1 node
                {
                    TemporalNode = Head;
                    while (TemporalNode.Next != null)
                    {
                        TemporalNode = TemporalNode.Next;
                    }

                    TemporalNode.Next = NewNode;
                    NewNode.Next = null;
                }

            }
            //End of insertLastMethod 

            //Remove a node from the list at certain Positionition

            public Proceso remove(int Position)
            {
                if (Position <= size())
                {
                    Proceso Data;
                    if (Position == 1)
                    {
                        Data = Head.Data;
                        Head = Head.Next;
                    }
                    else
                    {
                        Node TemporalNode;
                        TemporalNode = Head;
                        for (int f = 1; f <= Position - 2; f++)
                            TemporalNode = TemporalNode.Next;
                        Node NextNode = TemporalNode.Next;
                        TemporalNode.Next = NextNode.Next;
                        Data = NextNode.Data;
                    }
                    return Data;
                }
                else
                    return null; //Return -1 if the list can´t reach the position

            }
            //End of removeAt method  

            //Remove the first node of the list
            public Proceso removeFirst()
            {
                Proceso Data;
            if (Head != null)
            {
                Data = Head.Data;
                Head = Head.Next;
                return Data;
            }
            else return null;
               
                
            }
            //End of removeFirstMethod

            //Delete a node at certian position
            public void delete(int Position)
            {
                if (Position <= size())
                {
                    if (Position == 1)
                    {
                        Head = Head.Next;
                    }
                    else
                    {
                        Node TemporalNode = Head;
                        for (int f = 1; f <= Position - 2; f++)
                            TemporalNode = TemporalNode.Next;
                        Node NextNode = TemporalNode.Next;
                        TemporalNode.Next = NextNode.Next;
                    }
                }

            }
            //End of deleteAt Method

            //Gives the size of the list as an integer
            public int size()
            {
                int Size = 0;
                Node TemporalNode = Head;
                while (TemporalNode != null)
                {
                    TemporalNode = TemporalNode.Next;
                    Size++;
                }
                return Size;
            }
            //End of size method

            //Returns a boolean to see if the list is empty 
            public Boolean empty()
            {
                return Head == null;
            }
            //End of empty method

            //See if a node exists in the list
            public Boolean exists(Proceso Data)
            {
                Node TemporalNode = Head;
                while (TemporalNode != null)
                {
                    if (TemporalNode.Data == Data)
                        return true;
                    TemporalNode = TemporalNode.Next;
                }
                return false;
            }

        //Converts the list into an array
        public Proceso[] toArray()
        {
            Proceso[] procesos = new Proceso[size()];
            if (!empty())
            {          
            Node TemporalNode = Head;
            int Count = 0;         
            while (TemporalNode != null)
            {
                procesos[Count] = TemporalNode.Data;
                TemporalNode = TemporalNode.Next;
                Count++;
            }
            }
            return procesos;
        }
        //End of toArray method

            //Print the list
            public void print()
            {
                Node TemporalNode = Head;
                System.Console.WriteLine("Printing list");
                while (TemporalNode != null)
                {
                    System.Console.WriteLine(TemporalNode.Data.toString() + '\n');
                    TemporalNode = TemporalNode.Next;
                }
            }
        //End of print method

            //Método para calcular todas las prioridades de los procesos de la fila de ready
            public void calcularPrioridades()
        {
            Node TemporalNode = Head;
            System.Console.WriteLine("Printing list");
            while (TemporalNode != null)
            {
                TemporalNode.Data.calcularPrioridad();
                TemporalNode = TemporalNode.Next;
            }
        }

            //Método para calcular el menor tiempo de ejecución de los procesos en la fila de ready
        public void calcularMenorTiempoEjecucion()
        {
            int MenorTiempoRestante;
            Node TemporalNode;
            if (!empty())
            {
                TemporalNode = Head;
                MenorTiempoRestante = Head.Data.CpuRestante;
                while (TemporalNode != null)
                {
                    if (TemporalNode.Data.CpuRestante < MenorTiempoRestante)
                    {
                        MenorTiempoRestante = TemporalNode.Data.CpuRestante;
                    }
                    TemporalNode = TemporalNode.Next;
                }
                MenorTiempoEjecucion = MenorTiempoRestante;
            }
            
        }

        public void calcularMayorPrioridad()
        {
            double PrioridadMayor;
            Node TemporalNode;
            if (!empty())
            {
                calcularPrioridades();
                TemporalNode = Head;
                PrioridadMayor = Head.Data.Prioridad;
                while (TemporalNode != null)
                {
                    if (TemporalNode.Data.Prioridad> PrioridadMayor)
                    {
                        PrioridadMayor = TemporalNode.Data.Prioridad;
                    }
                    TemporalNode = TemporalNode.Next;
                }
                MayorPrioridad=PrioridadMayor;
            }

        }

        //Método para añadir envejecimiento a todos los procesos
        public void aumentarEnvejecimiento()
        {
            Node TemporalNode = Head;
            while (TemporalNode != null)
            {
                TemporalNode.Data.Envejecimiento = TemporalNode.Data.Envejecimiento + 1;
                TemporalNode = TemporalNode.Next;
            }
        }

        //Metodo para extraer el nodo de la lista con menor tiempo de llegada para cumplir con el algoritmo de FIFO
        public Proceso removeFifo()
        {
            int MenorTiempoLlegada, PosicionProceso = 1, Posicion = PosicionProceso;
            Node TemporalNode;
            Proceso TemporalProcess;
            if (!empty())
            {
                TemporalNode = Head.Next;
                MenorTiempoLlegada = Head.Data.TiempoLlegada;
                while (TemporalNode!=null)
                {
                    PosicionProceso++;
                    if (TemporalNode.Data.TiempoLlegada < MenorTiempoLlegada) { 
                    MenorTiempoLlegada = TemporalNode.Data.TiempoLlegada;
                    Posicion = PosicionProceso;
                    }
                    TemporalNode = TemporalNode.Next;                  
                }            
                if (Posicion == 1)
                {
                    TemporalProcess = Head.Data;
                    Head = Head.Next;
                }
                else
                {
                    TemporalNode = Head;
                    for (int i = 1; i <= Posicion - 2; i++)
                        TemporalNode = TemporalNode.Next;
                    
                    Node NextNode = TemporalNode.Next;
                    TemporalNode.Next = NextNode.Next;
                    TemporalProcess = NextNode.Data;
                }
                return TemporalProcess;
            }
            else return null;
        }
        //Fin del método removeFifo

        //Método para extraer un nodo de acuerdo al algoritmo SJF
        public Proceso removeSjf()
        {
            int MenorTiempoEstimado, PosicionProceso = 1, Posicion = PosicionProceso;
            Node TemporalNode;
            Proceso TemporalProcess;
            if (!empty())
            {
                TemporalNode = Head.Next;
                MenorTiempoEstimado = (int) Head.Data.TiempoEstimado;
                while (TemporalNode != null)
                {
                    PosicionProceso++;
                    if (TemporalNode.Data.TiempoEstimado < MenorTiempoEstimado)
                    {
                        MenorTiempoEstimado = (int)TemporalNode.Data.TiempoEstimado;
                        Posicion = PosicionProceso;
                    }
                    TemporalNode = TemporalNode.Next;              
                }

                if (Posicion == 1)
                {
                    TemporalProcess = Head.Data;
                    Head = Head.Next;
                }
                else
                {
                    TemporalNode = Head;
                    for (int i = 1; i <= Posicion - 2 ; i++)
                        TemporalNode = TemporalNode.Next;
                   
                    Node NextNode = TemporalNode.Next;
                    TemporalNode.Next = NextNode.Next;
                    TemporalProcess = NextNode.Data;

                }
                return TemporalProcess;
            }
            else return null;
        }
        //Fin del método removeSJF

        //Método para extraer un nodo de acuerdo al algoritmo SRT
        public Proceso removeSrt()
        {
            int PosicionProceso = 1, Posicion = PosicionProceso;
            Node TemporalNode;
            Proceso TemporalProcess;
            if (!empty())
            {
                calcularMenorTiempoEjecucion();
                System.Console.WriteLine(MenorTiempoEjecucion);
                TemporalNode = Head.Next;
                while (TemporalNode != null)
                {
                    PosicionProceso++;
                    

                    if (TemporalNode.Data.CpuRestante == MenorTiempoEjecucion)
                    {
                        Posicion = PosicionProceso;
                    }
                    TemporalNode = TemporalNode.Next;
                }

                if (Posicion == 1)
                {
                    TemporalProcess = Head.Data;
                    Head = Head.Next;
                }
                else
                {
                    TemporalNode = Head;
                    for (int i = 1; i <= Posicion - 2; i++)
                        TemporalNode = TemporalNode.Next;

                    Node NextNode = TemporalNode.Next;
                    TemporalNode.Next = NextNode.Next;
                    TemporalProcess = NextNode.Data;

                }
                return TemporalProcess;
            }
            else return null;
        }
        //Fin del método removeSRT

        //Método para extraer un nodo de acuerdo al algoritmo HRRN
        public Proceso removeHrrn()
        {
            int PosicionProceso = 1, Posicion = PosicionProceso;
            Node TemporalNode;
            Proceso TemporalProcess;
            if (!empty())
            {
                calcularMayorPrioridad();
                TemporalNode = Head.Next;
                while (TemporalNode != null)
                {
                    PosicionProceso++;
                    if (TemporalNode.Data.Prioridad == MayorPrioridad)
                    {
                        Posicion = PosicionProceso;
                    }
                    TemporalNode = TemporalNode.Next;
                }

                if (Posicion == 1)
                {
                    TemporalProcess = Head.Data;
                    Head = Head.Next;
                }
                else
                {
                    TemporalNode = Head;
                    for (int i = 1; i <= Posicion - 2; i++)
                        TemporalNode = TemporalNode.Next;

                    Node NextNode = TemporalNode.Next;
                    TemporalNode.Next = NextNode.Next;
                    TemporalProcess = NextNode.Data;

                }
                return TemporalProcess;
            }
            else return null;

        }
    }
        }
    



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Operativo
{
    public class Queue
    {
        //Attributes
        public Node Head { get; set; }
        public Node Tail { get; set; }

        //Constructor
        public Queue()
        {
            Head = null;
            Tail = null;
        }

        //Methods

        //Insert a node at the end of the queue
        public void add(Proceso Data)
        {
            Node TemporalNode = new Node();
            TemporalNode.Data = Data;
            TemporalNode.Next = null;
            if (empty())
            {
                Head = TemporalNode;
                Tail = TemporalNode;
            }
            else
            {
                Tail.Next = TemporalNode;
                Tail = TemporalNode;
            }
        }
        //End of insert method

        //Remove a node from the first place of the queue
        public Proceso remove()
        {
            if (!empty())
            {
                Proceso Data = Head.Data;
                if (Head == Tail)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    Head = Head.Next;
                }
                return Data;
            }
            else return null; //Return null if the queue is empty
        }
        //End of remove method

        //Gives the size of the queue as an integer
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

        //Returns a boolean value to see if the queue is empty
        public Boolean empty()
        {
            return Head == null;
        }
        //End of empty method

        //Converts the queue into an array
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

        //Print queue
        public void print()
        {
            Node TemporalNode = Head;
            System.Console.WriteLine("Printing queue");
            while (TemporalNode != null)
            {
                System.Console.WriteLine(TemporalNode.Data.toString() + '\n');
                TemporalNode = TemporalNode.Next;
            }
        }
        //End of print method

            //Método para aumentar en 1 el tiempo de todos los procesos que se encuentra en bloqued
        public void aumentarTiempoBloqued()
        {
            Node TemporalNode = Head;
            while (TemporalNode != null)
            {
                TemporalNode.Data.TiempoBloqued++;
                TemporalNode = TemporalNode.Next;
            }
        }
    }
}

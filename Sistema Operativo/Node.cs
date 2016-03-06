using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Operativo
{
    public class Node
    {
        //Attributes
        public Proceso Data { get; set; } //This can be an string, an object or any content of the node
        public Node Next { get; set; }
    }
}

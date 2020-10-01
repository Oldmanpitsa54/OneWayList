using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Node
    {
        public Node(string data)
        {
            Data = data;
        }
        public string Data { get; set; }
        public Node Next { get; set; }
    }
}

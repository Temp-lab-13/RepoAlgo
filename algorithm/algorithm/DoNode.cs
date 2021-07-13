using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace algorithm
{
    class DoNode<T>
    {
        public DoNode(T sata)
        {
            Sata = sata;
        }
        public T Sata { get; set; }
        public DoNode<T> NextNode { get; set; }
        public DoNode<T> PrevNode { get; set; }
    }

 
}

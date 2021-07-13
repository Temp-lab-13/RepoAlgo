using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Xml.Linq;

namespace algorithm
{
    public interface ILinkedList <T>
    {
        // выписка из методички. допилим и состыкуем в процессе.
        //int GetCount();
        //void AddNode(T sata);
        //void AddNodeAfter(DoNode<T> doNode, T sata);
        //void RemoveNode(int index);
        //void RemoveNode(DoNode<T> doNode);
        //DoNode<T> FindNode(int searchSata);
    }

    class DoList<T>
    {
        DoNode<T> head;
        DoNode<T> tail;

        // Запись на основе сообщений из телеграмма,
        // пока оставим в off, что бы не потерять. 
        //public DoList() 
        //{               
        //    head = new DoNode<T>();
        //    tail = new DoNode<T>();
        //}
        public int GetCount { get; set; }


        public void AddNode(T sata)
        {
            //этот кусок должен добавлять элементы.
            DoNode<T> doNode = new DoNode<T>(sata);

            if (head == null)
                head = doNode;
            else
            {
                tail.NextNode = doNode;
                doNode.PrevNode = tail;
            }
            tail = doNode;
            GetCount++;
        }

        public void AddNodeAfter(DoNode<T> doNode, T sata)
        {
            //этот кусок должен добавалять элементы после определённого элемента
            //над реализацием ещё думаем

        }

        public void RemoveNode(int index)
        { //пример из методички. удаление по индексу.
            if (index == 0)
            {
                var Head = head.NextNode;
                head.NextNode = null;
                return Head;
            }

            int currentIndex = 0;
            var currentNode = head;
            while (currentNode != null)
            {
                if (currentIndex == index - 1)
                {
                    RemoveNextNode(currentNode);
                    return head;
                }

                currentNode = currentNode.NextNode;
                currentIndex++;
            }

            return head;


        }






    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Queue_LinkedListImplementation
{
    public  class QueueUsingLL<T>
    {
        private Node<T> front;
        private Node<T> rear;
        private int size;


        public QueueUsingLL()
        {
            front = null;
            rear = null;
            size=0;
        }
        public int Size()
        {
            return size;
        }
        public bool IsEmpty()
        {
            return size==0;
        }
        public void Enqueue(T elem)
        {
            Node<T> NewNode = new Node<T>(elem);
            size++;
            if(front==null)// or rear==null
            {
                front = NewNode;
                rear = NewNode;
            }
            else
            {
                rear.next = NewNode;
                rear = NewNode;
            }

        }
        public T Dequeue()
        {
            if (front == null)
            {
                throw new Exception();
            }
            T temp = front.data;
            size--;
            front = front.next;//EARLIER FRONT NODE WILL BE REMOVED BY GRABAGE COLLECTOR WHICH RUNS PERIODICALLY AS FRONT NOT REFERRED BY ANYTHING IN THE PROGRAM
            if (front == null)
            {
                rear = null;//IF ALL THE NODES ARE DELETED THEN REAR WILL BE POINTING TO THE LAST ONE EVEN GARBAGE COLLECTOR WILL NOT BE ABLE TO FREE IT ,SO MAKE THAT NULL
            }
            return temp;
        }
        public T Front()
        {
            if (front == null)
            {
                throw new Exception();
            }
            return front.data;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dequeue_UC4
{
    internal class LinkedListQueue
    {
        Node Front;
        Node Rear;
        public void Enqueue(int data)
        {
            Node node=new Node(data);
            if(Front == null)
            {
                Rear = node;
                Front = Rear;
            }
            else
            {
                Rear.next = node;
                Rear = Rear.next;
            }
        }


        public void Display()
        {
            //Node temp = this.Front;
            if(Front==null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Node temp=Front;
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp=temp.next;
                }
            }
        }

        public void Dequeue()
        {
            if (this.Front == null)
                return;
            //Console.WriteLine("{0} is deleted", Front.data);

            this.Front=this.Front.next;

            if (this.Front == null)
                this.Rear = null;
        }
    }
}

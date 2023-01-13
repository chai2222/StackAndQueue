

namespace StackAndOueue
{
    public class QueuelinkedList
    {
        //In Queue front and rear Nodes are present
        Node front;
        Node rear;


        //Enqueue method is Used to Add elements in the queue
        public void Enqueue(int data)
        {
            Node newnode = new Node(data);
            if (front == null)
            {
                rear = newnode;
                front = rear;
            }
            else
            {
                rear.Next = newnode;
                rear = rear.Next;
            }
        }

        //Display method is used to display elements in queue

        public void Display()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            Node temp = front;
            while (temp != null)
            {
                Console.Write(" -> " + temp.data);
                temp = temp.Next;
            }
        }

    }
}


namespace QueueLinkedList
{
    public class StackLinkedList
    {
        Node top;
        public StackLinkedList()
        {
            top = null;
        }

        //Push method is to add element in th stack
        public void Push(int data)
        {
            Node nodeObj = new Node(data);
            nodeObj.Next = top;
            top = nodeObj;
            Console.WriteLine("{0} Push to the stack", data);

        }
        //Peek Method is used to take out element from stack

        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            Console.WriteLine("{0} element is at the top of stack", this.top.data);
        }

        //pop method is used to delete element from the stack

        public void pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }

            Console.WriteLine("{0} Deleted from stack ", this.top.data);
            Console.WriteLine("::::::::::::::::::::::::::::::::::::::");

            this.top = this.top.Next;

        }

        //IsEmpty method is used to empty the stack

        public void IsEmpty()
        {
            //just call peek and pop method to empty stack

            while (this.top != null)
            {
                Peek();
                pop();
            }
        }

        //Display method is used to display all the elements in the stack
        public void Display()
        {
            if (top == null)
                Console.WriteLine("Stack is Empty here");

            Node temp = top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.Next;
            }
        }
    }
}

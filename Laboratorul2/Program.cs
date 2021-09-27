using System;

namespace POOLab2
{
    public class box
    {

        int height;
        int width;
        int depth;

        public box()
        {
            height = 1;
            width = 1;
            depth = 1;
        }

        public box(int val)
        {
            height = val;
            width = val;
            depth = val;
        }

        public box(int height, int width, int depth)
        {
            this.height = height;
            this.width = width;
            this.depth = depth;
        }

        public double getArea()
        {
            return (2 * depth * width + 2 * depth * height + 2 * height * width);
        }

        public double getVol()
        {
            return (height * width * depth);
        }

        public string showRes()
        {
            return ("\nHeight: " + height + "\nWidth: " + width + "\nDepth: " + depth);
        }
    }
    public class Queue
    {
        int capacity;
        int[] queue;
        int front;
        int back;
        int count;

        public Queue(int size)
        {
            capacity = size;
            queue = new int[capacity];
            front = 0;
            back = -1;
            count = 0;
        }

        public Queue()
        {
            capacity = 50;
            queue = new int[50];
            front = 0;
            back = 0;
            count = 0;

        }

        public void push(int add)
        {
            Console.WriteLine("Element: " + add);
            if (back == capacity - 1)
            {
                back = -1;
            }
            queue[++back] = add;
            count++;
        }


        public int pop()
        {
            int temp = queue[front++];
            if (front == capacity)
            {
                front = 0;
            }
            count--;
            return temp;
        }

        public void isEmpty()
        {

            if (count == 0)
            {
                Console.WriteLine("Queue is empty");
            }
        }

        public void isFull()
        {

            if (capacity == size())
            {
                Console.WriteLine("Queue is full");
            }
            else
            {
                Console.WriteLine("Queue has elements, but it's not full");
            }

        }

        public int size()
        {
            return count;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Basic Level: \n");

            box b1 = new box();
            box b2 = new box(69);
            box b3 = new box(20, 9, 10);

            Console.WriteLine("First box");

            Console.WriteLine("Box's size: " + b1.showRes());
            Console.WriteLine("Box's surface area: " + b1.getArea() + " cm2");
            Console.WriteLine("Box's volume: " + b1.getVol() + " cm3");

            Console.WriteLine("-------------------------------");

            Console.WriteLine("Second box");
            Console.WriteLine("Box's size: " + b2.showRes());
            Console.WriteLine("Box's surface area: " + b2.getArea() + " cm2");
            Console.WriteLine("Box's volume: " + b2.getVol() + " cm3");

            Console.WriteLine("-------------------------------");

            Console.WriteLine("Third box");
            Console.WriteLine("Box's size: " + b3.showRes());
            Console.WriteLine("Box's surface area: " + b3.getArea() + " cm2");
            Console.WriteLine("Box's volume: " + b3.getVol() + " cm3");

            Console.WriteLine("\nAdvanced Levels:");

            Queue q1 = new Queue(10);
            Queue q2 = new Queue();

            Console.WriteLine("\nFirst queue:");
            q1.push(69);
            q1.push(420);
            q1.push(20);
            q1.push(123);
            q1.push(169);
            q1.push(13);
            q1.push(34);
            q1.push(98);
            q1.push(169);
            q1.push(13);
            q1.push(34);


            q1.pop();
            q1.isEmpty();
            q1.isFull();

            Console.WriteLine("The queue has " + q1.size() + " elements");

            Console.WriteLine("\nSecond queue:");
            q2.push(15);
            q2.push(380);
            q2.push(200);

            q2.pop();
            q2.isEmpty();
            q2.isFull();

            Console.WriteLine("The queue has " + q2.size() + " elements");
        }

    }
    
}

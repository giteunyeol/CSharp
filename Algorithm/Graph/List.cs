using System;
using System.Collections.Generic;

namespace Exercise
{

    // 스택 : LIFO(후입 선출)
    // 큐 : FIFO(선입선출) 

    // [1] [2] [3] [4] -> [주차장 입구]

    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(101);

            int data = stack.Pop();
            int data2 = stack.Peek(); //팝하지 않고 저장만

            Queue<int> stack = new Queue<int>();
            queue.Enqueue(101);
            int data3 = queue.Dequeue();
            int data4 = queue.Peek();

            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(101);
            list.AddLast(102);
            list.AddLast(103);

            //FIFO
            int value1 = list.First.Value;
            list.RemoveFirst();

            //LIFO
            int value2 = list.Last.Value;
            list.RemoveLast();

            List<int> list = new List<int>();
        }
    }
}
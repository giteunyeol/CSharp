using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Algorithm
{
    class MyLinkedListNode<T>
    {
        public T Data;
        public MyLinkedListNode<T> Next; // 주소값
        public MyLinkedListNode<T> Prev;
    }

    class MyLinkedList<T>
    {
        public MyLinkedListNode<T> Head = null; //첫번째
        public MyLinkedListNode<T> Tail = null; // 마지막
        public int Count = 0;

        // O(1)
        public MyLinkedListNode<T> AddLast(T data)
        {
            MyLinkedListNode<T> newRoom = new MyLinkedListNode<T>();
            newRoom.Data = data;

            //만약에 아직 방이 아예 없었다면, 새로 추가한 첫번째 방이 곧 Head이다.
            if (Head == null)
            {
                Head = newRoom;
            }

            // 101 102 103 104
            // 기존의 [마지막 방]과 [새로 추가되는 방]을 연결해준다.
            if (Tail != null)
            {
                Tail.Next = newRoom;
                newRoom.Prev = Tail;
            }

            // [새로 추가되는 방]을 [마지막 방]으로 인정
            Tail = newRoom;
            Count++;
            return newRoom;
        }

        // O(1)
        // 101 102 103 104 105
        public void Remove(MyLinkedListNode<T> room)
        {
            // [기존의 첫번째 방 다음 방]을 [첫번째 방으로] 인정한다
            if (Head == room) // 처음 방을 삭제하려했던 경우
            {
                Head = Head.Next;
            }

            // [기존의 마지막 방의 이전 방]을 [마지막 방으로] 인정한다.
            if (Tail == room) //마지막 방을 삭제하려 했던 경우
            {
                Tail = Tail.Prev;
            }

            if(room.Prev != null)
            {
                room.Prev.Next = room.Next;
            }

            if(room.Next != null)
            {
                room.Next.Prev= room.Prev;
            }

            Count--;
        }
    }

    class Board
    {
        public int[] _data = new int[25]; // 배열
        public MyLinkedList<int> _data3 = new MyLinkedList<int>(); //연결 리스트 c++ list


        public void Initialize()
        {
            _data3.AddLast(101);
            _data3.AddLast(102);
            MyLinkedListNode<int> node = _data3.AddLast(103);
            _data3.AddLast(104);
            _data3.AddLast(105);

            _data3.Remove(node);
        }
    }
}

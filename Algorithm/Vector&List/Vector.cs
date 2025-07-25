using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Algorithm
{
    class MyList<T>
    {
        const int DEFAULT_SIZE = 1;
        T[] _data = new T[DEFAULT_SIZE];
        public int Count; //실제로 사용중인 데이터 갯수
        public int Capacity { get { return _data.Length; } } // 예약된 데이터 갯수

        // 0(1) 예외 케이스 : 이사 비용은 무시한다 
        public void Add(T item)
        {
            // 1, 공간이 충분히 남아 있는지 확인한다
            if (Count >= Capacity)
            {
                //공간을 다시 늘려서확보
                T[] newArray = new T[Count * 2];
                for (int i = 0; i < Count; i++)
                {
                    newArray[i] = _data[i];
                }
                _data = newArray;
            }
            // 2. 공간에다가 데이터를 넣어준다 
            _data[Count] = item;
            Count++;
        }

        // 0(1)
        public T this[int index]
        {
            get { return _data[index]; }
            set { _data[index] = value; }
        }

        // 0(N)
        public void RemoveAt(int index)
        {
            // 101 102 103 104 105
            for (int i = index; i < Count - 1; i++)
                _data[i] = _data[i + 1];
            _data[Count - 1] = default(T);
            Count--;
        }
    }
    class Board
    {
        public int[] _data = new int[25]; // 배열
        public MyList<int> _data2 = new MyList<int>(); //동적 배열 c++ vector
        public LinkedList<int> _data3 = new LinkedList<int>(); //연결 리스트 c++ list

        public void Initialize()
        {
            
            _data2.Add(101);
            _data2.Add(102);
            _data2.Add(103);
            _data2.Add(104);
            _data2.Add(105);

            int temp = _data2[2];

            _data2.RemoveAt(2);
        }
    }
}

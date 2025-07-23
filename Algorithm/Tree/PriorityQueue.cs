using System;
using System.Collections.Generic;

namespace Exercise
{
    class PriorityQueue<T> where T : IComparable<T> //인터페이스.
    {
        //메모 *****
        // heap은 완전 이진트리.
        // 꼼수, 대입할때 1를 붙이고, 출력할때도 - 를 붙이면 대소관계가 뒤바뀜.

        List<T> _heap = new List<T>();
        //시간복잡도 : log2(N)
        public void Push(T data)
        {
            // 힙의 맨 끝에 새로운 데이터를 삽입한다.
            _heap.Add(data);

            int now = _heap.Count - 1;
            // 도장깨기를 시작
            while (now > 0)
            {
                // 도장 깨기를 시도
                int next = (now - 1) / 2;
                if (_heap[now].CompareTo(_heap[next]) < 0)
                {
                    break; //실패
                }

                // 두 값을 교체한다 
                T temp = _heap[now];
                _heap[now] = _heap[next];
                _heap[next] = temp;

                // 검사 위치를 이동한다
                now = next;
            }
        }
        //시간복잡도 : log2(N)
        public T Pop()
        {
            // 반환할 데이터를 따로 저장
            T ret = _heap[0];

            // 마지막 데이터를 루트로 이동한다
            int lastIndex = _heap.Count - 1;
            _heap[0] = _heap[lastIndex];
            _heap.RemoveAt(lastIndex);
            lastIndex--;

            // 역으로 내려가는 도장깨기 시작. 루트에서 리프로 내려감
            int now = 0;
            while (true)
            {
                int left = 2 * now + 1;
                int right = 2 * now + 2;
                
                int next = now; //일단 현재라고 가정.
                // 왼쪽값이 현재값보다 크면, 왼쪽으로 이동.
                if (left <= lastIndex && _heap[next].CompareTo(_heap[left]) < 0)
                {
                    next = left;
                }
                // 오른 값이 현재값(왼쪽 이동 포함)보다 크면, 오른 쪽으로 이동.
                if (right <= lastIndex && _heap[next].CompareTo(_heap[right]) < 0)
                {
                    next = right;
                }

                // 왼쪽/오른쪽 모두 현재값보다 작으면 종료
                if (next == now)
                {
                    break;
                }

                // 두 값을 교체한다.
                T temp = _heap[now];
                _heap[now] = _heap[next];
                _heap[next] = temp;
                // 검사 위치를 이동한다.
                now = next;
            }
            return ret;
        }
        public int Count()
        {
            return _heap.Count;
        }
    }
    
    class Knight : IComparable<Knight>
    { 
        public int id {get; set;}

        public int CompareTo(Knight other)
        {
            if( id == other.id)
            {
                return 0;
            }
            return id > other.id ? 1 : -1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue<Knight> q = new PriorityQueue<Knight>();
            q.Push(new Knight() { id = 20 });
            q.Push(new Knight() { id = 30 });
            q.Push(new Knight() { id = 40 });
            q.Push(new Knight() { id = 10 });
            q.Push(new Knight() { id = 05 });

            while (q.Count() > 0)
            {
                System.Console.WriteLine(q.Pop().id);
            }
        }
    }
}
using System;
using System.Collections.Generic;

namespace Exercise
{
    class Graph
    {
        int[,] adj = new int[6, 6]
        {
            {0, 1, 0, 1, 0, 0},
            {1, 0, 1, 1, 0, 0},
            {0, 1, 0, 0, 0, 0},
            {1, 1, 0, 0, 1, 0},
            {0, 0, 0, 1, 0, 1},
            {0, 0, 0, 0, 1, 0},
        };

        List<int>[] adj2 = new List<int>[] //c++ vector
        {
            new List<int>() { 1, 3 },
            new List<int>() { 0, 2, 3 },
            new List<int>() { 1 },
            new List<int>() { 0, 1, 4},
            new List<int>() { 3, 5 },
            new List<int>() { 4 },
        };

        public void BFS(int start) // 예약시스템 이용, 큐, 배열
        {
            bool[] found = new bool[6];
            int[] parent =  new int[6];
            int [] distance = new int[6];

            Queue<int> q = new Queue<int>();
            q.Enqueue(start);
            found[start] = true;
            parent[start] = start;
            distance[start] = 0;;
            while (q.Count > 0)
            {
                int now = q.Dequeue();
                System.Console.WriteLine(now);
                
                for(int next = 0; next < 6; next++)
                {
                    if(adj[now, next] == 0) //인접하지 않았으면스킵
                    {
                        continue;
                    }
                    if(found[next])
                    {
                        continue;
                    }
                    q.Enqueue(next);
                    found[next] = true;
                    parent[next] = now;
                    distance[next] = distance[now] + 1;
                }

            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // DFS (Depth First Search 깊이 우선 탐색)
            // BFS (Breadth First Search 너비 우선 탐색) 최단거리(길찾기때 사용)
            Graph graph = new Graph();
            graph.BFS(0);

        }
    }
}
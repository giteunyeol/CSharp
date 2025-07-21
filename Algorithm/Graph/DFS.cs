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
            {1, 1, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 1},
            {0, 0, 0, 0, 1, 0},
        };

        List<int>[] adj2 = new List<int>[] //c++ vector
        {
            new List<int>() { 1, 3 },
            new List<int>() { 0, 2, 3 },
            new List<int>() { 1 },
            new List<int>() { 0, 1 },
            new List<int>() { 5 },
            new List<int>() { 4 },
        };

        bool[] visited = new bool[6];
        // 1) 우선 now부터 방문하고,
        // 2) now와 연결된 정점들을 하나씩 확인해서, 아직 미발견(미방문) 방문한다.
        public void DFS(int now) // now는 시작점, array기반 DFS , 재귀함수로 구현!
        {
            System.Console.WriteLine(now);
            visited[now] = true;

            
            for (int next = 0; next < 6; next++) //6을 adj.GetLength(0)로 대체 가능
            {
                if (adj[now, next] == 0) // 연결되어 있지 않으면 스킵.
                {
                    continue;
                }
                if (visited[next]) // 이미 방문했으면 스킵, visited[next] == true랑 같은 의미.
                {
                    continue;
                }
                DFS(next); // 재귀함수
            }
        }

        public void DFS2(int now) // list기반 DFS
        {
            System.Console.WriteLine(now);
            visited[now] = true; // 1) 우선 now부터 방문.

            foreach(int next in adj2[now])
            {
                if(visited[next]) //이미 방문했으면 스킵.
                {
                    continue;
                }
                DFS2(next);
            }
        }

        public void SearchAll() // 모든 노드를 순회, 끊어져있는경우 대비
        {
            visited = new bool[6];
            for (int now = 0; now < 6; now++)
            {
                if(visited[now] == false)
                {
                    DFS(now);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // DFS (Depth First Search 깊이 우선 탐색)
            // BFS (Breadth First Search 너비 우선 탐색)
            Graph graph = new Graph();
            graph.SearchAll();
            //graph.DFS(0); //0을 시작점으로 배열 
            //graph.DFS2(0); //0을 시작점으로 리스트 
            
        }
    }
}
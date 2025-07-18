using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Xml.Schema;

namespace Algorithm
{
    class Board
    {
        const char CIRCLE = '\u25cf';
        public TileType[,] _tile; // 배열
        public int _size;

        public enum TileType
        {
            Empty,
            Wall,
        }

        public void Initialize(int size)
        {
            if (size % 2 == 0) //짝수면 리턴
            {
                return;
                _tile = new TileType[size, size];
                _size = size;
                // Mazes for Programmers
                //GenerateBinaryTree();
                GenerateBySideWinder();
            }
            void GenerateBySideWinder()
            {
                //일단 길을 다 막아버리는 작업
                for (int y = 0; y < _size; y++)
                {
                    for (int x = 0; x < _size; x++)
                    {
                        if (x % 2 == 0 || y % 2 == 0)
                        {
                            _tile[y, x] = TileType.Wall;
                        }
                        else
                        {
                            _tile[y, x] = TileType.Empty;
                        }
                    }
                }

                //랜덤으로 우측 혹은 아래로 길을 뚫는 작업
                Random rand = new Random();
                for (int y = 0; y < _size; y++)
                {
                    int count = 1;
                    for (int x = 0; x < _size; x++)
                    {
                        if (x % 2 == 0 || y % 2 == 0)
                            continue;
                                          
                        if (rand.Next(0, 2) == 0)
                        {
                            _tile[y, x + 1] = TileType.Empty;
                            count++;
                        }
                        else
                        {
                            int randomIndex = rand.Next(0, count);
                            _tile[y + 1, x - randomIndex * 2] = TileType.Empty;
                            count = 1;
                        }
                    }
                }
            }
        }

        public void Render()
        {
            ConsoleColor prevColor = Console.ForegroundColor;

            for (int y = 0; y < _size; y++)
            {
                for (int x = 0; x < _size; x++)
                {
                    Console.ForegroundColor = GetTileColor(_tile[y, x]);

                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.Write(CIRCLE);
                }
                System.Console.WriteLine();
            }

            Console.ForegroundColor = prevColor;
        }

        ConsoleColor GetTileColor(TileType type)
        {
            switch (type)
            {
                case TileType.Empty:
                    return ConsoleColor.Green;
                case TileType.Wall:
                    return ConsoleColor.Red;
                default:
                    return ConsoleColor.Green;
            }
        }
    }

}

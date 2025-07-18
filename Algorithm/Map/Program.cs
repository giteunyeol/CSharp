using System;
using System.Collections.Generic;
using Algorithm;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            Player player = new Player();
            board.Initialize(25, player);
            player.Initialize(1, 1, board);

            Console.CursorVisible = false;

            const int WAIT_TICK = 1000 / 30;
            int _sumTick = 0;
            int _lastindex = 0;

            int lastTick = 0;

            while (true)
            {
                #region 프레임 관리
                // 만약에 경과한 시간이 1/30초보다 작다면
                int currentTick = System.Environment.TickCount;
                int deltaTick = currentTick - lastTick;
                if (currentTick - lastTick < 1000 / 30)
                    continue;
                lastTick = currentTick;
                #endregion
                // 입력

                // 로직
                player.Update(deltaTick); // 위치 갱신

                // 렌더링
                Console.SetCursorPosition(0, 0);
                board.Render();
            }
        }

    }
}

namespace Kata2_TicTacToe
{
    enum GameStatus
    {
        NobodyWins,
        WinX,
        WinZero,
        InvalidPlayer,
        InvalidPosition,
        FieldIsUsed
    }

    public static class CharExtension
    {
        public static bool IsNotEmpty(this char self)
        {
            return self != '\0';
        }
    }

    class TicTacToe
    {
        private int _size = 3;
        private char[][] _fields;
        private GameStatus? _winner;
        public TicTacToe()
        {
            _fields = new char[_size][];
            for (int i = 0; i < _size; i++)
            {
                _fields[i] = new char[_size];
            }
        }

        private GameStatus SetPosition(int i, int j, char player)
        {
            if (_fields[i][j].IsNotEmpty())
            {
                return GameStatus.FieldIsUsed;
            }
            _fields[i][j] = player;
            var gameStatus = Status();
            if (gameStatus == GameStatus.WinZero || gameStatus == GameStatus.WinX)
            {
                _winner = gameStatus;
            }
            return gameStatus;
        }

        private GameStatus Status()
        {
            var diagonal1Count = 0;
            var diagonal2Count = 0;

            var diagonal1Winner = _fields[0][0];
            var diagonal2Winner = _fields[_size - 1][0];
            for (int i = 0; i < _size; i++)
            {
                var horizontalCount = 0;
                var verticalCount = 0;

                var horizontalWinner = _fields[i][0];
                var verticalWinner = _fields[0][i];

                for (int j = 0; j < _size; j++)
                {
                    if (horizontalWinner.IsNotEmpty() && horizontalWinner == _fields[i][j])
                    {
                        horizontalCount++;
                    }
                    if (verticalWinner.IsNotEmpty() && verticalWinner == _fields[j][i])
                    {
                        verticalCount++;
                    }
                }
                if (horizontalCount == _size)
                {
                    return horizontalWinner == 'X' ? GameStatus.WinX : GameStatus.WinZero;
                }
                if (verticalCount == _size)
                {
                    return verticalWinner == 'X' ? GameStatus.WinX : GameStatus.WinZero;
                }

                if (diagonal1Winner.IsNotEmpty() && diagonal1Winner == _fields[i][i])
                {
                    diagonal1Count++;
                }
                if (diagonal2Winner.IsNotEmpty() && diagonal2Winner == _fields[_size - 1 - i][i])
                {
                    diagonal2Count++;
                }

            }

            if (diagonal1Count == _size)
            {
                return diagonal1Winner == 'X' ? GameStatus.WinX : GameStatus.WinZero;
            }

            if (diagonal2Count == _size)
            {
                return diagonal2Winner == 'X' ? GameStatus.WinX : GameStatus.WinZero;
            }

            return GameStatus.NobodyWins;
        }

        public GameStatus Play(int i, int j, char player)
        {
            if (player != 'X' && player != '0')
            {
                return GameStatus.InvalidPlayer;
            }
            if (i < 1 || i > _size || j < 1 || j > _size)
            {
                return GameStatus.InvalidPosition;
            }
            if (_winner != null)
            {
                return _winner.Value;
            }
            return SetPosition(--i, --j, player);
        }
    }
}

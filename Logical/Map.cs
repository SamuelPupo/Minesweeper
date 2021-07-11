using System;

namespace Logical
{
    public class Map
    {
        private readonly Cell[,] _map;

        public int Height { get; }

        public int Width { get; }

        public Map(int rows, int columns, int mines)
        {
            if (rows <= 0 || rows > 30 || columns <= 0 || columns > 30)
                throw new InvalidOperationException("Invalid dimensions for the map.");
            _map = new Cell[rows, columns];
            Height = rows;
            Width = columns;
            Mines = mines;
            if (Mines > (Height - 1)*(Width - 1))
                Mines = (Height - 1)*(Width - 1);
            for (var i = 0; i < rows; i++)
                for (var j = 0; j < columns; j++)
                    _map[i, j] = new Cell(0);
        }

        #region ClickEvents

        private bool _isStart = true;
        private readonly int[] _rows = { -1, -1, 0, 1, 1, 1, 0, -1 };
        private readonly int[] _columns = { 0, 1, 1, 1, 0, -1, -1, -1 };
        private int _cellsSeen;

        public void LeftClick(int x, int y)
        {
            if (GameOver || !IsInside(x, y) || _map[x, y].Value > 9)
                return;
            if (_isStart)
            {
                _isStart = false;
                Creator(x, y);
            }
            _map[x, y].Value += 30;
            switch (_map[x, y].Value)
            {
                case 30:
                    for (var i = 0; i < _rows.Length; i++)
                    {
                        var f = x + _rows[i];
                        var c = y + _columns[i];
                        if (IsInside(f, c) && _map[f, c].Value < 9)
                            LeftClick(f, c);
                    }
                    break;
                case 39:
                    Defeat = true;
                    _map[x, y].Value = 49;
                    ShowMines();
                    break;
            }
            _cellsSeen++;
            if (Victory)
                ShowFlags();
        }

        public bool GameOver => Defeat || Victory;

        public bool Defeat { get; private set; }

        public bool Victory => !Defeat && _cellsSeen == Height*Width - Mines;

        public int Mines { get; }

        private bool IsInside(int x, int y) => x >= 0 && x < Height && y >= 0 && y < Width;
        
        private void Creator(int x, int y)
        {
            var mines = Mines;
            var r = new Random();
            while (mines > 0)
            {
                var f = r.Next(Height);
                var c = r.Next(Width);
                if (f == x && c == y || _map[f, c].Value == 9 || _map[f, c].Value == 19 || _map[f, c].Value == 29)
                    continue;
                mines--;
                if (_map[f, c].Value < 9)
                    _map[f, c].Value = 9;
                else if (_map[f, c].Value < 19)
                    _map[f, c].Value = 19;
                else if (_map[f, c].Value < 29)
                    _map[f, c].Value = 29;
                for (var k = 0; k < _rows.Length; k++)
                {
                    var nf = f + _rows[k];
                    var nc = c + _columns[k];
                    if (IsInside(nf, nc) && _map[nf, nc].Value != 9 && _map[nf, nc].Value != 19 && _map[nf, nc].Value != 29)
                        _map[nf, nc].Value++;
                }
            }
        }

        private void ShowMines()
        {
            if (!Defeat)
                return;
            for (var i = 0; i < Height; i++)
                for (var j = 0; j < Width; j++)
                {
                    if (_map[i, j].Value == 9 || _map[i, j].Value == 19 || _map[i, j].Value == 29)
                        _map[i, j].Value = 39;
                    else if (_map[i, j].Value > 9 && _map[i, j].Value < 20)
                        _map[i, j].Value = 40;
                }
        }

        private void ShowFlags()
        {
            if (!Victory)
                return;
            for (var i = 0; i < Height; i++)
                for (var j = 0; j < Width; j++)
                    if (_map[i, j].Value == 9 || _map[i, j].Value == 29)
                        _map[i, j].Value = 19;
        }

        public void DoubleClick(int x, int y)
        {
            if (GameOver || !IsInside(x, y) || _map[x, y].Value < 30)
                return;
            int f, c, qf = 0, qi = 0;
            for (var i = 0; i < _rows.Length; i++)
            {
                f = x + _rows[i];
                c = y + _columns[i];
                if (!IsInside(f, c) || _map[f, c].Value > 29) continue;
                qi++;
                if (_map[f, c].Value > 9 && _map[f, c].Value < 20)
                    qf++;
            }
            if (_map[x, y].Value == qf + 30)
                for (var i = 0; i < _rows.Length; i++)
                {
                    f = x + _rows[i];
                    c = y + _columns[i];
                    if (!IsInside(f, c))
                        continue;
                    if (_map[f, c].Value > 19 && _map[f, c].Value < 30)
                        _map[f, c].Value -= 20;
                    if (_map[f, c].Value < 10)
                        LeftClick(f, c);
                }
            else if (_map[x, y].Value == qi + 30)
                for (var i = 0; i < _rows.Length; i++)
                {
                    f = x + _rows[i];
                    c = y + _columns[i];
                    if (!IsInside(f, c))
                        continue;
                    if (_map[f, c].Value < 10)
                        _map[f, c].Value += 10;
                    else if (_map[f, c].Value > 19 && _map[f, c].Value < 30)
                        _map[f, c].Value -= 10;
                }
            else
                for (var i = 0; i < _rows.Length; i++)
                {
                    f = x + _rows[i];
                    c = y + _columns[i];
                    if (IsInside(f, c) && _map[f, c].Value < 10)
                        _map[f, c].Value += 20;
                }
        }

        public void RightClick(int x, int y)
        {
            if (GameOver || !IsInside(x, y) || _map[x, y].Value > 29)
                return;
            if (_map[x, y].Value < 20)
                _map[x, y].Value += 10;
            else
                _map[x, y].Value -= 20;
        }

        #endregion

        public Cell this[int x, int y]
        {
            get
            {
                if (!IsInside(x, y))
                    throw new ArgumentOutOfRangeException();
                return _map[x, y];
            }
        }

        public int FlagsQuantity
        {
            get
            {
                var count = 0;
                for (var i = 0; i < Height; i++)
                    for (var j = 0; j < Width; j++)
                        if (_map[i, j].Value > 9 && _map[i, j].Value < 20)
                            count++;
                return count;
            }
        }
    }
}
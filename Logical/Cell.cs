using System.ComponentModel;

namespace Logical
{
    public class Cell
    {
        private int _value;

        public Cell(int value)
        {
            _value = value;
        }

        public int Value
        {
            get => _value;
            set
            {
                if (value >= 0 && value < 50)
                    _value = value;
                else
                    throw new InvalidEnumArgumentException("Invalid numeration for a cell.");
            }
        }
    }
}

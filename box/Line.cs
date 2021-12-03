using System.Collections.Generic;
using Cell;
namespace Line
{
    public class Line<T>
    {
        private int _focusedCell;
        private string _name { get; set; }
        private readonly Dictionary<int, Cell<T>> _cells;
        private readonly Dictionary<Cell<T>, int> _cellIndices;
        public Line(string pstringLineName)
        {
            _name = pstringLineName;
            _focusedCell = -1;
            _cells = new Dictionary<int,Cell<T>>();
            _cellIndices = new Dictionary<Cell<T>, int>();
        }

        public void AddCell()
        {
            int intNewCellIndex = NewCellIndex();
            _cells.Add(intNewCellIndex, new Cell<T>());
            _cellIndices.Add(_cells[intNewCellIndex], intNewCellIndex);
            FocusCell(intNewCellIndex);
        }

        public void AddCell(T pobjectValue)
        {
            int intNewCellIndex = NewCellIndex();
            _cells.Add(intNewCellIndex, new Cell<T>(pobjectValue));
            _cellIndices.Add(_cells[intNewCellIndex], intNewCellIndex);
            FocusCell(intNewCellIndex);
        }

        public void AddMultipleCells(int pintNumberOfCellsToAdd, 
                                     Boolean pbooleanFocusLast = true)
        {
            int intNewCellIndex = NewCellIndex();
            for (int i = intNewCellIndex; i < pintNumberOfCellsToAdd; i++)
            {
                _cells.Add(i, new Cell<T>());
                _cellIndices.Add(_cells[i], i);
            }

            if (pbooleanFocusLast)
            {
                FocusLast();
            }
        }

        public void AddMultipleCells(int pintNumberOfCellsToAdd, 
                                     T pobjectStartingValue, 
                                     Boolean pbooleanFocusLast = true)
        {
            int intNewCellIndex = NewCellIndex();
            for (int i = CellCount(); i < pintNumberOfCellsToAdd; i++)
            {
                _cells.Add(i, new Cell<T>(pobjectStartingValue));
                _cellIndices.Add(_cells[i], i);
            }

            if (pbooleanFocusLast)
            {
                FocusLast();
            }
        }

        public int CellCount()
        {
            return _cells.Count;
        }

        public T? CellData()
        {
            if (_cells == null)
            {
                throw new Exception("Line contains no data.");
            }
            
            if (_focusedCell == -1)
            {
                throw new Exception("Unfocused cell. Cannot determine cell to read value from.");
            }

            return _cells[_focusedCell].Data;
        }

        private Boolean Empty()
        {
            return CellCount() == 0;
        }

        public void FocusCell(int pintCellToFocus)
        {
            _focusedCell = pintCellToFocus;
        }

        public void FocusFirst()
        {
            _focusedCell = 0;
        }

        public void FocusLast()
        {
            FocusCell(CellCount());
        }

        public void FocusNext()
        {
            _focusedCell++;
        }

        public int FocusedCell()
        {
            return _focusedCell;
        }

        public bool IsLastCell()
        {
            return FocusedCell() == CellCount();
        }

        public int NewCellIndex()
        {
            if (Empty() == false)
            {
                return CellCount() + 1;
            }

            return 0;
        }

        public void RemoveCell(int pintCellNumber)
        {
            _cellIndices.Remove(_cells[pintCellNumber]);
            _cells.Remove(pintCellNumber);
        }
    }
}
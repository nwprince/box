using Cell;
using Line;

namespace Box
{
    public class Box
    {
        #region "Columns"

        public void AddColumn<T>(string pstringColumnName) 
        {
            GuardData();
            _data.AddCell(new Line<object>(pstringColumnName));
            if (RowCount() > 1)
            {
                _data.CellData().AddMultipleCells(RowCount());
            } else if (RowCount() == 1)
            {
                _data.CellData().AddCell();
            }
        }

        public void AddColumn<T>(string pstringColumnName, T pobjectStartingValue)
        {
            GuardData();
            _data.AddCell(new Line<object>(pstringColumnName));
            if (RowCount() > 1)
            {
                _data.CellData().AddMultipleCells(RowCount(), pobjectStartingValue);
            }
            else if (RowCount() <= 1)
            {
                _data.CellData().AddCell(pobjectStartingValue);
            }
        }

        public int ColumnCount()
        {
            if (_data  == null)
            {
                return 0;
            }

            return _data.CellCount();
        }
        #endregion

        #region "Data"
        private Line<Line<object>>? _data;

        private void GuardData()
        {
            if (_data == null)
            {
                _data = new Line<Line<object>>("COLUMNS");
            }
        }

        public object CellValue()
        {
            return _data.CellData().CellData();
        }
        #endregion

        #region "Rows"

        public void AddRow()
        {
            GuardData();
            if (ColumnCount() == 0)
            {
                throw new Exception("No columns exists.");
            }

            int currentCell = _data.FocusedCell();
            _data.FocusFirst();
            while (_data.IsLastCell() == false)
            {
                _data.CellData().AddCell();
                _data.FocusNext();
            }
        }

        public int RowCount()
        {
            if (_data == null)
            {
                return 0;
            }

            _data.FocusFirst();

            return _data.CellData().CellCount();
        }
        #endregion

        public Box() {
            _data = null;
        }
    }
}

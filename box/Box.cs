using Cell;
using Line;

namespace box
{
    public class Box
    {
        #region "Columns"
        public void AddBooleanColumn(string pstringColumnName)
        {
            AddColumn<Boolean>(pstringColumnName);
        }

        public void AddCustomTypeColumn<T>(string pstringColumnName)
        {
            AddColumn<T>(pstringColumnName);
        }

        public void AddDateOnlyColumn(string pstringColumnName)
        {
            AddColumn<DateOnly>(pstringColumnName);
        }

        public void AddDateTimeColumn(string pstringColumnName)
        {
            AddColumn<DateTime>(pstringColumnName);
        }

        public void AddDecimalColumn(string pstringColumnName)
        {
            AddColumn<Decimal>(pstringColumnName);
        }

        public void AddDoubleColumn(string pstringColumnName)
        {
            AddColumn<Double>(pstringColumnName);
        }

        public void AddFloatColumn(string pstringColumnName)
        {
            AddColumn<float>(pstringColumnName);
        }

        public void AddIntColumn(string pstringColumnName)
        {
            AddColumn<int>(pstringColumnName);
        }

        public void AddLongColumn(string pstringColumnName)
        {
            AddColumn<string>(pstringColumnName);
        }

        public void AddStringColumn(string pstringColumnName)
        {
            AddColumn<String>(pstringColumnName);
        }

        private void AddColumn<T>(string pstringColumnName) 
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

        private void AddColumn<T>(string pstringColumnName, T pobjectStartingValue)
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

        public bool ColumnExists(string pstrColumnName)
        {
            if (_data == null)
            {
                return false;
            }
        
            if (ColumnCount() == 0)
            {
                return false;
            }
        
            foreach (Cell<Line<object>> row in _data.AllCells())
            {
                if (row.Data.MyName() == pstrColumnName)
                {
                    return true;
                }
            
            }

            return false;
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

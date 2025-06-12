/***************************************************************************
* Cell.cs
* -------------------------------------------------------------------------
* Project       : DouShouQi Mythology
* Author        : FORTUNE Gregoire
* Date          : 09/05/2025
* Description   : Represent the cell of the board
* -------------------------------------------------------------------------
***************************************************************************/
using System.ComponentModel;

namespace DouShouQiModel
{
    public class Cell : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int _row;
        private int _column;
        private CellType _type;
        private Team _teamCell;

        public int Row
        {
            get => _row;
            set
            {
                if (_row != value)
                {
                    _row = value;
                    OnPropertyChanged(nameof(Row));
                }
            }
        }

        public int Column
        {
            get => _column;
            set
            {
                if (_column != value)
                {
                    _column = value;
                    OnPropertyChanged(nameof(Column));
                }
            }
        }

        public CellType Type
        {
            get => _type;
            set
            {
                if (_type != value)
                {
                    _type = value;
                    OnPropertyChanged(nameof(Type));
                }
            }
        }

        public Team TeamCell
        {
            get => _teamCell;
            set
            {
                if (_teamCell != value)
                {
                    _teamCell = value;
                    OnPropertyChanged(nameof(TeamCell));
                }
            }
        }

        /// <summary>
        /// Constructeur de la classe Cell
        /// </summary>
        /// <param name="column"></param>
        /// <param name="row"></param>
        /// <param name="type"></param>
        /// <param name="teamCell"></param>
        public Cell(int column, int row, CellType type = CellType.Normal, Team teamCell = Team.Unknown)
        {
            _row = row;
            _column = column;
            _type = type;
            _teamCell = teamCell;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexTypes
{
    public class GameCollection<T> where T : GameBoard
    {
        private T _board;
        public T Board
        {
            get
            {
                return this._board;
            }
            set
            {
                this._board = value;
            }
        }
    }

    public abstract class GameBoard
    {

    }

    public class ChessBoard : GameBoard
    {

    }

    public class Hearthstone : GameBoard
    {

    }
}

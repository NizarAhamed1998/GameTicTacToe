using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTicTacToe
{
    public class EntryValues
    {
        

        
        string _player;
        int _point;
        int _totalMovesCount;
        int _xMovesCount;
        int _oMovesCount;

        public int OMovesCount
        {
            get { return _oMovesCount; }
            set { _oMovesCount = value; }
        }
        public int TotalMovesCount
        {
            get { return _totalMovesCount; }
            set { _totalMovesCount = value; }
        }


        public int XMovesCount
        {
            get { return _xMovesCount; }
            set { _xMovesCount = value; }
        }
        public string Player
        {
            get { return _player; }
            set { _player = value; }
        }
       

        public int Point
        {
            get { return _point; }
            set { _point = value; }
        }
    }
}

#nullable enable
using System;
using static System.Console;

namespace Bme121
{
    // Do not modify this file (except line 21 if necessary).
    // Class 'Board' represents one game board from Blokus.
    
    partial class Board
    {
        const int rows = 20;
        const int cols = 20;
        
        public char Unused { get; private set; }
        
        char[ , ] cells;
        
        public Board( )
        {
            Unused = '\u00b7'; // Change to '-' if '\u00b7' does not display as a dot.
            
            cells = new char[ rows, cols ];
            
            for( int r = 0; r < rows; r ++ )
            {
                for( int c = 0; c < cols; c ++ )
                {
                    cells[ r, c ] = Unused;
                }
            }
        }
    }
}

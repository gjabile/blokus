#nullable enable
using System;
using static System.Console;

namespace Bme121
{
    // Do not modify this file.
    // Class 'Piece' represents one playing piece from Blokus.
    
    class Piece
    {
        int[ , ] shape;
        
        bool IsTransposed { get; set; }
        bool IsHFlipped   { get; set; }
        bool IsVFlipped   { get; set; }
        
        public char Colour { get; private set; }

        public Piece( int[ , ] shape, char colour ) 
        { 
            this.shape = shape; 
            
            IsTransposed = false;
            IsHFlipped   = false;
            IsVFlipped   = false;
            
            Colour = colour;
        }
        
        public void OrientObverse( int degrees ) // "front" side up, degrees of rotation
        {
            switch( degrees )
            {
                case   0: IsTransposed = false; IsHFlipped = false; IsVFlipped = false; break;
                case  90: IsTransposed =  true; IsHFlipped = false; IsVFlipped =  true; break;
                case 180: IsTransposed = false; IsHFlipped =  true; IsVFlipped =  true; break;
                case 270: IsTransposed =  true; IsHFlipped =  true; IsVFlipped = false; break;
                default: break;
            }
        }
        
        public void OrientReverse( int degrees ) // "back" side up, degrees of rotation
        {
            switch( degrees )
            {
                case   0: IsTransposed =  true; IsHFlipped = false; IsVFlipped = false; break;
                case  90: IsTransposed = false; IsHFlipped = false; IsVFlipped =  true; break;
                case 180: IsTransposed =  true; IsHFlipped =  true; IsVFlipped =  true; break;
                case 270: IsTransposed = false; IsHFlipped =  true; IsVFlipped = false; break;
                default: break;
            }
        }
        
        public int this[ int row, int col ]
        {
            get
            {
                if( IsTransposed )
                {
                    int rows = shape.GetLength( 1 );
                    int cols = shape.GetLength( 0 );
                    if( IsHFlipped ) col = cols - 1 - col;
                    if( IsVFlipped ) row = rows - 1 - row;
                    return shape[ col, row ];
                }
                else
                {
                    int rows = shape.GetLength( 0 );
                    int cols = shape.GetLength( 1 );
                    if( IsHFlipped ) col = cols - 1 - col;
                    if( IsVFlipped ) row = rows - 1 - row;
                    return shape[ row, col ];
                }
            }
        }
        
        public int GetLength( int dimension )
        {
            if( IsTransposed ) return shape.GetLength( 1 - dimension );
            else               return shape.GetLength(     dimension );
        }
    }
}

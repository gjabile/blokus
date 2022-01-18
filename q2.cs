#nullable enable
using System;
using static System.Console;

namespace Bme121
{
   

    partial class Board
    {
        // Part A:
        // Write a representation of the board to the console.
        
        public void Display( )
        {
            // TO DO:
            //Write Column numbers at top
           Write( "    ");
            for(int c =0; c< cols; c++)
            {
				Write(c%10+" ");
			}
			WriteLine();
			//Write Each row number at the beginning and end of each row
			for(int r =0; r< rows; r++)
            {
				Write("  "+r%10);
				//display each cell in the row          
				for( int c = 0; c < cols; c ++ )
				{
					Write(" "+cells[ r, c ]);
				}
				WriteLine(" " +r%10);
			}
			//Write Column numbers at bottom of board
           Write( "    ");
            for(int c =0; c< cols; c++)
            {
				Write(c%10+" ");
			}
			WriteLine();
           
        }
        
        // Part B:
        // Update the board so a piece is placed at given coordinates.
        // The method does not check whether the piece will avoid existing pieces
        // on the board and will simply overwrite them.
        
        public void Place( Piece piece, int row, int col )
        {
            //check if the piece is null
            {
				//assume that the piece is null
				bool validpiece =false;
				for(int r =0; r< piece.GetLength(0); r++)
				{
					for(int c =0; c< piece.GetLength(1); c++)
					{
						//if a 1 is detected, you know the piece is valid
						if (piece[r,c] ==1)
						{
							validpiece = true;
							break;
						}
					}
				
				}
				//exit if invalid piece
				if (validpiece == false) return;
			}
            //check if any of the coordinates of the board would be off
            {
				//check if rows are in board size
				if(piece.GetLength(0)+row >=rows) return;
				//check if columns are in board size
				if(piece.GetLength(1)+col >=cols) return;
			}
			//Place the piece
			for (int r =0; r<piece.GetLength(0); r++)
			{
				for (int c =0; c<piece.GetLength(1); c++)
				{
					//if the piece has a 1 in that spot place a piece
					if (piece[r, c]==1)
					{
						cells[row+r, col+c] = piece.Colour;
					}
				}
			}
        }
        
        // Part C:
        // Test whether a piece will fit on the board at the given coordinates
        // without overwriting other pieces.
        // This method does not check whether the location is a valid Blokus play.
        
        public bool IsPlaceable( Piece piece, int row, int col )
        {
            //check if the piece is null
            {
				//assume that the piece is null
				bool validpiece =false;
				for(int r =0; r< piece.GetLength(0); r++)
				{
					for(int c =0; c< piece.GetLength(1); c++)
					{
						//if a 1 is detected, you know the piece is valid
						if (piece[r,c] ==1)
						{
							validpiece = true;
							break;
						}
					}
				
				}
				//exit if invalid piece
				if (validpiece == false) return false;
			}
            //check if row or col are out of range
            if (row<0||row>=rows||col<0||col>=cols) return false;
            //check if any of the coordinates of the board would be off
            {
				//check if rows are in board size
				if(piece.GetLength(0)+row >rows) return false;
				//check if columns are in board size
				if(piece.GetLength(1)+col >cols) return false;

			}
			//check if there are existing pieces in that spot
			for (int r =0; r<piece.GetLength(0); r++)
			{
				for (int c =0; c<piece.GetLength(1); c++)
				{
					//check if there is a block in that cell slot
					if (cells[row+r, col+c] !='\u00b7')
					{
						//check if the piece has a block in its orientation in that spot
						if(piece[r,c]==1) return false;
					}
				}
			}
			return true;
        }
			
        // Part D:
        // Test whether placing a piece at the given coordinates is a valid play.
        // This method does not check whether the location would overwrite other pieces.
        
        public bool IsOkTouch( Piece piece, int row, int col )
        {
            //check if the piece is null
            {
				//assume that the piece is null
				bool validpiece =false;
				for(int r =0; r< piece.GetLength(0); r++)
				{
					for(int c =0; c< piece.GetLength(1); c++)
					{
						//if a 1 is detected, you know the piece is valid
						if (piece[r,c] ==1)
						{
							validpiece = true;
							break;
						}
					}
				
				}
				//exit if invalid piece
				if (validpiece == false) return false;
			}
            //check if row or col are out of range
            if (row<0||row>=rows||col<0||col>=cols) return false;
            //check if any of the coordinates of the board would be off
            {
				//check if rows are in board size
				if(piece.GetLength(0)+row >rows) return false;
				//check if columns are in board size
				if(piece.GetLength(1)+col >cols) return false;

			}
			//check if there are any edge violations
			for (int r =0; r<piece.GetLength(0); r++)
			{
				for (int c =0; c<piece.GetLength(1); c++)
				{
					//check if piece has a block in this spot
					if (piece[r, c]==1)
					{
						//check above
						if (cells[row+r+1, col+c]==piece.Colour) return false;
						//check below
						if (cells[row+r-1, col+c]==piece.Colour) return false;
						//check left
						if (cells[row+r, col+c-1]==piece.Colour) return false;
						//check right
						if (cells[row+r, col+c+1]==piece.Colour) return false;
					}
				}
			}
			//check if there are any valid corners toucing
			for (int r =0; r<piece.GetLength(0); r++)
			{
				for (int c =0; c<piece.GetLength(1); c++)
				{
					//check if piece has a block in this spot
					if (piece[r, c]==1)
					{
						//check top left
						if (cells[row+r+1, col+c-1]==piece.Colour) return true;
						//check top right
						if (cells[row+r+1, col+c+1]==piece.Colour) return true;
						//check bottom left
						if (cells[row+r-1, col+c-1]==piece.Colour) return true;
						//check bottom right
						if (cells[row+r-1, col+c+1]==piece.Colour) return true;
					}
				}
			}
			return false;
        }
    }
}

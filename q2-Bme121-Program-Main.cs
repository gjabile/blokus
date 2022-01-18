#nullable enable
using System;
using static System.Console;

namespace Bme121
{
    // This file is not submitted for marking.
    // You may modify as desired to change the tests.
    // Uncomment one or more calls in 'Main' to test 'Board' methods.
    
    static class Program
    {
        static void Main( )
        {
            //TestBoardDisplay( );      // Part A test
            // TestBoardPlace( );        // Part B test
            // TestBoardIsPlaceable( );  // Part C test
            TestBoardIsOkTouch( );    // Part D test
            
            WriteLine( );
        }
        
        // Part A: Test the 'Display' method.
        
        static void TestBoardDisplay( )
        {
            WriteLine( );
            WriteLine( "Testing the Board.Display method" );
            
            Board board = new Board( );
            
            WriteLine( );
            board.Display( );
        }
        
        // Part B: Test the 'Place' method.
        
        static void TestBoardPlace( )
        {
            WriteLine( );
            WriteLine( "Testing the Board.Place method" );
            
            Board board = new Board( );
            
            Player player1 = new Player( 'R' ); // red player
            Piece piece1 = player1.PickPiece( 18 );
            piece1.OrientReverse( 270 );
            board.Place( piece1, row: 5, col: 6 );
            
            Player player2 = new Player( 'Y' ); // yellow player
            Piece piece2 = player2.PickPiece( 18 );
            piece2.OrientReverse( 270 );
            board.Place( piece2, row: 12, col: 6 );
            
            WriteLine( );
            board.Display( );
        }
        
        // Part C: Test the 'IsPlaceable' method.
        
        static void TestBoardIsPlaceable( )
        {
            WriteLine( );
            WriteLine( "Testing the Board.IsPlaceable method" );
            
            Board board = new Board( );
            
            Player player1 = new Player( 'R' ); // red player
            Piece piece1 = player1.PickPiece( 18 );
            piece1.OrientReverse( 270 );
            board.Place( piece1, row: 5, col: 6 );
            
            Piece piece2 = player1.PickPiece( 14 );
            piece2.OrientObverse( 270 );
            board.Place( piece2, row: 5, col: 13 );
            
            WriteLine( );
            board.Display( );
            
            WriteLine( );
            WriteLine( "board.IsPlaceable( piece2, row:  5, col: -1 ) = {0}", 
                        board.IsPlaceable( piece2, row:  5, col: -1 ) );
            WriteLine( "board.IsPlaceable( piece2, row:  5, col:  0 ) = {0}", 
                        board.IsPlaceable( piece2, row:  5, col:  0 ) );
            WriteLine( "board.IsPlaceable( piece2, row:  5, col:  4 ) = {0}", 
                        board.IsPlaceable( piece2, row:  5, col:  4 ) );
            WriteLine( "board.IsPlaceable( piece2, row:  5, col:  5 ) = {0}", 
                        board.IsPlaceable( piece2, row:  5, col:  5 ) );
            WriteLine( "board.IsPlaceable( piece2, row:  5, col:  6 ) = {0}", 
                        board.IsPlaceable( piece2, row:  5, col:  6 ) );
            WriteLine( "board.IsPlaceable( piece2, row:  5, col:  7 ) = {0}", 
                        board.IsPlaceable( piece2, row:  5, col:  7 ) );
            WriteLine( "board.IsPlaceable( piece2, row:  5, col:  8 ) = {0}", 
                        board.IsPlaceable( piece2, row:  5, col:  8 ) );
            WriteLine( "board.IsPlaceable( piece2, row:  5, col:  9 ) = {0}", 
                        board.IsPlaceable( piece2, row:  5, col:  9 ) );
            WriteLine( "board.IsPlaceable( piece2, row:  5, col: 18 ) = {0}", 
                        board.IsPlaceable( piece2, row:  5, col: 18 ) );
            WriteLine( "board.IsPlaceable( piece2, row:  5, col: 19 ) = {0}", 
                        board.IsPlaceable( piece2, row:  5, col: 19 ) );
                        
            WriteLine( );
            WriteLine( "board.IsPlaceable( piece2, row: -1, col:  8 ) = {0}", 
                        board.IsPlaceable( piece2, row: -1, col:  8 ) );
            WriteLine( "board.IsPlaceable( piece2, row:  0, col:  8 ) = {0}", 
                        board.IsPlaceable( piece2, row:  0, col:  8 ) );
            WriteLine( "board.IsPlaceable( piece2, row:  3, col:  8 ) = {0}", 
                        board.IsPlaceable( piece2, row:  3, col:  8 ) );
            WriteLine( "board.IsPlaceable( piece2, row:  4, col:  8 ) = {0}", 
                        board.IsPlaceable( piece2, row:  4, col:  8 ) );
            WriteLine( "board.IsPlaceable( piece2, row:  5, col:  8 ) = {0}", 
                        board.IsPlaceable( piece2, row:  5, col:  8 ) );
            WriteLine( "board.IsPlaceable( piece2, row:  6, col:  8 ) = {0}", 
                        board.IsPlaceable( piece2, row:  6, col:  8 ) );
            WriteLine( "board.IsPlaceable( piece2, row:  7, col:  8 ) = {0}", 
                        board.IsPlaceable( piece2, row:  7, col:  8 ) );
            WriteLine( "board.IsPlaceable( piece2, row:  8, col:  8 ) = {0}", 
                        board.IsPlaceable( piece2, row:  8, col:  8 ) );
            WriteLine( "board.IsPlaceable( piece2, row: 17, col:  8 ) = {0}", 
                        board.IsPlaceable( piece2, row: 17, col:  8 ) );
            WriteLine( "board.IsPlaceable( piece2, row: 18, col:  8 ) = {0}", 
                        board.IsPlaceable( piece2, row: 18, col:  8 ) );
        }
        
        // Part D: Test the 'IsOkTouch' method.
        
        static void TestBoardIsOkTouch( )
        {
            WriteLine( );
            WriteLine( "Testing the Board.IsOkTouch method" );
            
            Board board = new Board( );
            
            Player player1 = new Player( 'R' ); // red player
            Piece piece1 = player1.PickPiece( 18 );
            piece1.OrientReverse( 270 );
            board.Place( piece1, row:  5, col:  6 );
            
            Player player2 = new Player( 'Y' ); // yellow player
            Piece piece2 = player2.PickPiece( 14 );
            piece2.OrientObverse( 270 );
            board.Place( piece2, row:  5, col:  8 );
            
            Piece piece3 = player1.PickPiece( 10 );
            piece3.OrientReverse( 90 );
            board.Place( piece3, row:  7, col: 15 );
            
            WriteLine( );
            board.Display( );
            
            WriteLine( );
            WriteLine( "board.IsOkTouch( piece3, row:  7, col: 11 ) = {0}", 
                        board.IsOkTouch( piece3, row:  7, col: 11 ) );
            WriteLine( "board.IsOkTouch( piece3, row:  7, col: 10 ) = {0}", 
                        board.IsOkTouch( piece3, row:  7, col: 10 ) );
            WriteLine( "board.IsOkTouch( piece3, row:  7, col:  9 ) = {0}", 
                        board.IsOkTouch( piece3, row:  7, col:  9 ) );
            WriteLine( "board.IsOkTouch( piece3, row:  7, col:  8 ) = {0}", 
                        board.IsOkTouch( piece3, row:  7, col:  8 ) );
            WriteLine( "board.IsOkTouch( piece3, row:  7, col:  7 ) = {0}", 
                        board.IsOkTouch( piece3, row:  7, col:  7 ) );
            WriteLine( "board.IsOkTouch( piece3, row:  6, col:  9 ) = {0}", 
                        board.IsOkTouch( piece3, row:  6, col:  9 ) );
        }
    }
}

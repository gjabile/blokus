#nullable enable
using System;
using static System.Console;

namespace Bme121
{
    // Do not modify this file.
    // Class 'Player' represents one player from Blokus.
    
    class Player
    {
        Piece[ ] pieces;
        
        public char Colour { get; private set; }
        
        public Player( char colour )
        {
            Colour = colour;
            
            pieces = new Piece[ 21 ];
            
            pieces[  0 ] = new Piece( new int[ , ] {  {   1               }  }, colour );
                                                                             
            pieces[  1 ] = new Piece( new int[ , ] {  {   1, 1            }  }, colour );
                                                                             
            pieces[  2 ] = new Piece( new int[ , ] {  {   1, 1, 1         }  }, colour );
                                                                             
            pieces[  3 ] = new Piece( new int[ , ] {  {   1, 1            },            
                                                      {   0, 1            }  }, colour );
                                                                             
            pieces[  4 ] = new Piece( new int[ , ] {  {   1, 1, 1, 1      }  }, colour );
                                                                             
            pieces[  5 ] = new Piece( new int[ , ] {  {   1, 1, 1         },         
                                                      {   0, 0, 1         }  }, colour );
                                                                             
            pieces[  6 ] = new Piece( new int[ , ] {  {   1, 1, 1         },         
                                                      {   0, 1, 0         }  }, colour );
                                                                             
            pieces[  7 ] = new Piece( new int[ , ] {  {   1, 1, 0         },         
                                                      {   0, 1, 1         }  }, colour );
                                                                             
            pieces[  8 ] = new Piece( new int[ , ] {  {   1, 1            },            
                                                      {   1, 1            }  }, colour );
                                                                             
            pieces[  9 ] = new Piece( new int[ , ] {  {   1, 1, 1, 1, 1   }  }, colour );
                                                                             
            pieces[ 10 ] = new Piece( new int[ , ] {  {   1, 1, 1, 1      },      
                                                      {   0, 0, 0, 1      }  }, colour );
                                                                             
            pieces[ 11 ] = new Piece( new int[ , ] {  {   1, 1, 1, 1      },      
                                                      {   0, 0, 1, 0      }  }, colour );
                                                                             
            pieces[ 12 ] = new Piece( new int[ , ] {  {   1, 1, 1, 0      },      
                                                      {   0, 0, 1, 1      }  }, colour );
                                                                             
            pieces[ 13 ] = new Piece( new int[ , ] {  {   1, 1, 1         },         
                                                      {   0, 1, 1         }  }, colour );
                                                                             
            pieces[ 14 ] = new Piece( new int[ , ] {  {   1, 1, 1         },         
                                                      {   1, 0, 1         }  }, colour );
                                                                             
            pieces[ 15 ] = new Piece( new int[ , ] {  {   1, 1, 1         },         
                                                      {   0, 0, 1         },         
                                                      {   0, 0, 1         }  }, colour );
                                                                             
            pieces[ 16 ] = new Piece( new int[ , ] {  {   1, 1, 1         },         
                                                      {   0, 1, 0         },         
                                                      {   0, 1, 0         }  }, colour );
                                                                             
            pieces[ 17 ] = new Piece( new int[ , ] {  {   0, 1, 0         },         
                                                      {   1, 1, 1         },         
                                                      {   0, 1, 0         }  }, colour );
                                                                             
            pieces[ 18 ] = new Piece( new int[ , ] {  {   0, 0, 1         },         
                                                      {   1, 1, 1         },         
                                                      {   0, 1, 0         }  }, colour );
                                                                             
            pieces[ 19 ] = new Piece( new int[ , ] {  {   0, 0, 1         },         
                                                      {   1, 1, 1         },         
                                                      {   1, 0, 0         }  }, colour );
                                                                             
            pieces[ 20 ] = new Piece( new int[ , ] {  {   0, 1, 1         },         
                                                      {   1, 1, 0         },         
                                                      {   1, 0, 0         }  }, colour );
        }
        
        public Piece PickPiece( int id ) { return pieces[ id ]; }
    }
}

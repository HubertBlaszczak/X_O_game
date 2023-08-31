using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace X_O_game
{
    internal class Board
    {
            /// <summary>
            /// method to draw start board
            /// </summary>
            public static void drawBoardList(List<string> elementNumber)
            {               
                foreach (string element in elementNumber)
                {                               
                    Console.Write(" " + element + " ");
                    if (elementNumber[2] == element || elementNumber[5] == element || elementNumber[8] == element)
                        {
                            Console.WriteLine();
                        }        
                
                }          
            
            }
          
       
       

    }
}

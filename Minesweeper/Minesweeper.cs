using System;
using System.Collections.Generic;
using System.Text;

namespace Minesweeper
{
    class Minesweeper
    {
        static void Main(string[] args)
        {             
            /* Input For Map                      
           string[,] map = new string[6,6];                       

           Console.WriteLine("Set up the map: [6 lines & 6 cells/line]");
           Console.WriteLine("(With '*' is Mine, other symbols are nothing)");
           for (int rowMap = 0; rowMap < 6; rowMap++)
           {     
                        
                int positionLine = rowMap + 1;
                //Set up Mine for each line
                Console.WriteLine("Set up Mine for line {0}: ", positionLine);
                
                string linesetupMine = Console.ReadLine();

                //Add Mine's spot into map
                for (int columnMap = 0; columnMap < linesetupMine.Length; columnMap++)
                {
                    char spotIfMine = linesetupMine[columnMap];                                        
                    map[rowMap,columnMap] = Convert.ToString(spotIfMine);
                }
           }
            */
           string[,] map =
           {
            {"*", ".", ".", "."},
            {".", ".", ".", "."},
            {".", "*", ".", "."},
            {".", ".", ".", "."}
           };

           int MAP_HEIGHT = map.GetLength(0);
           int MAP_WIDTH = map.GetLength(1);

           string[,] mapReport = new string[MAP_HEIGHT,MAP_WIDTH];

           for (int yOrdinate = 0; yOrdinate < MAP_HEIGHT; yOrdinate++)
           {
                for (int xOrdinate = 0; xOrdinate < MAP_WIDTH; xOrdinate++)
                {
                    string currentCell = map[yOrdinate,xOrdinate];

                    if (currentCell.Equals("*"))
                    {
                        mapReport[yOrdinate,xOrdinate] = "*";
                    }
                    else
                    {
                        int[,] NEIGHBOURS_ORDINATE = {
                            {yOrdinate - 1, xOrdinate - 1}, {yOrdinate - 1, xOrdinate}, {yOrdinate - 1, xOrdinate + 1},
                            {yOrdinate, xOrdinate - 1}, {yOrdinate, xOrdinate + 1},
                            {yOrdinate + 1, xOrdinate - 1}, {yOrdinate + 1, xOrdinate}, {yOrdinate + 1, xOrdinate + 1}
                        };

                        int minesaround = 0;
                        int length = NEIGHBOURS_ORDINATE.GetLength(0);

                        for (int i = 0; i < length; i++)
                        {
                            int xOrdinateOfNeighbour = NEIGHBOURS_ORDINATE[i,1];
                            int yOrdinateOfNeighbour = NEIGHBOURS_ORDINATE[i,0];

                            bool isOutOfMapNeighbour = xOrdinateOfNeighbour < 0
                                || xOrdinateOfNeighbour == MAP_WIDTH
                                || yOrdinateOfNeighbour < 0
                                || yOrdinateOfNeighbour == MAP_HEIGHT;
                            
                            if (isOutOfMapNeighbour)
                            {
                                continue;
                            }

                            bool isMineOwnerNeighbour = map[yOrdinateOfNeighbour,xOrdinateOfNeighbour].Equals("*");
                            if (isMineOwnerNeighbour)
                            {
                                minesaround++;
                            }
                        }
                        mapReport[yOrdinate,xOrdinate] = minesaround.ToString();
                    }
                }
           }
           for (int yOrdinate = 0; yOrdinate < MAP_HEIGHT; yOrdinate++)
           {
                Console.WriteLine();
                for (int xOrdinate = 0; xOrdinate < MAP_WIDTH; xOrdinate++)
                {
                    string currentCellReport = mapReport[yOrdinate,xOrdinate];
                    Console.Write(currentCellReport);
                }
           }
        }
    }
}
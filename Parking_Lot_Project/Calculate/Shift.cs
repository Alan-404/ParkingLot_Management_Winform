using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot_Project
{
    class Shift
    {
        
        public Shift()
        {
            
        }
        
        public static int[,] a =
                    {
                            { 1,0,0,1,0,0,1},
                            { 0,1,0,0,1,0,0},
                            { 0,0,1,0,0,1,0}
                        };
        public static int[,] b =
                    {
                            { 0,0,1,0,0,1,0},
                            { 1,0,0,1,0,0,1},
                            { 0,1,0,0,1,0,0}
                        };
        public static int[,] c =
                    {
                            { 0,1,0,0,1,0,0},
                            { 0,0,1,0,0,1,0},
                            { 1,0,0,1,0,0,1}
                        };
        public static int[,] d = {
                            { 1,1,1,0,0,0,0},
                            { 1,1,1,1,0,0,0},
                            { 1,1,1,1,0,0,0}
                        };
        public static int[,] e = {
                            { 0,0,0,1,1,1,1},
                            { 0,0,0,0,1,1,1},
                            { 0,0,0,0,1,1,1}
                        };
        public static int[,] f = {
                            { 1,1,1,1,1,1,1},
                            { 1,1,1,1,1,1,1},
                            { 1,1,1,1,1,1,1}
                        };
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot_Project
{
    class Cons
    {
        public static volatile Cons instance;
        public static object key = new object();
        public static Cons Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (key)
                    {
                        instance = new Cons();
                    }
                }
                return instance;
            }
        }
        public static int DayOfWeek = 7;
        public static int DayOfColumn = 6;

        public static int dateButtonWidth = 75;
        public static int dateButtonHeight = 40;

        public static int margin = 6;
    }
}

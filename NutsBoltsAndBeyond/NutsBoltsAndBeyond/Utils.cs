using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutsBoltsAndBeyond
{
    class Utils
    {
        /*
         *  Helper functions & global variables
        */

        #region Global Variables

        public static String CONNECT_STRING = @"Server=cstnt.tstc.edu;Database=inew2330sp21;User Id=group1sp212330;password=1597159";
        public static String DB = "GROUP1SP212330";
        #endregion

        #region id generator
        /*
         *  Creates random 7-digit ID
         *  @params: void
         *  @return: int
         */

        public static int _IDGenerator()
        {
            var random = new Random();
            String id = String.Empty;
            for (int i = 0; i < 7; i++)
                id = String.Concat(id, random.Next(10).ToString());

            return Int32.Parse(id);
        }

        #endregion 
    }
}

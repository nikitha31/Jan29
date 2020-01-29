using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDemo
{
    /// <summary>
    /// class demonstrating use of "using" keyword to clear unmanaged date
    /// </summary>
    class UsingDemo
    {
        /// <summary>
        /// main method creating object for Font class (managed type which access unmanaged resources) and using "using" block to clear unamanged data 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var font2 = new Font("Arial", 10.0f);
            using (font2)
            {
                font2.GetHeight();
            }
           // font2.GetHeight(); (here this statement throws an exception because font2 is cleared at the end of using scope.
        }
        

    }

}


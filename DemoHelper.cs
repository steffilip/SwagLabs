using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SwagLabs___Final_Project
{
    public class DemoHelper
    {
        /// <summary>
        /// Brief delay to slow down browser interactions for
        /// demo video recording purposes
        /// </summary>
        /// <param name="secondsToPause"></param>
        public static void Pause(int secondsToPause = 3000)
        {
            Thread.Sleep(secondsToPause);
        }
    }
}

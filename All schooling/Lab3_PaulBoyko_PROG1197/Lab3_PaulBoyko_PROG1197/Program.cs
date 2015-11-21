using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_PaulBoyko_PROG1197
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Queue crit = new Queue("Critical");
            Queue high = new Queue("High");
            Queue normal = new Queue("Normal");
            Queue low = new Queue("Low");

            crit.Previous = high;
            high.Next = crit;
            high.Previous = normal;
            normal.Next = high;
            normal.Previous = low;
            low.Next = normal;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Process_Sheduler
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Sheduler());
        }
        public static List<Process> AddedProcesses=new List<Process>();
        public static Boolean IsProcesAdded;
        public static Int32 LastID=0;
        public static Int32 FirstID=0;
        public class Process
        {
            public String Name;
            public Int32 Priority, Memory, CP,ID,LifeTime;
        }
    }
}

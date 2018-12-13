using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace volchanka
{
    public class Program
    {
        public static class Global
        {
            public static string name { get; set; }
        }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                var file = new FileInfo(args[0]);
                if (file.Exists)
                {
                    Global.name = file.Name;
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            
        }
    }
}

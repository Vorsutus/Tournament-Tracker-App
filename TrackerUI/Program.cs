using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Initialize the DB Connections and pretends we are gong to talk to the text file and our DB
            TrackerLibrary.GlobalConfig.InitializeConnections(true, true);

            //Application.Run(new tournamentDashboardForm());
            Application.Run(new createPrizeForm());
        }
    }
}

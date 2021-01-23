using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    /// <summary>
    /// Can't instantiate GlobleConfig because it's alway public for everyone.
    /// </summary>
    public static class GlobalConfig
    {
        /// <summary>
        /// Static property that anyone can get, but private set so no one can mess with it.
        /// Only methods inside the GlobalConfig Class can set/change the value of Connections.
        /// Made it a list because we could have one or more data sources to save to and pull from.
        /// Initialize the List!
        /// </summary>
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        /// <summary>
        /// These are the connections that will be set up at the beginning of the application.
        /// Just need to pass in weather or not you want database, text files, or both.
        /// </summary>
        /// <param name="database"></param>
        /// <param name="textfiles"></param>
        public static void InitializeConnections(bool database, bool textfiles)
        {
            if (database)
            {
                //TODO - Create the SQL Connection properly (still initialization stuff that needs to be done on this class)
                SQLConnector sql = new SQLConnector();
                Connections.Add(sql);
            }

            if (textfiles)
            {
                //TODO - Create the Text file Connection properly.
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }

    }
}

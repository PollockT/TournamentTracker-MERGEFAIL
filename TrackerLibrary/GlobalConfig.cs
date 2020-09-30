using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        /// <summary>
        /// establishes connections, private set so only this file can set values
        /// any file can read values
        /// </summary>
        public static List<IDataConnection> Connections { get; private set; }
    
        /// <summary>
        /// Initializes the connections, and which way
        /// </summary>
        /// <param name="database">do you want to run off a database</param>
        /// <param name="textFiles">do you want to run off a text file</param>
        public static void InitializeConnections(bool database, bool textFiles)
        {
            if(database == true)
            {
                //TODO - Create the SQL Connection
            }

            if(textFiles == true)
            {
                //TODO - Create text file Connection
            }
        }
    }
}

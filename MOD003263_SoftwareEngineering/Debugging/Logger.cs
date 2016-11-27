using System;
using System.IO;

namespace MOD003263_SoftwareEngineering.Debug {
    public class Logger {
        private static Logger _instance;
        private StreamWriter _streamWriter;

        /// <summary>
        /// Logger Constructor
        /// </summary>
        private Logger() { }

        /// <summary>
        /// A static instance of Logger
        /// </summary>
        /// <returns>Logger instance</returns>
        public static Logger getInstance() {
            if (null == _instance) {
                _instance = new Logger();
            }
            return _instance;
        }

        /// <summary>
        /// Writes a log to a .txt file
        /// </summary>
        /// <param name="log">The log to write</param>
        public void WriteLine(string log) {
            _streamWriter = new StreamWriter("log.txt", true);
            _streamWriter.WriteLine(DateTime.Now.ToString() + ": " + log);
            _streamWriter.Close();
            _streamWriter.Dispose();
        }
    }
}

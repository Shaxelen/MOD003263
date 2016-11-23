using System;
using System.IO;

namespace MOD003263_SoftwareEngineering.Debug {
    public class Logger {
        private static Logger _instance;
        private StreamWriter _streamWriter;

        private Logger() { }

        public static Logger getInstance() {
            if (null == _instance) {
                _instance = new Logger();
            }
            return _instance;
        }

        public void WriteLine(string log) {
            _streamWriter = new StreamWriter("log.txt", true);
            _streamWriter.WriteLine(DateTime.Now.ToString() + ": " + log);
            _streamWriter.Close();
            _streamWriter.Dispose();
        }
    }
}

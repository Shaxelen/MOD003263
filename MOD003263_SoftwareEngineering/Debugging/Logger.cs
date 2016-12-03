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

        public bool WriteLine(string log) {
            try {
                _streamWriter = new StreamWriter("log.txt", true);
                _streamWriter.WriteLine(DateTime.Now.ToString() + ": " + log);
            } catch (IOException) {
                return false;
            }
            _streamWriter.Close();
            _streamWriter.Dispose();
            return true;
        }
    }
}

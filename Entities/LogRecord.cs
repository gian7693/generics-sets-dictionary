using System;
using System.Collections.Generic;

namespace Course.Entities
{
    class LogRecord
    {
        public string Username { get; set; }
        public DateTime Instante { get; set; }
        
        public LogRecord(string username,  DateTime instante)
        {
            Username = username;
            Instante = instante;
        }

        public override int GetHashCode()
        {
            return Username.GetHashCode() + Instante.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if(!(obj is LogRecord))
            {
                return false;
            }
            
            LogRecord other = obj as LogRecord;
            return Username.Equals(other.Username);
            
        }
    }
}

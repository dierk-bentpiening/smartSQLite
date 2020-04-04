using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Smart_SQLite
{
    class CsvImport
    {
        public static void Main(SQLiteConnection dbconn, Char[] splitchars, string tablename, string csvfilepath)
        {
            var db_comm = new SQLiteCommand(dbconn);
            
            string[] lines = System.IO.File.ReadAllLines(csvfilepath, Encoding.GetEncoding(65001));
            var columnnames = lines[0].Split(splitchars, StringSplitOptions.None);
            db_comm.CommandText = $"CREATE TABLE {tablename} ([{string.Join("] TEXT, [", columnnames)}] TEXT)";
            db_comm.ExecuteNonQuery();
            
            foreach (var line in lines.Skip(1))
            {
                var linesplit = line.Split(splitchars, StringSplitOptions.None);
                db_comm.CommandText = $"INSERT INTO {tablename} VALUES ({string.Join(",", linesplit)})";
                db_comm.ExecuteNonQuery();
            }

            



        }
    }
}

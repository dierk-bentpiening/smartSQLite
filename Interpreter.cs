using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_SQLite
{

    //to be continued
    class Interpreter
    {
        public static void startInterpreter()
         {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            
            while (true)
            {
                Console.Write("smartSQLiteEditor> ");
                string cmdbuffer = Console.ReadLine();
               
                if(cmdbuffer == "connect")
                {

                    Console.Write("Full path to db: ");
                    string dbpath = Console.ReadLine();
                }
            }
        }
    }
}

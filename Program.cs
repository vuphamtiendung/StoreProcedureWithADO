using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StoreProcedureWithADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProcedureClass procedure = new ProcedureClass();
            //procedure.Insert();
            //procedure.Update();
            procedure.Delete();
            ReadLine();
        }
    }
}

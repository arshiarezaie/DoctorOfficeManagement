using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorOfficeManagement.Classes
{
    public static class FormsTerminal
    {
        public static Object TerminalObject { get; set; }

        public static void ResetTerminalObject()
        {
            TerminalObject = default(object);
        }

    }
}

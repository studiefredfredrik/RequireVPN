using System;
using System.Diagnostics;

namespace RequireVPN
{
    class AppTerminator
    {
        public static Process selectedProcess;

        public static bool KillApp()
        {
            if (selectedProcess != null)
            {
                try
                {
                    selectedProcess.Kill();
                    return true;
                }
                catch(Exception)
                {
                    // There is a whole slew of reasons why killing a process might fail
                    // none of wich are interesting for the user
                }
            }
            return false;
        }
    }
}

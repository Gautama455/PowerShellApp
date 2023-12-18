using System.Management.Automation;
using System.Diagnostics;

namespace PowerShellApp
{
    class Programm
    {
        static void Main(string[] args)
        {
            var powerShell = PowerShell.Create();
            List<PSObject> processes = powerShell.AddCommand("Get-Process").Invoke().ToList();

            foreach (PSObject process in processes)
            {
                Console.WriteLine(process.ToString());
            }
        }
    }
}
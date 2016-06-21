using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace FTPSPatch
{
    class Program
    {
        static Process proc;

        static int Main(string[] args)
        {
            Console.Write("Executing ftps patch program...");            

            //Force passive mode
            string arguments = "-a ";

            //Forward all additional command lines to the child process
            foreach(string s in args)
            {
                arguments += s + " ";
            }

            //Construct process
            ProcessStartInfo start = new ProcessStartInfo();
            start.Arguments = arguments;
            start.FileName = "ftps.exe";
            start.WindowStyle = ProcessWindowStyle.Hidden;
            start.CreateNoWindow = true;
            start.RedirectStandardOutput = true;
            start.RedirectStandardError = true;
            start.UseShellExecute = false;
            int exitCode;

            //Execute ftps
            using (proc = Process.Start(start))
            {
                proc.WaitForExit();

                //Log our work :)
                StreamWriter w = File.AppendText("ftplog.txt");
                w.WriteLine("Execute on " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());
                w.WriteLine("");
                w.WriteLine("arguments = '" + arguments + "'");
                w.WriteLine("");
                w.WriteLine("Output: ");
                w.Write(proc.StandardOutput.ReadToEnd()); //Dump the ftps' standard output so we know exactly what it did
                w.WriteLine("");
                w.WriteLine("end execute");
                w.WriteLine("");

                w.Flush();
                w.Close();

                exitCode = proc.ExitCode;
            }
            
            //Return ftps' exit code to reflect it properly
            return exitCode;
        }
    }
}

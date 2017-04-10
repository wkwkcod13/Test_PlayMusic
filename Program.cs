using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.ComponentModel;

namespace mPlay
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            bool is_createdName1;
            Mutex mu1 = null;
            string mutexName1 = Process.GetCurrentProcess().MainModule.ModuleName.Replace(Path.DirectorySeparatorChar, '_');
            mu1 = new Mutex(true, "Global\\" + mutexName1, out is_createdName1);

            //重複開啟時
            if (!is_createdName1)
            {
                Process[] a = Process.GetProcessesByName(Process.GetCurrentProcess().MainModule.ModuleName);
                //Process[] a = Process.GetProcessesByName("Test_PlayMusic");
                if (a != null && a.Length > 0)
                {
                    foreach(Process b in a)
                    {
                        Console.WriteLine(b.ProcessName);
                        using (var searcher = new ManagementObjectSearcher("SELECT CommandLine FROM Win32_Process WHERE ProcessId = " + b.Id)) //在 Process 裏面找執行參數
                        {
                            foreach (var @object in searcher.Get())
                            {
                                Console.WriteLine(@object["CommandLine"]); //寫入參數
                            }
                        }
                    }
                }
                return;
            }

            string mutexRange = string.Empty;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(args));
        }
    }
}

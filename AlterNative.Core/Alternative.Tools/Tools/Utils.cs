﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace AlterNative.Tools
{
    public class Utils
    {
        public static void WriteToConsole(string message)
        {
            //AttachConsole(-1);
            //Console.WriteLine(message);
            Console.Out.WriteLine(message);
            //TextWriter stdWriter = Console.Out;
            //stdWriter.WriteLine(message);            
        }

        [DllImport("Kernel32.dll")]
        public static extern bool AttachConsole(int processId);
    }
}
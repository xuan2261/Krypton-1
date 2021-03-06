﻿using System.Drawing;
using Colorful;
using Krypton.Core;

namespace Krypton
{
    public class ConsoleLogger : ILogger
    {
        public void Success(string message)
        {
            WriteLine(message, Color.Cyan, '+');
        }

        public void Warning(string message)
        {
            WriteLine(message, Color.Orange, '-');
        }

        public void Error(string message)
        {
            WriteLine(message, Color.Red, '!');
        }

        public void Info(string message)
        {
            WriteLine(message, Color.Gray, '*');
        }

        public void InfoStr(string message, string message2)
        {
            WriteLineInfo(message, Color.Red, message2);
        }


        private void WriteLine(string message, Color color, char character)
        {
            Console.Write("[", Color.White);
            Console.Write(character, color);
            Console.Write("] ", Color.White);
            Console.WriteLine(message, color);
        }

        private void WriteLineInfo(string message, Color color, string msg2)
        {
            Console.Write("[", color);
            Console.Write(msg2, Color.White);
            Console.Write("] ", color);
            Console.WriteLine(message, Color.Aqua);
        }
    }
}
using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using class_lib_try;
using ThreadsAsync;

namespace c_sharp_connect_dll
{
    class Program
    {
        private const int DOER_COUNT = 4;

        private static IntPtr fileWriter;

        [DllImport("lib_on_c++.dll")]
        public static extern IntPtr fileWriterCreate();

        [DllImport("lib_on_c++.dll")]
        public static extern void fileWriterWrite(IntPtr fileWriter, string fileName, string fileText);

        [DllImport("lib_on_c++.dll", CharSet = CharSet.Auto)]
        public static extern void seyHiFromLib();

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, int type);

        private static void Main(string[] args)
        {
            seyHiFromLib();

            fileWriter = fileWriterCreate();
            fileWriterWrite(fileWriter, "logs.log", "Start execute");

            Thread[] threads = new Thread[DOER_COUNT];
            for (int i = 0; i < DOER_COUNT; i++)
            {
                JobDoer jobDoer = new JobDoer();
                jobDoer.IsWorking = true;
                threads[i] = new Thread(jobDoer.doJob);

                threads[i].Start();
            }

            MessageBox(IntPtr.Zero, "Начинаем исполнять задачки", "Начинаем исполнять задачки", 1);

            int taskCount;
            while (!Int32.TryParse(Console.ReadLine(), NumberStyles.Any, null, out taskCount))
            {
                
            }

            for (int i = 0; i < taskCount; i++)
            {
                Context context = new Context();
                context.TaskDelay = new Random().Next(3000);

                TaskQueue.addTask(context);
            }

            Console.ReadKey();
        }
    }
}

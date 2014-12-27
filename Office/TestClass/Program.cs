using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestClass
{
    public class Log
    {
        //Создание лог файла
        static private StreamWriter log = new StreamWriter("log.log");
        static public void Add(string msg) //Добавление сообщения в лог файл
        {
            log.WriteLine(msg);
        }

        static public void Close() //Закрыть лог файл
        {
            log.Close();
        }
    }
    abstract class Tester
    {
        protected void LogMessage(string s)
        //Добавление сообщения в лог-файл
        {
            Log.Add(s);
        }
    }

    class TCommandTester : Tester // Тестовый драйвер
    {
        Task OUT;

        public TCommandTester()
        {
            OUT = new Task();
            Run();
        }

        private void Run()
        {
            TaskTest();
        }

        private void TaskTest()
        {
            Random random = new Random();
            int[] hour = { 10, 8, 8, 14, 5, 20, -100, 25, random.Next() / 1000 };
            int[] minute = { 30, 0, 0, 45, -4, 78, -4000, 60, random.Next() / 1000 };
            int[] day = { 15, 25, 24, 15, 31, random.Next() / 1000, random.Next() / 1000, random.Next() / 1000, random.Next() / 1000 };
            int[] month = { 1, 10, 10, 2, 3, 6, -10, 26, random.Next() / 1000 };
            int[] year = { 2014, 2014, 2014, 2020, 1100, 2700, random.Next() / 100, random.Next() / 100, random.Next() / 100 };
            for (int i = 0; i < 9; i++)
            {
                LogMessage("Время:" + hour[i] + ":" + minute[i] + " дата:" + day[i] + "." + month[i] + "." + year[i] + " : " + OUT.Change(hour[i], minute[i], day[i], month[i], year[i])+OUT.ToString());
            }
        }

        static void Main()
        {
            TCommandTester CommandTester = new TCommandTester();
            Log.Close();
        }
    }

}


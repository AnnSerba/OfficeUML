using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System;
using System.IO;

namespace IntegracionnoeTestTask
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

    class TaskTester : Tester // Тестовый драйвер
    {
        Schedule OUTMain;
        public TaskTester()
        {
            Init();
        }
        public void Init()
        {
            OUTMain = new Schedule(new Register(),"Иванов");
        }
        private void Run()
        {
            ScheduleTaskTest();
        }

        private void ScheduleTaskTest()
        {
            LogMessage("Добавляем задачу в расписание");
            LogMessage(OUTMain.ToString(OUTMain.ListTask));
            for (int i = 0; i < 5; i++)
            {
                Task task = new Task();
                LogMessage("Создали по умолчанию:" + task.ToString()+" ");
                LogMessage("Изменяем на время:" + (8 + i) + ":" + 20 + " дата:" + (6 - i) + "." + 11 + "." + (int)Math.Pow(-1, i) * (2014 + i) + " ");
                LogMessage(task.Change(8+i, 20, 6-i, 11, (int)Math.Pow(-1,i)*(2014+i)));
                if (OUTMain.AddTaskToListTask(task) == true)
                {
                    LogMessage("Функция добавления задачи в расписании завершилась успешно");
                }
                else
                {
                    LogMessage("Функция добавления задачи в расписании завершилась неудачей");
                }
            }
            LogMessage(OUTMain.ToString(OUTMain.ListTask));

            for (int i = 0; i < 5; i++)
            {
                Task task = new Task();
                LogMessage("Создали по умолчанию:" + task.ToString() + " ");
                LogMessage("Изменяем на время:" + (10 - i) + ":" + (20 + i * 20) + " дата:" + 6 + "." + (11 + i) + "." + 2014 + " ");
                LogMessage(task.Change(10-i, 20+i*20, 6, 11+i, 2014));
                if (OUTMain.AddTaskToListTask(task) == true)
                {
                    LogMessage("Функция добавления задачи в расписании завершилась успешно");
                }
                else
                {
                    LogMessage("Функция добавления задачи в расписании завершилась неудачей");
                }
            }
            LogMessage(OUTMain.ToString(OUTMain.ListTask));
        }

        static void Main()
        {
            TaskTester TaskTester = new TaskTester();
            TaskTester.Run();
            Log.Close();
        }
    }
}

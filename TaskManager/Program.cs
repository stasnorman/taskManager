using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Performer worker1 = new Performer("Наталья");
            Performer worker2 = new Performer("Иван");

            Task[] tasks = {
                new Task(worker1, "Позвонить заказчику."),
                new Task(worker2, "Доработать проект по задачам от Заказчика.")
            };

            Board schedule = new Board(tasks);
            schedule.ShowAllTasks();

            Console.ReadKey();
        }
    }

    class Performer {
        public string Name;

        public Performer(string name)
        {
            Name = name;    
        }
    }

    class Board {
        public Task[] Tasks;
        public Board(Task[] tasks)
        {
            Tasks = tasks;
        }

        public void ShowAllTasks() {
            for (int i = 0; i < Tasks.Length; i++)
            {
                Tasks[i].ShowInfo();
            }
        }
    }

    class Task {
        public Performer Worker;
        public string Description;

        public Task(Performer worker, string description)
        {
            Worker = worker;
            Description = description;
        }

        public void ShowInfo() {
            Console.WriteLine($"Работник: {Worker.Name}.\nОписание задачи: {Description}");
        }
    }
}

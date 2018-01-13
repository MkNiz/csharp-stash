using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _051_operator_overloading
{
    class TaskList
    {
        private string Name { get; set; }
        private List<string> Tasks { get; set; }

        public TaskList(string name)
        {
            Name = name;
            Tasks = new List<string>();
        }

        public static TaskList operator +(TaskList tl1, TaskList tl2)
        {
            TaskList tl3 = tl1.Copy(tl1.Name + " / " + tl2.Name);
            foreach (string task in tl2.Tasks)
                tl3.Add(task);
            return tl3;
        }

        public static TaskList operator -(TaskList tl1, TaskList tl2)
        {
            foreach (string task in tl2.Tasks)
                tl1.Remove(task);
            return tl1;
        }

        public void Print()
        {
            Console.WriteLine(Name + ":");
            foreach (string task in Tasks)
            {
                Console.WriteLine("\t- " + task);
            }
            Console.WriteLine();
        }

        public void Add(String s)
        {
            Tasks.Add(s);
        }

        public void Remove(String s)
        {
            Tasks.Remove(s);
        }

        public void Remove(int idx)
        {
            Tasks.RemoveAt(idx);
        }

        public void Clear()
        {
            Tasks.Clear();
        }

        public TaskList Copy(string newName)
        {
            TaskList newTaskList = new TaskList(newName);
            foreach (string task in Tasks)
                newTaskList.Add(task);
            return newTaskList;
        }


    }
}

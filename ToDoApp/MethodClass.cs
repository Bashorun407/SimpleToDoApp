using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public class MethodClass
    {

        public static void RequiredTask(string day, List<ToDoClass> dataHolder)
        {
            while (true)
            {
                string newTask = string.Empty;
                string timeForTask = string.Empty;
                bool check2;

                Console.WriteLine($"Enter your task for {day}: ");
                newTask = Console.ReadLine();

                Console.WriteLine("Enter time to do task: ");
                timeForTask = Console.ReadLine();

                //Check if time format is correct
                check2 = TimeOnly.TryParse(timeForTask, out TimeOnly result2);

                if (check2 == false)
                {
                    Console.WriteLine("Time format entered is invalid!!");
                    break;
                }

                else
                {
                    ToDoClass newTodo = new ToDoClass(newTask, result2);
                    //Add to output list
                    dataHolder.Add(newTodo);
                }

                Console.WriteLine("If you wish to exit, enter 'NO', otherwise, press any character to continue: ");
                newTask = Console.ReadLine();
                if (newTask == "NO")
                {
                    break;
                }

            }
        }

        //Method to print tasks
        public static void PrintTask(List<ToDoClass> taskAdded)
        {
            foreach (var item in taskAdded)
            {
                Console.WriteLine(item);
            }
        }
    }
}

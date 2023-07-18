using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public class ToDoClass
    {
        private string? whatToDo;
        private string? timeToDo;

        public ToDoClass(string? whatToDo, string? timeToDo)
        {
            this.whatToDo = whatToDo;
            this.timeToDo = timeToDo;
        }

        public static void PrintTask(List<string> strings)
        {
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
        }
    }
}

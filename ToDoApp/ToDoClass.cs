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
        private TimeOnly timeToDo;

        //Class constructor
        public ToDoClass( string? whatToDo, TimeOnly time)
        {
            
            this.whatToDo = whatToDo;
            this.timeToDo = time;
        }

        public override string ToString()
        {
            return $"Task: {whatToDo}, time: {timeToDo}";
        }

    }
}

using System.ComponentModel.Design;
using ToDoApp;


Console.WriteLine("WELCOME TO OUR TODO APP");

//To display code output in colour green
Console.ForegroundColor = ConsoleColor.Green;
string input = string.Empty;
//List<ToDoClass> todo = new List<ToDoClass> { };
List<string> output = new List<string>();

while (input != "NO")
{
    //Prompts user for input
    Console.WriteLine("Select:\n 1 for Monday,\n 2 for Tuesday, \n 3 for Wednesday, \n 4 for Thursday, " +
        "\n 5 for Friday, \n 6 for Saturday, \n 7 for Sunday:\n ");
    //Accept user input
    input = Console.ReadLine();

    bool check = byte.TryParse(input, out byte result);

    //To check input by user

//To check if user inputs string

    if (check == false)
    {
        Console.WriteLine("Your input is invalid!!");
        //break;
    }


    //To check that the user inputs digit between 1 and 7
    else if (result < 1 || result > 7)
    {
        Console.WriteLine("Number input must be from 1 - 7!");
        //break;
    }

    else
    {
        //Using Switch for numbers from  1 - 7
        string task1 = string.Empty;

        switch (result)
        {
            case 1:
                Console.WriteLine("Enter your task for Monday: "); 
                task1 = Console.ReadLine();
                //Console.WriteLine($"Task added is: {task1}");
                output.Add(task1);
                break;

            case 2:
                Console.WriteLine("Enter your task for Tuesday: ");
                task1 = Console.ReadLine();
                //Console.WriteLine($"Task added is: {task1}");
                output.Add(task1);
                break;

            case 3:
                Console.WriteLine("Enter your task for Wednesday: ");
                task1 = Console.ReadLine();
                //Console.WriteLine($"Task added is: {task1}");
                output.Add(task1);
                break;

            case 4:
                Console.WriteLine("Enter your task for Thursday: ");
                task1 = Console.ReadLine();
                //Console.WriteLine($"Task added is: {task1}");
                output.Add(task1);
                break;

            case 5:
                Console.WriteLine("Enter your task for Friday: ");
                task1 = Console.ReadLine();
                //Console.WriteLine($"Task added is: {task1}");
                output.Add(task1);
                break;

            case 6:
                Console.WriteLine("No task for Saturday!");
                break;

            case 7:
                Console.WriteLine("Sunday is a day of rest...try dey rest!");
                break;
        }
    }

    Console.WriteLine("\n If you want to see your tasks, press: 1");
    input = Console.ReadLine();
    check = int.TryParse(input, out int x);

    if (x == 1)
    {
        //To display tasks to the console
        Console.WriteLine("\n\n Your tasks for the week are: \n");
        ToDoClass.PrintTask(output);
    }

    else
    {
        Console.WriteLine("Your task will be printed later.");
    }

   
    //To change the display to white
    Console.ForegroundColor = ConsoleColor.White;

    Console.WriteLine("To stop adding, enter 'NO', otherwise, enter any other character : ");
    input = Console.ReadLine() ;

    //To change the display to Green again
    Console.ForegroundColor = ConsoleColor.Green;
}

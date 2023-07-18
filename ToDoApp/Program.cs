using System.ComponentModel.Design;
using ToDoApp;


Console.WriteLine("WELCOME TO OUR TODO APP");

//To display code output in colour green
Console.ForegroundColor = ConsoleColor.Green;
string input = string.Empty;

//output will be our in-built memory
List<ToDoClass> output = new List<ToDoClass>();

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

        switch (result)
        {
            case 1:
                MethodClass.RequiredTask("Monday", output);
                break;

            case 2:
                MethodClass.RequiredTask("Tuesday", output);
                break;

            case 3:
                Console.WriteLine("Wednesdays are for Assessments");
                break;

            case 4:
                MethodClass.RequiredTask("Thurday", output);
                break;

            case 5:
                MethodClass.RequiredTask("Friday", output);
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

    if (check)
    {
        //To display tasks to the console
        Console.WriteLine("Your tasks for the week are: \n");
        MethodClass.PrintTask(output);
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

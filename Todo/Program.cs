using System;

namespace TodoApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                UI.ShowMainMenu();
                int input;
                Int32.TryParse(Console.ReadLine(), out input);
                if (input == 1)
                {
                    UI.Clear();
                    UI.ShowAllTodos();
                    Int32.TryParse(Console.ReadLine(), out input);
                    if (input == 1)
                    {
                        UI.ShowMarkAsDone();
                        Int32.TryParse(Console.ReadLine(), out input);
                        Console.Write(TodoManager.MarkAsDone(input));
                        FileHandler.UpdateFile();
                        UI.ShowSuccess();
                        Console.ReadLine();
                    }
              
                }
                else if (input == 2)
                {
                    UI.ShowCreateDialog();
                    string str = Console.ReadLine();
                    TodoManager.Create(str);
                    FileHandler.UpdateFile();
                }
                else { }
            }

           
            
        }
    }
}

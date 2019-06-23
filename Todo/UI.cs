using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApplication
{
    class UI
    {
        public static void ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("---------- Todo Application ----------\n");
            Console.WriteLine("1. All Todo List\n2. Create Todo\n3. Exit\n");
        }
        public static void ShowAllTodos()
        {
            UI.Clear();
            Console.WriteLine("---------- All Todos ----------\n");
            List<Todo> todos = FileHandler.GetTodosFromFile();
            foreach(Todo todo in todos)
            {
                Console.Write(todo.number);
                Console.Write(" ");
                Console.Write(todo.name);
                Console.Write(" ");
                Console.Write(todo.status);
                if (todo.status == 1) Console.Write("(done)");
                else Console.Write("(open)");
                Console.WriteLine();

            }
            Console.WriteLine("\n\n1. Mark Todo as done\n2. Back to Main Menu\n");
        }
        public static void Clear()
        {
            Console.Clear();
        }
        public static void ShowCreateDialog()
        {
            UI.Clear();
            Console.WriteLine("---------- Create Todo ----------\n");
            Console.WriteLine("---------- Enter The Name of Todo ----------");
        }
        public static void ShowMarkAsDone()
        {
            Console.WriteLine("---------- Enter The Number of todo you want to mark as done ----------");
        }
        public static void ShowSuccess()
        {
            Console.WriteLine("---------- Successfully marked as done . press enter to go back to main menu ----------");
        }
    }
}

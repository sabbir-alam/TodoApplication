using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TodoApplication
{
    class FileHandler
    {
        private static string path = @"C:\Users\sabbir.alam\Desktop\data.csv";
        public static void UpdateFile()
        {
            List<Todo> allTodos = TodoManager.getTodos();
            
            System.IO.File.WriteAllText(path, string.Empty);
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path))
            {
                foreach (Todo todo in allTodos)
                {
                    file.WriteLine(todo.toCSV());
                }
            }
        }
        public static List<Todo> GetTodosFromFile()
        {
            List<Todo> todos = new List<Todo>();
            foreach (string reader in File.ReadAllLines(path))
            {
                Todo todo = new Todo(reader);
                todos.Add(todo);
            }
            return todos;
        }
    }
}

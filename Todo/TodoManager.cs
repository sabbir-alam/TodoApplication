using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApplication
{
    class TodoManager
    {
        private static List<Todo> todos  = FileHandler.GetTodosFromFile();
        public static void Create(string line)
        {
            string str = (int)todos.Count + "," + line + ",0";
            Todo todo = new Todo(str);
            todos.Add(todo);
        }
        public static List<Todo> getTodos()
        {
            return todos;
        }
        public static bool MarkAsDone(int num)
        {
            int success = 0;
            foreach(Todo todo in todos)
            {
                if(todo.number == num)
                {
                    success = 1;
                    todo.status = 1;
                }
            }
            return success == 1;
        }
    }
}

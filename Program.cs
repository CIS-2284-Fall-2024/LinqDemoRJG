using LinqDemo.Models;
using Microsoft.Identity.Client;

namespace LinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Get a todo from user
                ToDo todo = new ToDo();
                todo.Title = Input("Please enter Title for Todo (or enter to quit): ");
                if (string.IsNullOrEmpty(todo.Title)) break;
                todo.Description = Input("Please enter description");

                //Add to database
                ApplicationDbContext context = new ApplicationDbContext();
                context.ToDos.Add(todo);
                context.SaveChanges();
            }
        }

        private static string Input(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}

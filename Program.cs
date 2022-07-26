using System;
using System.Collections.Generic;

namespace TaskManager
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var cont = true;
            var tasklist = new List<task>();
            int choice;
            string tempname;
            do
            {

                Console.WriteLine("\nWelcome to the Task Manager");
                Console.WriteLine("Please choose from the menu:");
                Console.WriteLine("1. Create a Task");
                Console.WriteLine("2. Delete a Task");
                Console.WriteLine("3. Edit a Task");
                Console.WriteLine("4. Complete a Task");
                Console.WriteLine("5. List not completed tasks");
                Console.WriteLine("6. List all tasks");
                Console.WriteLine("7. Search");
                Console.WriteLine("8. Exit");

                if (int.TryParse(Console.ReadLine(), out int temp))
                {
                    if (temp > 0 && temp < 8)
                    {
                        choice = temp;
                        switch (choice)
                        {
                            case 1:
                                var newtask = new Task();
                                Console.WriteLine("What is the Name?");
                                newtask.Name = Console.ReadLine();

                                Console.WriteLine("What is the description?");
                                newtask.Description = Console.ReadLine();
                                Console.WriteLine("When is the deadline?");
                                newtask.Deadline = Console.ReadLine();
                                tasklist.Add(newtask);
                                Console.WriteLine("\nTask added to tasklist!");
                                break;
                            case 2:
                                
                                if (tasklist.Count > 0)
                                {
                                    Console.WriteLine("What is the name of the Task you wish to delete?");
                                    tempname = Console.ReadLine();
                                    for(int i=0; i<tasklist.Count; i++)
                                    {
                                        if (tempname == tasklist[i].Name)
                                        {
                                            Console.WriteLine(tasklist[i].Name + "\t" + tasklist[i].Description + "\t" + tasklist[i].Deadline);
                                            Console.WriteLine("Is this the task you wish to delete?(y/n)");
                                            var ans = Console.ReadLine();
                                            if (ans == "y" || ans == "Y")
                                            {
                                                tasklist.RemoveAt(i);
                                                Console.WriteLine("\n Task deleted!");
                                            }

                                        }
                                        
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No tasks in the tasklist! ");
                                }
                                break;

                            case 3:
                               
                                if (tasklist.Count > 0)
                                {
                                    Console.WriteLine("What is the name of the Task you wish to edit?");
                                    tempname = Console.ReadLine();
                                    foreach (var task in tasklist)
                                    {
                                        if (tempname == task.Name)
                                        {
                                            Console.WriteLine(task.Name + "\t" + task.Description + "\t" + task.Deadline);
                                            Console.WriteLine("Is this the task you wish to edit?(y/n)");
                                            var ans = Console.ReadLine();
                                            if (ans == "y" || ans == "Y")
                                            {
                                                Console.WriteLine("What is the new Name?");
                                                task.Name = Console.ReadLine();
                                                Console.WriteLine("What is the new description?");
                                                task.Description = Console.ReadLine();
                                                Console.WriteLine("When is the new deadline?");
                                                task.Deadline = Console.ReadLine();
                                                Console.WriteLine("\nTask edit success!");
                                            }

                                        }
                                       
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No tasks in the tasklist! ");
                                }
                                break;
                            case 4:
                               
                                if (tasklist.Count > 0)
                                {
                                    Console.WriteLine("What is the name of the task you wish to complete?");
                                    tempname = Console.ReadLine();
                                    foreach (var task in tasklist)
                                    {
                                        if (tempname == task.Name)
                                        {
                                            Console.WriteLine(task.Name + "\t" + task.Description + "\t" + task.Deadline);
                                            Console.WriteLine("Is this the task you wish to complete?(y/n)");
                                            var ans = Console.ReadLine();
                                            if (ans == "y" || ans == "Y")
                                            {
                                                task.IsCompleted = true;
                                            }

                                        }
                                       
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No tasks in the tasklist! ");
                                }
                                break;




                            case 5:
                                bool contain = false;
                                if(tasklist.Count > 0)
                                {
                                    Console.WriteLine("\nNot Completed Tasks:\n");
                                    foreach (var task in tasklist)
                                    {
                                        if (task.IsCompleted == false)
                                        {
                                           
                                            Console.WriteLine(task.Name + "\t" + task.Description + "\t" + task.Deadline);
                                            contain = true;
                                        }
                                       

                                    }
                                    if(contain == false)
                                    {
                                        Console.WriteLine("All tasks are completed!");
                                    }
                                    Console.WriteLine("\n");
                                }
                                else
                                {
                                    Console.WriteLine("No tasks in the tasklist! ");
                                }

                                
                                break;


                             
                            case 6:
                                
                                if (tasklist.Count > 0)
                                {
                                    Console.WriteLine("\nTasks in the Tasklist:\n");
                                    foreach (var task in tasklist)
                                    {
                                        Console.WriteLine(task.Name + "\t" + task.Description + "\t" + task.Deadline);

                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No tasks in the tasklist! ");
                                }
                                Console.WriteLine("\n");
                                break;


                            case 7:
                                break;
                            case 8:
                                cont = false;
                                Console.WriteLine("Goodbye :D");
                                break;
                                
                        }
                    }
                    else
                        Console.WriteLine("Choose option 1-5");

                }
                else
                {
                    Console.WriteLine("Choose option 1-5");
                }

                

            } while (cont);

           

        }
    }
}

using System;
using System.Transactions;
using System.Collections.Generic;
class CollectionApp
{


    public void ListOperations()
    {
        List<string> list = new List<string>();

        Console.WriteLine("Enter the number of list operations you want to perform");

        int n = Convert.ToInt32(Console.ReadLine());

        for (int p = 0; p < n; p++)
        {

            while (true)
            {
                Console.WriteLine("Enter the operation you want to perform");
                Console.WriteLine("1.Add\n2.Read\n3.Update\n4.Delete");
                Console.WriteLine("Enter your choice:");

                int op = Convert.ToInt32(Console.ReadLine());

                if (op == 1)
                {
                    Console.WriteLine("You Chose Add Operation");

                    Console.WriteLine("Enter the String you want to Add:");
                    string ?str = Console.ReadLine();
                    list.Add(str);
                    break;
                }
                else if (op == 2)
                {
                    Console.WriteLine("You Chose Display Opertaion");

                    int size = list.Count;

                    if (size == 0)
                    {
                        Console.WriteLine("The List is Empty!");
                    }
                    else
                    {
                        Console.WriteLine("The List Contains: ");
                        for (int i = 0; i < size; i++)
                        {
                            if (i == size - 1) Console.WriteLine(list[i]);
                            else Console.Write(list[i] + ',');
                        }
                    }
                    break;
                }
                else if (op == 3)
                {
                    Console.WriteLine("You Chose Update Operation");

                    Console.WriteLine("Enter the index to update: ");
                    int idx = Convert.ToInt32(Console.ReadLine());
                    if (idx >= list.Count)
                    {
                        Console.WriteLine("The Index you have entered is not valid");
                    }
                    else
                    {
                        Console.WriteLine("Enter new string");
                        list[idx] = Console.ReadLine();
                    }
                    break;
                }
                else if (op == 4)
                {
                    Console.WriteLine("You Chose Delete Operation");

                    Console.WriteLine("Enter String to Delete");
                    string ?str = Console.ReadLine();
                    if (list.Contains(str))
                    {
                        list.Remove(str);
                        Console.WriteLine("Successfully Deleted the String");
                    }
                    else
                    {
                        Console.WriteLine("The String you want to delete does not exist in the list!");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("The Choice You Entered is Wrong, Please Enter a Valid one!");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
        }
    }

    public void SetOperations()
    {
        HashSet<String> set = new HashSet<String>();

        Console.WriteLine("Enter the number of Set Operations you want to perform");

        int n = Convert.ToInt32(Console.ReadLine());

        for (int p = 0; p < n; p++)
        {
            while (true)
            {
                Console.WriteLine("Enter the operation you want to perform");
                Console.WriteLine("1.Add\n2.Read\n3.Update\n4.Delete");

                Console.WriteLine("Enter your choice:");

                int op = Convert.ToInt32(Console.ReadLine());
                if (op == 1)
                {
                    Console.WriteLine("You Chose Add Operation");
                    Console.WriteLine("Enter the String you want to Add:");
                    string str = Console.ReadLine();
                    set.Add(str);
                    Console.WriteLine("Value Added to Set Successfully");
                    break;
                }

                else if (op == 2)
                {
                    Console.WriteLine("You Chose Display Opertaion");

                    int size = set.Count;
                    if (size == 0) Console.WriteLine("The Set is Empty!");
                    else
                    {
                        Console.WriteLine("Set: ");
                        foreach (var s in set)
                        {
                            Console.Write(s + " ");
                        }
                    }
                    break;
                }

                else if (op == 3)
                {
                    Console.WriteLine("You Chose Update Operation");

                    Console.WriteLine("Set items cannot be updated!");
                    break;
                }

                else if (op == 4)
                {
                    Console.WriteLine("You Chose Delete Operation");

                    Console.WriteLine("Enter the string you want to remove from the set");
                    string ?str = Console.ReadLine();
                    if (set.Contains(str))
                    {
                        set.Remove(str);
                        Console.WriteLine("The String has been removed successfully!");
                    }
                    else
                    {
                        Console.WriteLine("The Set Does not Contain  the String you entered");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("You  Entered Invalid Choice! Please Enter valid choice");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
        }
    }

    public void DictionaryOperations()
    {
        Dictionary<int, string> Dict = new Dictionary<int, string>();

        Console.WriteLine("Enter the number of Dictionary Operations you want to perform");

        int n = Convert.ToInt32(Console.ReadLine());

        for (int p = 0; p < n; p++)
        {
            while (true)
            {
                Console.WriteLine("Enter the operation you want to perform");
                Console.WriteLine("1.Add\n2.Read\n3.Update\n4.Delete");

                Console.WriteLine("Enter your choice:");

                int op = Convert.ToInt32(Console.ReadLine());

                if (op == 1)
                {
                    Console.WriteLine("You Chose Add Operation");

                    Console.WriteLine("Enter Key: ");
                    int key = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Value: ");
                    Dict[key] = Console.ReadLine();
                    break;
                }

                else if (op == 2)
                {
                    Console.WriteLine("You Chose Display Opertaion");
                    int size = Dict.Count;
                    if (size == 0)
                    {
                        Console.WriteLine("The Dictionary is Empty!");
                    }
                    else
                    {
                        foreach (var it in Dict)
                        {
                            Console.WriteLine(it.Key + "->" + it.Value);
                        }
                    }
                    break;
                }

                else if (op == 3)
                {
                    Console.WriteLine("You Chose Update Operation");

                    Console.WriteLine("Enter key to update: ");
                    int key = Convert.ToInt32(Console.ReadLine());

                    if (Dict.ContainsKey(key))
                    {
                        Console.WriteLine("Enter new value: ");
                        Dict[key] = Console.ReadLine();
                        Console.WriteLine("Value Updated Successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Key not found in Dictionary, Update Failed");
                    }
                    break;
                }

                else if (op == 4)
                {
                    Console.WriteLine("You Chose Delete Operation");

                    Console.WriteLine("Enter key to Delete: ");
                    int key = Convert.ToInt32(Console.ReadLine());
                    if (Dict.ContainsKey(key))
                    {
                        Dict.Remove(key);
                        Console.WriteLine("Key Removed Successfully");
                    }
                    else
                    {
                        Console.WriteLine("The Dictionarydoes not  contain the key you entered, Deletion Failed");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("You  Entered Invalid Choice! Please Enter valid choice");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
        }
    }
}

class Program
{
    static void Main()
    {
        CollectionApp app = new CollectionApp();
        while (true)
        {
            Console.WriteLine("Choose a Collection: ");
            Console.WriteLine("1.List\n2.Set\n3.Dictionary");

            Console.WriteLine("\n");

            Console.WriteLine("Enter a Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            if (choice == 1)
            {
                Console.WriteLine("You Chose List Collection");
                app.ListOperations();
                break;
            }

            else if (choice == 2)
            {
                Console.WriteLine("You Chose Set Collection");
                app.SetOperations();
                break;
            }

            else if (choice == 3)
            {
                Console.WriteLine("You Chose Dictionary Collection");
                app.DictionaryOperations();
                break;
            }
            else
            {
                Console.WriteLine("Your Choice is Invalid! Please Choose Again.");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_LINKEDLIST_CSHARP
{
    class LinkedList
    {

        static void Main(string[] args)
        {
            Console.WriteLine("********** Welcome to Linked List **********");

            Console.WriteLine("Please enter data to be stored: ");
            string data = Console.ReadLine();
            Node<string> first_node = new Node<string>(data);
            Node<string> PreviousNode = first_node;

            while (true)
            {
                try {
                    Console.WriteLine("Would you like to add more information (y/n): ");
                    char c = Console.ReadLine().ElementAt<char>(0);
                    if (c == 'n' || c == 'N')
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                    }

                    Console.WriteLine("Please enter data to be stored: ");
                    string tmp_data = Console.ReadLine();
                    Node<String> tmp_node = new Node<string>(tmp_data, PreviousNode);
                    PreviousNode = tmp_node;
                }
                catch { }
            }

            Console.WriteLine("Data Stored in Linked List as follows: ");
            Console.WriteLine(first_node.ListToString());
            Console.ReadKey();
        }

        
    }
}

using System;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number"
                + "\n(1, 2, 3 ,4, 0) of your choice"
                + "\n1. Examine a List"
                + "\n2. Examine a Queue"
                + "\n3. Examine a Stack"
                + "\n4. CheckParanthesis"
                + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.WriteLine("Please enter some input!");
                    Console.WriteLine(input);
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4,5)");
                        break;
                }
            }
        }





        static void ExamineList()
        {
            char firstChar = ' ';
            string value = " ";
            List<string> theList = new List<string>();
            Console.Clear();
            do
            {
                Console.WriteLine("**** List  *****\n" +
                    "+ Followed by a string to add\n" +
                    "- Followed by a string to delete from list\n" +
                    "l View det list\n" +
                    "m Back to menue");
                try
                {
                    string? listInput = Console.ReadLine(); 
                    firstChar = listInput[0];
                    value = listInput.Substring(1).Trim();
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                }
                switch (firstChar)
                {
                    case '+':
                        if (!theList.Contains(value))
                        {
                            theList.Add(value);
                            Console.Clear();
                            Console.WriteLine(value + " : is added to list");
                            Console.WriteLine("Capacity: " + theList.Capacity + " Count: " + theList.Count);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(value + " : Already exsist");
                        }
                        break;
                    case '-':
                        if (theList.Contains(value))
                        {
                            theList.Remove(value);
                            Console.Clear();
                            Console.WriteLine(value + " : Delted");
                        }
                        else if (theList.Count > 0 && !theList.Contains(value))
                        {
                            Console.Clear();
                            Console.WriteLine(value + " : Not exsists in the list");
                        }
                        else if (theList.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("List is empty");
                        }
                        break;
                    case 'l':
                        if (theList.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("List is empty");
                        }
                        else
                        {
                            Console.Clear();
                            Console.Write("Preson in the list: ");
                            foreach (string person in theList)
                                Console.Write(person + " ");
                            Console.WriteLine();
                        }
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            } while (firstChar != 'm');
        }


        /// <summary>
        /// FIFO
        /// </summary>
        static void ExamineQueue()
        {
            Queue<string> myQueue = new Queue<string>();
            char input = ' ';
            string? value = "";
            Console.Clear();
            do
            {
                Console.WriteLine("**** Queue *****\n" +
                "+ Followed by a string to Add\n" +
                "- Delete element\n" +
                "l View elemen\n" +
                "m Back to menue");
                try
                {
                    string? queueInput = Console.ReadLine();
                    input = queueInput[0];
                    value = queueInput.Substring(1).Trim();
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                }
                switch (input)
                {
                    case '+':
                        myQueue.Enqueue(value);
                        Console.Clear();
                        Console.WriteLine("Count: " + myQueue.Count);
                        Console.WriteLine(value + " added to queue");
                        break;
                    case '-':
                        try
                        {
                            myQueue.Dequeue();
                            Console.Clear();
                            Console.WriteLine("Count: " + myQueue.Count);
                        }
                        catch (InvalidOperationException)
                        {
                            Console.Clear();
                            Console.WriteLine("Queue is empty");

                        }
                        break;
                    case 'l':
                        Console.Clear();
                        if (myQueue.Count > 0)
                        {
                            Console.Write("Elements in queue: ");
                            foreach (string queueElement in myQueue)
                                Console.Write(queueElement + " ");
                            Console.WriteLine();
                        }
                        else if (myQueue.Count == 0)
                        {
                            Console.WriteLine("Elements in queue: 0");
                        }
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            } while (input != 'm');
        }



        /// <summary>
        /// LIFO
        /// </summary>
        static void ExamineStack()
        {
            Stack<string> myStack = new Stack<string>();
            char input = ' ';
            string? value = "";
            Console.Clear();
            do
            {
                Console.WriteLine("**** Stack *****\n" +
                "+ Followed by a string to Add\n" +
                "- Delete element\n" +
                "l View elemen\n" +
                "m Back to menue");
                try
                {
                    string? stackInput = Console.ReadLine();
                    input = stackInput[0];
                    value = stackInput.Substring(1).Trim();
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                }
                switch (input)
                {
                    case '+':
                        myStack.Push(value);
                        Console.Clear();
                        Console.WriteLine("Count: " + myStack.Count);
                        Console.WriteLine(value + " added to stack");
                        break;
                    case '-':
                        try
                        {
                            myStack.Pop();
                            Console.Clear();
                            Console.WriteLine("Count: " + myStack.Count);
                        }
                        catch (InvalidOperationException)
                        {
                            Console.Clear();
                            Console.WriteLine("Queue is empty");

                        }
                        break;
                    case 'l':
                        Console.Clear();
                        if (myStack.Count > 0)
                        {
                            Console.Write("Elements in queue: ");
                            foreach (string stackElement in myStack)
                                Console.Write(stackElement + " ");
                            Console.WriteLine();
                        }
                        else if (myStack.Count == 0)
                        {
                            Console.Write("Elements in queue: 0");
                        }
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            } while (input != 'm');
        }

        static void CheckParanthesis()
        {
            Stack<char> checkStack = new Stack<char>();
            char? input = ' ';
            string value = "";
            Console.Clear();
            do
            {
                Console.WriteLine("**** Paranthesis *****\n" +
                "i Followed by a string\n" +
                "m Back to menue");
                try
                {
                    string? testInput = Console.ReadLine();
                    input = testInput[0];
                    value = testInput.Substring(1).Trim();
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                }

                switch (input)
                {
                    case 'i':
                        if (value.Length < 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Please give me a string!");
                        }
                        else
                        {
                            for (int i = 0; i < value.Length; i++)
                            {
                                if (checkStack.Count == 0)
                                {
                                    checkStack.Push(value[i]);
                                }
                                else if ((checkStack.Peek() == '{' && value[i] == '}') ||
                                    (checkStack.Peek() == '[' && value[i] == ']') ||
                                    (checkStack.Peek() == '<' && value[i] == '>') ||
                                    (checkStack.Peek() == '(' && value[i] == ')'))
                                {
                                    checkStack.Pop();
                                }
                                else
                                {
                                    checkStack.Push(value[i]);
                                }
                            }
                            if (checkStack.Count == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Correct");
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Not correct");
                            }
                        }
                        break;
                    case 'm':
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            } while (input != 'm');
        }

    }

}


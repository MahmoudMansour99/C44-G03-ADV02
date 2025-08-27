using System.Collections;
using System.Globalization;

namespace Assignment
{
    internal class Program
    {
        static void ReverseQueue(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();

            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }

        static List<int> RemoveDuplicates(int[] arr)
        {
            List<int> result = new List<int>();

            foreach (int num in arr)
            {
                if (!result.Contains(num)) 
                {
                    result.Add(num);
                }
            }

            return result;
        }
        static void RemoveOdd(ArrayList list)
        {
            for (int i = list.Count - 1; i >= 0; i--) 
            {
                if ((int?)list[i] % 2 != 0)  
                {
                    list.RemoveAt(i);
                }
            }
        }

        static void SearchInStack(Stack<int> stack, int target)
        {
            int count = 0;
            bool found = false;

            Stack<int> temp = new Stack<int>();

            while (stack.Count > 0)
            {
                count++;
                int top = stack.Pop();
                temp.Push(top);

                if (top == target)
                {
                    found = true;
                    break;
                }
            }

            while (temp.Count > 0)
            {
                stack.Push(temp.Pop());
            }

            if (found)
            {
                Console.WriteLine($"Target was found successfully and the count = {count}");
            }
            else
            {
                Console.WriteLine("Target was not found");
            }
        }

        static void ReverseFirstK(Queue<int> queue, int k)
        {
            if (k <= 0 || k > queue.Count) return;

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < k; i++)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

            int size = queue.Count;
            for (int i = 0; i < size - k; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }
        }

        static void Main(string[] args)
        {
            #region Question 01

            //Console.WriteLine("Enter size of array and number of queries like (3 5)");
            //string[] array = Console.ReadLine().Split();

            //int n, q;
            //if (!int.TryParse(array[0], out n) || !int.TryParse(array[1], out q))
            //{
            //    Console.WriteLine("Invalid input for N or Q.");
            //    return;
            //}

            //Console.WriteLine($"Enter {n} integers for the array (Separated Space):");
            //List<int> list = new List<int>();
            //string[] numbers = Console.ReadLine().Split();

            //for (int i = 0; i < n; i++)
            //{
            //    int value;
            //    if (int.TryParse(numbers[i], out value))
            //    {
            //        list.Add(value);
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Invalid number at position {i + 1}.");
            //        return;
            //    }
            //}

            //list.Sort();

            //for (int i = 0; i < q; i++)
            //{
            //    Console.WriteLine($"Enter query #{i + 1}:");
            //    string queryInput = Console.ReadLine();
            //    int x;
            //    if (!int.TryParse(queryInput, out x))
            //    {
            //        Console.WriteLine("Invalid query input.");
            //        continue;
            //    }

            //    int index = list.BinarySearch(x);

            //    if (index < 0)
            //    {
            //        index = ~index;
            //    }
            //    else
            //    {

            //        while (index < list.Count && list[index] <= x)
            //        {
            //            index++;
            //        }
            //    }
            //    int count = n - index;
            //    Console.WriteLine($"Numbers greater than {x}: {count}");
            //}

            #endregion

            #region Question 02
            //Console.WriteLine("Enter the size of array:");
            //string ArraySize = Console.ReadLine();
            //int n;

            //if (!int.TryParse(ArraySize, out n) || n <= 0)
            //{
            //    Console.WriteLine("Invalid size input.");
            //    return;
            //}

            //Console.WriteLine($"Enter {n} integers (Separated Space):");
            //string[] numbers = Console.ReadLine().Split();

            //if (numbers.Length != n)
            //{
            //    Console.WriteLine("Number of inputs does not match size.");
            //    return;
            //}

            //List<int> arr = new List<int>();

            //for (int i = 0; i < n; i++)
            //{
            //    int value;
            //    if (int.TryParse(numbers[i], out value))
            //    {
            //        arr.Add(value);
            //    }
            //    else
            //    {
            //        Console.WriteLine($"❌ Invalid number at position {i + 1}.");
            //        return;
            //    }
            //}

            //bool isPalindrome = true;
            //for (int i = 0; i < n / 2; i++)
            //{
            //    if (arr[i] != arr[n - i - 1])
            //    {
            //        isPalindrome = false;
            //        break;
            //    }
            //}

            //Console.WriteLine(isPalindrome ? "YES" : "NO");

            #endregion

            #region Question 03
            //Queue<int> queue = new Queue<int>();
            //Console.WriteLine("Enter elements of the queue (Separated Space):");
            //string[] inputs = Console.ReadLine().Split();

            //foreach (string s in inputs)
            //{
            //    if (int.TryParse(s, out int value))
            //        queue.Enqueue(value);
            //    else
            //    {
            //        Console.WriteLine($"Invalid number: {s}");
            //        return;
            //    }
            //}

            //Console.WriteLine("Original Queue: " + string.Join(" ", queue));

            //ReverseQueue(queue);

            //Console.WriteLine("Reversed Queue: " + string.Join(" ", queue));
            #endregion

            #region Question 04

            #endregion

            #region Question 05
            //Console.WriteLine("Enter array elements (Separated Space):");
            //string[] input = Console.ReadLine().Split();
            //int[] arr = new int[input.Length];

            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (!int.TryParse(input[i], out arr[i]))
            //    {
            //        Console.WriteLine($"Invalid number at position {i + 1}");
            //        return;
            //    }
            //}

            //List<int> noDuplicates = RemoveDuplicates(arr);

            //Console.WriteLine("Array without duplicates:");
            //Console.WriteLine(string.Join(" ", noDuplicates));

            #endregion

            #region Question 06
            //Console.WriteLine("Enter elements of the array (Separated Space):");
            //string[] input = Console.ReadLine().Split();

            //ArrayList arr = new ArrayList();
            //foreach (string s in input)
            //{
            //    if (int.TryParse(s, out int value))
            //        arr.Add(value);
            //    else
            //    {
            //        Console.WriteLine($"Invalid number: {s}");
            //        return;
            //    }
            //}

            //Console.WriteLine("Original ArrayList: " + string.Join(" ", arr.ToArray()));

            //RemoveOdd(arr);

            //Console.WriteLine("ArrayList after removing odd numbers: " + string.Join(" ", arr.ToArray()));
            #endregion

            #region Question 07
            //Queue<object> queue = new Queue<object>();

            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question 08
            //Stack<int> stack = new Stack<int>();
            //Console.WriteLine("Enter integers to push onto the stack (Separated Space):");
            //string[] inputs = Console.ReadLine().Split();

            //foreach (string s in inputs)
            //{
            //    if (int.TryParse(s, out int value))
            //        stack.Push(value);
            //    else
            //    {
            //        Console.WriteLine($"Invalid input: {s}");
            //        return;
            //    }
            //}

            //Console.WriteLine("Enter the target integer to search:");
            //if (!int.TryParse(Console.ReadLine(), out int target))
            //{
            //    Console.WriteLine("Invalid target input.");
            //    return;
            //}

            //SearchInStack(stack, target);
            #endregion

            #region Question 09

            #endregion

            #region Question 10

            #endregion

            #region Question 11 
            //Console.WriteLine("Enter elements of the queue (space-separated):");
            //string[] input = Console.ReadLine().Split();
            //Queue<int> queue = new Queue<int>();

            //foreach (string s in input)
            //{
            //    if (int.TryParse(s, out int val))
            //        queue.Enqueue(val);
            //    else
            //    {
            //        Console.WriteLine($"Invalid number: {s}");
            //        return;
            //    }
            //}

            //Console.WriteLine("Enter K:");
            //int k = int.Parse(Console.ReadLine());

            //ReverseFirstK(queue, k);

            //Console.WriteLine("Queue after reversing first K elements:");
            //Console.WriteLine("[" + string.Join(", ", queue) + "]");
            #endregion
        }
    }
}

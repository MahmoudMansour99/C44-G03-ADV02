using System.Collections;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Revision

            #endregion

            #region Collections

            #endregion

            #region Non-Generic Collections [ArrayList]
            ArrayList arrayList = new ArrayList();

            Console.WriteLine($"{arrayList.Capacity}, {arrayList.Count}");

            #region Add Element
            arrayList.Add(1); // Boxing
            Console.WriteLine($"{arrayList.Capacity}, {arrayList.Count}");

            arrayList.AddRange(new int[] { 2, 3, 4 });
            Console.WriteLine($"{arrayList.Capacity}, {arrayList.Count}");

            arrayList.Add(5); // Boxing
            Console.WriteLine($"{arrayList.Capacity}, {arrayList.Count}");

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            #endregion
            #endregion
        }
    }
}

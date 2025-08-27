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
            //ArrayList arrayList = new ArrayList();

            //Console.WriteLine($"{arrayList.Capacity}, {arrayList.Count}");

            #region Add Element
            //arrayList.Add(1); // Boxing
            //Console.WriteLine($"{arrayList.Capacity}, {arrayList.Count}");

            //arrayList.AddRange(new int[] { 2, 3, 4 });
            //Console.WriteLine($"{arrayList.Capacity}, {arrayList.Count}");

            //arrayList.Add(5); // Boxing
            //Console.WriteLine($"{arrayList.Capacity}, {arrayList.Count}");

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Insert Element

            //arrayList.Insert(1, 10); // Boxing
            //Console.WriteLine("///////////");
            //Console.WriteLine($"{arrayList.Capacity}, {arrayList.Count}");
            //foreach (var item in arrayList) // Unboxing
            //{
            //    Console.WriteLine(item);
            //}

            ////arrayList.Insert(7, 200); // Our=t of range
            //arrayList.InsertRange(2, new int[] { 20, 30, 40 });
            //Console.WriteLine("///////////");
            //Console.WriteLine($"{arrayList.Capacity}, {arrayList.Count}");
            //foreach (var item in arrayList) 
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Trim To Size
            //Console.WriteLine($"{arrayList.Capacity}, {arrayList.Count}");
            //arrayList.TrimToSize();
            //Console.WriteLine($"{arrayList.Capacity}, {arrayList.Count}");

            //arrayList.Add(100);
            //Console.WriteLine($"{arrayList.Capacity}, {arrayList.Count}");

            #endregion

            //Console.WriteLine($"{arrayList.Capacity}, {arrayList.Count}");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //arrayList.Remove(2);
            ////arrayList.RemoveAt(5);
            ////Console.WriteLine($"{arrayList.Capacity}, {arrayList.Count}");
            ////foreach (var item in arrayList)
            ////{
            ////    Console.WriteLine(item);
            ////}

            ////int firstElement = (int?)arrayList[0] ?? 0;

            //Console.WriteLine(arrayList.Contains(1));

            //arrayList = new ArrayList() { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"{arrayList.Capacity}, {arrayList.Count}");

            //arrayList = new ArrayList(10) { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"{arrayList.Capacity}, {arrayList.Count}");

            //arrayList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            //Console.WriteLine($"{arrayList.Capacity}, {arrayList.Count}");

            //arrayList = new ArrayList();

            #endregion


        }
    }
}

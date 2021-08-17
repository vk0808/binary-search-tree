using System;

namespace BinarySearchTreeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Program\n");

            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            binarySearch.Display();
        }
    }
}

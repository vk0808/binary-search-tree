using System;

namespace BinarySearchTreeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Program\n");

            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
            binarySearch.Insert(3);
            binarySearch.Insert(11);
            binarySearch.Insert(16);
            binarySearch.Insert(22);
            binarySearch.Insert(30);
            binarySearch.Insert(40);
            binarySearch.Insert(60);
            binarySearch.Insert(63);
            binarySearch.Insert(65);
            binarySearch.Insert(67);
            binarySearch.Insert(70);
            binarySearch.Insert(95);
            binarySearch.Display();


            int searchElement = 63; 

            bool result = binarySearch.IfExists(searchElement, binarySearch);

            if (!result)
            {
                Console.WriteLine($"{searchElement} cannot be found in BST");
            }
        }
    }
}

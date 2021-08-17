using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTreeProblem
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        // instance variables
        public T NodeData { get; set; }
        public BinarySearchTree<T> LeftTree { get; set; }
        public BinarySearchTree<T> RightTree { get; set; }
        private int leftCount = 0, rightCount = 0;
        bool result = false;

        // constructor
        public BinarySearchTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.RightTree = null;
            this.LeftTree = null;
        }

        // method to insert
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.LeftTree == null)
                    this.LeftTree = new BinarySearchTree<T>(item);
                else
                    this.LeftTree.Insert(item);
            }
            else
            {
                if (this.RightTree == null)
                    this.RightTree = new BinarySearchTree<T>(item);
                else
                    this.RightTree.Insert(item);
            }
        }
        
        
        // method to display
        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.leftCount++;
                this.LeftTree.Display();

            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)
            {
                this.rightCount++;
                this.RightTree.Display();
            }
        }

        // method to check if value exits or not
        public bool IfExists(T element, BinarySearchTree<T> node)
        {
            if (node == null)
                return false;
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine($"Found the element {node.NodeData} in BST");
                result = true;
            }
            else
                Console.WriteLine($"Current element : {node.NodeData}");
            if (element.CompareTo(node.NodeData) < 0)
                IfExists(element, node.LeftTree);
            if (element.CompareTo(node.NodeData) > 0)
                IfExists(element, node.RightTree);
            return result;
        }
    }
}

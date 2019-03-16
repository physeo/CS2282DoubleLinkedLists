/***********************************
 * Double Linked List Class
 * Bryce Graham
 * CS 2282
 * Beard
 * An example of a double linked list
 * which allows inserts, deletions and
 * traversion through the list.
***********************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BryceGrahamProject4
{
    class DoubleLinkedList
    {
        private Memory mem;
        private int firstNode;
        private int currentNode;
        public const int nullIndex = -1;
        public const int unusedIndex = -2;

        public DoubleLinkedList()
        {
            mem = new Memory();
            firstNode = nullIndex;
            currentNode = nullIndex;
        }
        
        public DoubleLinkedList(int _max)
        {
            mem = new Memory(_max);
            firstNode = nullIndex;
            currentNode = nullIndex;
        }

        // Sets first node to a non-negative value that is
        // less than the maximum memory allowed
        public int FirstNode
        {
            get{ return firstNode; }
            set
            { 
                if(value >= 0 && value < mem.maxMem)
                    firstNode = value; 
            }
        }

        // Sets current node to a non-negative value that is
        // less than the maximum memory allowd
        public int CurrentNode
        {
            get { return currentNode; }
            set
            {
                if (value >= 0 && value < mem.maxMem)
                    currentNode = value;
            }
        }

        public Memory Mem
        {
            get { return mem; }
        }

        // Calls the appropriate method to insert a node into the linked list
        public void insertNode(char c)
        {
            if (currentNode == nullIndex)
                insertFirst(c);
            else if (mem.getPrev(currentNode) == mem.maxMem - 1)
                insertLast(c);
            else insertAfterCurrent(c);
        }

        // Inserts a node into an empty linked list
        private void insertFirst(char c)
        {
            int newNode = mem.getAvailableNode();
            firstNode = newNode;
            mem.setValue(newNode, c);
            currentNode = firstNode;
        }

        // Inserts node onto the end of an already existing list
        private void insertLast(char c)
        {
            int newNode = mem.getAvailableNode();
            mem.setPrev(newNode, currentNode);
            mem.setNext(currentNode, newNode);
            mem.setValue(newNode, c);
            currentNode = newNode;
        }

        // Inserts a node after the node with a specified index
        private void insertAfterCurrent(char c)
        {
            int newNode = mem.getAvailableNode();
            mem.setNext(newNode, mem.getNext(currentNode));
            mem.setPrev(newNode, currentNode);
            mem.setNext(currentNode, newNode);
            mem.setValue(newNode, c);
            currentNode = newNode;
        }

        // Runs through the list and counts each node
        public int getListLength()
        {
            int numberOfNodes = 0;
            int i = firstNode;
            while(i != nullIndex)
            {
                i = mem.getNext(i);
                numberOfNodes++;
            }
            return numberOfNodes;
        }

        // generates a display string for the list values in order
        public string getListString()
        {
            StringBuilder newString = new StringBuilder();
            int i = firstNode;
            while (i != nullIndex)
            {
                newString.Append(mem.getValue(i));
                newString.AppendLine();
                i = mem.getNext(i);
            }
            return newString.ToString();
        }

        // Changes the current node to the node after it
        public void makeNextNodeCurrentNode()
        {
            if(mem.getNext(currentNode) != nullIndex)
                currentNode = mem.getNext(currentNode);
        }

        // Changes the current node to the one before it
        public void makePreviousNodeCurrentNode()
        {
            int i = firstNode;
            while (i != nullIndex && currentNode != i)
            {
                if (mem.getNext(i) == currentNode)
                {
                    currentNode = i;
                }
                i = mem.getNext(i);
            }
        }

        // Removes current node from the list
        public void deleteCurrentNode()
        {
            int newCurrent;
            if (mem.getPrev(currentNode) == nullIndex)
            {
                newCurrent = mem.getNext(currentNode);
                firstNode = newCurrent;
            }           
            else newCurrent = mem.getPrev(currentNode);
            mem.deallocateNode(currentNode);
            currentNode = newCurrent;
        }
    }
}

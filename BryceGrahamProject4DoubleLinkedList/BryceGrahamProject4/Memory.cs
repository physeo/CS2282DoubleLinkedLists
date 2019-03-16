/**************************************
 * Memory Class
 * Bryce Graham
 * CS 2282
 * Beard
 * Acts as the memory and nodes for the
 * Double Linked List class
  *************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BryceGrahamProject4
{
    class Memory
    {
        private char[] values;
        private int[] next;
        private int[] prev;
        public int maxMem;
        public const int nullIndex = -1;
        public const int unusedIndex = -2;

        // Memory default constructor creates 3 arrays of length 10
        public Memory()
        {
            maxMem = 10;
            values = new char[maxMem];
            next = new int[maxMem];
            prev = new int[maxMem];

            for (int i = 0; i < maxMem; i++)
            {
                values[i] = '#';
                next[i] = nullIndex;
                prev[i] = unusedIndex;
            }
        }

        // Memory overloaded constructor creates 3 arrays of length _length
        public Memory(int _max)
        {
            maxMem = _max;
            values = new char[maxMem];
            next = new int[maxMem];
            prev = new int[maxMem];

            for (int i = 0; i < maxMem; i++)
            {
                values[i] = '#';
                next[i] = nullIndex;
                prev[i] = unusedIndex;
            }
        }

        // Returns the value in the ith node
        public char getValue(int i)
        {
            return values[i];
        }

        public void setValue(int i, char c)
        {
            values[i] = c;
        }

        // returns the node after the ith node
        public int getNext(int i)
        {
            return next[i];
        }

        public void setNext(int i, int _next)
        {
            next[i] = _next;
        }

        // returns the node before the ith node
        public int getPrev(int i)
        {
            return prev[i];
        }

        public void setPrev(int i, int _prev)
        {
            prev[i] = _prev;
        }

        public int getMaximumMemory()
        {
            return maxMem;
        }

        // finds a node with -2 in prev and returns its index
        public int getAvailableNode()
        {
            for (int i = 0; i < maxMem; i++)
            {
                if (prev[i] == unusedIndex)
                {
                    next[i] = nullIndex;
                    prev[i] = nullIndex;
                    return i;
                }
            }
            return unusedIndex;
            
        }

        // sets ith node to "unused"
        public void deallocateNode(int i)
        {
            values[i] = '#';
            if (prev[i] != nullIndex)
            {
                    next[prev[i]] = next[i];
            }
            prev[i] = unusedIndex;
        }

        // determines the number of allocated nodes in the list
        public int getNumberOfAllocatedNodes()
        {
            int totalUnallocated = 0;
            for (int i = 0; i < values.Length; i++)
                if (prev[i] == unusedIndex)
                    totalUnallocated++;
            return maxMem - totalUnallocated;
        }

        // Turns the memory into a string that can be viewed for debugging
        public string getRawMemoryDisplayString()
        {
            StringBuilder newString = new StringBuilder();
            for (int i = 0; i < maxMem; i++)
            {
                newString.Append("value " + i + " = " + values[i] + "     ");
                newString.Append("next " + i + " = " + next[i] + "     ");
                newString.Append("previous " + i + " = " + prev[i]);
                newString.AppendLine();
            }
            return newString.ToString();
        }

        // Determines if the memory is full or not
        public bool isFull()
        {
            if (getNumberOfAllocatedNodes() == maxMem)
                return true;
            else return false;
        }
    }
}

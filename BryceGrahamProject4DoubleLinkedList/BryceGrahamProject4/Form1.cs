/*******************************
 * Form1 Class
 * Bryce Graham
 * CS 2282
 * Beard
 * Allows a user to interface with the
 * Double Linked List class and
 * to view memory
 ******************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BryceGrahamProject4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DoubleLinkedList Dll;

        // Initializes the double linked list
        private void createDllButton_Click(object sender, EventArgs e)
        {
            string sizeInput = listSizeTextBox.Text.Trim();
            int intOut;
            if(int.TryParse(sizeInput, out intOut))
            {
                int memSize = intOut;
                Dll = new DoubleLinkedList(memSize);
            }
            else Dll = new DoubleLinkedList();

            foreach(Control c in Controls)
            {
                c.Enabled = true;
            }
        }

        // Displays the raw memory assiciated with the Double Linked List
        private void testMemoryButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = Dll.Mem.getRawMemoryDisplayString();
        }

        // Adds the input value as a node to the double linked list
        private void addNodeButton_Click(object sender, EventArgs e)
        {
            char[] inString = addNodeTextBox.Text.ToCharArray();
            char c = inString[0];
            if (!Dll.Mem.isFull())
                Dll.insertNode(c);
            else MessageBox.Show("Full memory");
            currentNodeTextBox.Text = Dll.CurrentNode.ToString();
            addNodeTextBox.Clear();
            addNodeButton.Focus();
        }

        // Removes the current node from the double linked list
        private void deleteCurrentNodeButton_Click(object sender, EventArgs e)
        {
            Dll.deleteCurrentNode();
            currentNodeTextBox.Text = Dll.CurrentNode.ToString();
        }

        // Moves the current node to the next node on the double linked list
        private void nextNodeButton_Click(object sender, EventArgs e)
        {
            Dll.makeNextNodeCurrentNode();
            currentNodeTextBox.Text = Dll.CurrentNode.ToString();
        }

        // Moves the current node to the previous node on the double linked list
        private void prevNodeButton_Click(object sender, EventArgs e)
        {
            Dll.makePreviousNodeCurrentNode();
            currentNodeTextBox.Text = Dll.CurrentNode.ToString();
        }

        // Traverses and displays the double linked list in order
        private void displayDoubleLinkedListButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = Dll.getListString();
        }
    }
}

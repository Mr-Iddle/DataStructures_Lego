using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LegoAlgorithm
{
    public partial class Form1 : Form
    {
        private ChrisArrayList<string> _arrayList;
        private CorvinLinkedList<string> _linkedList;
        private Dll<string> _doubleLinkedList;
        private object[] values;
        public Form1()
        {
            InitializeComponent();
            this._arrayList = new ChrisArrayList<string>();
            this._linkedList = new CorvinLinkedList<string>();
            this._doubleLinkedList = new Dll<string>();
            DefaultOptions();
        }
        private void importCSVBtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                using (StreamReader reader = new StreamReader(filePath))
                {
                    reader.ReadLine();

                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] fields = line.Split(',');
                        if (fields.Length >= 2)
                        {
                            InsertIntoAll(fields[1].Trim());
                        }
                        outputListBox.Items.Add(string.Join(", ", fields));
                    }
                }

            }
        }


        private void InsertIntoAll(string data)
        {
            try
            {
                _arrayList.Add(data);
                _linkedList.AddLast(data);
                _doubleLinkedList.AddLastNode(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DefaultOptions()
        {
            BinarySearchRadio.Enabled = false;
            BinarySearchRadio.Checked = false;

            QuickSortRadio.Enabled = false;
            BubbleSortRadio.Enabled = false;
            LinearSearchRadio.Enabled = false;
            ForwardTraversRadio.Enabled = false;
            BackwardsTraversRadio.Enabled = false;

            QuickSortRadio.Checked = false;
            BubbleSortRadio.Checked = false;
            LinearSearchRadio.Checked = false;
            ForwardTraversRadio.Checked = false;
            BackwardsTraversRadio.Checked = false;

            SortBtn.Enabled = false;
            SearchBtn.Enabled = false;
        }

        private void collectionChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosenList.Text = collectionChoice.Text;
        }

        private void collectionChoice_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DefaultOptions();
            string selectedOption = collectionChoice.SelectedItem.ToString();

            if (selectedOption.Equals("ArrayList"))
            {
                BinarySearchRadio.Enabled = true;
                LinearSearchRadio.Enabled = true;
                QuickSortRadio.Enabled = true;
                BubbleSortRadio.Enabled = true;
                SearchBtn.Enabled = true;
                SortBtn.Enabled = true;
            }
            else if (selectedOption.Equals("LinkedList"))
            {
                BinarySearchRadio.Enabled = true;
                LinearSearchRadio.Enabled = true;
                QuickSortRadio.Enabled = true;
                BubbleSortRadio.Enabled = true;
                SearchBtn.Enabled = true;
                SortBtn.Enabled = true;

            }
            else if (selectedOption.Equals("DoubleLinkedList"))
            {
                BinarySearchRadio.Enabled = true;
                LinearSearchRadio.Enabled = true;
                QuickSortRadio.Enabled = true;
                BubbleSortRadio.Enabled = true;
                ForwardTraversRadio.Enabled = true;
                BackwardsTraversRadio.Enabled = true;
                SearchBtn.Enabled = true;
                SortBtn.Enabled = true;
            }
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            string selectedOption = collectionChoice.SelectedItem.ToString();

            if (BubbleSortRadio.Checked)
            {
                if (selectedOption.Equals("ArrayList"))
                {
                    var result = _arrayList.BubbleSort(0, _arrayList.Count - 1);
                    outputListBox.Items.Clear();
                    outputListBox.Items.Add("Bubble Sort took: " + result);
                    foreach (string item in _arrayList)
                    {
                        string itemText = item ?? "null";
                        outputListBox.Items.Add(itemText);
                    }
                }
                else if (selectedOption.Equals("LinkedList"))
                {
                    _linkedList.BubbleSort();
                    outputListBox.Items.Clear();
                    outputListBox.Items.Add("---- RESULT BUBBLE SORT LL ----");
                    foreach (string item in _linkedList.Check())
                    {
                        outputListBox.Items.Add(item);
                    }
                }
                else if (selectedOption.Equals("DoubleLinkedList"))
                {
                    _doubleLinkedList.BubbleSort();
                    outputListBox.Items.Clear();
                    outputListBox.Items.Add("---- TRAVERSAL FORWARD BUBBLE SORT ----");
                    foreach (string item in _doubleLinkedList.TrFwd())
                    {
                        outputListBox.Items.Add(item);
                    }
                    Console.WriteLine($"Time elapsed for Bubble Sort: {_doubleLinkedList.BubbleSort()} seconds.");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }

            if (QuickSortRadio.Checked)
            {
                if (selectedOption.Equals("ArrayList"))
                {
                    var result = _arrayList.QuickSort(0, _arrayList.Count - 1);
                    outputListBox.Items.Clear();
                    outputListBox.Items.Add("Quick sort took: " + result);
                    foreach (string item in _arrayList)
                    {
                        string itemText = item ?? "null";
                        outputListBox.Items.Add(itemText);
                    }
                }
                else if (selectedOption.Equals("LinkedList"))
                {
                    _linkedList.QuickSort();
                    outputListBox.Items.Clear();
                    outputListBox.Items.Add("---- RESULT QUICK SORT LL ----");
                    foreach (string item in _linkedList.Check())
                    {
                        outputListBox.Items.Add(item);
                    }
                }
                else if (selectedOption.Equals("DoubleLinkedList"))
                {
                    outputListBox.Items.Clear();
                    _doubleLinkedList.QuickSort();
                    outputListBox.Items.Add("---- TRAVERSAL BACKWARDS QUICK SORT ----");
                    foreach (string item in _doubleLinkedList.TrBwd())
                    {
                        outputListBox.Items.Add(item);
                    }
                    Console.WriteLine($"Time elapsed for Quick Sort: {_doubleLinkedList.QuickSort()} seconds.");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }

            if (ForwardTraversRadio.Checked)
            {
                outputListBox.Items.Clear();
                outputListBox.Items.Add("---- TRAVERSAL FORWARD ----");
                foreach (string item in _doubleLinkedList.TrFwd())
                {
                    outputListBox.Items.Add(item);
                }
            }

            if (BackwardsTraversRadio.Checked)
            {
                outputListBox.Items.Clear();
                outputListBox.Items.Add("---- TRAVERSAL BACKWARDS ----");
                foreach (string item in _doubleLinkedList.TrBwd())
                {
                    outputListBox.Items.Add(item);
                }
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string selectedOption = collectionChoice.SelectedItem.ToString();
            string searchChoice = searchForTxtBox.Text;

            if (LinearSearchRadio.Checked)
            {
                if (selectedOption.Equals("ArrayList"))
                {
                    _arrayList.BubbleSort(0, _arrayList.Count - 1);
                    var result = _arrayList.LinearSearch(searchChoice, 0, _arrayList.Count - 1);
                    outputListBox.Items.Clear();
                    outputListBox.Items.Add(searchChoice + " " + "found at index: " + result);
                }
                else if (selectedOption.Equals("LinkedList"))
                {
                    _linkedList.BubbleSort();
                    outputListBox.Items.Clear();
                    if (_linkedList.LinearSearch(searchChoice) != 1)
                    {
                        outputListBox.Items.Add(searchChoice + " " + "found at Node: " + _linkedList.LinearSearch(searchChoice));
                    };
                }
                else if (selectedOption.Equals("DoubleLinkedList"))
                {
                    _doubleLinkedList.QuickSort();
                    outputListBox.Items.Clear();
                    if (_doubleLinkedList.LinearSearch(searchChoice) != -1)
                    {
                        outputListBox.Items.Add(searchChoice + " " + "found at index: " + _doubleLinkedList.LinearSearch(searchChoice));
                    }
                    Console.WriteLine(_doubleLinkedList.LinearSearch(searchChoice));
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }

            if (BinarySearchRadio.Checked)
            {
                if (selectedOption.Equals("ArrayList"))
                {
                    _arrayList.BubbleSort(0, _arrayList.Count - 1);
                    var result = _arrayList.BinarySearch(searchChoice, 0, _arrayList.Count - 1);
                    outputListBox.Items.Clear();
                    outputListBox.Items.Add(searchChoice + " " + "found at index: " + result);
                }
                else if (selectedOption.Equals("LinkedList"))
                {
                    _linkedList.BubbleSort();
                    outputListBox.Items.Clear();
                    if (_linkedList.BinarySearch(searchChoice) != -1)
                    {
                        outputListBox.Items.Add(searchChoice + " " + "found at Node: " + _linkedList.BinarySearch(searchChoice));
                    };
                }
                else if (selectedOption.Equals("DoubleLinkedList"))
                {
                    _doubleLinkedList.BubbleSort();
                    outputListBox.Items.Clear();
                    if (_doubleLinkedList.BSearch(searchChoice) != -1)
                    {
                        outputListBox.Items.Add(searchChoice + " " + "found at index: " + _doubleLinkedList.BSearch(searchChoice));
                    }
                    Console.WriteLine(_doubleLinkedList.BSearch(searchChoice));
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}

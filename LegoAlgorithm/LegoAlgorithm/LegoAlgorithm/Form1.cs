using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            SentinelSearchRadio.Enabled = false;
            SentinelSearchRadio.Checked = false;

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
                SentinelSearchRadio.Enabled = true;
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
                    //_arrayList.BubbleSort();
                }else if (selectedOption.Equals("LinkedList"))
                {
                    //_linkedList.BubbleSort()''
                }else if (selectedOption.Equals("DoubleLinkedList"))
                {
                    _doubleLinkedList.BubbleSort();
                }else
                {
                    MessageBox.Show("Error");
                }
            }

            if(QuickSortRadio.Checked) {
                if (selectedOption.Equals("ArrayList"))
                {
                    //_arrayList.QuickSort();
                }else if (selectedOption.Equals("LinkedList"))
                {
                    //_linkedList.QuickSort();
                }else if (selectedOption.Equals("DoubleLinkedList"))
                {
                    _doubleLinkedList.QuickSort();
                    _doubleLinkedList.TrFwd();
                }
                else
                {
                    MessageBox.Show("Error");
                }

            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string selectedOption = collectionChoice.SelectedItem.ToString();

            if (LinearSearchRadio.Checked)
            {
                if (selectedOption.Equals("ArrayList"))
                {
                    //_arrayList.LinearSearch();
                }
                else if (selectedOption.Equals("LinkedList"))
                {
                    //_linkedList.LinearSearch();
                }
                else if (selectedOption.Equals("DoubleLinkedList"))
                {
                    //_doubleLinkedList.LinearSearch();
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
                    //_arrayList.BinarySearch();
                }
                else if (selectedOption.Equals("LinkedList"))
                {
                    //_linkedList.BinarySearch();
                }
                else if (selectedOption.Equals("DoubleLinkedList"))
                {
                    //_doubleLinkedList.BSearch();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}

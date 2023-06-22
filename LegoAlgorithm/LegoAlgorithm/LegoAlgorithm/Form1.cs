using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LegoAlgorithm
{
    public partial class Form1 : Form
    {
        private ChrisArrayList<int> _integers; 
        ChrisArrayList<int> myList = new ChrisArrayList<int>();

        public Form1()
        {
            InitializeComponent();
            _integers = new ChrisArrayList<int>();
            integerInput.TextChanged += integerInput_TextChanged;
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            if (bubbleSortRadio.Checked)
            {
                myList.BubbleSort(0, _integers.Count - 1);
            }
            else if (quickSortRadio.Checked)
            {
                myList.QuickSort(0, _integers.Count - 1);
            }
            DisplayTheIntegers();
        }

        private void integerInput_TextChanged(object sender, EventArgs e)
        {
            string input = integerInput.Text;
            string[] numberStrings = input.Split(',');

            _integers.Clear();

            foreach (string numberString in numberStrings)
            {
                if (int.TryParse(numberString, out int number))
                {
                    _integers.Add(number);
                } 
                else
                {
                    richTextBox.Text = "Waiting...";
                    return;
                }
            }
            DisplayTheIntegers();
        }

        private void DisplayTheIntegers()
        {
            richTextBox.Clear();
            for (var i = 0; i < _integers.Count; i++)
            {
                object item = _integers.Get(i);
                richTextBox.AppendText(item.ToString() + "\n");
            }
        }
    }
}

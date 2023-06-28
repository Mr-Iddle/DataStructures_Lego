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
       // CsvS<string> _csv = new CsvS<string>();
        private ChrisArrayList<string> _arrayList;
        private CorvinLinkedList<string[]> _linkedList;
        //private DoubleLinkedList<string> _doubleLinkedList;
        private object[] values;
        public Form1()
        {
            InitializeComponent();
            //_csv.NodeBuilder("C:\\Users\\Chris\\Source\\Repos\\AlgoLego2.0\\LegoAlgorithm\\LegoAlgorithm\\LegoAlgorithm\\colors.csv");
            this._arrayList = new ChrisArrayList<string>();
            this._linkedList = new CorvinLinkedList<string[]>();
            //this._doubleLinkedList = new DoubleLinkedList<>();
        }
         private void importCSVBtn_Click(object sender, EventArgs e)
            {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                CorvinLinkedList<string[]> data = ReadCSV(filePath);

                //clear the content of the datagridview
                outputListBox.Items.Clear();
                
                foreach (string[] row in data)
                {
                    outputListBox.Items.Add(string.Join(", ", row));
                }
            }
        }

        private CorvinLinkedList<string[]> ReadCSV(string filePath)
        {
            CorvinLinkedList<string[]> data = new CorvinLinkedList<string[]>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    data.AddLast(values);
                }
            }
            return data;
        }

        private void collectionChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosenList.Text = collectionChoice.Text;
        }

        private void collectionChoice_SelectionChangeCommitted(object sender, EventArgs e) 
        {
            string selectedOption = collectionChoice.SelectedItem.ToString();

            switch (selectedOption)
            {
                case "ArrayList":
                    if (BubbleSortRadio.Checked)
                    {
                        //do something
                    }else if (QuickSortRadio.Checked)
                    {
                        //do something
                    }
                    break;

                case "LinkedList":
                    if (BubbleSortRadio.Checked)
                    {
                        //do something
                    }
                    else if (QuickSortRadio.Checked)
                    {
                        //do something
                    }
                    break;

                case "DoubleLinkedList":
                    if (BubbleSortRadio.Checked)
                    {
                        //do something
                    }
                    else if (QuickSortRadio.Checked)
                    {
                        //do something
                    }
                    break;
            }
        }
    }
}

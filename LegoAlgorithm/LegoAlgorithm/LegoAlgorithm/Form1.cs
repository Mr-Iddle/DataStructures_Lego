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
        CsvS<string> _csv = new CsvS<string>();
        private ChrisArrayList<string> _arrayList;
        private CorvinLinkedList<string> _linkedList;
        //private DoubleLinkedList<string> _doubleLinkedList;

        public Form1()
        {
            InitializeComponent();
            _csv.NodeBuilder("C:\\Users\\Chris\\Source\\Repos\\AlgoLego2.0\\LegoAlgorithm\\LegoAlgorithm\\LegoAlgorithm\\colors.csv");
            _arrayList = new ChrisArrayList<string>();
            _linkedList = new CorvinLinkedList<string>();
            //this._doubleLinkedList = new DoubleLinkedList<>();
            DefaultOptions();
        }

        private void ImportCSVBtn_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = new OpenFileDialog()
            {
                Filter = "CSV Files (*.csv)|*.csv",
            };
            if (fileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(fileDialog.FileName))
                    {
                        //ignores fist line
                        bool firtstline = true;
                        while (!sr.EndOfStream)
                        {
                            //read line
                            string line = sr.ReadLine();
                            //split line
                            string[] values = line.Split(',');
                            if (firtstline)
                            {
                                foreach (string s in values)
                                {
                                    //result_TB.Text += s + "\t";
                                }
                                //result_TB.Text += "\n";
                                firtstline = false;
                            }
                            else
                            {
                                int id = int.Parse(values[0]);
                                string name = values[1];
                                string rgb = values[2];
                                string transparency = values[3];
                                //create new lego data
                                //LegoData legoData = new LegoData(id, name, rgb, transparency);
                                //ArrayList.Add(legoData);
                                //add to listbox
                                foreach (string s in values)
                                {
                                    //result_TB.Text += s + "\t";
                                }
                                //result_TB.Text += "\n";
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
            }else if (selectedOption.Equals("LinkedList"))
            {
                BinarySearchRadio.Enabled = true;
                LinearSearchRadio.Enabled = true;
                QuickSortRadio.Enabled = true;
                BubbleSortRadio.Enabled = true;
                SearchBtn.Enabled = true;
                SortBtn.Enabled = true;

            }else if (selectedOption.Equals("DoubleLinkedList"))
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
            //do something
        }

        private void GetCollectionType(string collectionType)
        {
            if (collectionType.Equals("LinkedList"))
            {
                return _linkedList;
            }
            else if (collectionType.Equals("ArrayList"))
            {
                return _arrayList;
            }
            else if (collectionType.Equals("BinarySearchTree"))
            {
                return null;
            }
            else
            {
                throw new InvalidOperationException("This collection wont work with this item");
            }
        }
    }
}

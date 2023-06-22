using System;
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

namespace LegoAlgorithm
{
    public partial class Form1 : Form
    {
        private MyLinkedList CorvinLinkedList = new MyLinkedList();
        private LinkedListTest<int> value;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            input_txt.TextChanged += input_txt_TextChanged;
        }

        private void import_bttn_Click(object sender, EventArgs e)
        {
            //create filedialog to see the csv
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
                                    result_TB.Text += s + "\t";
                                }
                                result_TB.Text += "\n";
                                firtstline = false;
                            }
                            else
                            {
                                int id = int.Parse(values[0]);
                                string name = values[1];
                                string rgb = values[2];
                                string transparency = values[3];
                                //create new lego data
                                LegoData legoData = new LegoData(id, name, rgb, transparency);
                                //add to linked list
                                CorvinLinkedList.AddLast(legoData);
                                //add to listbox
                                foreach (string s in values)
                                {
                                    result_TB.Text += s + "\t";
                                }
                                result_TB.Text += "\n";
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

        private void sort_bttn_Click(object sender, EventArgs e)
        {

            var watch = Stopwatch.StartNew();

            if (quicksort_radio.Checked)
            {
                value.QuickSort(0, value.Count-1);
            }




            /* if (radioButton1.Checked)
             {
                 using (StreamReader sr = new StreamReader(result_TB.Text))
                 {
                     bool firtstline = true;
                     while (!sr.EndOfStream)
                     {
                         //read line
                         string line = sr.ReadLine();
                         //split line
                         string[] result = line.Split(',');
                         //ignore the first line
                         foreach (string s in result)
                         {
                             if (firtstline)
                             {
                                 firtstline = false;
                             }
                             else
                             {
                                 int id = int.Parse(result[0]);
                                 string name = result[1];
                                 string rgb = result[2];
                                 string transparency = result[3];
                                 //create new lego data
                                 LegoData legoData = new LegoData(id, name, rgb, transparency);
                                 //quicksort the linked list
                                 CorvinLinkedList.QuickSortMethodCustom(legoData.ToArray(), 0, CorvinLinkedList.Count - 1);
                             }
                         }

                     }*/


        }

        private void input_txt_TextChanged(object sender, EventArgs e)
        {
            string input = input_txt.Text;
            string[] numberStrings = input.Split(' ');

            value = new LinkedListTest<int>();

            foreach (string numberString in numberStrings)
            {
                if (int.TryParse(numberString, out int number))
                {
                    value.AddFirst(number);
                }
                else
                {
                    result_TB.Text = "Error";
                }

            }
            DisplayTheIntegers();
        }
        private void DisplayTheIntegers()
        {
            result_TB.Clear();
            for (int i = 0; i < value.Count; i++)
            {
                var item = value.GetNodeAt(i);
                result_TB.AppendText(item.ToString() + "\n");
                //result_TB.Text += item.ToString() + "\n";
            }

        }
    }
}


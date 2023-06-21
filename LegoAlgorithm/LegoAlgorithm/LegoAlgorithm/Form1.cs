﻿using System;
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
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void import_bttn_Click(object sender, EventArgs e) 
        {
            //create filedialog to see the csv
            FileDialog fileDialog = new OpenFileDialog()
            {
                Filter = "CSV Files (*.csv)|*.csv",
            };
            if(fileDialog.ShowDialog().Equals(DialogResult.OK) )
            {
                try
                {
                    using (StreamReader sr = new StreamReader(fileDialog.FileName))
                    {
                        //ignores fist line
                        bool firtstline = true;
                        MyLinkedList CorvinLinkedList = new MyLinkedList();
                       

                       
                        while (!sr.EndOfStream)
                        {
                            //read line
                            string line = sr.ReadLine();
                            //split line
                            string[] values = line.Split(',');
                            if (firtstline)
                            {
                                foreach(string s in values)
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
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void sort_bttn_Click(object sender, EventArgs e)
        {
            MyLinkedList myLinkedList = new MyLinkedList();
            var watch = Stopwatch.StartNew();

            if(radioButton1.Checked)
            {
                //sort the content of the text box with QuickSort
                string[] lines = result_TB.Text.Split('\n');
                myLinkedList.QuickSortMethodCustom(lines, 0, lines.Length - 1);
            }
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.Elapsed} s");
        }
    }
}

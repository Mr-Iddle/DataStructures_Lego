using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                        MyLinkedList<T> CorvinLinkedList = new MyLinkedList<T>();
                        while(!sr.EndOfStream)
                        {
                            //read line
                            string line = sr.ReadLine();
                            //split line
                            string[] values = line.Split(',');
                            //create new lego data
                            LegoData legoData = new LegoData(int.Parse(values[0]), values[1], values[2], values[3]);
                            //add to linked list
                            CorvinLinkedList.AddLast(legoData);
                            //add to listbox
                            result_TB.Text += legoData;
                        }
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

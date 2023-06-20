using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoAlgorithm
{
    public class LegoData
    {
        private int _id;
        private string _name;
        private string _rgb;
        private string _transparency;

        public LegoData(int id, string name, string rgb, string transparency)
        {
            _id = id;
            _name = name;
            _rgb = rgb;
            _transparency = transparency;
        }

        //getter and setter
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Rgb
        {
            get { return _rgb; }
            set { _rgb = value; }
        }

        public string Transparency
        {
            get { return _transparency; }
            set { _transparency = value; }
        }

        public override string ToString()
        {
            return "Id: " + _id + " Name: " + _name + " Rgb: " + _rgb + " Transparency: " + _transparency;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoAlgorithm
{
    public class LegoData<T>
    {
        private T _id;
        private T _name;
        private T _rgb;
        private T _transparency;

        public LegoData(T id, T name, T rgb, T transparency)
        {
            _id = id;
            _name = name;
            _rgb = rgb;
            _transparency = transparency;
        }

        //getter and setter
        public T Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public T Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public T Rgb
        {
            get { return _rgb; }
            set { _rgb = value; }
        }

        public T Transparency
        {
            get { return _transparency; }
            set { _transparency = value; }
        }

        public override string ToString()
        {
            return "Id: " + _id + " Name: " + _name + " Rgb: " + _rgb + " Transparency: " + _transparency;
        }

        //create a toArray function
        public string[] ToArray()
        {
            string[] array = new string[4];
            array[0] = _id.ToString();
            array[1] = _name.ToString();
            array[2] = _rgb.ToString();
            array[3] = _transparency.ToString();
            return array;
        }
    }
}

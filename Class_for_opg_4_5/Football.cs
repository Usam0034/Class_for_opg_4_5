using System;

namespace Class_for_opg_4_5
{
    public class Football
    {
        private int _id;
        private string _name;
        private double _price;
        private int _shirtNumber;


        public Football(int id, string name, double price, int shirtNumber)
        {
            _id = id;
            _name = name;
            _price = price;
            _shirtNumber = shirtNumber;
        }

        public int id
        {
            get;
            set;
        }
        public string name
        {
            get => _name;
            set
            {
                if (value.Length < 4) throw new ArgumentException();
                _name = value;
            }
        }

        public double price
        {
            get => _price;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException();
                _price = value;
            }
        }

        public int shirtNumber
        {
            get => _shirtNumber;
            set
            {
                if (value <= 1 || value >= 100) throw new ArgumentOutOfRangeException();
                _shirtNumber = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;

namespace NetOrderApp
{
    internal class orderlist
    {

        private int _amount;
        private string _add;
        private int _price;
        private Color _colour;



        public event PropertyChangedEventHandler PropertyChanged;

        private string _Name;

        public Color Colour
        {
            get { return _colour; }
            set
            {
                _colour = value;
                OnPropertyChanged();
            }
        }




        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                OnPropertyChanged();
            }


        }

        public orderlist()
        {
            this._amount = 1994;
            this._add = "Ford";
            this._price = 0;
        }

        public orderlist(int amount, string add, int price, string Name, Color colour)
        {
            this._amount = amount;
            this._add = add;
            this._price = price;
            this._Name = Name;
            Colour = colour;


        }




        public int amount
        {
            get
            {
                return _amount;
            }

            set
            {
                _amount = value;

                OnPropertyChanged();

            }
        }

        public string add
        {
            get { return _add; }
            set
            {
                _add = value;
                OnPropertyChanged();
            }

        }

        public int price
        {
            get { return _price; }
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }



        public void SelectMore(int increment)
        {
            price += increment;

        }
        public void SelectLess(int increment)
        {
            price -= increment;
        }


        public int GetMake()
        {
            return _amount;
        }

        public void SetMake(int amount)
        {
            _amount = amount;
        }



        private void OnPropertyChanged([CallerMemberName] string propertyname = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }


    }
}

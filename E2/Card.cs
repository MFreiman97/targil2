using System;
using System.Collections;
using System.Collections.Generic;
//using System.Linq;
using System.Text;


namespace dotNet5778_02_1706_9253
{
    enum E_Color { red, black }

    class Card:IComparable 
    {
       
        int Min = 2;
        int Max = 14;
        // E_Color
        private E_Color Color;
        public E_Color Color_
        {
            get { return Color; }
            set { Color = value; }
        }
        // Num
        private int num;
        public int NUM
        {
            get { return num; }
            set
            {
                if (value >= Min && value <= Max)
                    num = value;
            }
        }
        // CardName
        public string CardName
        {
            get
            {
                if (NUM >= Min && NUM <= 10)
                    return num.ToString() ;
                else
                {
                    switch (NUM)
                    {
                        case 11:
                            return "Jack";
                            break;

                        case 12:
                            return "Queen";
                            break;
                        case 13:
                            return "King";
                            break;
                        case 14:
                            return "Ace";
                            break;
                        default:
                            return "";
                    }              
                }
            }
        }
        // Ctor
        public Card(E_Color c, int n)
        {
            this.Color = c;
            this.num = n;
        }
        public Card()//default ctor
        {
            this.num = 0;
        }
        // ToString
        public override string ToString()
        {
            return string.Format("Color: {0,-10} Number: {1,-10}", Color.ToString(), CardName);
        }

        public int CompareTo(object obj)
        {
            Card o = (Card)obj;//CASTING
            return num.CompareTo(o.NUM);//using the compare to of INT
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.Text;//Aviel Hassid 209209253
//Matanya Freiman 318281706

namespace dotNet5778_02_1706_9253
{
    class Player
    {
      public  string name;

        public string NAME
        {
            get { return    name; }
            set { name = value; }
        }

        Queue<Card> CardsPlayers   = new Queue<Card>();
   public Player()
        {
            NAME = "";
        }
    public override string ToString()
    {
            string str = "";
            foreach(Card item in CardsPlayers)
            {
                str += item +"\n";
            }
        return "Name: " + (NAME) + ", " + "Numbers: " + (CardsPlayers.Count)+'\n'+str;

        }
        public void addCard(params Card[] arr)//enqueue many cards!
        {
            for (int i = 0; i < arr.Length; i++)
            {
                CardsPlayers.Enqueue(arr[i]);
            }
        }
        public bool lose()//check if the player lost
        {
            if (CardsPlayers.Count == 0)
                return true;
            return false;
        }
        public Card pop()// smart deqeue
        {
            if(CardsPlayers.Count!=0)
            return CardsPlayers.Dequeue();
           return null;
        }
        public int count()//return how many cards!
        {
            return CardsPlayers.Count;
        }


    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
//Aviel Hassid 209209253
//Matanya Freiman 318281706
namespace dotNet5778_02_1706_9253
{

    class CardStock:IEnumerable
    {
        List<Card> Cards = new List<Card>();
        public CardStock()//ctor
        {    
            Random r1 = new Random();
            for (int i = 0; i < 13; i++)
            {
                Cards.Add(new Card { Color_ = E_Color.black , NUM= i+2 });
            }
            for (int i = 0; i < 13; i++)
            {
                Cards.Add(new Card { Color_ = E_Color.red , NUM = i+2 });
            }
            mixing();
        }
    public override string ToString()
        {
            string sen = "";
            for (int i = 0; i < Cards.Count; i++)
            {
                sen += Cards[i]+" ";
               
            }
            return sen;
        }

        public void mixing ()
        {
            Random r1 = new Random();
            int x, y;
            for (int i = 0; i < 200; i++)// i decided that 200 changes is enough for mixing the cards
            {
                x = r1.Next(0, Cards.Count);
                y = r1.Next(0, Cards.Count);
                Card_Changing(x, y);
            }


        }

        private void Card_Changing(int x, int y)
        {
            Card temp = Cards[y];
            Cards[y] = Cards[x];
            Cards[x] = temp;//i could also use swap ...
        }
        public  CardStock addCard( Card c)
        {
            Cards.Add(c);
            return this;
        }
        public Card this[string index]
        {
            get
            {
                for (int i = 0; i < Cards.Count; i++)
                {
                    if (Cards[i].CardName == index)
                        return Cards[i];//returning the first apperance in the list
                }
                return null;
            }
       
        }
        public void sort()
        {
            Cards.Sort();//in the card class i implemented the compareTo function therefore i can use sort
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Cards.Count; i++)
            {
                yield return Cards[i];// return new enumerator every call 
            }
            
        }

        public void removeCard()
        {
            Cards.RemoveAt(0);//remove the card that in the first element

        }

        public void distribute(params Player[] players)
        {
            Card[] arr1 = new Card[13];
            Card[] arr2 = new Card[13];//I assume that i know that there is 2 players in the game
               foreach (Player p in players)//players is array ,therefore,there is enumerable interface
            {
                for (int i = 0; i < 13; i++)
                {
                    p.addCard(Cards[i]);
                }
               
                for (int i = 0; i < 13; i++)
                    removeCard();//i want to remove 13 cards from the kupa 
            }
        }
    }
}


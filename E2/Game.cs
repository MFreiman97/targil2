using System;
using System.Collections.Generic;
using System.Text;
//Aviel Hassid 209209253
//Matanya Freiman 318281706

namespace dotNet5778_02_1706_9253
{
    class Game
    {
       
        Player p1 = new Player();
        Player p2 = new Player();
        CardStock kupa=new CardStock();
        public Game()//the ctor will distribute the cards
        {
            p1.NAME = "p1";
            p2.NAME = "p2";
            kupa.distribute(p1, p2);
        }
        public string winner()
        {
            if ( p2.lose() == true)
                return "The winner is: " + p1.NAME ;//using the property 
            else
                return "The winner is: "+p2.NAME;
        }//return the name of the winner!

        public bool checking()
        {
            if (p2.lose() == false && p1.lose() == false)
                return false;//when the 2 players have cards that means that the game didnt over!
             return true;

        }
        public override string ToString()
        {
            return string.Format("{0,-25}\n{1,-25}\n",p1,p2);//using the Tostring of the Players
        }

        static int flag = 0;
        static List<Card> arr = new List<Card>();//wiil be neccesary in a situation of equal cards
        public void Step1(Card first, Card second)
        {

            if (first.CompareTo(second) > 0)
            {
                p1.addCard(first, second);
                flag = 1;
            }
            else if (first.CompareTo(second) < 0)
            {
                p2.addCard(first, second);
                flag = 2;//will be neccesary when i need to consider a situation of same cards many times 
            }
            if (first.CompareTo(second) == 0)//same card value!
            {
                arr.Add(first);
                arr.Add(second);
                if (p1.count() - 2 > 0 && p2.count() - 2 > 0)//to preventing a situation of runtime error!
                {
                    for (int i = 0; i < 2; i++)
                    {

                        arr.Add(p1.pop());
                        arr.Add(p2.pop());
                    }


                    Step1(p1.pop(), p2.pop());//recursion call
                    if (flag == 1)
                    {
                        filling(p1);//i need to fill the queue of player p1 because p1 won .
                        rikun();
                    }
                    if (flag == 2)
                    {
                        filling(p2);//i need to fill the queue of player p2 because p1 won .
                        rikun();
                    }
                }
                else
                {
                    if (p1.count() > p2.count())
                    {
                        for (int i = 0; i < p2.count(); i++)
                        {
                            arr.Add(p2.pop());
                        }
                        filling(p1);
                        rikun();
                    }
                    else
                    {
                        for (int i = 0; i < p1.count(); i++)
                        {
                            arr.Add(p1.pop());
                        }
                        filling(p2);
                        rikun();
                    }
                }
            }
        }

       
        public void filling(Player p)
        {

            for (int i = 0; i < arr.Count; i++)
            {
                p.addCard(arr[i]);
            }


        }
     

        
        public void Step()
        {

            Step1(p1.pop(), p2.pop());

      }
        public void rikun()

        {
            arr.Clear();//removing all the elements in the static list!
        }

    }
}
 


using System;
using System.Collections.Generic;
using System.Text;
//Aviel Hassid 209209253
//Matanya Freiman 318281706
namespace dotNet5778_02_1706_9253
{//hello!!
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#################################################################");
            Console.WriteLine("#################### WELCOME TO THE BATTLE ######################");
            Console.WriteLine("#################################################################");
            Game g=new Game();
            Console.WriteLine(g);//printing the cards
            int n;
            do
            {

           
            Console.WriteLine("~press 0 for 1 step"+'\n'+"~press 1 for finish the game");
            n = int.Parse(Console.ReadLine());

            if (n==0)
            {
                g.Step();
                    Console.WriteLine(g);//printing 
                }
            if(n==1)
            {
                    do
                    {
                        g.Step();
                         Console.WriteLine(g);//printing every step 
                    } while (g.checking()==false);//continue until the game will finish

            }
            } while (g.checking() == false);
          
            Console.WriteLine(g.winner());//printing the winner
            Console.ReadKey();
      
        }
    }
}//#############################example of running##############################
//Color: black Number: King
//Color: black Number: Ace
//Color: red Number: 3
//Color: black Number: 7
//Color: red Number: King
//Color: red Number: 6
//Color: red Number: 9
//Color: red Number: 4
//Color: red Number: 10
//Color: red Number: 2
//Color: red Number: Ace
//Color: black Number: 6
//Color: red Number: Queen
//Color: red Number: 7
//Color: black Number: 8
//Color: black Number: 3
//Color: black Number: Jack


//Name: p1, Numbers: 2
//Color: black Number: 10
//Color: black Number: 9

//Name: p2, Numbers: 24
//Color: black Number: 4
//Color: red Number: Jack
//Color: red Number: 5
//Color: black Number: 5
//Color: black Number: 2
//Color: black Number: King
//Color: black Number: Ace
//Color: red Number: 3
//Color: black Number: 7
//Color: red Number: King
//Color: red Number: 6
//Color: red Number: 9
//Color: red Number: 4
//Color: red Number: 10
//Color: red Number: 2
//Color: red Number: Ace
//Color: black Number: 6
//Color: red Number: Queen
//Color: red Number: 7
//Color: black Number: 8
//Color: black Number: 3
//Color: black Number: Jack
//Color: red Number: 8
//Color: black Number: Queen


//Name: p1, Numbers: 3
//Color: black Number: 9
//Color: black Number: 10
//Color: black Number: 4

//Name: p2, Numbers: 23
//Color: red Number: Jack
//Color: red Number: 5
//Color: black Number: 5
//Color: black Number: 2
//Color: black Number: King
//Color: black Number: Ace
//Color: red Number: 3
//Color: black Number: 7
//Color: red Number: King
//Color: red Number: 6
//Color: red Number: 9
//Color: red Number: 4
//Color: red Number: 10
//Color: red Number: 2
//Color: red Number: Ace
//Color: black Number: 6
//Color: red Number: Queen
//Color: red Number: 7
//Color: black Number: 8
//Color: black Number: 3
//Color: black Number: Jack
//Color: red Number: 8
//Color: black Number: Queen


//Name: p1, Numbers: 2
//Color: black Number: 10
//Color: black Number: 4

//Name: p2, Numbers: 24
//Color: red Number: 5
//Color: black Number: 5
//Color: black Number: 2
//Color: black Number: King
//Color: black Number: Ace
//Color: red Number: 3
//Color: black Number: 7
//Color: red Number: King
//Color: red Number: 6
//Color: red Number: 9
//Color: red Number: 4
//Color: red Number: 10
//Color: red Number: 2
//Color: red Number: Ace
//Color: black Number: 6
//Color: red Number: Queen
//Color: red Number: 7
//Color: black Number: 8
//Color: black Number: 3
//Color: black Number: Jack
//Color: red Number: 8
//Color: black Number: Queen
//Color: black Number: 9
//Color: red Number: Jack


//Name: p1, Numbers: 3
//Color: black Number: 4
//Color: black Number: 10
//Color: red Number: 5

//Name: p2, Numbers: 23
//Color: black Number: 5
//Color: black Number: 2
//Color: black Number: King
//Color: black Number: Ace
//Color: red Number: 3
//Color: black Number: 7
//Color: red Number: King
//Color: red Number: 6
//Color: red Number: 9
//Color: red Number: 4
//Color: red Number: 10
//Color: red Number: 2
//Color: red Number: Ace
//Color: black Number: 6
//Color: red Number: Queen
//Color: red Number: 7
//Color: black Number: 8
//Color: black Number: 3
//Color: black Number: Jack
//Color: red Number: 8
//Color: black Number: Queen
//Color: black Number: 9
//Color: red Number: Jack


//Name: p1, Numbers: 2
//Color: black Number: 10
//Color: red Number: 5

//Name: p2, Numbers: 24
//Color: black Number: 2
//Color: black Number: King
//Color: black Number: Ace
//Color: red Number: 3
//Color: black Number: 7
//Color: red Number: King
//Color: red Number: 6
//Color: red Number: 9
//Color: red Number: 4
//Color: red Number: 10
//Color: red Number: 2
//Color: red Number: Ace
//Color: black Number: 6
//Color: red Number: Queen
//Color: red Number: 7
//Color: black Number: 8
//Color: black Number: 3
//Color: black Number: Jack
//Color: red Number: 8
//Color: black Number: Queen
//Color: black Number: 9
//Color: red Number: Jack
//Color: black Number: 4
//Color: black Number: 5


//Name: p1, Numbers: 3
//Color: red Number: 5
//Color: black Number: 10
//Color: black Number: 2

//Name: p2, Numbers: 23
//Color: black Number: King
//Color: black Number: Ace
//Color: red Number: 3
//Color: black Number: 7
//Color: red Number: King
//Color: red Number: 6
//Color: red Number: 9
//Color: red Number: 4
//Color: red Number: 10
//Color: red Number: 2
//Color: red Number: Ace
//Color: black Number: 6
//Color: red Number: Queen
//Color: red Number: 7
//Color: black Number: 8
//Color: black Number: 3
//Color: black Number: Jack
//Color: red Number: 8
//Color: black Number: Queen
//Color: black Number: 9
//Color: red Number: Jack
//Color: black Number: 4
//Color: black Number: 5


//Name: p1, Numbers: 2
//Color: black Number: 10
//Color: black Number: 2

//Name: p2, Numbers: 24
//Color: black Number: Ace
//Color: red Number: 3
//Color: black Number: 7
//Color: red Number: King
//Color: red Number: 6
//Color: red Number: 9
//Color: red Number: 4
//Color: red Number: 10
//Color: red Number: 2
//Color: red Number: Ace
//Color: black Number: 6
//Color: red Number: Queen
//Color: red Number: 7
//Color: black Number: 8
//Color: black Number: 3
//Color: black Number: Jack
//Color: red Number: 8
//Color: black Number: Queen
//Color: black Number: 9
//Color: red Number: Jack
//Color: black Number: 4
//Color: black Number: 5
//Color: red Number: 5
//Color: black Number: King


//Name: p1, Numbers: 1
//Color: black Number: 2

//Name: p2, Numbers: 25
//Color: red Number: 3
//Color: black Number: 7
//Color: red Number: King
//Color: red Number: 6
//Color: red Number: 9
//Color: red Number: 4
//Color: red Number: 10
//Color: red Number: 2
//Color: red Number: Ace
//Color: black Number: 6
//Color: red Number: Queen
//Color: red Number: 7
//Color: black Number: 8
//Color: black Number: 3
//Color: black Number: Jack
//Color: red Number: 8
//Color: black Number: Queen
//Color: black Number: 9
//Color: red Number: Jack
//Color: black Number: 4
//Color: black Number: 5
//Color: red Number: 5
//Color: black Number: King
//Color: black Number: 10
//Color: black Number: Ace


//Name: p1, Numbers: 0

//Name: p2, Numbers: 26
//Color: black Number: 7
//Color: red Number: King
//Color: red Number: 6
//Color: red Number: 9
//Color: red Number: 4
//Color: red Number: 10
//Color: red Number: 2
//Color: red Number: Ace
//Color: black Number: 6
//Color: red Number: Queen
//Color: red Number: 7
//Color: black Number: 8
//Color: black Number: 3
//Color: black Number: Jack
//Color: red Number: 8
//Color: black Number: Queen
//Color: black Number: 9
//Color: red Number: Jack
//Color: black Number: 4
//Color: black Number: 5
//Color: red Number: 5
//Color: black Number: King
//Color: black Number: 10
//Color: black Number: Ace
//Color: black Number: 2
//Color: red Number: 3


//The winner is: p2

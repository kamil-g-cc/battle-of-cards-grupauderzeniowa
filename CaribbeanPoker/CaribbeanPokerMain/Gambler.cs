using System;
using System.Collections.Generic;
using System.Text;

namespace CaribbeanPokerMain
{
    class Gambler : Hand
    {
        public int Money {get;set;}
        public string state;
        public Gambler() => Money = 1000;
        public Gambler(Card[] cards): base(cards) => Money = 1000;
        // FIXME: This method should close the program
        public void Quit(Game game)
        {
           state = "Quit"; 
        
        }
        
        // The aim of this function is to get a value of the ante from keyboard. Player can also write quit. In that case method quit is executed.    
        //FIXME: You don't take any arguments. All needed fields are provided by object gambler.
        public Ante getAnte(Ante ante)

        {   //before starting the game we choose Ante
            //FIXME: loop condition
            while( ante > 0) 
            {
            int myAnte; 
            Console.WriteLine("Bet obligatory Ante:");
            myAnte = int.Parse(Console.ReadLine());
            // The player decides how much to play
     
            switch (myAnte)
            {
                // TODO: In order to handle casting error, please add try cath statements
                case ((int)Ante.Ten):
                    // FIXME: You don't need this message
                    Console.WriteLine("You bet 10");
                    break;
                case ((int)Ante.Twenty):
                    Console.WriteLine("You bet 20");
                    break;
                case ((int)Ante.Fifty):
                    Console.WriteLine("You bet 50");
                    break;
                case ((int)Ante.Hundred):
                    Console.WriteLine("You bet 100");
                    break;

                default:
                    Console.WriteLine("Sorry, you have entered an invalid value");
                    break;
             }
            }
            return ante;
            
        }
        //FIXME: The aim of this function is to get yes/no answer from player if he participates in jackpot
        //FIXME: You don't take any arguments. All needed fields are provided by object gambler.
        public bool getJackpot(Gambler Jackpot)
        { 
            bool gameJ = true;
            while(gameJ){
                //bonus pool
                int bonus = Jackpot[++];
                return true;  
                }

            return false;
            }

        
        //FIXME: The aim of this function is to get yes/no answer from player if he calls or folds
        //FIXME: You don't take any arguments. All needed fields are provided by object gambler.
        public bool getCall(Ante JackpotAnte)
        {
            
            int fold = 0;
            if(Money >= fold){
                //We're losing Ante and JackpotAnte
              
              Money -= Ante + JackpotAnte;
              fold = Money;
              return true;
              }
             
            else
            {
               //If we decide to keep playing, we pay Ante 2 times
                Money += Ante * 2;
                return false;
            }
           
        }
          
         
        //FIXME: You don't take any arguments. All needed fields are provided by object gambler.
        //FIXME: Check if money <= 0 and return bool value
        public bool isBroke(Gambler Money)
        {
            bool broke = true;
            while(Money == null && broke)
            {
                
                Console.WriteLine("We're sorry you are broke :(");
            }
            return true;
        }
    }
}

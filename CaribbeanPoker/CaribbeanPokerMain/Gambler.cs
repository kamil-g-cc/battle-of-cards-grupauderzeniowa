using System;
using System.Collections.Generic;
using System.Text;

namespace CaribbeanPokerMain
{
    class Gambler : Hand
    {
        public int Money {get;set;}
        public Gambler() => Money = 1000;
        public Gambler(Card[] cards): base(cards) => Money = 1000;
        // FIXME: This method should close the program
        public void Quit(Game game)
        {
          Console.Write("Press <Enter> to exit... ");
          while (Console.ReadKey().Key != ConsoleKey.Enter){}
        } 
        
    
        
        // The aim of this function is to get a value of the ante from keyboard. Player can also write quit. In that case method quit is executed.    
        //FIXME: You don't take any arguments. All needed fields are provided by object gambler.
        public Ante getAnte()

        {   //before starting the game we choose Ante
            //FIXME: loop condition
            int myAnte; 
            Console.WriteLine("Bet obligatory Ante:");
            myAnte = int.Parse(Console.ReadLine());
            
            // The player decides how much to play
            while(myAnte != 0) 
            {   
                switch (myAnte)
                {
                    // TODO: In order to handle casting error, please add try cath statements
                    case ((int)Ante.Ten):
                        // FIXME: You don't need this message
                
                        break;
                    case ((int)Ante.Twenty):

                        
                        break;
                    case ((int)Ante.Fifty):
                        
                        break;
                    case ((int)Ante.Hundred):
                        
                        break;

                    default:
                        Console.WriteLine("Sorry, you have entered an invalid value");
                        break;
                }
                if(myAnte == int.Parse("Enter")){
                   break;
                }
                
            } 
              return getAnte(); 
        }      
   
        //FIXME: The aim of this function is to get yes/no answer from player if he participates in jackpot
        //FIXME: You don't take any arguments. All needed fields are provided by object gambler.
        public bool getJackpot()
        { 

            int folds;
            Console.WriteLine("Do  you participates in jackpot?Y/N");
            folds = int.Parse(Console.ReadLine());
            if (folds==int.Parse("Y"))
            {
                return true;  
            }
            else
            {
                return false;
            }
           
            }

        
        //FIXME: The aim of this function is to get yes/no answer from player if he calls or folds
        //FIXME: You don't take any arguments. All needed fields are provided by object gambler.
        public bool getCall()
        {

            int folds;
            Console.WriteLine("Do you fold?Y/N");
            folds = int.Parse(Console.ReadLine());
            if (folds==int.Parse("Y"))
            {
                return true;  
            }
            else
            {
                return false;
            }

        }
        //FIXME: You don't take any arguments. All needed fields are provided by object gambler.
        //FIXME: Check if money <= 0 and return bool value
        public bool isBroke()
        {
        
            if(Money <= 0)
            {
                
                Console.WriteLine("We're sorry you are broke");
                return true;
            }
            
            else{
                return false;
            }
        }
    }
}

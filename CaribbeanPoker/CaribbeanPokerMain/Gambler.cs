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
        public void Quit()
        {
          System.Environment.Exit(0);
        } 
        
    
        
        // The aim of this function is to get a value of the ante from keyboard. Player can also write quit. In that case method quit is executed.    
        //FIXME: You don't take any arguments. All needed fields are provided by object gambler.
        public Ante getAnte()

        {   //before starting the game we choose Ante
            //FIXME: loop condition
            int myAnte = 0;
            while(myAnte == 0) 

            {    
                myAnte = 0;
                Console.WriteLine("Bet obligatory Ante:");
                myAnte = int.Parse(Console.ReadLine());
                
            // The player decides how much to play
                try{

                    switch (myAnte)
                       {
                           
                        case ((int)Ante.Ten):
                            
                    
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
                    }
                    catch(Exception e){
                         Console.WriteLine($"Sorry, you have entered an invalid value'{e}'");
                         }
                    if(myAnte == int.Parse("Enter"))
                    {
                        Console.Write("Press <Enter> to exit... ");
                        while (Console.ReadKey().Key != ConsoleKey.Enter){}
                        
                    }       
                
            } 
              return getAnte(); 
        }      
   
        //FIXME: The aim of this function is to get yes/no answer from player if he participates in jackpot
        //FIXME: You don't take any arguments. All needed fields are provided by object gambler.
        public bool getJackpot()
        { 
            bool jack = true;
            while(jack){
            int folds;
            Console.WriteLine("Do  you participates in jackpot?Y/N");
            folds = int.Parse(Console.ReadLine());
            try{

                if (folds==int.Parse("Y"))
                {
                    return true;  
                }
                else
                {
                    return false;
                }
               }
               catch(Exception e)
               {
                   Console.WriteLine($"Sorry, you have entered an invalid value'{e}'");
               }
            }
            return getJackpot();
        }
        //FIXME: The aim of this function is to get yes/no answer from player if he calls or folds
        //FIXME: You don't take any arguments. All needed fields are provided by object gambler.
        public bool getCall()
        {

            bool call = true;
            while(call){
            int folds;
            Console.WriteLine("Do you fold?Y/N");
            folds = int.Parse(Console.ReadLine());
            try{
                if (folds==int.Parse("Y"))
                {
                    return true;  
                }
                else
                {
                    return false;
                }
            }
            catch(Exception e)
            {
               Console.WriteLine($"Sorry, you have entered an invalid value'{e}'"); 
            }
             }
             return getCall();
        }
          
        //FIXME: You don't take any arguments. All needed fields are provided by object gambler.
        //FIXME: Check if money <= 0 and return bool value
        public bool isBroke()
        {
        
            if(Money <= 0)
            {
                
                
                return true;
            }
            
            else{
                return false;
            }
        }
    }
}

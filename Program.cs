using System;

namespace SnakeGame {     
   //Driver Class
   class Game{

      // CreateBoard()
      // UpdateBoard()
      // DisplayBoard()
      // bool Win()
      // bool Lose()

      static void Main (string[] args){
         Console.WriteLine("Do you wish to play Snake? Type 'yes' to PLAY or 'no' to QUIT");
         string userPlay = Console.ReadLine();
         while (userPlay.Length == 3){
            //CreateBoard();
            Snake boi = new Snake(2);
            Fruit yum = new Fruit();
            
            //Start Game
            //while lose() == false
               //get user input and update snake
               //check if wine() == true
            //show score?

            boi.print(boi);
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            Console.WriteLine("Do you wish to play Snake? Type 'yes' to PLAY or 'no' to QUIT");
            userPlay = Console.ReadLine();
         }
      }
   }
}

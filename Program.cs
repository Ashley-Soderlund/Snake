using System;

namespace SnakeGame {     
   //Driver Class
   class Game{

      // CreateBoard(){
      //    for(int i = 0; i < 20; i ++){
      //       for(int j = 0; i < 20; j++){
      //          Console.Write("0");
      //       }  
      //    }
      // }

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

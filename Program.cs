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
         //CreateBoard();
         Snake boi = new Snake(2);
         Fruit yum = new Fruit();

         boi.print(boi);
         Console.WriteLine("Hello World!");
         Console.ReadKey();
      }
   }
}
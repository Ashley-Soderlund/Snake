using System;
using System.IO;

namespace SnakeGame {     
   //Driver Class
   class Game{

      public static int[,]CreateBoard(){

         int[,] board = new int[,] {
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}
         };   
         return board;

      }

      //Also pass in snake location and fruit location once created!
      static int[,] UpdateBoard(int[,] board, Fruit yum, OldFruit lessyum, Snake boi){

         //snake takes priority on board placement!
         
         for(int i = 0; i < 20; i++){
            for(int j = 0; j < 20; j++){
               if(j == yum.XaxisFruit && i == yum.YaxisFruit){
                  board[j,i] = 2;
               }
               else if ( j == lessyum.XaxisFruitOld && i == lessyum.YaxisFruitOld){
                  board[j,i] = 0;
               }
               else if (j == boi.XaxisSnake && i == boi.YaxisSnake){
                  board[j,i] = 5;
               }
            }
         }
         int[,] updatedBoard = board;
         return updatedBoard;
      }

      //remove? calls to check if fruit is eaten to remove

      static void PrintBoard(int[,] board){
         for(int i = 0; i < 20; i++){
               for(int j = 0; j < 20; j++){
                  if(board[j,i] == 1){
                     Console.Write("#" + " ");
                  }
                  else if(board[j,i] == 2){

                     Console.Write("*" + " ");
                  }
                  else if(board[j,i] == 5){
                     Console.Write("o" + " ");
                  }
                  else if(board[j,i] == 6){
                     Console.WriteLine("O" + " ");
                  }
                  else{
                     Console.Write(" " + " ");
                  }
               }
               Console.Write("\n");

            }
      }

      public static bool checkLose(bool loseValue, Snake boi){
         if(boi.XaxisSnake == 0 || boi.YaxisSnake == 0 || boi.XaxisSnake == 19 || boi.YaxisSnake == 19){
            loseValue = true;
            return loseValue;
         }
         else{
            return loseValue;
         }
      }

      public static bool checkWin(bool winValue){
         //if(all 0 places in board are filled with snake){
            //winValue = true;
            //return winValue;
         //}
         //else{
            //return winValue;
         //}
         return winValue;
      }

      static void Main (string[] args){
         Console.WriteLine("Do you wish to play Snake? Type 'yes' to PLAY or 'no' to QUIT");
         string userPlay = Console.ReadLine();

         bool winValue = false;
         bool loseValue = false;
         
         while (userPlay == "yes" || userPlay == "Yes" || userPlay == "YES"){ //accept all case values
            //Create Board and Snake & Fruit objects
            int[,] startboard = CreateBoard();
            Snake boi = new Snake(2);
            Fruit yum = new Fruit();
            OldFruit lessyum = new OldFruit();
            ConsoleKeyInfo consoleKey;

            int delayInMillisecs = 500;

            //Create first Board with snake and fruit
            int[,] updatedboard = UpdateBoard(startboard, yum, lessyum, boi);

            Console.WriteLine("                SNAKE                     ");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Instructions:                             " +"\n");
            Console.WriteLine("PRESS ANY KEY TO GET STARTED!");
            Console.ReadKey();

            PrintBoard(updatedboard); //pass board by reference

            //Wait for userinput to move

            //(checkWin(winValue) == false && checkLose(loseValue)==false)
            while(winValue == false && loseValue == false){ 
               //if(timer for 3 seconds)
                  //checkInput() if user provides input break


               //See if key has been pressed
               if(Console.KeyAvailable){
                  consoleKey = Console.ReadKey(true);
                  switch(consoleKey.Key){
                     case ConsoleKey.UpArrow:
                     boi.YSnakeUpdate(-1, boi);
                     break;
                     case ConsoleKey.DownArrow:
                     boi.YSnakeUpdate(1, boi);
                     break;
                     case ConsoleKey.LeftArrow:
                     boi.XSnakeUpdate(-1, boi);
                     break;
                     case ConsoleKey.RightArrow:
                     boi.XSnakeUpdate(1, boi);
                     break;
                     case ConsoleKey.Escape:
                        loseValue = true;
                        break;
                  }

                  updatedboard = UpdateBoard(updatedboard, yum, lessyum, boi);
                  //Console.Clear();
                  PrintBoard(updatedboard);

                  System.Threading.Thread.Sleep(delayInMillisecs);
               }
               
               //check lose, win
               loseValue = checkLose(loseValue, boi);
               winValue = checkWin(winValue);

               //Check if fruit has been hit
               if(boi.XaxisSnake == yum.XaxisFruit && boi.YaxisSnake == yum.YaxisFruit){
                  lessyum.UpdateOldFruit(lessyum, yum);
                  yum.UpdateFruit(yum);
                  boi.SnakeGrow(boi);
               }

            }
            Console.WriteLine("Do you wish to play Snake? Type 'yes' to PLAY or 'no' to QUIT");
            userPlay = Console.ReadLine();
         }
      }
   }
}

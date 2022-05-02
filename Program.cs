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
      static int[,] UpdateBoard(int[,] board, Fruit yum, OldFruit lessyum){
         //insert snake location into board, head as 5 body as 6
         //remove old locations if needed

         //snake takes priority on board placement!
         
         for(int i = 0; i < 20; i++){
            for(int j = 0; j < 20; j++){
               if(j == yum.XaxisFruit && i == yum.YaxisFruit){
                  board[j,i] = 2;
               }
               else if ( j == lessyum.XaxisFruitOld && i == lessyum.YaxisFruitOld){
                  board[j,i] = 0;
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
                     Console.Write("o", " ");
                  }
                  else if(board[j,i] == 6){
                     Console.WriteLine("O", " ");
                  }
                  else{
                     Console.Write(" " + " ");
                  }
               }
               Console.Write("\n");

            }
      }

      public bool checkLose(bool loseValue){
         //if(snakeHead hits board position of 1 or another part of snake body){
            //loseValue = true;
            //return loseValue;
         //}
         //else{
            //return loseValue;
         //}
         return loseValue;
      }

      public bool checkWin(bool winValue){
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
         
         while (userPlay == "yes"){ //accept all case values
            //Create Board and Snake & Fruit objects
            int[,] startboard = CreateBoard();
            Snake boi = new Snake(2);
            Fruit yum = new Fruit();
            OldFruit lessyum = new OldFruit();

            //Create first Board with snake and fruit
            int[,] updatedboard = UpdateBoard(startboard, yum, lessyum);

            Console.WriteLine("                SNAKE                     ");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Instructions:                             " +"\n");
            Console.WriteLine("PRESS ANY KEY TO GET STARTED!");
            Console.ReadKey();

            PrintBoard(updatedboard); //pass board by reference

            //Wait for userinput to move

            //(checkWin(winValue) == false && checkLose(loseValue)==false)
            while(winValue == false && loseValue == false){ 
               lessyum.UpdateOldFruit(lessyum, yum);
               yum.UpdateFruit(yum);
               updatedboard = UpdateBoard(updatedboard, yum, lessyum);
               lessyum.UpdateOldFruit(lessyum, yum);
               yum.UpdateFruit(yum);
               PrintBoard(updatedboard);
               updatedboard = UpdateBoard(updatedboard, yum, lessyum);
               PrintBoard(updatedboard);
               //if(timer for 3 seconds)
                  //checkInput() if user provides input break

               
               //check lose, win

               //Check if fruit has been hit
               //if(snakehead = fruitlocation){
                  //lessyum.UpdateOldFruit(lessyum, yum);
                  //yum.UpdateFruit(yum);
                  //GrowSnake();
               //}

               //updateSnake based on userinput

               //updatedboard = UpdateBoard(updatedboard, yum, lessyum);

               //PrintBoard(updatedboard);
      
               Console.ReadKey();
               loseValue = true;
            }
            Console.WriteLine("Do you wish to play Snake? Type 'yes' to PLAY or 'no' to QUIT");
            userPlay = Console.ReadLine();
         }
      }
   }
}

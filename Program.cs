using System;
using System.IO;
using System.Collections;

namespace SnakeGame {     
   //Driver Class
   class Game{


      //Creation of starter board, 20x20
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

      //Updates the characters of the snake, fruit, and board
      static int[,] UpdateBoard(int[,] board, Fruit yum, OldFruit lessyum, Snake boi, System.Collections.Generic.LinkedList<int> xSnakePositions, System.Collections.Generic.LinkedList<int> ySnakePositions){
         
         //Cycles through every position on the board
         for(int i = 0; i < 20; i++){
            for(int j = 0; j < 20; j++){
               //Add Fruit to the Board
               if(j == yum.XaxisFruit && i == yum.YaxisFruit){
                  board[j,i] = 2;
               }
               //Remove Old Fruit from the Board
               else if ( j == lessyum.XaxisFruitOld && i == lessyum.YaxisFruitOld){
                  board[j,i] = 0;
               }
               //Add Snake to the Board
               else if (j == boi.XaxisSnake && i == boi.YaxisSnake){
                  board[j,i] = 5;
               }
            }
         }

         //Create a normal list from linked list values of the x poition of snake
         List<int> xSnakePos = new List<int>();
         foreach(int n in xSnakePositions)
         {
            xSnakePos.Add(n);
         }

         //Create a normal list from the linked list values of the y position of the snake
         List<int> ySnakePos = new List<int>();
         foreach(int m in ySnakePositions)
         {
            ySnakePos.Add(m);
         }


         //Remove the tail characters from the snake so the snake will be its correct length
         for(int a = 0; xSnakePositions.Count > a; a++){
            if(a > boi.Size){
               if(board[xSnakePos[a], ySnakePos[a]] != 2){
                  board[xSnakePos[a], ySnakePos[a]] = 0;
               }
            }
         }

         int[,] updatedBoard = board;
         return updatedBoard;
      }


      //Display the board to the terminal
      static void PrintBoard(int[,] board){
         for(int i = 0; i < 20; i++){
               for(int j = 0; j < 20; j++){
                  //Shows the boarder
                  if(board[j,i] == 1){
                     Console.Write("#" + " ");
                  }
                  //Shows the fruit
                  else if(board[j,i] == 2){

                     Console.Write("*" + " ");
                  }
                  //Shows the snake
                  else if(board[j,i] == 5){
                     Console.Write("o" + " ");
                  }
                  //Shows empty space
                  else{
                     Console.Write(" " + " ");
                  }
               }
               Console.Write("\n");

            }
      }

      //Checks to see if snake has hit a wall and lost
      public static bool checkLose(bool loseValue, Snake boi, int [,] board){
         if(boi.XaxisSnake == 0 || boi.YaxisSnake == 0 || boi.XaxisSnake == 19 || boi.YaxisSnake == 19){
            loseValue = true;
            Console.WriteLine("Sorry, You Have Lost \n");
            return loseValue;
         }
         else{

            // for(int i = 0; i < 20; i++){
            //    for(int j = 0; j < 20; j++){
            //       if(board[j,i] == 5){
            //          if(boi.XaxisSnake != && boi.YaxisSnake != i){
            //             loseValue = true;
            //             Console.WriteLine("Sorry, You Have Lost \n");
            //             return loseValue;
            //          }
            //       }
            //    }
            // }

            return loseValue;
         }



      }

      //Checks to see if snake has gathered 10 fruits from the board
      public static bool checkWin(bool winValue, int[,] board, Fruit yum){
         int count = 0;

         for(int i = 0; i < 20; i++){
            for(int j = 0; j < 20; j++){
               if(board[j,i] == 1 || board[j,i] == 5){
                  count =+ 1;
               }
            }

         }

         //Ignore first if statement, does not apply to program currently
         if(count == 40){
            winValue = true;
            Console.WriteLine("You Have WON! \n");
            return winValue;
         }
         else if (yum.FruitCount == 10){
            winValue = true;
            Console.WriteLine("You Have WON! \n");
            return winValue;
         }
         else{
            return winValue;
         }
      }

      static void Main (string[] args){
         
         //Ask
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

            LinkedList<int> xSnakePositions = new LinkedList<int>();
            LinkedList<int> ySnakePositions = new LinkedList<int>();

            xSnakePositions.AddLast(boi.XaxisSnake);
            ySnakePositions.AddLast(boi.YaxisSnake);

            int delayInMillisecs = 500;

            //Create first Board with snake and fruit
            int[,] updatedboard = UpdateBoard(startboard, yum, lessyum, boi, xSnakePositions, ySnakePositions);

            Console.WriteLine("              INV S BL  SNAKE             ");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Instructions: Using the Up, Down, Left, and Right" +"\n" + "Arrow Keys, Collect 10 '*' to Win the Game of Snake");
            Console.WriteLine("Be sure to not run into the all and keep track of your snake!" + "\n");
            Console.WriteLine("PRESS ANY KEY TO GET STARTED!");
            Console.ReadKey();

            PrintBoard(updatedboard); 

            while(winValue == false && loseValue == false){ 

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

                  xSnakePositions.AddFirst(boi.XaxisSnake);
                  ySnakePositions.AddFirst(boi.YaxisSnake);

                  updatedboard = UpdateBoard(updatedboard, yum, lessyum, boi, xSnakePositions, ySnakePositions);
                  Console.Clear();
                  PrintBoard(updatedboard);

                  System.Threading.Thread.Sleep(delayInMillisecs);
               }
               
               //Check if player has lost or won
               loseValue = checkLose(loseValue, boi, updatedboard);
               winValue = checkWin(winValue, updatedboard, yum);

               //Check if fruit has been hit
               if(boi.XaxisSnake == yum.XaxisFruit && boi.YaxisSnake == yum.YaxisFruit){
                  lessyum.UpdateOldFruit(lessyum, yum);
                  yum.UpdateFruit(yum);
                  boi.SnakeGrow(boi);
               }

            }
            Console.WriteLine("Thanks for Playing! Fruits Collected: " + yum.FruitCount);
            userPlay = "no";
         }
      }
   }
}

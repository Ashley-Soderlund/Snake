

namespace SnakeGame {
   public class Snake{
      //Snake class creation

      private int snakeLegnth;
      private int snakeYaxis;
      private int snakeXaxis;

      public Snake(int _snakeLegnth){
          snakeLegnth = _snakeLegnth;
          snakeXaxis = 10;
          snakeYaxis = 10;
      }

      //accessors
      public int Size
      {
         get{return snakeLegnth;}
         set{snakeLegnth = value;}
      }

      public int XaxisSnake
      {
         get{return snakeXaxis;}
         set{snakeXaxis = value;}
      }

      public int YaxisSnake
      {
         get{return snakeYaxis;}
         set{snakeYaxis = value;}
      }

      //UpdateSnake()

      //Update the Y position of the snake
      public void YSnakeUpdate(int value, Snake boi){
         boi.YaxisSnake = boi.YaxisSnake + value;
      }

      //Update X position of the snake
      public void XSnakeUpdate(int value, Snake boi){
         boi.XaxisSnake = boi.XaxisSnake + value;
      }

      //Keep track of the size of the snake
      public void SnakeGrow(Snake boi){
         boi.Size = boi.Size + 1;
      }
   }

}

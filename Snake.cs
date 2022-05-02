

namespace SnakeGame {
   public class Snake{
      //Snake class creation

      private int snakeLegnth;
      private int snakeYaxis;
      private int snakeXaxis;

      public Snake(int _snakeLegnth){
          snakeLegnth = _snakeLegnth;
          snakeXaxis = 10;
          snakeXaxis = 10;
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
      //SnakeGrow()
      //Movement()?
      


      public void print(Snake snake){
          Console.WriteLine("Snakes Legnth is " + snake.Size);
      }
   }

}

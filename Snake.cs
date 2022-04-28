

namespace SnakeGame {
   public class Snake{
      //Snake class creation

      private int snakeLegnth;

      public Snake(int _snakeLegnth){
          snakeLegnth = _snakeLegnth;
      }

      //accessors
      public int Size
      {
         get
         {return snakeLegnth;}
         set
         {snakeLegnth = value;}
      }

      public void print(Snake snake){
          Console.WriteLine("Snakes Legnth is " + snake.Size);
      }
   }

}
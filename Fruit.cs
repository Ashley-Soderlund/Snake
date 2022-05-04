
namespace SnakeGame {
   public class Fruit{
      private int fruitYaxis;
      private int fruitXaxis;

      private int fruitCount;


      public Fruit(){
         fruitXaxis = 5;
         fruitYaxis = 5;
         fruitCount = 0;
      }

      //Setters and Getters for Fruit Values
      public int XaxisFruit
      {
         get{return fruitXaxis;}
         set{fruitXaxis = value;}
      }

      public int YaxisFruit
      {
         get{return fruitYaxis;}
         set{fruitYaxis = value;}
      }

      public int FruitCount
      {
         get{return fruitCount;}
         set{fruitCount = value;}
      }

      //Get a Random number from 1 to 18
      public int RandomLocation(){
         Random rnd = new Random();
         int locationvalue = rnd.Next(1, 19);
         return locationvalue;
      }

      //Updates Fruit's Location Values with Random Numbers Function
      public void UpdateFruit(Fruit yum){

         int randomLocationX = RandomLocation();
         int randomLocationY = RandomLocation();

         yum.XaxisFruit = randomLocationX;
         yum.YaxisFruit = randomLocationY;

         yum.fruitCount += 1;
      }
   }

}

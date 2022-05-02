namespace SnakeGame {
   public class OldFruit{
      private int fruitYaxis;
      private int fruitXaxis;


      public OldFruit(){
         fruitXaxis = 1;
         fruitYaxis = 1;
      }

      //Setters and Getters for Fruit Values
      public int XaxisFruitOld
      {
         get{return fruitXaxis;}
         set{fruitXaxis = value;}
      }

      public int YaxisFruitOld
      {
         get{return fruitYaxis;}
         set{fruitYaxis = value;}
      }

      //Updates the Old Fruit's Location Values with Current Value of Fruit
      public void UpdateOldFruit(OldFruit yumOld, Fruit yum){

         yumOld.XaxisFruitOld = yum.XaxisFruit;
         yumOld.YaxisFruitOld = yum.YaxisFruit;
      }
   }

}

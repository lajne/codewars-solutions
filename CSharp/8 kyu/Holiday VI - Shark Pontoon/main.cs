public class Kata {

    public static string Shark(int pontoonDistance, int sharkDistance, int yourSpeed, int sharkSpeed, bool dolphin) {
      if(dolphin) {
        sharkSpeed /= 2;
      }
        
      return pontoonDistance/yourSpeed < sharkDistance/sharkSpeed ? "Alive!" : "Shark Bait!";
    }
}
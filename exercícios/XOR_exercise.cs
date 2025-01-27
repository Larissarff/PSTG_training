public class Kata
{
    public static bool Xor(bool a, bool b)
    {
        if ( a == false){
          if (b == false){
            return false;
          } else{
            return true;
          }
        } else if(a == true){
            if (b == true){
              return false;
            } else  {
              return true;
            }
            
        }
      return true;
    }
}

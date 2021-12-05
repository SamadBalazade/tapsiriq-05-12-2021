using System;

public class ReverseText
{

  public string text;
  public string newText;

  public ReverseText (string text_)
  {
    text = text_;
  }
  
  public string getTextLength(){
    for(int i = text.Length-1; i>=0; i--){
        newText += text[i];
    }
    
    

    return newText;
  }


}

public class Program
{
  public static void Main ()
  {
    ReverseText newReverse = new ReverseText (text_:"Hello world");
    Console.WriteLine(newReverse.getTextLength());

  }
}

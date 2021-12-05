using System;


public class Person {
    public int age;
    
    public void SetAge(int newAge){
        age = newAge;
    }
    
    public void Greet(int initial_age){
        age = initial_age;
    }
    
}

public class Student : Person
{
  
  public void Study(){
      Console.WriteLine("I'm studying");
  }
  
  public void ShowAge(){
      Console.WriteLine("My Age is " + age + " Years old");
  }
 
}


public class Teacher{
   public void Explaining(){
       Console.WriteLine("i'm explaining");
   }
}




public class Program
{
  public static void Main ()
  {
     
      Student newStudent = new Student();
      newStudent.Greet(20); // set student age;
      newStudent.ShowAge(); // show my age;
      newStudent.SetAge(40); // set age;
      newStudent.ShowAge(); // show my age;
      newStudent.Study();
      
      
    //   get teacher 
    
     Teacher newTeacher = new Teacher();
     newTeacher.Explaining();
     

  }
}

using System;
class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Employee Records with Objects");

    Employee unknown = new Employee();
    unknown.Intro();

    Employee robert = new Employee("Robert", "Downey", 12321, 12, 100);
    robert.Intro();  

       Employee john = new Employee("John", "Smith", S0089, 38, 50000);
    john.Intro();  

       Employee maria = new Employee("Maria", "Lambert", 26, s00010, 100);
    robert.Intro();  


  }
}
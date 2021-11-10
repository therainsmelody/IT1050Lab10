using System;
//Employee Fields
class Employee {
   
     private string firstname;
     private string lastname;
     private string id;
     private int age;
     private string address;
     private string phonenumber;
     private string title;
     private double yearlysalary;
     private string employmentstatus;


     public string Firstname {}
     public string Lastname {}
     public string Id {}
     public int Age {}
     public string Address {}
     public string Phonenumber {}
     public string Title{}
     public double Yearlysalary {}
     public string Employmentstatus {}
     
//Employee Properties
 public string firstname {get; set;}
 public string lastname {get; set;}
 
 public int Id {get; set;}
 public int Age {
       get{ return age; }
       set{
         if (value>=18)
            age = value;
        else
        age = 18;
        Console.WriteLine("You can't employ minors") ;
     }
}


   public string Address {get; set;}
   public string Phonenumber {get; set;}
   public string Title {get; set;} 
   public string Yearlysalary get{ return yearlysalary; }
       set{
         if (value>1000)
            yearlysalary = value;
        else
        age = 1000;
   public string Employmentstatus {get; set;}

//no parameters
public Employee()
{
  Firstname = "Unknown"; 
  Lastname = "Unknown"; 
  Id = "Unknown; 
  Age = 0; 
  Employmentstatus = "Unknown";
  Console.WriteLine("A new employee object has been created");
}

//with paramenters
  public Employee(string firstname, string lastname, string id)
  {
  Firstname = firstname; 
  Lastname = lastname; 
  Id = id; 
  Age= age; 
  Employmentstatus = employmentstatus ;
  Console.WriteLine("A new employee object has been created");
  }

  public void Intro ()
  {
    Console.WriteLine("Employee's First Name: " + firstname);
    Console.WriteLine("Employee's Last Name: " + lastname);
    Console.WriteLine("Employee's ID: " + id);
    Console.WriteLine("Employee's Age Name: " + age);
    Console.WriteLine("Employee's Employement Status: " + employmentstatus);
  }

    public void IncreaseSalary ()
  {
    Console.WriteLine("Enter the percent of increase:")

    
    if ( yearlysalary > 0){
    }

    else 
    {
      Console.WriteLine(" Invalid input. Yearly Salary not updated.")
    } 
    }
  }

    public void RemoveEmployee ()
  {
    if ( employmentstatus = "inactive"){
      Console.WriteLine("Employee is already inactive.")
    }
    else  
    {
      employmentstatus = "inactive";
      Console.Writeline("Employee Removed.")
    }
  }
  }
}
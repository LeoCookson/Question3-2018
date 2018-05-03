using System;

namespace Question3
{
    //Create class
     class Person {
         //Get / sets
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public DateTime DateOfBirth {get; set;}

        public Person(string firstName, string lastName, DateTime dob) {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dob;

           
        }
            //Method
        public string GetFullName() {
            return $"{FirstName} {LastName}";
        }

        //Age method
        public int GetAge() {
                
            var age = DateTime.Now.Year - DateOfBirth.Year;  
            if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear) {
                age = age - 1;  
            }  
                
            return age;  
        }
         // DisplayInfo method 
        public  string DInfo() {
            return $"Person: {GetFullName()} is {GetAge()} years old";
        }
    

  
        static void Main(string[] args)
        {
            Console.WriteLine("Enter new person below");
            Console.WriteLine("Firstname:");
           var firstN = Console.ReadLine();

            Console.WriteLine("LastName:");
          var lastN = Console.ReadLine();
          Console.WriteLine("\n Creating new person record... \n");

          Console.WriteLine("Enter year of birth in (dd/mm/year) \n");
          var dob = Console.ReadLine();
          var date = DateTime.Parse(dob);
          
           //Create person and display
          var persons = new Person(firstN, lastN, date);
          Console.WriteLine(persons.DInfo());
        }
    
}
}
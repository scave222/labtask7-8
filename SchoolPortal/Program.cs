using System;

namespace SchoolPortal
{
    class Program
    {
        static void Main(string[] args)
        {
            Science science = new Science(001, "Caleb", "Okogbe", 98, 60, 50, 88);
            Commercial commercial = new Commercial(002, "Mathew", "Samuel", 98, 30, 80, 78);

            
          Console.Write("Input your department: ");
          string dept = Console.ReadLine();

          if(dept == "SCI"){
          Console.Write("Input your first name: ");
          science.FirstName = Console.ReadLine();
          Console.Write("Input your last name: ");
          science.LastName = Console.ReadLine();
          Console.Write("Input your registration number: ");
          science.RegNumber = Convert.ToInt32(Console.ReadLine());
          science.ToString();
          }

           if(dept == "COM"){
          Console.Write("Input your first name: ");
          commercial.FirstName = Console.ReadLine();
          Console.Write("Input your last name: ");
          commercial.LastName = Console.ReadLine();
          Console.Write("Input your registration number: ");
          commercial.RegNumber = Convert.ToInt32(Console.ReadLine());
          commercial.ToString();
          }
          
        }
    }
}

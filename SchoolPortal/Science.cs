using System;
namespace SchoolPortal
{
    public class Science : Student
    {
        private int computerNetwork;
        private int dataStructure;
        private int cSharp;

        public Science(int regNumber, string firstName, string lastName, int scores, int computerNetwork, int dataStructure, int cSharp) :
        base(regNumber, firstName, lastName, scores)
        {
            ComputerNetwork = computerNetwork;
            DataStructure = dataStructure;
            CSharp = cSharp;
        }

        public int ComputerNetwork
        {
            get { return computerNetwork;}
            set 
            {
                if(value >= 0 && value <= 100)
                {
                    computerNetwork = value;
                }
                else {
                    throw new System.ArgumentOutOfRangeException("Your score is out of range.");
                }
            }
        }

         public int DataStructure
        {
            get { return dataStructure;}
            set 
            {
                if(value >= 0 && value <= 100)
                {
                    dataStructure = value;
                }
                else {
                    throw new System.ArgumentOutOfRangeException("Your score is out of range.");
                }
            }
        }

            public int CSharp
        {
            get { return cSharp;}
            set 
            {
                if(value >= 0 && value <= 100)
                {
                    cSharp = value;
                }
                else {
                    throw new System.ArgumentOutOfRangeException("Your score is out of range.");
                }
            }
        }



      public void average()
      {
          
          Console.WriteLine($"Registration Number: {RegNumber}\nName: {FirstName} {LastName}\nComputer: {ComputerNetwork}\nData Structure: {DataStructure}\nC-Sharp: {CSharp}\nAverage Score: {(ComputerNetwork + DataStructure + CSharp)/3}");
      }

        
        public override string ToString()
        {
            average();
            return $"Registration Number: {RegNumber}\nName: {FirstName} {LastName}\nComputer: {ComputerNetwork}\nData Structure: {DataStructure}\nC-Sharp: {CSharp}\nAverage Score: {(ComputerNetwork + DataStructure + CSharp)/3}";
        }
    }
}
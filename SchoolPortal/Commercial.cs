using System;
namespace SchoolPortal
{
    public class Commercial: Student
    {
        private int elecCircuit {get; set;}
        private int circuitAnalysis {get; set;}

        private int analogComm {get; set;}

        public Commercial (int regNumber, string firstName, string lastName, int scores, int elecCircuit, int circuitAnalysis, int analogComm):
        base(regNumber, firstName, lastName, scores)
        {
            ElecCircuit = elecCircuit;
            CircuitAnalysis = circuitAnalysis;
            AnalogComm = analogComm;
        }

         public int  ElecCircuit
        {
            get { return  elecCircuit;}
            set 
            {
                if(value >= 0 && value <= 100)
                {
                     elecCircuit = value;
                }
                else {
                    throw new System.ArgumentOutOfRangeException("Your score is out of range.");
                }
            }
        }

         public int  CircuitAnalysis
        {
            get { return  circuitAnalysis;}
            set 
            {
                if(value >= 0 && value <= 100)
                {
                     circuitAnalysis = value;
                }
                else {
                    throw new System.ArgumentOutOfRangeException("Your score is out of range.");
                }
            }
        }

         public int  AnalogComm
        {
            get { return  analogComm;}
            set 
            {
                if(value >= 0 && value <= 100)
                {
                     analogComm = value;
                }
                else {
                    throw new System.ArgumentOutOfRangeException("Your score is out of range.");
                }
            }
        }

         

        public void average()
        {
            Console.WriteLine($"Registration Number: {RegNumber}\nName: {FirstName} {LastName}\nElectronic Circuit: {ElecCircuit}\nCircuit Analysis: {CircuitAnalysis}\nAnalog Communication: {AnalogComm}\nAverage Score: {(ElecCircuit + CircuitAnalysis + AnalogComm)/3}");
        }

        public override string ToString()
        {
            average();
            return $"Registration Number: {RegNumber}\nName: {FirstName} {LastName}\nElectronic Circuit: {ElecCircuit}\nCircuit Analysis: {CircuitAnalysis}\nAnalog Communication: {AnalogComm}\nAverage Score: {(ElecCircuit + CircuitAnalysis + AnalogComm)/3}";
        
        }
    }
}
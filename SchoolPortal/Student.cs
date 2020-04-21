namespace SchoolPortal
{
    public class Student
    {
        public int RegNumber {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public int Scores {get; set;}

        public Student(int regNumber, string firstName, string lastName, int scores)
        {
            RegNumber = regNumber;
            FirstName = firstName;
            LastName = lastName;
            Scores = scores;
        } 
    }
}
namespace ShapesTest
{
    public class Figure
    {
        private double x;
        private double y;
        public string Name {get; set;}

        public Figure(double _x, double _y, string _name)
        {
            X = _x;
            Y = _y;
            Name = _name;
        }

        public double X
        {
            get { return x;}
            set 
            {
                if(value > 0)
                {
                    x = value;
                }
               
            }
        }

         public double Y
        {
            get { return y;}
            set 
            {
                if(value > 0)
                {
                    y = value;
                }
               
            }
        }

        public virtual void area()
        {

        }
    }
}
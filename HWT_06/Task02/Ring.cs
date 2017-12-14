namespace Task02
{
    public class Ring : Circle  
    {
        private int outterRadius;//todo pn а как ты используешь r? какой тогда смысл был наследоваться от окружности?
        private int innnerRadius;

        public int InnerRadius
        {
            get
            {
                return innnerRadius;
            }

            set
            {
                innnerRadius = value;   
            }
        }

        public int OutterRadius
        {
            get
            {
                return outterRadius;
            }

            set
            {
                if (innnerRadius < value)
                {
                    outterRadius = value;
                }
            }
        }

        public double SumLenghtOfRing(int outterRadius, int innerRadius)
        {
            return GetLenght(outterRadius) + GetLenght(innerRadius);
        }

        public double SumAreaOfRing(int outterRadius, int innerRadius)
        {
            return GetArea(outterRadius) - GetArea(innerRadius);
        }
    }
}
